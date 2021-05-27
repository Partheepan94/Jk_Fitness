using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class _20212705_Branch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveMonthrange",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "MembershipIdRange",
                table: "Branches");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleteble",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MembershipActiveMonthRange",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MembershipInitialRangeFrom",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MembershipInitialRangeTo",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleteble",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "MembershipActiveMonthRange",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "MembershipInitialRangeFrom",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "MembershipInitialRangeTo",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "ActiveMonthrange",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MembershipIdRange",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
