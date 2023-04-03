using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class PopulateMovies1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Movies_GenreType_GenreTypeId",
            //    table: "Movies");

            //migrationBuilder.DropIndex(
            //    name: "IX_Movies_GenreTypeId",
            //    table: "Movies");

            //migrationBuilder.AlterColumn<int>(
            //    name: "GenreTypeId",
            //    table: "Movies",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(byte),
            //    oldType: "tinyint");

            //migrationBuilder.AddColumn<byte>(
            //    name: "GenreTypeId1",
            //    table: "Movies",
            //    type: "tinyint",
            //    nullable: false,
            //    defaultValue: (byte)0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Movies_GenreTypeId1",
            //    table: "Movies",
            //    column: "GenreTypeId1");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Movies_GenreType_GenreTypeId1",
            //    table: "Movies",
            //    column: "GenreTypeId1",
            //    principalTable: "GenreType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Movies_GenreType_GenreTypeId1",
            //    table: "Movies");

            //migrationBuilder.DropIndex(
            //    name: "IX_Movies_GenreTypeId1",
            //    table: "Movies");

            //migrationBuilder.DropColumn(
            //    name: "GenreTypeId1",
            //    table: "Movies");

            //migrationBuilder.AlterColumn<byte>(
            //    name: "GenreTypeId",
            //    table: "Movies",
            //    type: "tinyint",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

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
    }
}
