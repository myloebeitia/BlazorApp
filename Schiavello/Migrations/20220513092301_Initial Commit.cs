using Microsoft.EntityFrameworkCore.Migrations;

namespace Schiavello.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[] { 1001, "Test", "Active" });

            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[] { 1002, "test2", "Active" });

            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[] { 1003, "test3", "Active" });

            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[] { 1004, "test4", "Active" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "List");
        }
    }
}
