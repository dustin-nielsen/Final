using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuoteText = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 1, "Virgil", "(Virgil, 151)", "151 AD", "Fortune favors the bold", "Bravery" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 2, "Mahatma Gandhi", "(Gandhi, 1989)", "30 July 1989", "You must be the change you wish to see in the world", "Change" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 3, "Alfred, Lord Tennyson", "(In Memoriam A. H. H., Alfred)", "1850", "Tis better to have loved and lost than to have never loved at all", "Love" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
