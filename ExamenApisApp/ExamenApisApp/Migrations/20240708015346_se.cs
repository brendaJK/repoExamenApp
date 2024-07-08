using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamenApisApp.Migrations
{
    /// <inheritdoc />
    public partial class se : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "producto",
                columns: new[] { "idProducto", "categoria", "descripcion", "nombre", "precio" },
                values: new object[,]
                {
                    { 1, "Perfumes", "Perfume con aroma a blueberry.", "BlueBerry Perfume", 25m },
                    { 2, "Perfumes", "Perfume con aroma a strawberry.", "Strawberry Perfume", 30m },
                    { 3, "Perfumes", "Perfume con aroma a cherry.", "Cherry Perfume", 28m },
                    { 4, "Perfumes", "Perfume florar, con notas de lavender.", "Lavender Perfume", 30m },
                    { 5, "Skincare", "Facial Cleanser con extractos de cucumber o roses.", "Facial Cleanser", 50m },
                    { 6, "Skincare", "Lip balm con extracto de rosas y miel.", "Lipbalm", 15m },
                    { 7, "Skincare", "Facial Scrub, deja tu piel suave.", "Facial Scrub", 55m },
                    { 8, "Skincare", "Toner, refresca y prepara la piel.", "Toner", 48m },
                    { 9, "Skincare", "Face Cream, hidrata y portege tu piel.", "Face Cream", 52m },
                    { 10, "Make-up", "Gloss, hidrata y pigmenta los labios.", "Gloss", 22m },
                    { 11, "Make-up", "Kit BT21, contiene una base de maquillage.", "Kit BT21", 60m },
                    { 12, "Make-up", "Blush, dale un color natural a tus mejillas.", "Kit BT21", 26m },
                    { 13, "Make-up", "Blush duo, duo de dos rubores.", "Blush duo", 30m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producto");
        }
    }
}
