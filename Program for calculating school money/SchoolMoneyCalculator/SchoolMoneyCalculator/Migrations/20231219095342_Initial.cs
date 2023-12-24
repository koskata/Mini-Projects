using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMoneyCalculator.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Стипендия = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Транспортни = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Месец = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    СумаЗаМесеца = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculators", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculators");
        }
    }
}
