using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoetbalApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesAndStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamLeaderId",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamLeaderId",
                table: "Teams",
                column: "TeamLeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_AspNetUsers_TeamLeaderId",
                table: "Teams",
                column: "TeamLeaderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_TeamLeaderId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamLeaderId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamLeaderId",
                table: "Teams");
        }
    }
}
