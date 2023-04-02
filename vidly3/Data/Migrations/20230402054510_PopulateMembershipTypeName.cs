using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class PopulateMembershipTypeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql1 = "UPDATE MembershipType Set Name='Pay As You Go' WHERE Id=1";
            var sql2 = "UPDATE MembershipType Set Name='Monthly' WHERE Id=2";
            var sql3 = "UPDATE MembershipType Set Name='Quarterly' WHERE Id=3";
            var sql4 = "UPDATE MembershipType Set Name='Annually' WHERE Id=4";

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
