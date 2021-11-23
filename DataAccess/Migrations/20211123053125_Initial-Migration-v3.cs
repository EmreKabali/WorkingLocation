using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialMigrationv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "SubMenuItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubMenuItems_MenuItemId",
                table: "SubMenuItems",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenuItems_MenuItems_MenuItemId",
                table: "SubMenuItems",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenuItems_MenuItems_MenuItemId",
                table: "SubMenuItems");

            migrationBuilder.DropIndex(
                name: "IX_SubMenuItems_MenuItemId",
                table: "SubMenuItems");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "SubMenuItems");
        }
    }
}
