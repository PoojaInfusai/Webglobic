using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webglobic.Migrations
{
    /// <inheritdoc />
    public partial class WebgloicV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestingOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int", nullable: false),
                    NameDesignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StreetHsnr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Field1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameDesignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StreetHsnr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Field1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "objects",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameDesignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressTo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StreetHsnr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ObjectType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Field1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectBuilding = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameDesignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StreetHsnr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "testers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestingOffice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameDesignationCompany = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CertificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateUpload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfIssueCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDateCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "testingOffices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntrepreneursDeclaration = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ShowBusinessDeclarationInReports = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Field = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testingOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "testObjects",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TradeSystemType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ObjectBuilding = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameDesignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SystemIdentificationTestOffice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SystemIdentifierCustomerOperator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastTest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastExaminer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YearOfConstruction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NextInspection = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonForChangedTestInterval = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HumidifierAvailable = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AirVolumeSupplyAir = table.Column<float>(type: "real", nullable: false),
                    AirVolumeExhaustAir = table.Column<float>(type: "real", nullable: false),
                    AirVolumeRecirculatedAir = table.Column<float>(type: "real", nullable: false),
                    AirVolumeOutsideAir = table.Column<float>(type: "real", nullable: false),
                    CaseHeight = table.Column<float>(type: "real", nullable: false),
                    TypeOfRoomsServed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfRoomsServedFreeText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirQualityOutsideAirAUL_ODA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirQualitySupplyAirZUL_SUP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirQualityExhaustAirABL_ETA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirQualityExhaustAirFOL_EHA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirQualityIndoorAirRAL_IDA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testObjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "userCertifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Certificate1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Certificate2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Certificate3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userCertifications", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "objects");

            migrationBuilder.DropTable(
                name: "owner");

            migrationBuilder.DropTable(
                name: "testers");

            migrationBuilder.DropTable(
                name: "testingOffices");

            migrationBuilder.DropTable(
                name: "testObjects");

            migrationBuilder.DropTable(
                name: "userCertifications");
        }
    }
}
