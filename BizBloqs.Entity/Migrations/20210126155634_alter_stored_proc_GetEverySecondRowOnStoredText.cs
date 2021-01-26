using Microsoft.EntityFrameworkCore.Migrations;

namespace BizBloqs.Entity.Migrations
{
    public partial class alter_stored_proc_GetEverySecondRowOnStoredText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"ALTER PROCEDURE [dbo].[GetEverySecondRowOnStoredText]
                        as
                        BEGIN
                        SELECT t.StoreTextId, t.[Data], t.CreatedOn
                        FROM
                        (
                            SELECT StoreTextId, [Data], CreatedOn, ROW_NUMBER() OVER (ORDER BY StoreTextId) AS rownum
                            FROM [BizBloqDB].[Document].[StoredText]
                        ) AS t
                        WHERE t.rownum % 2 = 0
                        ORDER BY t.[Data]
                        END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"ALTER PROCEDURE [dbo].[GetEverySecondRowOnStoredText]
                        as
                        BEGIN
                        SELECT t.StoreTextId, t.[Data]
                        FROM
                        (
                            SELECT StoreTextId, [Data], ROW_NUMBER() OVER (ORDER BY StoreTextId) AS rownum
                            FROM [BizBloqDB].[Document].[StoredText]
                        ) AS t
                        WHERE t.rownum % 2 = 0
                        ORDER BY t.[Data]
                        END";

            migrationBuilder.Sql(sp);
        }
    }
}
