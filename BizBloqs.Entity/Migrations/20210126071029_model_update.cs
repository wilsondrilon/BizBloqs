using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizBloqs.Entity.Migrations
{
    public partial class model_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rapyd_WebhookLogs",
                schema: "Document",
                table: "Rapyd_WebhookLogs");

            migrationBuilder.RenameTable(
                name: "Rapyd_WebhookLogs",
                schema: "Document",
                newName: "StoredText",
                newSchema: "Document");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                schema: "Document",
                table: "StoredText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoredText",
                schema: "Document",
                table: "StoredText",
                column: "StoreTextId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoredText",
                schema: "Document",
                table: "StoredText");

            migrationBuilder.RenameTable(
                name: "StoredText",
                schema: "Document",
                newName: "Rapyd_WebhookLogs",
                newSchema: "Document");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                schema: "Document",
                table: "Rapyd_WebhookLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rapyd_WebhookLogs",
                schema: "Document",
                table: "Rapyd_WebhookLogs",
                column: "StoreTextId");
        }
    }
}
