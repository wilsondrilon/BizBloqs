using Microsoft.EntityFrameworkCore.Migrations;

namespace BizBloqs.Entity.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Document");

            migrationBuilder.CreateTable(
                name: "Rapyd_WebhookLogs",
                schema: "Document",
                columns: table => new
                {
                    StoreTextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapyd_WebhookLogs", x => x.StoreTextId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rapyd_WebhookLogs",
                schema: "Document");
        }
    }
}
