using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddVideoToOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2ac4db42-fdf9-489f-aaac-513604c27467"));

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Owners",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile", "Video" },
                values: new object[] { new Guid("78b8e65f-1a90-4f51-9e73-b53703540145"), null, "avatar.jpg", "Alraies Makktof", "Backend Web Programmer", "video.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("78b8e65f-1a90-4f51-9e73-b53703540145"));

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Owners");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("2ac4db42-fdf9-489f-aaac-513604c27467"), null, "avatar.jpg", "Alraies Makktof", "Backend Web Programmer" });
        }
    }
}
