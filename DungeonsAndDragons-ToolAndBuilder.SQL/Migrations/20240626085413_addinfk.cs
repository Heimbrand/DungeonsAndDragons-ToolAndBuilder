using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Migrations
{
    /// <inheritdoc />
    public partial class addinfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "" +
                      "NpcId" +
                      "" +
                      "" +
                      "",
                table: "Proficiencies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProficiencyId",
                table: "Proficiencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_NpcId",
                table: "Proficiencies",
                column: "NpcId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Npcs_NpcId",
                table: "Proficiencies",
                column: "NpcId",
                principalTable: "Npcs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Npcs_NpcId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficiencies_NpcId",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "NpcId",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "Proficiencies");
        }
    }
}
