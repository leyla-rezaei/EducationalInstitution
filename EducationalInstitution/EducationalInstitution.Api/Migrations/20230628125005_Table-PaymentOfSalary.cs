using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    /// <inheritdoc />
    public partial class TablePaymentOfSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentOfSalary_User_UserId",
                table: "PaymentOfSalary");

            migrationBuilder.DropForeignKey(
                name: "FK_TotalBills_PaymentOfSalary_PaymentOfSalaryId",
                table: "TotalBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentOfSalary",
                table: "PaymentOfSalary");

            migrationBuilder.RenameTable(
                name: "PaymentOfSalary",
                newName: "PaymentOfSalarys");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentOfSalary_UserId",
                table: "PaymentOfSalarys",
                newName: "IX_PaymentOfSalarys_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentOfSalarys",
                table: "PaymentOfSalarys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentOfSalarys_User_UserId",
                table: "PaymentOfSalarys",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TotalBills_PaymentOfSalarys_PaymentOfSalaryId",
                table: "TotalBills",
                column: "PaymentOfSalaryId",
                principalTable: "PaymentOfSalarys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentOfSalarys_User_UserId",
                table: "PaymentOfSalarys");

            migrationBuilder.DropForeignKey(
                name: "FK_TotalBills_PaymentOfSalarys_PaymentOfSalaryId",
                table: "TotalBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentOfSalarys",
                table: "PaymentOfSalarys");

            migrationBuilder.RenameTable(
                name: "PaymentOfSalarys",
                newName: "PaymentOfSalary");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentOfSalarys_UserId",
                table: "PaymentOfSalary",
                newName: "IX_PaymentOfSalary_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentOfSalary",
                table: "PaymentOfSalary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentOfSalary_User_UserId",
                table: "PaymentOfSalary",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TotalBills_PaymentOfSalary_PaymentOfSalaryId",
                table: "TotalBills",
                column: "PaymentOfSalaryId",
                principalTable: "PaymentOfSalary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
