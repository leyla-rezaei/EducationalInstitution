using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    /// <inheritdoc />
    public partial class editTableClassandreletedentites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SalaryAmount",
                table: "MiscellaneousExpense",
                newName: "Amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tuition",
                table: "Course",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "MiscellaneousExpense",
                newName: "SalaryAmount");

            migrationBuilder.AlterColumn<double>(
                name: "Tuition",
                table: "Course",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
