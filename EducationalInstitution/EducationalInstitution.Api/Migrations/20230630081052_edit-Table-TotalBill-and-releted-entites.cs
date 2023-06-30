using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    /// <inheritdoc />
    public partial class editTableTotalBillandreletedentites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLogo",
                table: "InstitutionInformations");

            migrationBuilder.AlterColumn<int>(
                name: "TotalNumberCourses",
                table: "RegistrationInvoice",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "ImageLogoAddressUrl",
                table: "InstitutionInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLogoAddressUrl",
                table: "InstitutionInformations");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNumberCourses",
                table: "RegistrationInvoice",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageLogo",
                table: "InstitutionInformations",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
