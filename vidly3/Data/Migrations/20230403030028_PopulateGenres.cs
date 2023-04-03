using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class PopulateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql11 = "Insert INTO GenreType( Id, Name) VALUES(1,'Action')";
            var sql12 = "Insert INTO GenreType( Id, Name) VALUES(2,'Comedy')";
            var sql13 = "Insert INTO GenreType( Id, Name) VALUES(3,'Drama')";
            var sql14 = "Insert INTO GenreType( Id, Name) VALUES(4,'Family')";
           
            migrationBuilder.Sql(sql11);
            migrationBuilder.Sql(sql12);
            migrationBuilder.Sql(sql13);
            migrationBuilder.Sql(sql14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
