using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99d7f685-c73b-4e15-a4f1-c92f02dd094f", "35fd8fb7-9249-4d95-a741-ee5835f4447d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a494257-ba79-4b84-8f68-7c06c78aa61e", "49478cdf-3369-45eb-ad2c-69a9a2173d30", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a494257-ba79-4b84-8f68-7c06c78aa61e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99d7f685-c73b-4e15-a4f1-c92f02dd094f");
        }
    }
}
