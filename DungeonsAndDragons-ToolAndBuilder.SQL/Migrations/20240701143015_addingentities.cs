using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Migrations
{
    /// <inheritdoc />
    public partial class addingentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DungeonMasterId",
                table: "SideQuests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DungeonMasterId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DungeonMasterId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DungeonMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DmNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungeonMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    DungeonMasterId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journals_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Journals_DungeonMasters_DungeonMasterId",
                        column: x => x.DungeonMasterId,
                        principalTable: "DungeonMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SideQuests_DungeonMasterId",
                table: "SideQuests",
                column: "DungeonMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DungeonMasterId",
                table: "Locations",
                column: "DungeonMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_DungeonMasterId",
                table: "Events",
                column: "DungeonMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_CharacterId",
                table: "Journals",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journals_DungeonMasterId",
                table: "Journals",
                column: "DungeonMasterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_DungeonMasters_DungeonMasterId",
                table: "Events",
                column: "DungeonMasterId",
                principalTable: "DungeonMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_DungeonMasters_DungeonMasterId",
                table: "Locations",
                column: "DungeonMasterId",
                principalTable: "DungeonMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SideQuests_DungeonMasters_DungeonMasterId",
                table: "SideQuests",
                column: "DungeonMasterId",
                principalTable: "DungeonMasters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_DungeonMasters_DungeonMasterId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_DungeonMasters_DungeonMasterId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_SideQuests_DungeonMasters_DungeonMasterId",
                table: "SideQuests");

            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "DungeonMasters");

            migrationBuilder.DropIndex(
                name: "IX_SideQuests_DungeonMasterId",
                table: "SideQuests");

            migrationBuilder.DropIndex(
                name: "IX_Locations_DungeonMasterId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Events_DungeonMasterId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DungeonMasterId",
                table: "SideQuests");

            migrationBuilder.DropColumn(
                name: "DungeonMasterId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "DungeonMasterId",
                table: "Events");
        }
    }
}
