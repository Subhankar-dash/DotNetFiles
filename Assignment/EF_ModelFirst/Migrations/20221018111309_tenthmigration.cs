using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ModelFirst.Migrations
{
    public partial class tenthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    fees = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatienceCount = table.Column<int>(type: "int", nullable: true),
                    RoomCount = table.Column<int>(type: "int", nullable: true),
                    MachineCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Contact", "Department", "Discriminator", "Education", "Name", "PatienceCount", "StaffCategory", "fees" },
                values: new object[] { 1, 567, "heart", "Doctor", "mbbs", "sk", 10, "doctor", 56 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Contact", "Department", "Discriminator", "Education", "Name", "RoomCount", "StaffCategory", "fees" },
                values: new object[] { 2, 567, "heart", "Nurse", "bbs", "fg", 10, "nurse", 56 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Contact", "Department", "Discriminator", "Education", "MachineCount", "Name", "StaffCategory", "fees" },
                values: new object[] { 3, 567, "heart", "Technician", "ghj", 7, "ghj", "technician", 45 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
