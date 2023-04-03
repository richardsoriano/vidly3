using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class AddMoviesGenreTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<byte>(
            //    name: "GenreTypeId",
            //    table: "Movies",
            //    type: "tinyint",
            //    nullable: false,
            //    defaultValue: (byte)0);

            //migrationBuilder.CreateTable(
            //    name: "GenreType",
            //    columns: table => new
            //    {
            //        Id = table.Column<byte>(type: "tinyint", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GenreType", x => x.Id);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Movies_GenreTypeId",
            //    table: "Movies",
            //    column: "GenreTypeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Movies_GenreType_GenreTypeId",
            //    table: "Movies",
            //    column: "GenreTypeId",
            //    principalTable: "GenreType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_GenreType_GenreTypeId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "GenreType");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreTypeId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreTypeId",
                table: "Movies");
        }
    }
}
