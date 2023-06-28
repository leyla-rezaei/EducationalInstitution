using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    /// <inheritdoc />
    public partial class TableTotalBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentOfSalary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositID = table.Column<int>(type: "int", nullable: false),
                    DepositDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOfSalary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOfSalary_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TotalBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentOfSalaryId = table.Column<int>(type: "int", nullable: false),
                    RegistrationInvoiceId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalBills_PaymentOfSalary_PaymentOfSalaryId",
                        column: x => x.PaymentOfSalaryId,
                        principalTable: "PaymentOfSalary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalBills_RegistrationInvoice_RegistrationInvoiceId",
                        column: x => x.RegistrationInvoiceId,
                        principalTable: "RegistrationInvoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfSalary_UserId",
                table: "PaymentOfSalary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalBills_PaymentOfSalaryId",
                table: "TotalBills",
                column: "PaymentOfSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalBills_RegistrationInvoiceId",
                table: "TotalBills",
                column: "RegistrationInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TotalBills");

            migrationBuilder.DropTable(
                name: "PaymentOfSalary");
        }
    }
}
