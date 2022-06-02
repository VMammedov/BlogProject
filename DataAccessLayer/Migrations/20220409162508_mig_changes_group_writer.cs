using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_changes_group_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Groups_GroupID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_GroupID",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Writers");

            migrationBuilder.CreateTable(
                name: "WriterGroup",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterGroup", x => new { x.WriterID, x.GroupID });
                    table.ForeignKey(
                        name: "FK_WriterGroup_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WriterGroup_Writers_WriterID",
                        column: x => x.WriterID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WriterGroup_GroupID",
                table: "WriterGroup",
                column: "GroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WriterGroup");

            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "Writers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_GroupID",
                table: "Writers",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Groups_GroupID",
                table: "Writers",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
