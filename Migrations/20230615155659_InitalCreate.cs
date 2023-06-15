using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeShop.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Publisher = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<float>(type: "float", nullable: false),
                    Artist = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISBN = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InStock = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Size = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Platform = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Studio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subtitles = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BillingAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentMethod = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Artist", "Author", "Category", "Color", "Description", "Duration", "Genre", "ISBN", "InStock", "Language", "Manufacturer", "Name", "Pages", "Platform", "Price", "Publisher", "Quantity", "Rating", "Region", "ReleaseDate", "Size", "Studio", "Subtitles" },
                values: new object[,]
                {
                    { 1, null, null, "DVD", null, "The complete first season of One Piece anime series on DVD.", 750, "Shonen", null, true, null, null, "One Piece Season 1", 0, null, 29.99m, "Toei Animation", 0, 4.9f, "Region 1", new DateTime(1999, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 2, null, null, "DVD", null, "The first box set of Naruto anime series on DVD.", 840, "Shonen", null, true, null, null, "Naruto Box Set 1", 0, null, 49.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 3, null, null, "DVD", null, "The complete series of Bleach anime on DVD.", 2700, "Shonen", null, true, null, null, "Bleach Complete Series", 0, null, 149.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2004, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 4, null, null, "DVD", null, "The complete first season of Dragon Ball Z anime series on DVD.", 900, "Shonen", null, true, null, null, "Dragon Ball Z: Season 1", 0, null, 34.99m, "Funimation", 0, 4.9f, "Region 1", new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 5, null, null, "DVD", null, "The complete first season of My Hero Academia anime series on DVD.", 325, "Shonen", null, true, null, null, "My Hero Academia Season 1", 0, null, 24.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2016, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 6, null, null, "DVD", null, "The complete first season of One Punch Man anime series on DVD.", 300, "Shonen", null, true, null, null, "One Punch Man Season 1", 0, null, 19.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 7, null, null, "DVD", null, "The complete first season of Demon Slayer anime series on DVD.", 625, "Shonen", null, true, null, null, "Demon Slayer Season 1", 0, null, 39.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 8, null, null, "DVD", null, "The complete first season of Attack on Titan anime series on DVD.", 625, "Shonen", null, true, null, null, "Attack on Titan Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 9, null, null, "DVD", null, "The first box set of Hunter x Hunter anime series on DVD.", 675, "Shonen", null, true, null, null, "Hunter x Hunter Box Set 1", 0, null, 59.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(1999, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 10, null, null, "DVD", null, "The first collection of Fairy Tail anime series on DVD.", 600, "Shonen", null, true, null, null, "Fairy Tail Collection 1", 0, null, 39.99m, "Funimation", 0, 4.6f, "Region 1", new DateTime(2009, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 11, null, null, "DVD", null, "The complete first season of Yu Yu Hakusho anime series on DVD.", 575, "Shonen", null, true, null, null, "Yu Yu Hakusho: Season 1", 0, null, 34.99m, "Funimation", 0, 4.9f, "Region 1", new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 12, null, null, "DVD", null, "The complete first season of Black Clover anime series on DVD.", 625, "Shonen", null, true, null, null, "Black Clover Season 1", 0, null, 29.99m, "Crunchyroll", 0, 4.7f, "Region 1", new DateTime(2017, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 13, null, null, "DVD", null, "The first part of Dragon Ball Super anime series on DVD.", 325, "Shonen", null, true, null, null, "Dragon Ball Super: Part 1", 0, null, 39.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 14, null, null, "DVD", null, "The complete collection of Fullmetal Alchemist: Brotherhood anime series on DVD.", 2750, "Shonen", null, true, null, null, "Fullmetal Alchemist: Brotherhood Complete Collection", 0, null, 99.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2009, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 15, null, null, "DVD", null, "The complete first season of Sword Art Online anime series on DVD.", 600, "Shonen", null, true, null, null, "Sword Art Online: Season 1", 0, null, 34.99m, "Aniplex", 0, 4.8f, "Region 1", new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 16, null, null, "DVD", null, "The complete first season of Fruits Basket anime series on DVD.", 600, "Shojo", null, true, null, null, "Fruits Basket Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2001, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 17, null, null, "DVD", null, "A DVD collection of the Your Lie in April anime series.", 550, "Shojo", null, true, null, null, "Your Lie in April", 0, null, 39.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2014, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 18, null, null, "DVD", null, "The complete collection of the Nana anime series on DVD.", 1150, "Shojo", null, true, null, null, "Nana Complete Collection", 0, null, 99.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2006, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 19, null, null, "DVD", null, "A DVD set of the Princess Tutu anime series.", 650, "Shojo", null, true, null, null, "Princess Tutu", 0, null, 29.99m, "ADV Films", 0, 4.8f, "Region 1", new DateTime(2002, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 20, null, null, "DVD", null, "The complete first season of the Kimi ni Todoke anime series on DVD.", 625, "Shojo", null, true, null, null, "Kimi ni Todoke Season 1", 0, null, 34.99m, "NIS America", 0, 4.9f, "Region 1", new DateTime(2009, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 21, null, null, "DVD", null, "The complete first season of Attack on Titan anime series on DVD.", 625, "Seinen", null, true, null, null, "Attack on Titan Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 22, null, null, "DVD", null, "The complete first season of Tokyo Ghoul anime series on DVD.", 300, "Seinen", null, true, null, null, "Tokyo Ghoul Season 1", 0, null, 24.99m, "Funimation", 0, 4.7f, "Region 1", new DateTime(2014, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 23, null, null, "DVD", null, "A DVD collection of the Death Note anime series.", 675, "Seinen", null, true, null, null, "Death Note", 0, null, 39.99m, "Viz Media", 0, 4.9f, "Region 1", new DateTime(2006, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 24, null, null, "DVD", null, "The complete series of the Cowboy Bebop anime on DVD.", 1175, "Seinen", null, true, null, null, "Cowboy Bebop Complete Series", 0, null, 49.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 25, null, null, "DVD", null, "The complete collection of the Parasyte -the maxim- anime series on DVD.", 625, "Seinen", null, true, null, null, "Parasyte -the maxim- Complete Collection", 0, null, 59.99m, "Sentai Filmworks", 0, 4.7f, "Region 1", new DateTime(2014, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 26, null, null, "DVD", null, "The complete series of the Nodame Cantabile anime on DVD.", 1325, "Josei", null, true, null, null, "Nodame Cantabile Complete Series", 0, null, 79.99m, "Geneon Universal Entertainment", 0, 4.8f, "Region 1", new DateTime(2007, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 27, null, null, "DVD", null, "A DVD collection of the Honey and Clover anime series.", 850, "Josei", null, true, null, null, "Honey and Clover", 0, null, 49.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2005, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 28, null, null, "DVD", null, "The complete first season of the Chihayafuru anime series on DVD.", 625, "Josei", null, true, null, null, "Chihayafuru Season 1", 0, null, 39.99m, "Madhouse", 0, 4.9f, "Region 1", new DateTime(2011, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 29, null, null, "DVD", null, "The complete collection of the Nana anime series on DVD.", 1150, "Josei", null, true, null, null, "Nana Complete Collection", 0, null, 99.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2006, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 30, null, null, "DVD", null, "A DVD set of the Paradise Kiss anime series.", 325, "Josei", null, true, null, null, "Paradise Kiss", 0, null, 29.99m, "Geneon Universal Entertainment", 0, 4.8f, "Region 1", new DateTime(2005, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 31, null, null, "DVD", null, "The complete Indigo League season of the Pokémon anime series on DVD.", 1175, "Kodomomuke", null, true, null, null, "Pokémon Indigo League", 0, null, 39.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(1997, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 32, null, null, "DVD", null, "A DVD collection of Doraemon episodes.", 325, "Kodomomuke", null, true, null, null, "Doraemon: Gadget Cat from the Future", 0, null, 29.99m, "Shin-Ei Animation", 0, 4.7f, "Region 1", new DateTime(1979, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 33, null, null, "DVD", null, "The complete first season of the Sailor Moon anime series on DVD.", 625, "Kodomomuke", null, true, null, null, "Sailor Moon Season 1", 0, null, 49.99m, "Viz Media", 0, 4.9f, "Region 1", new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 34, null, null, "DVD", null, "The complete first season of the Yo-kai Watch anime series on DVD.", 525, "Kodomomuke", null, true, null, null, "Yo-kai Watch Season 1", 0, null, 29.99m, "Level-5", 0, 4.8f, "Region 1", new DateTime(2014, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 35, null, null, "DVD", null, "The complete first season of the Detective Conan anime series on DVD.", 625, "Kodomomuke", null, true, null, null, "Detective Conan Season 1", 0, null, 39.99m, "TMS Entertainment", 0, 4.7f, "Region 1", new DateTime(1996, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 36, null, null, "DVD", null, "The complete first season of Sword Art Online anime series on DVD.", 600, "Isekai", null, true, null, null, "Sword Art Online Season 1", 0, null, 34.99m, "Aniplex", 0, 4.8f, "Region 1", new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 37, null, null, "DVD", null, "The complete first season of Overlord anime series on DVD.", 325, "Isekai", null, true, null, null, "Overlord Season 1", 0, null, 29.99m, "Funimation", 0, 4.7f, "Region 1", new DateTime(2015, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 38, null, null, "DVD", null, "The complete first season of Re:Zero anime series on DVD.", 625, "Isekai", null, true, null, null, "Re:Zero Season 1", 0, null, 39.99m, "Crunchyroll", 0, 4.9f, "Region 1", new DateTime(2016, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 39, null, null, "DVD", null, "The complete first season of Konosuba anime series on DVD.", 300, "Isekai", null, true, null, null, "Konosuba Season 1", 0, null, 24.99m, "Crunchyroll", 0, 4.8f, "Region 1", new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 40, null, null, "DVD", null, "The complete first season of The Rising of the Shield Hero anime series on DVD.", 625, "Isekai", null, true, null, null, "The Rising of the Shield Hero Season 1", 0, null, 29.99m, "Crunchyroll", 0, 4.7f, "Region 1", new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English" },
                    { 41, null, null, "Merchandise", null, "Hoodie featuring the Attack on Titan logo.", 0, "Seinen", null, true, null, null, "Attack on Titan Hoodie", 0, null, 39.99m, "Kodansha", 0, 4.8f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 42, null, null, "Merchandise", null, "Set of keychains featuring the characters from My Hero Academia.", 0, "Shonen", null, true, null, null, "My Hero Academia Keychain Set", 0, null, 14.99m, "Funimation", 0, 4.8f, null, new DateTime(2016, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 43, null, null, "Merchandise", null, "Authentic Naruto headband worn by the ninjas of the Hidden Leaf Village.", 0, "Shonen", null, true, null, null, "Naruto Headband", 0, null, 19.99m, "Shueisha", 0, 4.7f, null, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 44, null, null, "Merchandise", null, "T-Shirt featuring the Demon Slayer logo.", 0, "Shonen", null, true, null, null, "Demon Slayer T-Shirt", 0, null, 24.99m, "Aniplex", 0, 4.9f, null, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 45, null, null, "Merchandise", null, "Backpack featuring the Fairy Tail guild emblem.", 0, "Shonen", null, true, null, null, "Fairy Tail Backpack", 0, null, 39.99m, "Kodansha", 0, 4.7f, null, new DateTime(2006, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 46, null, null, "Merchandise", null, "Set of plushies featuring the characters from Sailor Moon.", 0, "Shojo", null, true, null, null, "Sailor Moon Plushies Set", 0, null, 29.99m, "Kodansha", 0, 4.8f, null, new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 47, null, null, "Merchandise", null, "Mug featuring the Tokyo Ghoul logo.", 0, "Seinen", null, true, null, null, "Tokyo Ghoul Mug", 0, null, 14.99m, "Shueisha", 0, 4.6f, null, new DateTime(2011, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 48, null, null, "Merchandise", null, "Keychain featuring the Attack on Titan Survey Corps emblem.", 0, "Seinen", null, true, null, null, "Attack on Titan Keychain", 0, null, 9.99m, "Kodansha", 0, 4.7f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 49, null, null, "Merchandise", null, "Poster featuring the characters from Haikyu!!.", 0, "Shonen", null, true, null, null, "Haikyu!! Poster", 0, null, 9.99m, "Shueisha", 0, 4.8f, null, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 50, null, null, "Merchandise", null, "Music box playing the theme song from Your Lie in April.", 0, "Shojo", null, true, null, null, "Your Lie in April Music Box", 0, null, 34.99m, "Kodansha", 0, 4.9f, null, new DateTime(2011, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 51, null, null, "Apparel", null, "Hoodie featuring the Attack on Titan Survey Corps emblem.", 0, "Seinen", null, true, null, null, "Attack on Titan Hoodie", 0, null, 49.99m, "Kodansha", 0, 4.8f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 52, null, null, "Apparel", null, "T-Shirt featuring Naruto Uzumaki artwork.", 0, "Shonen", null, true, null, null, "Naruto T-Shirt", 0, null, 19.99m, "Shueisha", 0, 4.7f, null, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 53, null, null, "Apparel", null, "Sweatshirt featuring the Sailor Moon logo.", 0, "Shojo", null, true, null, null, "Sailor Moon Sweatshirt", 0, null, 34.99m, "Kodansha", 0, 4.9f, null, new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 54, null, null, "Apparel", null, "Cap featuring the One Piece Jolly Roger emblem.", 0, "Shonen", null, true, null, null, "One Piece Cap", 0, null, 14.99m, "Shueisha", 0, 4.8f, null, new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 55, null, null, "Apparel", null, "Set of socks featuring characters from My Hero Academia.", 0, "Shonen", null, true, null, null, "My Hero Academia Socks Set", 0, null, 9.99m, "Shueisha", 0, 4.7f, null, new DateTime(2014, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://res.cloudinary.com/danedskby/image/upload/v1686843216/OnePiece/p12129031_b_h9_ab_okykpq.jpg", 1 },
                    { 2, "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/8776327_so_vfd2wj.jpg", 1 },
                    { 3, "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/v0qPfG_y7t3b7.jpg", 1 },
                    { 4, "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/one_piece_opening_1000.jpg_423682103_p8jcjq.webp", 1 },
                    { 5, "https://res.cloudinary.com/danedskby/image/upload/v1686843214/OnePiece/One-Piece-chapter-1_tgay9v.jpg", 1 },
                    { 6, "https://your-url.com/naruto-image1.jpg", 2 },
                    { 7, "https://your-url.com/naruto-image2.jpg", 2 },
                    { 8, "https://your-url.com/naruto-image3.jpg", 2 },
                    { 9, "https://your-url.com/naruto-image4.jpg", 2 },
                    { 10, "https://your-url.com/naruto-image5.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_UserId",
                table: "ShoppingCartItems",
                column: "UserId");
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

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
