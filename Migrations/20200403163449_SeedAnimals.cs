using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBuisnessApi.Migrations
{
    public partial class SeedAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "LookingForSlave", "Name", "Personality", "PowerStatus", "Type" },
                values: new object[] { 1, 123, "male", true, "Cornelious", "stoic", 75, "turtle" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "LookingForSlave", "Name", "Personality", "PowerStatus", "Type" },
                values: new object[] { 2, 8, "male", true, "Jasper", "mischevious", 38, "cat" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "LookingForSlave", "Name", "Personality", "PowerStatus", "Type" },
                values: new object[] { 3, 2, "female", false, "Shiba", "insightful", 40, "hamster" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);
        }
    }
}
