using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamLeadHelp.Migrations
{
    /// <inheritdoc />
    public partial class TaskTableIT25Feb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HoursEstimated",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnHold",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "WorkedHours",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoursEstimated",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OnHold",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "WorkedHours",
                table: "Tasks");
        }
    }
}
