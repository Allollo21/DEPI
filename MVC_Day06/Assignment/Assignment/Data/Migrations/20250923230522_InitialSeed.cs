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
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Teachers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "MgrName", "Name" },
                values: new object[,]
                {
                    { 1, "Manager 1", "Department of Computer Science" },
                    { 2, "Manager 2", "Department of Mathematics" },
                    { 3, "Manager 3", "Department of Physics" },
                    { 4, "Manager 4", "Department of Chemistry" },
                    { 5, "Manager 5", "Department of Biology" },
                    { 6, "Manager 6", "Department of History" },
                    { 7, "Manager 7", "Department of English" },
                    { 8, "Manager 8", "Department of Psychology" },
                    { 9, "Manager 9", "Department of Economics" },
                    { 10, "Manager 10", "Department of Engineering" },
                    { 11, "Manager 11", "Department of Art" },
                    { 12, "Manager 12", "Department of Music" },
                    { 13, "Manager 13", "Department of Philosophy" },
                    { 14, "Manager 14", "Department of Sociology" },
                    { 15, "Manager 15", "Department of Geography" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 19, 1, "Student 1" },
                    { 2, 20, 1, "Student 2" },
                    { 3, 21, 1, "Student 3" },
                    { 4, 22, 1, "Student 4" },
                    { 5, 23, 1, "Student 5" },
                    { 6, 24, 1, "Student 6" },
                    { 7, 25, 1, "Student 7" },
                    { 8, 26, 1, "Student 8" },
                    { 9, 27, 1, "Student 9" },
                    { 10, 18, 1, "Student 10" },
                    { 11, 19, 1, "Student 11" },
                    { 12, 20, 1, "Student 12" },
                    { 13, 21, 1, "Student 13" },
                    { 14, 22, 1, "Student 14" },
                    { 15, 23, 1, "Student 15" },
                    { 16, 24, 1, "Student 16" },
                    { 17, 25, 1, "Student 17" },
                    { 18, 26, 1, "Student 18" },
                    { 19, 27, 1, "Student 19" },
                    { 20, 18, 1, "Student 20" },
                    { 21, 19, 1, "Student 21" },
                    { 22, 20, 1, "Student 22" },
                    { 23, 21, 1, "Student 23" },
                    { 24, 22, 1, "Student 24" },
                    { 25, 23, 1, "Student 25" },
                    { 26, 24, 1, "Student 26" },
                    { 27, 25, 1, "Student 27" },
                    { 28, 26, 1, "Student 28" },
                    { 29, 27, 1, "Student 29" },
                    { 30, 18, 1, "Student 30" },
                    { 31, 19, 1, "Student 31" },
                    { 32, 20, 1, "Student 32" },
                    { 33, 21, 1, "Student 33" },
                    { 34, 22, 1, "Student 34" },
                    { 35, 23, 1, "Student 35" },
                    { 36, 24, 1, "Student 36" },
                    { 37, 25, 1, "Student 37" },
                    { 38, 26, 1, "Student 38" },
                    { 39, 27, 1, "Student 39" },
                    { 40, 18, 1, "Student 40" },
                    { 41, 19, 1, "Student 41" },
                    { 42, 20, 1, "Student 42" },
                    { 43, 21, 1, "Student 43" },
                    { 44, 22, 1, "Student 44" },
                    { 45, 23, 1, "Student 45" },
                    { 46, 24, 1, "Student 46" },
                    { 47, 25, 1, "Student 47" },
                    { 48, 26, 1, "Student 48" },
                    { 49, 27, 1, "Student 49" },
                    { 50, 18, 1, "Student 50" },
                    { 51, 19, 1, "Student 51" },
                    { 52, 20, 1, "Student 52" },
                    { 53, 21, 1, "Student 53" },
                    { 54, 22, 1, "Student 54" },
                    { 55, 23, 1, "Student 55" },
                    { 56, 24, 1, "Student 56" },
                    { 57, 25, 1, "Student 57" },
                    { 58, 26, 1, "Student 58" },
                    { 59, 27, 1, "Student 59" },
                    { 60, 18, 1, "Student 60" },
                    { 61, 19, 2, "Student 61" },
                    { 62, 20, 2, "Student 62" },
                    { 63, 21, 2, "Student 63" },
                    { 64, 22, 2, "Student 64" },
                    { 65, 23, 2, "Student 65" },
                    { 66, 24, 2, "Student 66" },
                    { 67, 25, 2, "Student 67" },
                    { 68, 26, 2, "Student 68" },
                    { 69, 27, 2, "Student 69" },
                    { 70, 18, 2, "Student 70" },
                    { 71, 19, 2, "Student 71" },
                    { 72, 20, 2, "Student 72" },
                    { 73, 21, 2, "Student 73" },
                    { 74, 22, 2, "Student 74" },
                    { 75, 23, 2, "Student 75" },
                    { 76, 24, 2, "Student 76" },
                    { 77, 25, 2, "Student 77" },
                    { 78, 26, 2, "Student 78" },
                    { 79, 27, 2, "Student 79" },
                    { 80, 18, 2, "Student 80" },
                    { 81, 19, 2, "Student 81" },
                    { 82, 20, 2, "Student 82" },
                    { 83, 21, 2, "Student 83" },
                    { 84, 22, 2, "Student 84" },
                    { 85, 23, 2, "Student 85" },
                    { 86, 24, 2, "Student 86" },
                    { 87, 25, 2, "Student 87" },
                    { 88, 26, 2, "Student 88" },
                    { 89, 27, 2, "Student 89" },
                    { 90, 18, 2, "Student 90" },
                    { 91, 19, 2, "Student 91" },
                    { 92, 20, 2, "Student 92" },
                    { 93, 21, 2, "Student 93" },
                    { 94, 22, 2, "Student 94" },
                    { 95, 23, 2, "Student 95" },
                    { 96, 24, 2, "Student 96" },
                    { 97, 25, 2, "Student 97" },
                    { 98, 26, 2, "Student 98" },
                    { 99, 27, 2, "Student 99" },
                    { 100, 18, 2, "Student 100" },
                    { 101, 19, 2, "Student 101" },
                    { 102, 20, 2, "Student 102" },
                    { 103, 21, 2, "Student 103" },
                    { 104, 22, 2, "Student 104" },
                    { 105, 23, 2, "Student 105" },
                    { 106, 24, 2, "Student 106" },
                    { 107, 25, 2, "Student 107" },
                    { 108, 26, 2, "Student 108" },
                    { 109, 27, 2, "Student 109" },
                    { 110, 18, 2, "Student 110" },
                    { 111, 19, 3, "Student 111" },
                    { 112, 20, 3, "Student 112" },
                    { 113, 21, 3, "Student 113" },
                    { 114, 22, 3, "Student 114" },
                    { 115, 23, 3, "Student 115" },
                    { 116, 24, 3, "Student 116" },
                    { 117, 25, 3, "Student 117" },
                    { 118, 26, 3, "Student 118" },
                    { 119, 27, 3, "Student 119" },
                    { 120, 18, 3, "Student 120" },
                    { 121, 19, 3, "Student 121" },
                    { 122, 20, 3, "Student 122" },
                    { 123, 21, 3, "Student 123" },
                    { 124, 22, 3, "Student 124" },
                    { 125, 23, 3, "Student 125" },
                    { 126, 24, 3, "Student 126" },
                    { 127, 25, 3, "Student 127" },
                    { 128, 26, 3, "Student 128" },
                    { 129, 27, 3, "Student 129" },
                    { 130, 18, 3, "Student 130" },
                    { 131, 19, 3, "Student 131" },
                    { 132, 20, 3, "Student 132" },
                    { 133, 21, 3, "Student 133" },
                    { 134, 22, 3, "Student 134" },
                    { 135, 23, 3, "Student 135" },
                    { 136, 24, 3, "Student 136" },
                    { 137, 25, 3, "Student 137" },
                    { 138, 26, 3, "Student 138" },
                    { 139, 27, 3, "Student 139" },
                    { 140, 18, 3, "Student 140" },
                    { 141, 19, 4, "Student 141" },
                    { 142, 20, 5, "Student 142" },
                    { 143, 21, 6, "Student 143" },
                    { 144, 22, 7, "Student 144" },
                    { 145, 23, 8, "Student 145" },
                    { 146, 24, 9, "Student 146" },
                    { 147, 25, 10, "Student 147" },
                    { 148, 26, 11, "Student 148" },
                    { 149, 27, 12, "Student 149" },
                    { 150, 18, 13, "Student 150" },
                    { 151, 19, 14, "Student 151" },
                    { 152, 20, 15, "Student 152" },
                    { 153, 21, 4, "Student 153" },
                    { 154, 22, 5, "Student 154" },
                    { 155, 23, 6, "Student 155" },
                    { 156, 24, 7, "Student 156" },
                    { 157, 25, 8, "Student 157" },
                    { 158, 26, 9, "Student 158" },
                    { 159, 27, 10, "Student 159" },
                    { 160, 18, 11, "Student 160" },
                    { 161, 19, 12, "Student 161" },
                    { 162, 20, 13, "Student 162" },
                    { 163, 21, 14, "Student 163" },
                    { 164, 22, 15, "Student 164" },
                    { 165, 23, 4, "Student 165" },
                    { 166, 24, 5, "Student 166" },
                    { 167, 25, 6, "Student 167" },
                    { 168, 26, 7, "Student 168" },
                    { 169, 27, 8, "Student 169" },
                    { 170, 18, 9, "Student 170" },
                    { 171, 19, 10, "Student 171" },
                    { 172, 20, 11, "Student 172" },
                    { 173, 21, 12, "Student 173" },
                    { 174, 22, 13, "Student 174" },
                    { 175, 23, 14, "Student 175" },
                    { 176, 24, 15, "Student 176" },
                    { 177, 25, 4, "Student 177" },
                    { 178, 26, 5, "Student 178" },
                    { 179, 27, 6, "Student 179" },
                    { 180, 18, 7, "Student 180" },
                    { 181, 19, 8, "Student 181" },
                    { 182, 20, 9, "Student 182" },
                    { 183, 21, 10, "Student 183" },
                    { 184, 22, 11, "Student 184" },
                    { 185, 23, 12, "Student 185" },
                    { 186, 24, 13, "Student 186" },
                    { 187, 25, 14, "Student 187" },
                    { 188, 26, 15, "Student 188" },
                    { 189, 27, 4, "Student 189" },
                    { 190, 18, 5, "Student 190" },
                    { 191, 19, 6, "Student 191" },
                    { 192, 20, 7, "Student 192" },
                    { 193, 21, 8, "Student 193" },
                    { 194, 22, 9, "Student 194" },
                    { 195, 23, 10, "Student 195" },
                    { 196, 24, 11, "Student 196" },
                    { 197, 25, 12, "Student 197" },
                    { 198, 26, 13, "Student 198" },
                    { 199, 27, 14, "Student 199" },
                    { 200, 18, 15, "Student 200" },
                    { 201, 19, 4, "Student 201" },
                    { 202, 20, 5, "Student 202" },
                    { 203, 21, 6, "Student 203" },
                    { 204, 22, 7, "Student 204" },
                    { 205, 23, 8, "Student 205" },
                    { 206, 24, 9, "Student 206" },
                    { 207, 25, 10, "Student 207" },
                    { 208, 26, 11, "Student 208" },
                    { 209, 27, 12, "Student 209" },
                    { 210, 18, 13, "Student 210" },
                    { 211, 19, 14, "Student 211" },
                    { 212, 20, 15, "Student 212" },
                    { 213, 21, 4, "Student 213" },
                    { 214, 22, 5, "Student 214" },
                    { 215, 23, 6, "Student 215" },
                    { 216, 24, 7, "Student 216" },
                    { 217, 25, 8, "Student 217" },
                    { 218, 26, 9, "Student 218" },
                    { 219, 27, 10, "Student 219" },
                    { 220, 18, 11, "Student 220" },
                    { 221, 19, 12, "Student 221" },
                    { 222, 20, 13, "Student 222" },
                    { 223, 21, 14, "Student 223" },
                    { 224, 22, 15, "Student 224" },
                    { 225, 23, 4, "Student 225" },
                    { 226, 24, 5, "Student 226" },
                    { 227, 25, 6, "Student 227" },
                    { 228, 26, 7, "Student 228" },
                    { 229, 27, 8, "Student 229" },
                    { 230, 18, 9, "Student 230" },
                    { 231, 19, 10, "Student 231" },
                    { 232, 20, 11, "Student 232" },
                    { 233, 21, 12, "Student 233" },
                    { 234, 22, 13, "Student 234" },
                    { 235, 23, 14, "Student 235" },
                    { 236, 24, 15, "Student 236" },
                    { 237, 25, 4, "Student 237" },
                    { 238, 26, 5, "Student 238" },
                    { 239, 27, 6, "Student 239" },
                    { 240, 18, 7, "Student 240" },
                    { 241, 19, 8, "Student 241" },
                    { 242, 20, 9, "Student 242" },
                    { 243, 21, 10, "Student 243" },
                    { 244, 22, 11, "Student 244" },
                    { 245, 23, 12, "Student 245" },
                    { 246, 24, 13, "Student 246" },
                    { 247, 25, 14, "Student 247" },
                    { 248, 26, 15, "Student 248" },
                    { 249, 27, 4, "Student 249" },
                    { 250, 18, 5, "Student 250" },
                    { 251, 19, 6, "Student 251" },
                    { 252, 20, 7, "Student 252" },
                    { 253, 21, 8, "Student 253" },
                    { 254, 22, 9, "Student 254" },
                    { 255, 23, 10, "Student 255" },
                    { 256, 24, 11, "Student 256" },
                    { 257, 25, 12, "Student 257" },
                    { 258, 26, 13, "Student 258" },
                    { 259, 27, 14, "Student 259" },
                    { 260, 18, 15, "Student 260" },
                    { 261, 19, 4, "Student 261" },
                    { 262, 20, 5, "Student 262" },
                    { 263, 21, 6, "Student 263" },
                    { 264, 22, 7, "Student 264" },
                    { 265, 23, 8, "Student 265" },
                    { 266, 24, 9, "Student 266" },
                    { 267, 25, 10, "Student 267" },
                    { 268, 26, 11, "Student 268" },
                    { 269, 27, 12, "Student 269" },
                    { 270, 18, 13, "Student 270" },
                    { 271, 19, 14, "Student 271" },
                    { 272, 20, 15, "Student 272" },
                    { 273, 21, 4, "Student 273" },
                    { 274, 22, 5, "Student 274" },
                    { 275, 23, 6, "Student 275" },
                    { 276, 24, 7, "Student 276" },
                    { 277, 25, 8, "Student 277" },
                    { 278, 26, 9, "Student 278" },
                    { 279, 27, 10, "Student 279" },
                    { 280, 18, 11, "Student 280" },
                    { 281, 19, 12, "Student 281" },
                    { 282, 20, 13, "Student 282" },
                    { 283, 21, 14, "Student 283" },
                    { 284, 22, 15, "Student 284" },
                    { 285, 23, 4, "Student 285" },
                    { 286, 24, 5, "Student 286" },
                    { 287, 25, 6, "Student 287" },
                    { 288, 26, 7, "Student 288" },
                    { 289, 27, 8, "Student 289" },
                    { 290, 18, 9, "Student 290" },
                    { 291, 19, 10, "Student 291" },
                    { 292, 20, 11, "Student 292" },
                    { 293, 21, 12, "Student 293" },
                    { 294, 22, 13, "Student 294" },
                    { 295, 23, 14, "Student 295" },
                    { 296, 24, 15, "Student 296" },
                    { 297, 25, 4, "Student 297" },
                    { 298, 26, 5, "Student 298" },
                    { 299, 27, 6, "Student 299" },
                    { 300, 18, 7, "Student 300" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Address", "DepartmentId", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "1 Academic Street", 1, "Teacher 1", 50500m },
                    { 2, "2 Academic Street", 1, "Teacher 2", 51000m },
                    { 3, "3 Academic Street", 1, "Teacher 3", 51500m },
                    { 4, "4 Academic Street", 1, "Teacher 4", 52000m },
                    { 5, "5 Academic Street", 1, "Teacher 5", 52500m },
                    { 6, "6 Academic Street", 1, "Teacher 6", 53000m },
                    { 7, "7 Academic Street", 1, "Teacher 7", 53500m },
                    { 8, "8 Academic Street", 1, "Teacher 8", 54000m },
                    { 9, "9 Academic Street", 1, "Teacher 9", 54500m },
                    { 10, "10 Academic Street", 1, "Teacher 10", 55000m },
                    { 11, "11 Academic Street", 1, "Teacher 11", 55500m },
                    { 12, "12 Academic Street", 1, "Teacher 12", 56000m },
                    { 13, "13 Academic Street", 1, "Teacher 13", 56500m },
                    { 14, "14 Academic Street", 1, "Teacher 14", 57000m },
                    { 15, "15 Academic Street", 1, "Teacher 15", 57500m },
                    { 16, "16 Academic Street", 1, "Teacher 16", 58000m },
                    { 17, "17 Academic Street", 1, "Teacher 17", 58500m },
                    { 18, "18 Academic Street", 1, "Teacher 18", 59000m },
                    { 19, "19 Academic Street", 1, "Teacher 19", 59500m },
                    { 20, "20 Academic Street", 1, "Teacher 20", 60000m },
                    { 21, "21 Academic Street", 1, "Teacher 21", 60500m },
                    { 22, "22 Academic Street", 1, "Teacher 22", 61000m },
                    { 23, "23 Academic Street", 1, "Teacher 23", 61500m },
                    { 24, "24 Academic Street", 1, "Teacher 24", 62000m },
                    { 25, "25 Academic Street", 1, "Teacher 25", 62500m },
                    { 26, "26 Academic Street", 1, "Teacher 26", 63000m },
                    { 27, "27 Academic Street", 1, "Teacher 27", 63500m },
                    { 28, "28 Academic Street", 1, "Teacher 28", 64000m },
                    { 29, "29 Academic Street", 1, "Teacher 29", 64500m },
                    { 30, "30 Academic Street", 1, "Teacher 30", 65000m },
                    { 31, "31 Academic Street", 1, "Teacher 31", 65500m },
                    { 32, "32 Academic Street", 1, "Teacher 32", 66000m },
                    { 33, "33 Academic Street", 1, "Teacher 33", 66500m },
                    { 34, "34 Academic Street", 1, "Teacher 34", 67000m },
                    { 35, "35 Academic Street", 1, "Teacher 35", 67500m },
                    { 36, "36 Academic Street", 1, "Teacher 36", 68000m },
                    { 37, "37 Academic Street", 1, "Teacher 37", 68500m },
                    { 38, "38 Academic Street", 1, "Teacher 38", 69000m },
                    { 39, "39 Academic Street", 1, "Teacher 39", 69500m },
                    { 40, "40 Academic Street", 1, "Teacher 40", 70000m },
                    { 41, "41 Academic Street", 1, "Teacher 41", 70500m },
                    { 42, "42 Academic Street", 1, "Teacher 42", 71000m },
                    { 43, "43 Academic Street", 1, "Teacher 43", 71500m },
                    { 44, "44 Academic Street", 1, "Teacher 44", 72000m },
                    { 45, "45 Academic Street", 1, "Teacher 45", 72500m },
                    { 46, "46 Academic Street", 1, "Teacher 46", 73000m },
                    { 47, "47 Academic Street", 1, "Teacher 47", 73500m },
                    { 48, "48 Academic Street", 1, "Teacher 48", 74000m },
                    { 49, "49 Academic Street", 1, "Teacher 49", 74500m },
                    { 50, "50 Academic Street", 1, "Teacher 50", 75000m },
                    { 51, "51 Academic Street", 1, "Teacher 51", 75500m },
                    { 52, "52 Academic Street", 1, "Teacher 52", 76000m },
                    { 53, "53 Academic Street", 1, "Teacher 53", 76500m },
                    { 54, "54 Academic Street", 1, "Teacher 54", 77000m },
                    { 55, "55 Academic Street", 1, "Teacher 55", 77500m },
                    { 56, "56 Academic Street", 1, "Teacher 56", 78000m },
                    { 57, "57 Academic Street", 1, "Teacher 57", 78500m },
                    { 58, "58 Academic Street", 1, "Teacher 58", 79000m },
                    { 59, "59 Academic Street", 1, "Teacher 59", 79500m },
                    { 60, "60 Academic Street", 1, "Teacher 60", 80000m },
                    { 61, "61 Academic Street", 2, "Teacher 61", 80500m },
                    { 62, "62 Academic Street", 2, "Teacher 62", 81000m },
                    { 63, "63 Academic Street", 2, "Teacher 63", 81500m },
                    { 64, "64 Academic Street", 2, "Teacher 64", 82000m },
                    { 65, "65 Academic Street", 2, "Teacher 65", 82500m },
                    { 66, "66 Academic Street", 2, "Teacher 66", 83000m },
                    { 67, "67 Academic Street", 2, "Teacher 67", 83500m },
                    { 68, "68 Academic Street", 2, "Teacher 68", 84000m },
                    { 69, "69 Academic Street", 2, "Teacher 69", 84500m },
                    { 70, "70 Academic Street", 2, "Teacher 70", 85000m },
                    { 71, "71 Academic Street", 2, "Teacher 71", 85500m },
                    { 72, "72 Academic Street", 2, "Teacher 72", 86000m },
                    { 73, "73 Academic Street", 2, "Teacher 73", 86500m },
                    { 74, "74 Academic Street", 2, "Teacher 74", 87000m },
                    { 75, "75 Academic Street", 2, "Teacher 75", 87500m },
                    { 76, "76 Academic Street", 2, "Teacher 76", 88000m },
                    { 77, "77 Academic Street", 2, "Teacher 77", 88500m },
                    { 78, "78 Academic Street", 2, "Teacher 78", 89000m },
                    { 79, "79 Academic Street", 2, "Teacher 79", 89500m },
                    { 80, "80 Academic Street", 2, "Teacher 80", 90000m },
                    { 81, "81 Academic Street", 2, "Teacher 81", 90500m },
                    { 82, "82 Academic Street", 2, "Teacher 82", 91000m },
                    { 83, "83 Academic Street", 2, "Teacher 83", 91500m },
                    { 84, "84 Academic Street", 2, "Teacher 84", 92000m },
                    { 85, "85 Academic Street", 2, "Teacher 85", 92500m },
                    { 86, "86 Academic Street", 2, "Teacher 86", 93000m },
                    { 87, "87 Academic Street", 2, "Teacher 87", 93500m },
                    { 88, "88 Academic Street", 2, "Teacher 88", 94000m },
                    { 89, "89 Academic Street", 2, "Teacher 89", 94500m },
                    { 90, "90 Academic Street", 2, "Teacher 90", 95000m },
                    { 91, "91 Academic Street", 2, "Teacher 91", 95500m },
                    { 92, "92 Academic Street", 2, "Teacher 92", 96000m },
                    { 93, "93 Academic Street", 2, "Teacher 93", 96500m },
                    { 94, "94 Academic Street", 2, "Teacher 94", 97000m },
                    { 95, "95 Academic Street", 2, "Teacher 95", 97500m },
                    { 96, "96 Academic Street", 2, "Teacher 96", 98000m },
                    { 97, "97 Academic Street", 2, "Teacher 97", 98500m },
                    { 98, "98 Academic Street", 2, "Teacher 98", 99000m },
                    { 99, "99 Academic Street", 2, "Teacher 99", 99500m },
                    { 100, "100 Academic Street", 2, "Teacher 100", 100000m },
                    { 101, "101 Academic Street", 2, "Teacher 101", 100500m },
                    { 102, "102 Academic Street", 2, "Teacher 102", 101000m },
                    { 103, "103 Academic Street", 2, "Teacher 103", 101500m },
                    { 104, "104 Academic Street", 2, "Teacher 104", 102000m },
                    { 105, "105 Academic Street", 2, "Teacher 105", 102500m },
                    { 106, "106 Academic Street", 2, "Teacher 106", 103000m },
                    { 107, "107 Academic Street", 2, "Teacher 107", 103500m },
                    { 108, "108 Academic Street", 2, "Teacher 108", 104000m },
                    { 109, "109 Academic Street", 2, "Teacher 109", 104500m },
                    { 110, "110 Academic Street", 2, "Teacher 110", 105000m },
                    { 111, "111 Academic Street", 3, "Teacher 111", 105500m },
                    { 112, "112 Academic Street", 3, "Teacher 112", 106000m },
                    { 113, "113 Academic Street", 3, "Teacher 113", 106500m },
                    { 114, "114 Academic Street", 3, "Teacher 114", 107000m },
                    { 115, "115 Academic Street", 3, "Teacher 115", 107500m },
                    { 116, "116 Academic Street", 3, "Teacher 116", 108000m },
                    { 117, "117 Academic Street", 3, "Teacher 117", 108500m },
                    { 118, "118 Academic Street", 3, "Teacher 118", 109000m },
                    { 119, "119 Academic Street", 3, "Teacher 119", 109500m },
                    { 120, "120 Academic Street", 3, "Teacher 120", 110000m },
                    { 121, "121 Academic Street", 3, "Teacher 121", 110500m },
                    { 122, "122 Academic Street", 3, "Teacher 122", 111000m },
                    { 123, "123 Academic Street", 3, "Teacher 123", 111500m },
                    { 124, "124 Academic Street", 3, "Teacher 124", 112000m },
                    { 125, "125 Academic Street", 3, "Teacher 125", 112500m },
                    { 126, "126 Academic Street", 3, "Teacher 126", 113000m },
                    { 127, "127 Academic Street", 3, "Teacher 127", 113500m },
                    { 128, "128 Academic Street", 3, "Teacher 128", 114000m },
                    { 129, "129 Academic Street", 3, "Teacher 129", 114500m },
                    { 130, "130 Academic Street", 3, "Teacher 130", 115000m },
                    { 131, "131 Academic Street", 3, "Teacher 131", 115500m },
                    { 132, "132 Academic Street", 3, "Teacher 132", 116000m },
                    { 133, "133 Academic Street", 3, "Teacher 133", 116500m },
                    { 134, "134 Academic Street", 3, "Teacher 134", 117000m },
                    { 135, "135 Academic Street", 3, "Teacher 135", 117500m },
                    { 136, "136 Academic Street", 3, "Teacher 136", 118000m },
                    { 137, "137 Academic Street", 3, "Teacher 137", 118500m },
                    { 138, "138 Academic Street", 3, "Teacher 138", 119000m },
                    { 139, "139 Academic Street", 3, "Teacher 139", 119500m },
                    { 140, "140 Academic Street", 3, "Teacher 140", 120000m },
                    { 141, "141 Academic Street", 4, "Teacher 141", 120500m },
                    { 142, "142 Academic Street", 5, "Teacher 142", 121000m },
                    { 143, "143 Academic Street", 6, "Teacher 143", 121500m },
                    { 144, "144 Academic Street", 7, "Teacher 144", 122000m },
                    { 145, "145 Academic Street", 8, "Teacher 145", 122500m },
                    { 146, "146 Academic Street", 9, "Teacher 146", 123000m },
                    { 147, "147 Academic Street", 10, "Teacher 147", 123500m },
                    { 148, "148 Academic Street", 11, "Teacher 148", 124000m },
                    { 149, "149 Academic Street", 12, "Teacher 149", 124500m },
                    { 150, "150 Academic Street", 13, "Teacher 150", 125000m }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DepartmentId", "MinDegree", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Master", 1, "Certificate", "Course 1", 2 },
                    { 2, "PhD", 1, "Certificate", "Course 2", 3 },
                    { 3, "Certificate", 1, "Certificate", "Course 3", 4 },
                    { 4, "Bachelor", 1, "Certificate", "Course 4", 5 },
                    { 5, "Master", 1, "Certificate", "Course 5", 6 },
                    { 6, "PhD", 1, "Certificate", "Course 6", 7 },
                    { 7, "Certificate", 1, "Certificate", "Course 7", 8 },
                    { 8, "Bachelor", 1, "Certificate", "Course 8", 9 },
                    { 9, "Master", 1, "Certificate", "Course 9", 10 },
                    { 10, "PhD", 1, "Certificate", "Course 10", 11 },
                    { 11, "Certificate", 1, "Certificate", "Course 11", 12 },
                    { 12, "Bachelor", 1, "Certificate", "Course 12", 13 },
                    { 13, "Master", 1, "Certificate", "Course 13", 14 },
                    { 14, "PhD", 1, "Certificate", "Course 14", 15 },
                    { 15, "Certificate", 1, "Certificate", "Course 15", 16 },
                    { 16, "Bachelor", 1, "Certificate", "Course 16", 17 },
                    { 17, "Master", 1, "Certificate", "Course 17", 18 },
                    { 18, "PhD", 1, "Certificate", "Course 18", 19 },
                    { 19, "Certificate", 1, "Certificate", "Course 19", 20 },
                    { 20, "Bachelor", 1, "Certificate", "Course 20", 21 },
                    { 21, "Master", 1, "Certificate", "Course 21", 22 },
                    { 22, "PhD", 1, "Certificate", "Course 22", 23 },
                    { 23, "Certificate", 1, "Certificate", "Course 23", 24 },
                    { 24, "Bachelor", 1, "Certificate", "Course 24", 25 },
                    { 25, "Master", 1, "Certificate", "Course 25", 26 },
                    { 26, "PhD", 1, "Certificate", "Course 26", 27 },
                    { 27, "Certificate", 1, "Certificate", "Course 27", 28 },
                    { 28, "Bachelor", 1, "Certificate", "Course 28", 29 },
                    { 29, "Master", 1, "Certificate", "Course 29", 30 },
                    { 30, "PhD", 1, "Certificate", "Course 30", 31 },
                    { 31, "Certificate", 1, "Certificate", "Course 31", 32 },
                    { 32, "Bachelor", 1, "Certificate", "Course 32", 33 },
                    { 33, "Master", 1, "Certificate", "Course 33", 34 },
                    { 34, "PhD", 1, "Certificate", "Course 34", 35 },
                    { 35, "Certificate", 1, "Certificate", "Course 35", 36 },
                    { 36, "Bachelor", 1, "Certificate", "Course 36", 37 },
                    { 37, "Master", 1, "Certificate", "Course 37", 38 },
                    { 38, "PhD", 1, "Certificate", "Course 38", 39 },
                    { 39, "Certificate", 1, "Certificate", "Course 39", 40 },
                    { 40, "Bachelor", 1, "Certificate", "Course 40", 41 },
                    { 41, "Master", 1, "Certificate", "Course 41", 42 },
                    { 42, "PhD", 1, "Certificate", "Course 42", 43 },
                    { 43, "Certificate", 1, "Certificate", "Course 43", 44 },
                    { 44, "Bachelor", 1, "Certificate", "Course 44", 45 },
                    { 45, "Master", 1, "Certificate", "Course 45", 46 },
                    { 46, "PhD", 1, "Certificate", "Course 46", 47 },
                    { 47, "Certificate", 1, "Certificate", "Course 47", 48 },
                    { 48, "Bachelor", 1, "Certificate", "Course 48", 49 },
                    { 49, "Master", 1, "Certificate", "Course 49", 50 },
                    { 50, "PhD", 1, "Certificate", "Course 50", 51 },
                    { 51, "Certificate", 1, "Certificate", "Course 51", 52 },
                    { 52, "Bachelor", 1, "Certificate", "Course 52", 53 },
                    { 53, "Master", 1, "Certificate", "Course 53", 54 },
                    { 54, "PhD", 1, "Certificate", "Course 54", 55 },
                    { 55, "Certificate", 1, "Certificate", "Course 55", 56 },
                    { 56, "Bachelor", 1, "Certificate", "Course 56", 57 },
                    { 57, "Master", 1, "Certificate", "Course 57", 58 },
                    { 58, "PhD", 1, "Certificate", "Course 58", 59 },
                    { 59, "Certificate", 1, "Certificate", "Course 59", 60 },
                    { 60, "Bachelor", 1, "Certificate", "Course 60", 61 },
                    { 61, "Master", 2, "Certificate", "Course 61", 62 },
                    { 62, "PhD", 2, "Certificate", "Course 62", 63 },
                    { 63, "Certificate", 2, "Certificate", "Course 63", 64 },
                    { 64, "Bachelor", 2, "Certificate", "Course 64", 65 },
                    { 65, "Master", 2, "Certificate", "Course 65", 66 },
                    { 66, "PhD", 2, "Certificate", "Course 66", 67 },
                    { 67, "Certificate", 2, "Certificate", "Course 67", 68 },
                    { 68, "Bachelor", 2, "Certificate", "Course 68", 69 },
                    { 69, "Master", 2, "Certificate", "Course 69", 70 },
                    { 70, "PhD", 2, "Certificate", "Course 70", 71 },
                    { 71, "Certificate", 2, "Certificate", "Course 71", 72 },
                    { 72, "Bachelor", 2, "Certificate", "Course 72", 73 },
                    { 73, "Master", 2, "Certificate", "Course 73", 74 },
                    { 74, "PhD", 2, "Certificate", "Course 74", 75 },
                    { 75, "Certificate", 2, "Certificate", "Course 75", 76 },
                    { 76, "Bachelor", 2, "Certificate", "Course 76", 77 },
                    { 77, "Master", 2, "Certificate", "Course 77", 78 },
                    { 78, "PhD", 2, "Certificate", "Course 78", 79 },
                    { 79, "Certificate", 2, "Certificate", "Course 79", 80 },
                    { 80, "Bachelor", 2, "Certificate", "Course 80", 81 },
                    { 81, "Master", 2, "Certificate", "Course 81", 82 },
                    { 82, "PhD", 2, "Certificate", "Course 82", 83 },
                    { 83, "Certificate", 2, "Certificate", "Course 83", 84 },
                    { 84, "Bachelor", 2, "Certificate", "Course 84", 85 },
                    { 85, "Master", 2, "Certificate", "Course 85", 86 },
                    { 86, "PhD", 2, "Certificate", "Course 86", 87 },
                    { 87, "Certificate", 2, "Certificate", "Course 87", 88 },
                    { 88, "Bachelor", 2, "Certificate", "Course 88", 89 },
                    { 89, "Master", 2, "Certificate", "Course 89", 90 },
                    { 90, "PhD", 2, "Certificate", "Course 90", 91 },
                    { 91, "Certificate", 2, "Certificate", "Course 91", 92 },
                    { 92, "Bachelor", 2, "Certificate", "Course 92", 93 },
                    { 93, "Master", 2, "Certificate", "Course 93", 94 },
                    { 94, "PhD", 2, "Certificate", "Course 94", 95 },
                    { 95, "Certificate", 2, "Certificate", "Course 95", 96 },
                    { 96, "Bachelor", 2, "Certificate", "Course 96", 97 },
                    { 97, "Master", 2, "Certificate", "Course 97", 98 },
                    { 98, "PhD", 2, "Certificate", "Course 98", 99 },
                    { 99, "Certificate", 2, "Certificate", "Course 99", 100 },
                    { 100, "Bachelor", 2, "Certificate", "Course 100", 101 },
                    { 101, "Master", 2, "Certificate", "Course 101", 102 },
                    { 102, "PhD", 2, "Certificate", "Course 102", 103 },
                    { 103, "Certificate", 2, "Certificate", "Course 103", 104 },
                    { 104, "Bachelor", 2, "Certificate", "Course 104", 105 },
                    { 105, "Master", 2, "Certificate", "Course 105", 106 },
                    { 106, "PhD", 2, "Certificate", "Course 106", 107 },
                    { 107, "Certificate", 2, "Certificate", "Course 107", 108 },
                    { 108, "Bachelor", 2, "Certificate", "Course 108", 109 },
                    { 109, "Master", 2, "Certificate", "Course 109", 110 },
                    { 110, "PhD", 2, "Certificate", "Course 110", 111 },
                    { 111, "Certificate", 3, "Certificate", "Course 111", 112 },
                    { 112, "Bachelor", 3, "Certificate", "Course 112", 113 },
                    { 113, "Master", 3, "Certificate", "Course 113", 114 },
                    { 114, "PhD", 3, "Certificate", "Course 114", 115 },
                    { 115, "Certificate", 3, "Certificate", "Course 115", 116 },
                    { 116, "Bachelor", 3, "Certificate", "Course 116", 117 },
                    { 117, "Master", 3, "Certificate", "Course 117", 118 },
                    { 118, "PhD", 3, "Certificate", "Course 118", 119 },
                    { 119, "Certificate", 3, "Certificate", "Course 119", 120 },
                    { 120, "Bachelor", 3, "Certificate", "Course 120", 121 },
                    { 121, "Master", 3, "Certificate", "Course 121", 122 },
                    { 122, "PhD", 3, "Certificate", "Course 122", 123 },
                    { 123, "Certificate", 3, "Certificate", "Course 123", 124 },
                    { 124, "Bachelor", 3, "Certificate", "Course 124", 125 },
                    { 125, "Master", 3, "Certificate", "Course 125", 126 },
                    { 126, "PhD", 3, "Certificate", "Course 126", 127 },
                    { 127, "Certificate", 3, "Certificate", "Course 127", 128 },
                    { 128, "Bachelor", 3, "Certificate", "Course 128", 129 },
                    { 129, "Master", 3, "Certificate", "Course 129", 130 },
                    { 130, "PhD", 3, "Certificate", "Course 130", 131 },
                    { 131, "Certificate", 3, "Certificate", "Course 131", 132 },
                    { 132, "Bachelor", 3, "Certificate", "Course 132", 133 },
                    { 133, "Master", 3, "Certificate", "Course 133", 134 },
                    { 134, "PhD", 3, "Certificate", "Course 134", 135 },
                    { 135, "Certificate", 3, "Certificate", "Course 135", 136 },
                    { 136, "Bachelor", 3, "Certificate", "Course 136", 137 },
                    { 137, "Master", 3, "Certificate", "Course 137", 138 },
                    { 138, "PhD", 3, "Certificate", "Course 138", 139 },
                    { 139, "Certificate", 3, "Certificate", "Course 139", 140 },
                    { 140, "Bachelor", 3, "Certificate", "Course 140", 141 },
                    { 141, "Master", 4, "Certificate", "Course 141", 142 },
                    { 142, "PhD", 5, "Certificate", "Course 142", 143 },
                    { 143, "Certificate", 6, "Certificate", "Course 143", 144 },
                    { 144, "Bachelor", 7, "Certificate", "Course 144", 145 },
                    { 145, "Master", 8, "Certificate", "Course 145", 146 },
                    { 146, "PhD", 9, "Certificate", "Course 146", 147 },
                    { 147, "Certificate", 10, "Certificate", "Course 147", 148 },
                    { 148, "Bachelor", 11, "Certificate", "Course 148", 149 },
                    { 149, "Master", 12, "Certificate", "Course 149", 150 },
                    { 150, "PhD", 13, "Certificate", "Course 150", 1 },
                    { 151, "Certificate", 14, "Certificate", "Course 151", 2 },
                    { 152, "Bachelor", 15, "Certificate", "Course 152", 3 },
                    { 153, "Master", 4, "Certificate", "Course 153", 4 },
                    { 154, "PhD", 5, "Certificate", "Course 154", 5 },
                    { 155, "Certificate", 6, "Certificate", "Course 155", 6 },
                    { 156, "Bachelor", 7, "Certificate", "Course 156", 7 },
                    { 157, "Master", 8, "Certificate", "Course 157", 8 },
                    { 158, "PhD", 9, "Certificate", "Course 158", 9 },
                    { 159, "Certificate", 10, "Certificate", "Course 159", 10 },
                    { 160, "Bachelor", 11, "Certificate", "Course 160", 11 },
                    { 161, "Master", 12, "Certificate", "Course 161", 12 },
                    { 162, "PhD", 13, "Certificate", "Course 162", 13 },
                    { 163, "Certificate", 14, "Certificate", "Course 163", 14 },
                    { 164, "Bachelor", 15, "Certificate", "Course 164", 15 },
                    { 165, "Master", 4, "Certificate", "Course 165", 16 },
                    { 166, "PhD", 5, "Certificate", "Course 166", 17 },
                    { 167, "Certificate", 6, "Certificate", "Course 167", 18 },
                    { 168, "Bachelor", 7, "Certificate", "Course 168", 19 },
                    { 169, "Master", 8, "Certificate", "Course 169", 20 },
                    { 170, "PhD", 9, "Certificate", "Course 170", 21 },
                    { 171, "Certificate", 10, "Certificate", "Course 171", 22 },
                    { 172, "Bachelor", 11, "Certificate", "Course 172", 23 },
                    { 173, "Master", 12, "Certificate", "Course 173", 24 },
                    { 174, "PhD", 13, "Certificate", "Course 174", 25 },
                    { 175, "Certificate", 14, "Certificate", "Course 175", 26 },
                    { 176, "Bachelor", 15, "Certificate", "Course 176", 27 },
                    { 177, "Master", 4, "Certificate", "Course 177", 28 },
                    { 178, "PhD", 5, "Certificate", "Course 178", 29 },
                    { 179, "Certificate", 6, "Certificate", "Course 179", 30 },
                    { 180, "Bachelor", 7, "Certificate", "Course 180", 31 },
                    { 181, "Master", 8, "Certificate", "Course 181", 32 },
                    { 182, "PhD", 9, "Certificate", "Course 182", 33 },
                    { 183, "Certificate", 10, "Certificate", "Course 183", 34 },
                    { 184, "Bachelor", 11, "Certificate", "Course 184", 35 },
                    { 185, "Master", 12, "Certificate", "Course 185", 36 },
                    { 186, "PhD", 13, "Certificate", "Course 186", 37 },
                    { 187, "Certificate", 14, "Certificate", "Course 187", 38 },
                    { 188, "Bachelor", 15, "Certificate", "Course 188", 39 },
                    { 189, "Master", 4, "Certificate", "Course 189", 40 },
                    { 190, "PhD", 5, "Certificate", "Course 190", 41 },
                    { 191, "Certificate", 6, "Certificate", "Course 191", 42 },
                    { 192, "Bachelor", 7, "Certificate", "Course 192", 43 },
                    { 193, "Master", 8, "Certificate", "Course 193", 44 },
                    { 194, "PhD", 9, "Certificate", "Course 194", 45 },
                    { 195, "Certificate", 10, "Certificate", "Course 195", 46 },
                    { 196, "Bachelor", 11, "Certificate", "Course 196", 47 },
                    { 197, "Master", 12, "Certificate", "Course 197", 48 },
                    { 198, "PhD", 13, "Certificate", "Course 198", 49 },
                    { 199, "Certificate", 14, "Certificate", "Course 199", 50 },
                    { 200, "Bachelor", 15, "Certificate", "Course 200", 51 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourseResults",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 2, "A", 2 },
                    { 2, 3, "A-", 3 },
                    { 3, 4, "B+", 4 },
                    { 4, 5, "B", 5 },
                    { 5, 6, "B-", 6 },
                    { 6, 7, "C+", 7 },
                    { 7, 8, "C", 8 },
                    { 8, 9, "C-", 9 },
                    { 9, 10, "D", 10 },
                    { 10, 11, "F", 11 },
                    { 11, 12, "A+", 12 },
                    { 12, 13, "A", 13 },
                    { 13, 14, "A-", 14 },
                    { 14, 15, "B+", 15 },
                    { 15, 16, "B", 16 },
                    { 16, 17, "B-", 17 },
                    { 17, 18, "C+", 18 },
                    { 18, 19, "C", 19 },
                    { 19, 20, "C-", 20 },
                    { 20, 21, "D", 21 },
                    { 21, 22, "F", 22 },
                    { 22, 23, "A+", 23 },
                    { 23, 24, "A", 24 },
                    { 24, 25, "A-", 25 },
                    { 25, 26, "B+", 26 },
                    { 26, 27, "B", 27 },
                    { 27, 28, "B-", 28 },
                    { 28, 29, "C+", 29 },
                    { 29, 30, "C", 30 },
                    { 30, 31, "C-", 31 },
                    { 31, 32, "D", 32 },
                    { 32, 33, "F", 33 },
                    { 33, 34, "A+", 34 },
                    { 34, 35, "A", 35 },
                    { 35, 36, "A-", 36 },
                    { 36, 37, "B+", 37 },
                    { 37, 38, "B", 38 },
                    { 38, 39, "B-", 39 },
                    { 39, 40, "C+", 40 },
                    { 40, 41, "C", 41 },
                    { 41, 42, "C-", 42 },
                    { 42, 43, "D", 43 },
                    { 43, 44, "F", 44 },
                    { 44, 45, "A+", 45 },
                    { 45, 46, "A", 46 },
                    { 46, 47, "A-", 47 },
                    { 47, 48, "B+", 48 },
                    { 48, 49, "B", 49 },
                    { 49, 50, "B-", 50 },
                    { 50, 51, "C+", 51 },
                    { 51, 52, "C", 52 },
                    { 52, 53, "C-", 53 },
                    { 53, 54, "D", 54 },
                    { 54, 55, "F", 55 },
                    { 55, 56, "A+", 56 },
                    { 56, 57, "A", 57 },
                    { 57, 58, "A-", 58 },
                    { 58, 59, "B+", 59 },
                    { 59, 60, "B", 60 },
                    { 60, 61, "B-", 61 },
                    { 61, 62, "C+", 62 },
                    { 62, 63, "C", 63 },
                    { 63, 64, "C-", 64 },
                    { 64, 65, "D", 65 },
                    { 65, 66, "F", 66 },
                    { 66, 67, "A+", 67 },
                    { 67, 68, "A", 68 },
                    { 68, 69, "A-", 69 },
                    { 69, 70, "B+", 70 },
                    { 70, 71, "B", 71 },
                    { 71, 72, "B-", 72 },
                    { 72, 73, "C+", 73 },
                    { 73, 74, "C", 74 },
                    { 74, 75, "C-", 75 },
                    { 75, 76, "D", 76 },
                    { 76, 77, "F", 77 },
                    { 77, 78, "A+", 78 },
                    { 78, 79, "A", 79 },
                    { 79, 80, "A-", 80 },
                    { 80, 81, "B+", 81 },
                    { 81, 82, "B", 82 },
                    { 82, 83, "B-", 83 },
                    { 83, 84, "C+", 84 },
                    { 84, 85, "C", 85 },
                    { 85, 86, "C-", 86 },
                    { 86, 87, "D", 87 },
                    { 87, 88, "F", 88 },
                    { 88, 89, "A+", 89 },
                    { 89, 90, "A", 90 },
                    { 90, 91, "A-", 91 },
                    { 91, 92, "B+", 92 },
                    { 92, 93, "B", 93 },
                    { 93, 94, "B-", 94 },
                    { 94, 95, "C+", 95 },
                    { 95, 96, "C", 96 },
                    { 96, 97, "C-", 97 },
                    { 97, 98, "D", 98 },
                    { 98, 99, "F", 99 },
                    { 99, 100, "A+", 100 },
                    { 100, 101, "A", 101 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 200);

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
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StudentCourseResults",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 101);

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
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
