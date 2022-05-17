using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persons.Entities.Migrations
{
    public partial class CreatingIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "AddressType",
                schema: "Person",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for AddressType records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Address type description. For example, Billing, Home, or Shipping."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.AddressTypeID);
                },
                comment: "Types of addresses stored in the Address table. ");*/

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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            /*migrationBuilder.CreateTable(
                name: "BusinessEntity",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for all customers, vendors, and employees.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntity", x => x.BusinessEntityID);
                },
                comment: "Source of the ID that connects vendors, customers, and employees with address and contact information.");

            migrationBuilder.CreateTable(
                name: "ContactType",
                schema: "Person",
                columns: table => new
                {
                    ContactTypeID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for ContactType records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Contact type description."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.ContactTypeID);
                },
                comment: "Lookup table containing the types of business entity contacts.");

            migrationBuilder.CreateTable(
                name: "CountryRegion",
                schema: "Person",
                columns: table => new
                {
                    CountryRegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO standard code for countries and regions."),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Country or region name."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryRegion_CountryRegionCode", x => x.CountryRegionCode);
                },
                comment: "Lookup table containing the ISO standard codes for countries and regions.");

            migrationBuilder.CreateTable(
                name: "PhoneNumberType",
                schema: "Person",
                columns: table => new
                {
                    PhoneNumberTypeID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for telephone number type records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the telephone number type"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberType", x => x.PhoneNumberTypeID);
                },
                comment: "Type of phone number of a person.");*/

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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            /*migrationBuilder.CreateTable(
                name: "Person",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Person records."),
                    PersonType = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: false, comment: "Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact"),
                    NameStyle = table.Column<bool>(type: "bit", nullable: false, comment: "0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order."),
                    Title = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, comment: "A courtesy title. For example, Mr. or Ms."),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the person."),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Middle name or middle initial of the person."),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the person."),
                    Suffix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Surname suffix. For example, Sr. or Jr."),
                    EmailPromotion = table.Column<int>(type: "int", nullable: false, comment: "0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. "),
                    AdditionalContactInfo = table.Column<string>(type: "xml", nullable: true, comment: "Additional contact information about the person stored in xml format. "),
                    Demographics = table.Column<string>(type: "xml", nullable: true, comment: "Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_BusinessEntityID", x => x.BusinessEntityID);
                    table.ForeignKey(
                        name: "FK_Person_BusinessEntity_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");

            migrationBuilder.CreateTable(
                name: "SalesTerritory",
                schema: "Sales",
                columns: table => new
                {
                    TerritoryID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for SalesTerritory records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Sales territory description"),
                    CountryRegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. "),
                    Group = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Geographic area to which the sales territory belong."),
                    SalesYTD = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))", comment: "Sales in the territory year to date."),
                    SalesLastYear = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))", comment: "Sales in the territory the previous year."),
                    CostYTD = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))", comment: "Business costs in the territory year to date."),
                    CostLastYear = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))", comment: "Business costs in the territory the previous year."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritory_TerritoryID", x => x.TerritoryID);
                    table.ForeignKey(
                        name: "FK_SalesTerritory_CountryRegion_CountryRegionCode",
                        column: x => x.CountryRegionCode,
                        principalSchema: "Person",
                        principalTable: "CountryRegion",
                        principalColumn: "CountryRegionCode",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Sales territory lookup table.");

            migrationBuilder.CreateTable(
                name: "BusinessEntityContact",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to BusinessEntity.BusinessEntityID."),
                    PersonID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to Person.BusinessEntityID."),
                    ContactTypeID = table.Column<int>(type: "int", nullable: false, comment: "Primary key.  Foreign key to ContactType.ContactTypeID."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID", x => new { x.BusinessEntityID, x.PersonID, x.ContactTypeID });
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_BusinessEntity_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_ContactType_ContactTypeID",
                        column: x => x.ContactTypeID,
                        principalSchema: "Person",
                        principalTable: "ContactType",
                        principalColumn: "ContactTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_Person_PersonID",
                        column: x => x.PersonID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Cross-reference table mapping stores, vendors, and employees to people");

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID"),
                    EmailAddressID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. ID of this email address.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "E-mail address for the person."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress_BusinessEntityID_EmailAddressID", x => new { x.BusinessEntityID, x.EmailAddressID });
                    table.ForeignKey(
                        name: "FK_EmailAddress_Person_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Where to send a person email.");

            migrationBuilder.CreateTable(
                name: "Password",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false, comment: "Password for the e-mail account."),
                    PasswordSalt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, comment: "Random value concatenated with the password string before the password is hashed."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password_BusinessEntityID", x => x.BusinessEntityID);
                    table.ForeignKey(
                        name: "FK_Password_Person_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "One way hashed authentication information");

            migrationBuilder.CreateTable(
                name: "PersonPhone",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Business entity identification number. Foreign key to Person.BusinessEntityID."),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Telephone number identification number."),
                    PhoneNumberTypeID = table.Column<int>(type: "int", nullable: false, comment: "Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID", x => new { x.BusinessEntityID, x.PhoneNumber, x.PhoneNumberTypeID });
                    table.ForeignKey(
                        name: "FK_PersonPhone_Person_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID",
                        column: x => x.PhoneNumberTypeID,
                        principalSchema: "Person",
                        principalTable: "PhoneNumberType",
                        principalColumn: "PhoneNumberTypeID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Telephone number and type of a person.");

            migrationBuilder.CreateTable(
                name: "StateProvince",
                schema: "Person",
                columns: table => new
                {
                    StateProvinceID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for StateProvince records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateProvinceCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false, comment: "ISO standard state or province code."),
                    CountryRegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. "),
                    IsOnlyStateProvinceFlag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))", comment: "0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode."),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "State or province description."),
                    TerritoryID = table.Column<int>(type: "int", nullable: false, comment: "ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateProvince", x => x.StateProvinceID);
                    table.ForeignKey(
                        name: "FK_StateProvince_CountryRegion_CountryRegionCode",
                        column: x => x.CountryRegionCode,
                        principalSchema: "Person",
                        principalTable: "CountryRegion",
                        principalColumn: "CountryRegionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateProvince_SalesTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "State and province lookup table.");

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Person",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Address records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "First street address line."),
                    AddressLine2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Second street address line."),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the city."),
                    StateProvinceID = table.Column<int>(type: "int", nullable: false, comment: "Unique identification number for the state or province. Foreign key to StateProvince table."),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Postal code for the street address."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_StateProvince_StateProvinceID",
                        column: x => x.StateProvinceID,
                        principalSchema: "Person",
                        principalTable: "StateProvince",
                        principalColumn: "StateProvinceID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Street address information for customers, employees, and vendors.");

            migrationBuilder.CreateTable(
                name: "BusinessEntityAddress",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to BusinessEntity.BusinessEntityID."),
                    AddressID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to Address.AddressID."),
                    AddressTypeID = table.Column<int>(type: "int", nullable: false, comment: "Primary key. Foreign key to AddressType.AddressTypeID."),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())", comment: "ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date and time the record was last updated.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID", x => new { x.BusinessEntityID, x.AddressID, x.AddressTypeID });
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_Address_AddressID",
                        column: x => x.AddressID,
                        principalSchema: "Person",
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_AddressType_AddressTypeID",
                        column: x => x.AddressTypeID,
                        principalSchema: "Person",
                        principalTable: "AddressType",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID",
                        column: x => x.BusinessEntityID,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Cross-reference table mapping customers, vendors, and employees to their addresses.");*/

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da35697a-0d6a-4ff2-9023-dfd0950568f7", "3989dee1-bd11-4b10-af19-8588e5424c75", "EM", "Employee" },
                    { "6f6d4080-3beb-4050-89a2-ef28d409a086", "bc3b4aaa-4e61-4f2a-91ec-9962436f2511", "SP", "Sales Person" },
                    { "bea42a2a-ccce-48cf-ae48-f4d4d211e882", "4eb242be-fe2f-423d-b5d4-2034729a1320", "IN", "Individual Customer" },
                    { "852b7d9c-697c-444a-89bd-e0557daaeed6", "0bb833a8-cb2f-40a7-b6ac-ab83496dd63a", "SC", "Store Contact" },
                    { "5d3f1757-f49f-4fff-bc05-7692b2220059", "580ffbe7-27fe-4a6d-96e5-b412ce494998", "VC", "Vendor Contact" },
                    { "423c78c8-206d-4a5b-881d-065c2862b112", "77b80645-3993-4e7d-a34c-3d456322b9ad", "GC", "General Contact" }
                });

            /*migrationBuilder.CreateIndex(
                name: "AK_Address_rowguid",
                schema: "Person",
                table: "Address",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode",
                schema: "Person",
                table: "Address",
                columns: new[] { "AddressLine1", "AddressLine2", "City", "StateProvinceID", "PostalCode" },
                unique: true,
                filter: "[AddressLine1] IS NOT NULL AND [AddressLine2] IS NOT NULL AND [City] IS NOT NULL AND [PostalCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateProvinceID",
                schema: "Person",
                table: "Address",
                column: "StateProvinceID");

            migrationBuilder.CreateIndex(
                name: "AK_AddressType_Name",
                schema: "Person",
                table: "AddressType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_AddressType_rowguid",
                schema: "Person",
                table: "AddressType",
                column: "rowguid",
                unique: true);*/

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

            /*migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");*/

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            /*migrationBuilder.CreateIndex(
                name: "AK_BusinessEntity_rowguid",
                schema: "Person",
                table: "BusinessEntity",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_BusinessEntityAddress_rowguid",
                schema: "Person",
                table: "BusinessEntityAddress",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityAddress_AddressID",
                schema: "Person",
                table: "BusinessEntityAddress",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityAddress_AddressTypeID",
                schema: "Person",
                table: "BusinessEntityAddress",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "AK_BusinessEntityContact_rowguid",
                schema: "Person",
                table: "BusinessEntityContact",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityContact_ContactTypeID",
                schema: "Person",
                table: "BusinessEntityContact",
                column: "ContactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityContact_PersonID",
                schema: "Person",
                table: "BusinessEntityContact",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "AK_ContactType_Name",
                schema: "Person",
                table: "ContactType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_CountryRegion_Name",
                schema: "Person",
                table: "CountryRegion",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_EmailAddress",
                schema: "Person",
                table: "EmailAddress",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "AK_Person_rowguid",
                schema: "Person",
                table: "Person",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_LastName_FirstName_MiddleName",
                schema: "Person",
                table: "Person",
                columns: new[] { "LastName", "FirstName", "MiddleName" });

            migrationBuilder.CreateIndex(
                name: "PXML_Person_AddContact",
                schema: "Person",
                table: "Person",
                column: "AdditionalContactInfo");

            migrationBuilder.CreateIndex(
                name: "PXML_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLPATH_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLPROPERTY_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "XMLVALUE_Person_Demographics",
                schema: "Person",
                table: "Person",
                column: "Demographics");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhone_PhoneNumber",
                schema: "Person",
                table: "PersonPhone",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhone_PhoneNumberTypeID",
                schema: "Person",
                table: "PersonPhone",
                column: "PhoneNumberTypeID");

            migrationBuilder.CreateIndex(
                name: "AK_SalesTerritory_Name",
                schema: "Sales",
                table: "SalesTerritory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_SalesTerritory_rowguid",
                schema: "Sales",
                table: "SalesTerritory",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesTerritory_CountryRegionCode",
                schema: "Sales",
                table: "SalesTerritory",
                column: "CountryRegionCode");

            migrationBuilder.CreateIndex(
                name: "AK_StateProvince_Name",
                schema: "Person",
                table: "StateProvince",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_StateProvince_rowguid",
                schema: "Person",
                table: "StateProvince",
                column: "rowguid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_StateProvince_StateProvinceCode_CountryRegionCode",
                schema: "Person",
                table: "StateProvince",
                columns: new[] { "StateProvinceCode", "CountryRegionCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StateProvince_CountryRegionCode",
                schema: "Person",
                table: "StateProvince",
                column: "CountryRegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_StateProvince_TerritoryID",
                schema: "Person",
                table: "StateProvince",
                column: "TerritoryID");*/
        }

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

            migrationBuilder.DropTable(
                name: "BusinessEntityAddress",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "BusinessEntityContact",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "EmailAddress",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "Password",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "PersonPhone",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "AddressType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "ContactType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "PhoneNumberType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "StateProvince",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "BusinessEntity",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "SalesTerritory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "CountryRegion",
                schema: "Person");
        }
    }
}
