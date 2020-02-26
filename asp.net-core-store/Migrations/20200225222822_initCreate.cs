using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.net_core_store.Migrations
{
    public partial class initCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Cost", "ItemName", "Price", "Status" },
                values: new object[,]
                {
                    { 1, 90m, "Product1", 100m, false },
                    { 2, 100m, "Product2", 120m, false },
                    { 3, 150m, "Product3", 200m, false },
                    { 4, 120m, "Product4", 150m, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
