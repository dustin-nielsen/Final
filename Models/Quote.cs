using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }
        [Required(ErrorMessage = "You need to enter a Quote!")]
        public string QuoteText { get; set; }
        [Required(ErrorMessage = "You're quote needs an Author!")]
        public string Author { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
