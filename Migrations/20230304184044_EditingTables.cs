using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListGames.Migrations
{
    /// <inheritdoc />
    public partial class EditingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_GameEntities_GameEntityId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_GameEntities_GameEntityId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_GameEntityId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Genres_GameEntityId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "GameEntityId",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "GameEntityId",
                table: "Genres");

            migrationBuilder.CreateIndex(
                name: "IX_GameEntities_GenreId",
                table: "GameEntities",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GameEntities_TypeOfGameId",
                table: "GameEntities",
                column: "TypeOfGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameEntities_Genres_GenreId",
                table: "GameEntities",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameEntities_Types_TypeOfGameId",
                table: "GameEntities",
                column: "TypeOfGameId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameEntities_Genres_GenreId",
                table: "GameEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_GameEntities_Types_TypeOfGameId",
                table: "GameEntities");

            migrationBuilder.DropIndex(
                name: "IX_GameEntities_GenreId",
                table: "GameEntities");

            migrationBuilder.DropIndex(
                name: "IX_GameEntities_TypeOfGameId",
                table: "GameEntities");

            migrationBuilder.AddColumn<int>(
                name: "GameEntityId",
                table: "Types",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameEntityId",
                table: "Genres",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_GameEntityId",
                table: "Types",
                column: "GameEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GameEntityId",
                table: "Genres",
                column: "GameEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_GameEntities_GameEntityId",
                table: "Genres",
                column: "GameEntityId",
                principalTable: "GameEntities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Types_GameEntities_GameEntityId",
                table: "Types",
                column: "GameEntityId",
                principalTable: "GameEntities",
                principalColumn: "Id");
        }
    }
}
