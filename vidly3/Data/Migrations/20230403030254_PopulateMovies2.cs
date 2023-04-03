using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class PopulateMovies2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql0 = "SET IDENTITY_INSERT Movies ON";
            var sql1 = "Insert INTO Movies( Id, Name,ReleaseDate,AddedDate,NumberInStock,GenreTypeId) VALUES(1,'Shrek','01/01/2023','02/02/24',78,1)";
            var sql2 = "Insert INTO Movies( Id, Name,ReleaseDate,AddedDate,NumberInStock,GenreTypeId) VALUES(2,'John Wicke 4','01/01/2023','02/03/24',88,3)";
            var sql3 = "Insert INTO Movies( Id, Name,ReleaseDate,AddedDate,NumberInStock,GenreTypeId) VALUES(3,'Outlaws','02/01/2023','02/04/24',98,2)";
            var sql4 = "Insert INTO Movies( Id, Name,ReleaseDate,AddedDate,NumberInStock,GenreTypeId) VALUES(4,'White Chicks','03/14/2023','02/05/24',108,4)";

            migrationBuilder.Sql(sql0);
            migrationBuilder.Sql(sql1);
            migrationBuilder.Sql(sql2);
            migrationBuilder.Sql(sql3);
            migrationBuilder.Sql(sql4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
