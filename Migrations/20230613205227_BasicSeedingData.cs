using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeShop.Migrations
{
    /// <inheritdoc />
    public partial class BasicSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Genre", "Name", "Price", "Publisher", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Manga", "A manga about pirates in search of the ultimate treasure.", "Shonen", "One Piece", 10.99m, "Shueisha", 4.9f, new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Manga", "A manga about a ninja's journey to becoming the strongest in his village.", "Shonen", "Naruto", 9.99m, "Shueisha", 4.8f, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Manga", "A manga about a teenager who becomes a soul reaper.", "Shonen", "Bleach", 10.99m, "Shueisha", 4.7f, new DateTime(2001, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Manga", "A manga about a high school student who discovers a notebook that allows him to kill anyone by writing their name in it.", "Shonen", "Death Note", 11.99m, "Shueisha", 4.9f, new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Manga", "A manga about humanity's fight for survival against giant humanoid creatures.", "Seinen", "Attack on Titan", 10.99m, "Kodansha", 4.8f, new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "DVD", "The complete first season of My Hero Academia anime series on DVD.", "Shonen", "My Hero Academia Season 1", 24.99m, "Funimation", 4.9f, new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "DVD", "The complete first season of One Punch Man anime series on DVD.", "Seinen", "One Punch Man Season 1", 19.99m, "Viz Media", 4.8f, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "DVD", "The complete first season of Demon Slayer: Kimetsu no Yaiba anime series on DVD.", "Shonen", "Demon Slayer: Kimetsu no Yaiba Season 1", 24.99m, "Aniplex", 4.9f, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "DVD", "The complete first season of Attack on Titan anime series on DVD.", "Seinen", "Attack on Titan Season 1", 29.99m, "Funimation", 4.8f, new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "DVD", "The complete series of Naruto Shippuden anime on DVD.", "Shonen", "Naruto Shippuden Complete Series", 199.99m, "Viz Media", 4.7f, new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Merchandise", "Straw Hat of the iconic Monkey D. Luffy from One Piece.", "Shonen", "One Piece Straw Hat", 19.99m, "Toei Animation", 4.9f, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Merchandise", "Cloak worn by the members of Akatsuki from Naruto.", "Shonen", "Naruto Akatsuki Cloak", 59.99m, "Studio Pierrot", 4.8f, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Merchandise", "Survey Corps Jacket from Attack on Titan.", "Seinen", "Attack on Titan Survey Corps Jacket", 49.99m, "Wit Studio", 4.7f, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Merchandise", "Pocket watch used by the State Alchemists in Fullmetal Alchemist.", "Shonen", "Fullmetal Alchemist Pocket Watch", 29.99m, "Bones", 4.9f, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Merchandise", "Replica of the Death Note used in the Death Note series.", "Shonen", "Death Note Notebook", 14.99m, "Madhouse", 4.8f, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://static.wikia.nocookie.net/onepiece/images/c/c6/Volume_100.png/revision/latest?cb=20210903160940", 1 },
                    { 2, "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421564609/one-piece-vol-70-9781421564609_hr.jpg", 1 },
                    { 3, "https://img.asmedia.epimg.net/resizer/0AAWhRs-18LkHLrC1Zp3X1c2y9Y=/1472x828/cloudfront-eu-central-1.images.arcpublishing.com/diarioas/7FLY3ULLSRH2VCC3DDTEQDXMKI.jpg", 1 },
                    { 4, "https://your-url.com/death-note.jpg", 4 },
                    { 5, "https://your-url.com/attack-on-titan.jpg", 5 },
                    { 6, "https://your-url.com/FullMetal_Alchemist_Brotherhood_DVD.jpg", 6 },
                    { 7, "https://your-url.com/Death_Note_DVD.jpg", 7 },
                    { 8, "https://your-url.com/Attack_on_Titan_DVD.jpg", 8 },
                    { 9, "https://your-url.com/Naruto_Shippuden_DVD.jpg", 9 },
                    { 10, "https://your-url.com/Demon_Slayer_DVD.jpg", 10 },
                    { 21, "https://example.com/one-piece-hat.jpg", 11 },
                    { 22, "https://example.com/naruto-akatsuki-cloak.jpg", 12 },
                    { 23, "https://example.com/aot-survey-corps-jacket.jpg", 13 },
                    { 24, "https://example.com/fullmetal-alchemist-watch.jpg", 14 },
                    { 25, "https://example.com/death-note-notebook.jpg", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);
        }
    }
}
