using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Migrations
{
    /// <inheritdoc />
    public partial class addingstuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "Proficiencies");

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "QuestItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "MiscellaneousItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "MagicalArtifacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "Consumables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedGearId",
                table: "Armors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EquippedGear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquippedGear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquippedGear_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_EquippedGearId",
                table: "Weapons",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestItems_EquippedGearId",
                table: "QuestItems",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousItems_EquippedGearId",
                table: "MiscellaneousItems",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicalArtifacts_EquippedGearId",
                table: "MagicalArtifacts",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumables_EquippedGearId",
                table: "Consumables",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_EquippedGearId",
                table: "Armors",
                column: "EquippedGearId");

            migrationBuilder.CreateIndex(
                name: "IX_EquippedGear_CharacterId",
                table: "EquippedGear",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_EquippedGear_EquippedGearId",
                table: "Armors",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumables_EquippedGear_EquippedGearId",
                table: "Consumables",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicalArtifacts_EquippedGear_EquippedGearId",
                table: "MagicalArtifacts",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MiscellaneousItems_EquippedGear_EquippedGearId",
                table: "MiscellaneousItems",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestItems_EquippedGear_EquippedGearId",
                table: "QuestItems",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_EquippedGear_EquippedGearId",
                table: "Weapons",
                column: "EquippedGearId",
                principalTable: "EquippedGear",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armors_EquippedGear_EquippedGearId",
                table: "Armors");

            migrationBuilder.DropForeignKey(
                name: "FK_Consumables_EquippedGear_EquippedGearId",
                table: "Consumables");

            migrationBuilder.DropForeignKey(
                name: "FK_MagicalArtifacts_EquippedGear_EquippedGearId",
                table: "MagicalArtifacts");

            migrationBuilder.DropForeignKey(
                name: "FK_MiscellaneousItems_EquippedGear_EquippedGearId",
                table: "MiscellaneousItems");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestItems_EquippedGear_EquippedGearId",
                table: "QuestItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_EquippedGear_EquippedGearId",
                table: "Weapons");

            migrationBuilder.DropTable(
                name: "EquippedGear");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_EquippedGearId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_QuestItems_EquippedGearId",
                table: "QuestItems");

            migrationBuilder.DropIndex(
                name: "IX_MiscellaneousItems_EquippedGearId",
                table: "MiscellaneousItems");

            migrationBuilder.DropIndex(
                name: "IX_MagicalArtifacts_EquippedGearId",
                table: "MagicalArtifacts");

            migrationBuilder.DropIndex(
                name: "IX_Consumables_EquippedGearId",
                table: "Consumables");

            migrationBuilder.DropIndex(
                name: "IX_Armors_EquippedGearId",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "QuestItems");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "MiscellaneousItems");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "MagicalArtifacts");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "Consumables");

            migrationBuilder.DropColumn(
                name: "EquippedGearId",
                table: "Armors");

            migrationBuilder.AddColumn<int>(
                name: "ProficiencyId",
                table: "Proficiencies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
