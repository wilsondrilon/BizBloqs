using Microsoft.EntityFrameworkCore.Migrations;

namespace BizBloqs.Entity.Migrations
{
    public partial class store_proc_return_every_second_row : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetEverySecondRowOnStoredText]
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC GetEverySecondRowOnStoredText");
        }
    }
}
