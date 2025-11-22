using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estately.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "LkpAppointmentStatus",
            //    columns: table => new
            //    {
            //        StatusId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpAppointmentStatus", x => x.StatusId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpDocumentType",
            //    columns: table => new
            //    {
            //        DocumentTypeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpDocumentType", x => x.DocumentTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpPropertyHistoryTypes",
            //    columns: table => new
            //    {
            //        HistoryTypeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpPropertyHistoryTypes", x => x.HistoryTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpPropertyStatus",
            //    columns: table => new
            //    {
            //        StatusID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpPropertyStatus", x => x.StatusID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpPropertyTypes",
            //    columns: table => new
            //    {
            //        PropertyTypeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpPropertyTypes", x => x.PropertyTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpUserType",
            //    columns: table => new
            //    {
            //        UserTypeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpUserType", x => x.UserTypeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblBranches",
            //    columns: table => new
            //    {
            //        BranchID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblBranches", x => x.BranchID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblCities",
            //    columns: table => new
            //    {
            //        CityID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblCities", x => x.CityID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblDepartments",
            //    columns: table => new
            //    {
            //        DepartmentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblDepartments", x => x.DepartmentID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblJobTitles",
            //    columns: table => new
            //    {
            //        JobTitleId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        JobTitleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblJobTitles", x => x.JobTitleId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblPropertyFeatures",
            //    columns: table => new
            //    {
            //        FeatureID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsAmenity = table.Column<bool>(type: "bit", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblPropertyFeatures", x => x.FeatureID);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "TblUsers",
            //    columns: table => new
            //    {
            //        UserID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserTypeID = table.Column<int>(type: "int", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblUsers", x => x.UserID);
            //        table.ForeignKey(
            //            name: "FK_TblUsers_LkpUserType_UserTypeID",
            //            column: x => x.UserTypeID,
            //            principalTable: "LkpUserType",
            //            principalColumn: "UserTypeID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblZones",
            //    columns: table => new
            //    {
            //        ZoneID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CityID = table.Column<int>(type: "int", nullable: false),
            //        ZoneName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblZones", x => x.ZoneID);
            //        table.ForeignKey(
            //            name: "FK_TblZones_TblCities_CityID",
            //            column: x => x.CityID,
            //            principalTable: "TblCities",
            //            principalColumn: "CityID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblBranchDepartments",
            //    columns: table => new
            //    {
            //        BranchDepartmentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BranchID = table.Column<int>(type: "int", nullable: false),
            //        DepartmentID = table.Column<int>(type: "int", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblBranchDepartments", x => x.BranchDepartmentID);
            //        table.ForeignKey(
            //            name: "FK_TblBranchDepartments_TblBranches_BranchID",
            //            column: x => x.BranchID,
            //            principalTable: "TblBranches",
            //            principalColumn: "BranchID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblBranchDepartments_TblDepartments_DepartmentID",
            //            column: x => x.DepartmentID,
            //            principalTable: "TblDepartments",
            //            principalColumn: "DepartmentID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblClientProfiles",
            //    columns: table => new
            //    {
            //        ClientProfileID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserID = table.Column<int>(type: "int", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblClientProfiles", x => x.ClientProfileID);
            //        table.ForeignKey(
            //            name: "FK_TblClientProfiles_TblUsers_UserID",
            //            column: x => x.UserID,
            //            principalTable: "TblUsers",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblDeveloperProfiles",
            //    columns: table => new
            //    {
            //        DeveloperProfileID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserID = table.Column<int>(type: "int", nullable: false),
            //        DeveloperTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DeveloperName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        WebsiteURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PortofolioPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblDeveloperProfiles", x => x.DeveloperProfileID);
            //        table.ForeignKey(
            //            name: "FK_TblDeveloperProfiles_TblUsers_UserID",
            //            column: x => x.UserID,
            //            principalTable: "TblUsers",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblEmployees",
            //    columns: table => new
            //    {
            //        EmployeeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserID = table.Column<int>(type: "int", nullable: false),
            //        BranchDepartmentId = table.Column<int>(type: "int", nullable: true),
            //        JobTitleId = table.Column<int>(type: "int", nullable: false),
            //        ReportsTo = table.Column<int>(type: "int", nullable: true),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Age = table.Column<int>(type: "int", nullable: false),
            //        Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Nationalid = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        HireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblEmployees", x => x.EmployeeID);
            //        table.ForeignKey(
            //            name: "FK_TblEmployees_TblBranchDepartments_BranchDepartmentId",
            //            column: x => x.BranchDepartmentId,
            //            principalTable: "TblBranchDepartments",
            //            principalColumn: "BranchDepartmentID");
            //        table.ForeignKey(
            //            name: "FK_TblEmployees_TblEmployees_ReportsTo",
            //            column: x => x.ReportsTo,
            //            principalTable: "TblEmployees",
            //            principalColumn: "EmployeeID");
            //        table.ForeignKey(
            //            name: "FK_TblEmployees_TblJobTitles_JobTitleId",
            //            column: x => x.JobTitleId,
            //            principalTable: "TblJobTitles",
            //            principalColumn: "JobTitleId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblEmployees_TblUsers_UserID",
            //            column: x => x.UserID,
            //            principalTable: "TblUsers",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblEmployeeClients",
            //    columns: table => new
            //    {
            //        EmployeeClientID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EmployeeID = table.Column<int>(type: "int", nullable: false),
            //        ClientProfileID = table.Column<int>(type: "int", nullable: false),
            //        AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblEmployeeClients", x => x.EmployeeClientID);
            //        table.ForeignKey(
            //            name: "FK_TblEmployeeClients_TblClientProfiles_ClientProfileID",
            //            column: x => x.ClientProfileID,
            //            principalTable: "TblClientProfiles",
            //            principalColumn: "ClientProfileID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblEmployeeClients_TblEmployees_EmployeeID",
            //            column: x => x.EmployeeID,
            //            principalTable: "TblEmployees",
            //            principalColumn: "EmployeeID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblProperties",
            //    columns: table => new
            //    {
            //        PropertyID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AgentId = table.Column<int>(type: "int", nullable: true),
            //        DeveloperProfileID = table.Column<int>(type: "int", nullable: true),
            //        PropertyTypeID = table.Column<int>(type: "int", nullable: false),
            //        StatusId = table.Column<int>(type: "int", nullable: true),
            //        ZoneID = table.Column<int>(type: "int", nullable: false),
            //        YearBuilt = table.Column<int>(type: "int", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        FloorNo = table.Column<int>(type: "int", nullable: true),
            //        BedsNo = table.Column<int>(type: "int", nullable: false),
            //        BathsNo = table.Column<int>(type: "int", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        ListingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ExpectedRentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: true),
            //        Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        PropertyCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblProperties", x => x.PropertyID);
            //        table.ForeignKey(
            //            name: "FK_TblProperties_LkpPropertyStatus_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "LkpPropertyStatus",
            //            principalColumn: "StatusID");
            //        table.ForeignKey(
            //            name: "FK_TblProperties_LkpPropertyTypes_PropertyTypeID",
            //            column: x => x.PropertyTypeID,
            //            principalTable: "LkpPropertyTypes",
            //            principalColumn: "PropertyTypeID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblProperties_TblDeveloperProfiles_DeveloperProfileID",
            //            column: x => x.DeveloperProfileID,
            //            principalTable: "TblDeveloperProfiles",
            //            principalColumn: "DeveloperProfileID");
            //        table.ForeignKey(
            //            name: "FK_TblProperties_TblEmployees_AgentId",
            //            column: x => x.AgentId,
            //            principalTable: "TblEmployees",
            //            principalColumn: "EmployeeID");
            //        table.ForeignKey(
            //            name: "FK_TblProperties_TblZones_ZoneID",
            //            column: x => x.ZoneID,
            //            principalTable: "TblZones",
            //            principalColumn: "ZoneID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblAppointments",
            //    columns: table => new
            //    {
            //        AppointmentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StatusID = table.Column<int>(type: "int", nullable: false),
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        EmployeeClientID = table.Column<int>(type: "int", nullable: false),
            //        AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblAppointments", x => x.AppointmentID);
            //        table.ForeignKey(
            //            name: "FK_TblAppointments_LkpAppointmentStatus_StatusID",
            //            column: x => x.StatusID,
            //            principalTable: "LkpAppointmentStatus",
            //            principalColumn: "StatusId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblAppointments_TblEmployeeClients_EmployeeClientID",
            //            column: x => x.EmployeeClientID,
            //            principalTable: "TblEmployeeClients",
            //            principalColumn: "EmployeeClientID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblAppointments_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblClientPropertyInterests",
            //    columns: table => new
            //    {
            //        InterestId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ClientProfileId = table.Column<int>(type: "int", nullable: false),
            //        PropertyId = table.Column<int>(type: "int", nullable: false),
            //        InterestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblClientPropertyInterests", x => x.InterestId);
            //        table.ForeignKey(
            //            name: "FK_TblClientPropertyInterests_TblClientProfiles_ClientProfileId",
            //            column: x => x.ClientProfileId,
            //            principalTable: "TblClientProfiles",
            //            principalColumn: "ClientProfileID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblClientPropertyInterests_TblProperties_PropertyId",
            //            column: x => x.PropertyId,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblFavorites",
            //    columns: table => new
            //    {
            //        FavoriteID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ClientProfileID = table.Column<int>(type: "int", nullable: false),
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblFavorites", x => x.FavoriteID);
            //        table.ForeignKey(
            //            name: "FK_TblFavorites_TblClientProfiles_ClientProfileID",
            //            column: x => x.ClientProfileID,
            //            principalTable: "TblClientProfiles",
            //            principalColumn: "ClientProfileID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblFavorites_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblPropertyDocuments",
            //    columns: table => new
            //    {
            //        DocumentID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        UserID = table.Column<int>(type: "int", nullable: true),
            //        DocumentTypeID = table.Column<int>(type: "int", nullable: false),
            //        FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblPropertyDocuments", x => x.DocumentID);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyDocuments_LkpDocumentType_DocumentTypeID",
            //            column: x => x.DocumentTypeID,
            //            principalTable: "LkpDocumentType",
            //            principalColumn: "DocumentTypeID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyDocuments_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyDocuments_TblUsers_UserID",
            //            column: x => x.UserID,
            //            principalTable: "TblUsers",
            //            principalColumn: "UserID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblPropertyFeaturesMapping",
            //    columns: table => new
            //    {
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        FeatureID = table.Column<int>(type: "int", nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblPropertyFeaturesMapping", x => new { x.PropertyID, x.FeatureID });
            //        table.ForeignKey(
            //            name: "FK_TblPropertyFeaturesMapping_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyFeaturesMapping_TblPropertyFeatures_FeatureID",
            //            column: x => x.FeatureID,
            //            principalTable: "TblPropertyFeatures",
            //            principalColumn: "FeatureID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblPropertyHistory",
            //    columns: table => new
            //    {
            //        HistoryID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        UserID = table.Column<int>(type: "int", nullable: true),
            //        HistoryTypeID = table.Column<int>(type: "int", nullable: false),
            //        OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblPropertyHistory", x => x.HistoryID);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyHistory_LkpPropertyHistoryTypes_HistoryTypeID",
            //            column: x => x.HistoryTypeID,
            //            principalTable: "LkpPropertyHistoryTypes",
            //            principalColumn: "HistoryTypeID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyHistory_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyHistory_TblUsers_UserID",
            //            column: x => x.UserID,
            //            principalTable: "TblUsers",
            //            principalColumn: "UserID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TblPropertyImages",
            //    columns: table => new
            //    {
            //        ImageID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PropertyID = table.Column<int>(type: "int", nullable: false),
            //        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UploadedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TblPropertyImages", x => x.ImageID);
            //        table.ForeignKey(
            //            name: "FK_TblPropertyImages_TblProperties_PropertyID",
            //            column: x => x.PropertyID,
            //            principalTable: "TblProperties",
            //            principalColumn: "PropertyID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblAppointments",
            //        table: "TblAppointments",
            //        column: "StatusID",
            //        unique: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblAppointments_EmployeeClientID",
            //        table: "TblAppointments",
            //        column: "EmployeeClientID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblAppointments_PropertyID",
            //        table: "TblAppointments",
            //        column: "PropertyID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblBranchDepartments_BranchID",
            //        table: "TblBranchDepartments",
            //        column: "BranchID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblBranchDepartments_DepartmentID",
            //        table: "TblBranchDepartments",
            //        column: "DepartmentID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblClientProfiles",
            //        table: "TblClientProfiles",
            //        column: "UserID",
            //        unique: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblClientPropertyInterests_ClientProfileId",
            //        table: "TblClientPropertyInterests",
            //        column: "ClientProfileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblClientPropertyInterests_PropertyId",
            //        table: "TblClientPropertyInterests",
            //        column: "PropertyId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblDeveloperProfiles",
            //        table: "TblDeveloperProfiles",
            //        column: "UserID",
            //        unique: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployeeClients_ClientProfileID",
            //        table: "TblEmployeeClients",
            //        column: "ClientProfileID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployeeClients_EmployeeID",
            //        table: "TblEmployeeClients",
            //        column: "EmployeeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployees",
            //        table: "TblEmployees",
            //        column: "UserID",
            //        unique: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployees_BranchDepartmentId",
            //        table: "TblEmployees",
            //        column: "BranchDepartmentId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployees_JobTitleId",
            //        table: "TblEmployees",
            //        column: "JobTitleId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblEmployees_ReportsTo",
            //        table: "TblEmployees",
            //        column: "ReportsTo");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblFavorites_ClientProfileID",
            //        table: "TblFavorites",
            //        column: "ClientProfileID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblFavorites_PropertyID",
            //        table: "TblFavorites",
            //        column: "PropertyID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_1",
            //        table: "TblProperties",
            //        column: "PropertyCode",
            //        unique: true,
            //        filter: "[PropertyCode] IS NOT NULL");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_AgentId",
            //        table: "TblProperties",
            //        column: "AgentId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_DeveloperProfileID",
            //        table: "TblProperties",
            //        column: "DeveloperProfileID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_PropertyTypeID",
            //        table: "TblProperties",
            //        column: "PropertyTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_StatusId",
            //        table: "TblProperties",
            //        column: "StatusId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblProperties_ZoneID",
            //        table: "TblProperties",
            //        column: "ZoneID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyDocuments_DocumentTypeID",
            //        table: "TblPropertyDocuments",
            //        column: "DocumentTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyDocuments_PropertyID",
            //        table: "TblPropertyDocuments",
            //        column: "PropertyID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyDocuments_UserID",
            //        table: "TblPropertyDocuments",
            //        column: "UserID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyFeaturesMapping_FeatureID",
            //        table: "TblPropertyFeaturesMapping",
            //        column: "FeatureID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyHistory_HistoryTypeID",
            //        table: "TblPropertyHistory",
            //        column: "HistoryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyHistory_PropertyID",
            //        table: "TblPropertyHistory",
            //        column: "PropertyID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyHistory_UserID",
            //        table: "TblPropertyHistory",
            //        column: "UserID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblPropertyImages_PropertyID",
            //        table: "TblPropertyImages",
            //        column: "PropertyID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblUsers_UserTypeID",
            //        table: "TblUsers",
            //        column: "UserTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TblZones_CityID",
            //        table: "TblZones",
            //        column: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "TblAppointments");

            //migrationBuilder.DropTable(
            //    name: "TblClientPropertyInterests");

            //migrationBuilder.DropTable(
            //    name: "TblFavorites");

            //migrationBuilder.DropTable(
            //    name: "TblPropertyDocuments");

            //migrationBuilder.DropTable(
            //    name: "TblPropertyFeaturesMapping");

            //migrationBuilder.DropTable(
            //    name: "TblPropertyHistory");

            //migrationBuilder.DropTable(
            //    name: "TblPropertyImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "LkpAppointmentStatus");

            //migrationBuilder.DropTable(
            //    name: "TblEmployeeClients");

            //migrationBuilder.DropTable(
            //    name: "LkpDocumentType");

            //migrationBuilder.DropTable(
            //    name: "TblPropertyFeatures");

            //migrationBuilder.DropTable(
            //    name: "LkpPropertyHistoryTypes");

            //migrationBuilder.DropTable(
            //    name: "TblProperties");

            //migrationBuilder.DropTable(
            //    name: "TblClientProfiles");

            //migrationBuilder.DropTable(
            //    name: "LkpPropertyStatus");

            //migrationBuilder.DropTable(
            //    name: "LkpPropertyTypes");

            //migrationBuilder.DropTable(
            //    name: "TblDeveloperProfiles");

            //migrationBuilder.DropTable(
            //    name: "TblEmployees");

            //migrationBuilder.DropTable(
            //    name: "TblZones");

            //migrationBuilder.DropTable(
            //    name: "TblBranchDepartments");

            //migrationBuilder.DropTable(
            //    name: "TblJobTitles");

            //migrationBuilder.DropTable(
            //    name: "TblUsers");

            //migrationBuilder.DropTable(
            //    name: "TblCities");

            //migrationBuilder.DropTable(
            //    name: "TblBranches");

            //migrationBuilder.DropTable(
            //    name: "TblDepartments");

            //migrationBuilder.DropTable(
            //    name: "LkpUserType");
        }
    }
}
