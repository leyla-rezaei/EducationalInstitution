using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    /// <inheritdoc />
    public partial class TableSiteAccessControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiteAccessControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicInformation = table.Column<bool>(type: "bit", nullable: false),
                    Reporting = table.Column<bool>(type: "bit", nullable: false),
                    StudentAffairs = table.Column<bool>(type: "bit", nullable: false),
                    FinancialSector = table.Column<bool>(type: "bit", nullable: false),
                    Assessment = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationInformation = table.Column<bool>(type: "bit", nullable: false),
                    CourseInformation = table.Column<bool>(type: "bit", nullable: false),
                    ClassInformation = table.Column<bool>(type: "bit", nullable: false),
                    RelatedAnnouncements = table.Column<bool>(type: "bit", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAccessControls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteAccessControls");
        }
    }
}
