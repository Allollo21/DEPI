using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "MgrName", "Name" },
                values: new object[,]
                {
                    { 1, "Dr. Smith", "Computer Science" },
                    { 2, "Dr. Johnson", "Mathematics" },
                    { 3, "Dr. Brown", "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 20, 1, "Alice Johnson" },
                    { 2, 22, 1, "Bob Williams" },
                    { 3, 19, 2, "Carol Davis" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Address", "DepartmentId", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, "John Doe", 75000m },
                    { 2, "456 Oak Ave", 1, "Jane Smith", 80000m },
                    { 3, "789 Pine Rd", 2, "Mike Wilson", 72000m }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DepartmentId", "MinDegree", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Bachelor", 1, "Certificate", "Introduction to Programming", 1 },
                    { 2, "Bachelor", 1, "Bachelor", "Data Structures", 2 },
                    { 3, "Bachelor", 2, "Certificate", "Calculus I", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourseResults",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, "A", 1 },
                    { 2, 2, "B+", 1 },
                    { 3, 1, "A-", 2 },
                    { 4, 3, "A", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
