using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ProjnameFromOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("78b8e65f-1a90-4f51-9e73-b53703540145"));

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Owners");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "FullName", "Profile", "Video" },
                values: new object[] { new Guid("129769a9-a6e2-4bb3-aa00-dadc0611ad13"), null, "Alraies Makktof", "Backend Web Programmer", "video.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("129769a9-a6e2-4bb3-aa00-dadc0611ad13"));

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile", "Video" },
                values: new object[] { new Guid("78b8e65f-1a90-4f51-9e73-b53703540145"), null, "avatar.jpg", "Alraies Makktof", "Backend Web Programmer", "video.mp4" });
        }
    }
}
