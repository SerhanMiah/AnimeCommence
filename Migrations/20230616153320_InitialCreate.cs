using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrailerUrl = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
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
                columns: new[] { "ProductId", "Artist", "Author", "Category", "Color", "Description", "Duration", "Genre", "ISBN", "InStock", "Language", "Manufacturer", "Name", "Pages", "Platform", "Price", "Publisher", "Quantity", "Rating", "Region", "ReleaseDate", "Size", "Studio", "Subtitles", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, "Eiichiro Oda", "Eiichiro Oda", "DVD", "Blue", "Monkey D. Luffy wants to become the King of all pirates.", 750, "Shonen", "123-4567891234", true, "English", "Toei Animation", "One Piece Season 1", 200, "DVD", 29.99m, "Toei Animation", 100, 4.9f, "Region 1", new DateTime(1999, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", "Toei Animation", "English", "https://www.youtube.com/watch?v=UTMoDHvgaJk" },
                    { 2, null, null, "DVD", null, "Immerse yourself in the thrilling world of Naruto with the first box set of the iconic anime series on DVD. This box set includes the exhilarating episodes from the early seasons, introducing you to the epic journey of Naruto Uzumaki as he aspires to become the strongest ninja in his village.", 840, "Shonen", null, true, null, null, "Naruto Box Set 1", 0, null, 49.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 3, null, null, "DVD", null, "The complete series of Bleach anime on DVD.", 2700, "Shonen", null, true, null, null, "Bleach Complete Series", 0, null, 149.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2004, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 4, null, null, "DVD", null, "The complete first season of Dragon Ball Z anime series on DVD.", 900, "Shonen", null, true, null, null, "Dragon Ball Z: Season 1", 0, null, 34.99m, "Funimation", 0, 4.9f, "Region 1", new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 5, null, null, "DVD", null, "The complete first season of My Hero Academia anime series on DVD.", 325, "Shonen", null, true, null, null, "My Hero Academia Season 1", 0, null, 24.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2016, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 6, null, null, "DVD", null, "The complete first season of One Punch Man anime series on DVD.", 300, "Shonen", null, true, null, null, "One Punch Man Season 1", 0, null, 19.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 7, null, null, "DVD", null, "The complete first season of Demon Slayer anime series on DVD.", 625, "Shonen", null, true, null, null, "Demon Slayer Season 1", 0, null, 39.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 8, null, null, "DVD", null, "The complete first season of Attack on Titan anime series on DVD.", 625, "Shonen", null, true, null, null, "Attack on Titan Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 9, null, null, "DVD", null, "The first box set of Hunter x Hunter anime series on DVD.", 675, "Shonen", null, true, null, null, "Hunter x Hunter Box Set 1", 0, null, 59.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(1999, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 10, null, null, "DVD", null, "The first collection of Fairy Tail anime series on DVD.", 600, "Shonen", null, true, null, null, "Fairy Tail Collection 1", 0, null, 39.99m, "Funimation", 0, 4.6f, "Region 1", new DateTime(2009, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 11, null, null, "DVD", null, "The complete first season of Yu Yu Hakusho anime series on DVD.", 575, "Shonen", null, true, null, null, "Yu Yu Hakusho: Season 1", 0, null, 34.99m, "Funimation", 0, 4.9f, "Region 1", new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 12, null, null, "DVD", null, "The complete first season of Black Clover anime series on DVD.", 625, "Shonen", null, true, null, null, "Black Clover Season 1", 0, null, 29.99m, "Crunchyroll", 0, 4.7f, "Region 1", new DateTime(2017, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 13, null, null, "DVD", null, "The first part of Dragon Ball Super anime series on DVD.", 325, "Shonen", null, true, null, null, "Dragon Ball Super: Part 1", 0, null, 39.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 14, null, null, "DVD", null, "The complete collection of Fullmetal Alchemist: Brotherhood anime series on DVD.", 2750, "Shonen", null, true, null, null, "Fullmetal Alchemist: Brotherhood Complete Collection", 0, null, 99.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2009, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 15, null, null, "DVD", null, "The complete first season of Sword Art Online anime series on DVD.", 600, "Shonen", null, true, null, null, "Sword Art Online: Season 1", 0, null, 34.99m, "Aniplex", 0, 4.8f, "Region 1", new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 16, null, null, "DVD", null, "The complete first season of Fruits Basket anime series on DVD.", 600, "Shojo", null, true, null, null, "Fruits Basket Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2001, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 17, null, null, "DVD", null, "A DVD collection of the Your Lie in April anime series.", 550, "Shojo", null, true, null, null, "Your Lie in April", 0, null, 39.99m, "Aniplex", 0, 4.9f, "Region 1", new DateTime(2014, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 18, null, null, "DVD", null, "The complete collection of the Nana anime series on DVD.", 1150, "Shojo", null, true, null, null, "Nana Complete Collection", 0, null, 99.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2006, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 19, null, null, "DVD", null, "A DVD set of the Princess Tutu anime series.", 650, "Shojo", null, true, null, null, "Princess Tutu", 0, null, 29.99m, "ADV Films", 0, 4.8f, "Region 1", new DateTime(2002, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 20, null, null, "DVD", null, "The complete first season of the Kimi ni Todoke anime series on DVD.", 625, "Shojo", null, true, null, null, "Kimi ni Todoke Season 1", 0, null, 34.99m, "NIS America", 0, 4.9f, "Region 1", new DateTime(2009, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 21, null, null, "DVD", null, "The complete first season of Attack on Titan anime series on DVD.", 625, "Seinen", null, true, null, null, "Attack on Titan Season 1", 0, null, 29.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 22, null, null, "DVD", null, "The complete first season of Tokyo Ghoul anime series on DVD.", 300, "Seinen", null, true, null, null, "Tokyo Ghoul Season 1", 0, null, 24.99m, "Funimation", 0, 4.7f, "Region 1", new DateTime(2014, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 23, null, null, "DVD", null, "A DVD collection of the Death Note anime series.", 675, "Seinen", null, true, null, null, "Death Note", 0, null, 39.99m, "Viz Media", 0, 4.9f, "Region 1", new DateTime(2006, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 24, null, null, "DVD", null, "The complete series of the Cowboy Bebop anime on DVD.", 1175, "Seinen", null, true, null, null, "Cowboy Bebop Complete Series", 0, null, 49.99m, "Funimation", 0, 4.8f, "Region 1", new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 25, null, null, "DVD", null, "The complete collection of the Parasyte -the maxim- anime series on DVD.", 625, "Seinen", null, true, null, null, "Parasyte -the maxim- Complete Collection", 0, null, 59.99m, "Sentai Filmworks", 0, 4.7f, "Region 1", new DateTime(2014, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 26, null, null, "DVD", null, "The complete series of the Nodame Cantabile anime on DVD.", 1325, "Josei", null, true, null, null, "Nodame Cantabile Complete Series", 0, null, 79.99m, "Geneon Universal Entertainment", 0, 4.8f, "Region 1", new DateTime(2007, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 27, null, null, "DVD", null, "A DVD collection of the Honey and Clover anime series.", 850, "Josei", null, true, null, null, "Honey and Clover", 0, null, 49.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2005, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 28, null, null, "DVD", null, "The complete first season of the Chihayafuru anime series on DVD.", 625, "Josei", null, true, null, null, "Chihayafuru Season 1", 0, null, 39.99m, "Madhouse", 0, 4.9f, "Region 1", new DateTime(2011, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 29, null, null, "DVD", null, "The complete collection of the Nana anime series on DVD.", 1150, "Josei", null, true, null, null, "Nana Complete Collection", 0, null, 99.99m, "Viz Media", 0, 4.7f, "Region 1", new DateTime(2006, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 30, null, null, "DVD", null, "A DVD set of the Paradise Kiss anime series.", 325, "Josei", null, true, null, null, "Paradise Kiss", 0, null, 29.99m, "Geneon Universal Entertainment", 0, 4.8f, "Region 1", new DateTime(2005, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 31, null, null, "DVD", null, "The complete Indigo League season of the Pokémon anime series on DVD.", 1175, "Kodomomuke", null, true, null, null, "Pokémon Indigo League", 0, null, 39.99m, "Viz Media", 0, 4.8f, "Region 1", new DateTime(1997, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 32, null, null, "DVD", null, "A DVD collection of Doraemon episodes.", 325, "Kodomomuke", null, true, null, null, "Doraemon: Gadget Cat from the Future", 0, null, 29.99m, "Shin-Ei Animation", 0, 4.7f, "Region 1", new DateTime(1979, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 33, null, null, "DVD", null, "The complete first season of the Sailor Moon anime series on DVD.", 625, "Kodomomuke", null, true, null, null, "Sailor Moon Season 1", 0, null, 49.99m, "Viz Media", 0, 4.9f, "Region 1", new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 34, null, null, "DVD", null, "The complete first season of the Yo-kai Watch anime series on DVD.", 525, "Kodomomuke", null, true, null, null, "Yo-kai Watch Season 1", 0, null, 29.99m, "Level-5", 0, 4.8f, "Region 1", new DateTime(2014, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 35, null, null, "DVD", null, "The complete first season of the Detective Conan anime series on DVD.", 625, "Kodomomuke", null, true, null, null, "Detective Conan Season 1", 0, null, 39.99m, "TMS Entertainment", 0, 4.7f, "Region 1", new DateTime(1996, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 36, null, null, "DVD", null, "The complete first season of Sword Art Online anime series on DVD.", 600, "Isekai", null, true, null, null, "Sword Art Online Season 1", 0, null, 34.99m, "Aniplex", 0, 4.8f, "Region 1", new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 37, null, null, "DVD", null, "The complete first season of Overlord anime series on DVD.", 325, "Isekai", null, true, null, null, "Overlord Season 1", 0, null, 29.99m, "Funimation", 0, 4.7f, "Region 1", new DateTime(2015, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 38, null, null, "DVD", null, "The complete first season of Re:Zero anime series on DVD.", 625, "Isekai", null, true, null, null, "Re:Zero Season 1", 0, null, 39.99m, "Crunchyroll", 0, 4.9f, "Region 1", new DateTime(2016, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 39, null, null, "DVD", null, "The complete first season of Konosuba anime series on DVD.", 300, "Isekai", null, true, null, null, "Konosuba Season 1", 0, null, 24.99m, "Crunchyroll", 0, 4.8f, "Region 1", new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 40, null, null, "DVD", null, "The complete first season of The Rising of the Shield Hero anime series on DVD.", 625, "Isekai", null, true, null, null, "The Rising of the Shield Hero Season 1", 0, null, 29.99m, "Crunchyroll", 0, 4.7f, "Region 1", new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "English", null },
                    { 41, null, null, "Merchandise", null, "Hoodie featuring the Attack on Titan logo.", 0, "Seinen", null, true, null, null, "Attack on Titan Hoodie", 0, null, 39.99m, "Kodansha", 0, 4.8f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 42, null, null, "Merchandise", null, "Set of keychains featuring the characters from My Hero Academia.", 0, "Shonen", null, true, null, null, "My Hero Academia Keychain Set", 0, null, 14.99m, "Funimation", 0, 4.8f, null, new DateTime(2016, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 43, null, null, "Merchandise", null, "Authentic Naruto headband worn by the ninjas of the Hidden Leaf Village.", 0, "Shonen", null, true, null, null, "Naruto Headband", 0, null, 19.99m, "Shueisha", 0, 4.7f, null, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 44, null, null, "Merchandise", null, "T-Shirt featuring the Demon Slayer logo.", 0, "Shonen", null, true, null, null, "Demon Slayer T-Shirt", 0, null, 24.99m, "Aniplex", 0, 4.9f, null, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 45, null, null, "Merchandise", null, "Backpack featuring the Fairy Tail guild emblem.", 0, "Shonen", null, true, null, null, "Fairy Tail Backpack", 0, null, 39.99m, "Kodansha", 0, 4.7f, null, new DateTime(2006, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 46, null, null, "Merchandise", null, "Set of plushies featuring the characters from Sailor Moon.", 0, "Shojo", null, true, null, null, "Sailor Moon Plushies Set", 0, null, 29.99m, "Kodansha", 0, 4.8f, null, new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 47, null, null, "Merchandise", null, "Mug featuring the Tokyo Ghoul logo.", 0, "Seinen", null, true, null, null, "Tokyo Ghoul Mug", 0, null, 14.99m, "Shueisha", 0, 4.6f, null, new DateTime(2011, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 48, null, null, "Merchandise", null, "Keychain featuring the Attack on Titan Survey Corps emblem.", 0, "Seinen", null, true, null, null, "Attack on Titan Keychain", 0, null, 9.99m, "Kodansha", 0, 4.7f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 49, null, null, "Merchandise", null, "Poster featuring the characters from Haikyu!!.", 0, "Shonen", null, true, null, null, "Haikyu!! Poster", 0, null, 9.99m, "Shueisha", 0, 4.8f, null, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 50, null, null, "Merchandise", null, "Music box playing the theme song from Your Lie in April.", 0, "Shojo", null, true, null, null, "Your Lie in April Music Box", 0, null, 34.99m, "Kodansha", 0, 4.9f, null, new DateTime(2011, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 51, null, null, "Apparel", null, "Hoodie featuring the Attack on Titan Survey Corps emblem.", 0, "Seinen", null, true, null, null, "Attack on Titan Hoodie", 0, null, 49.99m, "Kodansha", 0, 4.8f, null, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 52, null, null, "Apparel", null, "T-Shirt featuring Naruto Uzumaki artwork.", 0, "Shonen", null, true, null, null, "Naruto T-Shirt", 0, null, 19.99m, "Shueisha", 0, 4.7f, null, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 53, null, null, "Apparel", null, "Sweatshirt featuring the Sailor Moon logo.", 0, "Shojo", null, true, null, null, "Sailor Moon Sweatshirt", 0, null, 34.99m, "Kodansha", 0, 4.9f, null, new DateTime(1992, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 54, null, null, "Apparel", null, "Cap featuring the One Piece Jolly Roger emblem.", 0, "Shonen", null, true, null, null, "One Piece Cap", 0, null, 14.99m, "Shueisha", 0, 4.8f, null, new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null },
                    { 55, null, null, "Apparel", null, "Set of socks featuring characters from My Hero Academia.", 0, "Shonen", null, true, null, null, "My Hero Academia Socks Set", 0, null, 9.99m, "Shueisha", 0, 4.7f, null, new DateTime(2014, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null }
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
                    { 6, "https://res.cloudinary.com/danedskby/image/upload/v1686923807/Naruto/naruto-vol-68-9781421576824_hr_rlrggo.jpg", 2 },
                    { 7, "https://res.cloudinary.com/danedskby/image/upload/v1686923807/Naruto/naruto1_visual_xziu06.webp", 2 },
                    { 8, "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/b12b9782aa863b75cdbee3a35ab62bd2_fy0bob.jpg", 2 },
                    { 9, "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/AAAABYxJFBDckfZw1YUEIPwyuIg43Kw_HUBLvnCcgdOlvvf5Nc90SF3HSAi5L8uLyBqjziKBY-kGD2wu2JAqVsdHVR0frb6qG26I_U5v_a9ihom.jpg", 2 },
                    { 10, "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/Profil-Picture-Naruto-Shippuden-600x600_ycugfi.webp", 2 },
                    { 11, "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/image-asset_hoalrl.jpg", 3 },
                    { 12, "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/bleach-20th-anniversary-anime-return_cicuq1.jpg", 3 },
                    { 13, "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/3f367-16729468481724_euq3zu.avif", 3 },
                    { 14, "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/LzRDfFeNHeUCtpH-1600x900-noPad_pns11d.jpg", 3 },
                    { 15, "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/LzRDfFeNHeUCtpH-1600x900-noPad_pns11d.jpg", 3 },
                    { 16, "https://cdn.vox-cdn.com/thumbor/6zsaqAYi7xeMcbhLW4MsxUN6NZs=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/3652050/wall6_wallpaper_1280x800.0.jpg", 4 },
                    { 17, "https://m.media-amazon.com/images/I/71iprqtljOL._AC_UF1000,1000_QL80_.jpg", 4 },
                    { 18, "https://e24joaz2t6m.exactdn.com/wp-content/uploads/2016/07/DragonBallZ-Season1-a.jpg", 4 },
                    { 19, "https://www.crunchyroll.com/imgsrv/display/thumbnail/1200x675/catalog/crunchyroll/36bdc5ea4443cd8e42f22ec7d3884cbb.jpe", 4 },
                    { 20, "https://assets.mycast.io/posters/dragon-ball-z-netflix-season-1-saiyan-saga-fan-casting-poster-144948-large.jpg?1636572989", 4 },
                    { 21, "https://m.media-amazon.com/images/I/81mOMGHVHdL._AC_UF1000,1000_QL80_.jpg", 5 },
                    { 22, "https://i0.wp.com/boldcanon.com/wp-content/uploads/2019/09/mv5bnmqzyme2mgetzjk4ys00ymvjlwewzwmtodrkmjc4mtm5n2i3xkeyxkfqcgdeqxvyntayodkwoq4040._v1_-e1567632423552.jpg?resize=1000%2C720&ssl=1", 5 },
                    { 23, "https://twinfinite.net/wp-content/uploads/2022/04/my-hero-academia-season-1-1.jpg?fit=1200%2C675", 5 },
                    { 24, "https://www.screenspy.com/wp-content/uploads/2022/04/Screenshotter-MyHeroAcademiaE7DekuvsKacchan-1943.jpg", 5 },
                    { 25, "https://i0.wp.com/butwhytho.net/wp-content/uploads/2022/11/My-Hero-Academia-Episode-122-But-Why-Tho-1.jpg?fit=800%2C410&ssl=1", 5 },
                    { 26, "https://static.wikia.nocookie.net/onepunchman/images/c/cd/One-Punch_Man_TV_Anime_Key_Visual.png/revision/latest?cb=20220818034817", 6 },
                    { 27, "https://img4.hulu.com/user/v3/artwork/34ebf58e-5a2a-4efa-8e4d-fb16039a3051?base_image_bucket_name=image_manager&base_image=ec6b707a-85c2-4d7c-9e3d-f9adf79004e3&size=600x338&format=jpeg", 6 },
                    { 28, "https://e0.pxfuel.com/wallpapers/84/241/desktop-wallpaper-one-punch-man-best-season-1-funny-saitama.jpg", 6 },
                    { 29, "https://static.wikia.nocookie.net/onepunchman/images/9/99/Puri-Puri_Prisoner_vs._Deep_Sea_King.png/revision/latest?cb=20160101201537", 6 },
                    { 30, "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/c5ef21697095ba7cc0bbec2c96dafca98119bac23349e0a8baac7d78a4107c07._RI_TTW_SX720_FMjpg_.jpg", 6 },
                    { 31, "https://m.media-amazon.com/images/M/MV5BYTIxNjk3YjItYmYzMC00ZTdmLTk0NGUtZmNlZTA0NWFkZDMwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_UY1200_CR85,0,630,1200_AL_.jpg", 7 },
                    { 32, "https://images.immediate.co.uk/production/volatile/sites/3/2022/10/Demon-Slayer-Attack-Different-Swords-8836587.jpg", 7 },
                    { 33, "https://www.hindustantimes.com/ht-img/img/2023/04/05/1600x900/Demon_slayer_season_2_recap_1680711861129_1680711892122_1680711892122.png", 7 },
                    { 34, "https://cdn.vox-cdn.com/thumbor/JBMeqrjWveSK05wPniHAOUzErrI=/1400x1050/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/24423451/Demon_Slayer_World_Tour_KV_ENG.jpg", 7 },
                    { 35, "https://cdn.animenewsnetwork.com/thumbnails/max650x650/cms/news.6/192798/kimetsu_worldtour.jpg", 7 },
                    { 36, "https://flxt.tmsimg.com/assets/p10873160_b1t_v8_aa.jpg", 8 },
                    { 37, "https://2danicritic.github.io/index_files/ReviewImages/review_Attack_on_Titan_-_Season_12.jpg", 8 },
                    { 38, "https://static.wikia.nocookie.net/shingekinokyojin/images/8/83/Eren_vs_Colossal_Titan.png/revision/latest?cb=20170623113218", 8 },
                    { 39, "https://static.wikia.nocookie.net/shingekinokyojin/images/8/83/Eren_vs_Colossal_Titan.png/revision/latest?cb=20170623113218", 8 },
                    { 40, "https://i0.wp.com/www.screenspy.com/wp-content/uploads/2022/07/attack-on-titan-s1-e25-2.png?ssl=1", 8 },
                    { 41, "https://dw9to29mmj727.cloudfront.net/promo/2016/6231-SeriesHeaders_HxH_2000x800.jpg", 9 },
                    { 42, "https://static1.cbrimages.com/wordpress/wp-content/uploads/2021/06/Hunter-x-Hunter-1.jpg", 9 },
                    { 43, "https://staticg.sportskeeda.com/editor/2022/04/33e84-16505291054558-1920.jpg", 9 },
                    { 44, "https://www.thenewshouse.com/wp-content/uploads/Untitled-design-4-1024x683.png", 9 },
                    { 45, "https://staticg.sportskeeda.com/editor/2022/11/70a3e-16680920162796-1920.jpg", 9 }
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
