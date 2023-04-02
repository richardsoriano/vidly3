using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class PopulateMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql1 = "Insert INTO MembershipType( Id, SignUpFree,DurationInMonths,DiscountRate) VALUES(1,0,0,0)";
            var sql2 = "Insert INTO MembershipType( Id, SignUpFree,DurationInMonths,DiscountRate) VALUES(2,30,1,10)";
            var sql3 = "Insert INTO MembershipType( Id, SignUpFree,DurationInMonths,DiscountRate) VALUES(3,90,3,15)";
            var sql4 = "Insert INTO MembershipType( Id, SignUpFree,DurationInMonths,DiscountRate) VALUES(4,300,12,20)";

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
