using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShop.Server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "he Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The HitchHikers Guide to The Galaxy" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Lord of the Rings: The Fellowship of the Ring is a 2001 epic fantasy adventure film directed by Peter Jackson, based on the 1954 novel The Fellowship of the Ring, the first volume of J. R. R. Tolkien's The Lord of the Rings. The film is the first installment in the Lord of the Rings trilogy. It was produced by Barrie M.The film features an ensemble. It was followed in 2002 by The Two Towers and in 2003 by The Return of the King.", "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg", 14.99m, "The Lord of the Rings: The Fellowship of the Ring" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "The Witcher (Polish: Wiedźmin, pronounced [ˈvʲɛd͡ʑmʲin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous , Geralt of Rivia. In Sapkowski's works, witchers are beast hunters who develop supernatural abilities at a young age to battle wild beasts and monsters.", "https://upload.wikimedia.org/wikipedia/en/1/14/Andrzej_Sapkowski_-_The_Last_Wish.jpg", 9.99m, "The Witcher" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
