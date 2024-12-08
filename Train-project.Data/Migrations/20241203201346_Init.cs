using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Train_project.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    EmployedFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeCode);
                });

            migrationBuilder.CreateTable(
                name: "PublicInquiry",
                columns: table => new
                {
                    InquiryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescriptionInquiry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusInquiry = table.Column<bool>(type: "bit", nullable: false),
                    TreatedBy = table.Column<int>(type: "int", nullable: false),
                    ComplainantsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplainantsPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicInquiry", x => x.InquiryId);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    StationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationGPSCoordinates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPlatforms = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.StationID);
                });

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    TrainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainLine = table.Column<int>(type: "int", nullable: false),
                    NumberOfCars = table.Column<int>(type: "int", nullable: false),
                    TrainStatus = table.Column<bool>(type: "bit", nullable: false),
                    RegularRoute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.TrainID);
                });

            migrationBuilder.CreateTable(
                name: "TrainRoute",
                columns: table => new
                {
                    TrainRouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driver = table.Column<int>(type: "int", nullable: false),
                    Train = table.Column<int>(type: "int", nullable: false),
                    Station = table.Column<int>(type: "int", nullable: false),
                    FirstTrain = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTrain = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubstituteDriver = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainRoute", x => x.TrainRouteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PublicInquiry");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.DropTable(
                name: "TrainRoute");
        }
    }
}
