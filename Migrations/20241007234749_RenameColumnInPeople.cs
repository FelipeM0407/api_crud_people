using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnInPeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Years",
                table: "Peoples",
                newName: "years");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Peoples",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Peoples",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "Peoples",
                newName: "peopleId");

            migrationBuilder.RenameColumn(
                name: "Profission",
                table: "Peoples",
                newName: "profession");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "years",
                table: "Peoples",
                newName: "Years");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Peoples",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Peoples",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "peopleId",
                table: "Peoples",
                newName: "PeopleId");

            migrationBuilder.RenameColumn(
                name: "profession",
                table: "Peoples",
                newName: "Profission");
        }
    }
}
