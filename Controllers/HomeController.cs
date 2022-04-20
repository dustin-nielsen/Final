using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private QuoteContext _quoteContext { get; set; }

        public HomeController(QuoteContext x)
        {
            _quoteContext = x;
        }

        public IActionResult Index()
        {
            var quotes = _quoteContext.Quotes
                .OrderBy(x => x.Author)
                .ToList();

            return View(quotes);
        }

        public IActionResult Random()
        {
            Random rnd = new Random();
            var quotes = _quoteContext.Quotes
                .ToList();

            var maxId = quotes.Max(x => x.QuoteId);
            Quote quote = null;

            while (quote == null)
            {
                int num = rnd.Next(1, maxId + 1);
                quote = _quoteContext.Quotes.SingleOrDefault(x => x.QuoteId == num);
            }

            return View(quote);
        }

        public IActionResult Details(int quoteid)
        {
            var quote = _quoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View(quote);
        }

        [HttpGet]
        public IActionResult AddQuote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddQuote (Quote q)
        {
            if (ModelState.IsValid)
            {
                _quoteContext.Add(q);
                _quoteContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else //If Invalid
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            var quote = _quoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View("AddQuote", quote);
        }

        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            if (ModelState.IsValid)
            {
                _quoteContext.Update(q);
                _quoteContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else //If Invalid
            {
                return View("AddQuote");
            }
        }

        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = _quoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View(quote);
        }

        [HttpPost]
        public IActionResult Delete(Quote q)
        {
            _quoteContext.Quotes.Remove(q);
            _quoteContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
