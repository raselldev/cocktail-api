using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cocktailapi.Migrations
{
    /// <inheritdoc />
    public partial class Cocktail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDrink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDrink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDrinkAlternate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIBA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrAlcoholic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrGlass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDrinkThumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrIngredient15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeasure15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrImageSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrImageAttribution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrCreativeCommonsConfirmed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModified = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cocktails");
        }
    }
}
