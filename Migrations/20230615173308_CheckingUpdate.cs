using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeShop.Migrations
{
    /// <inheritdoc />
    public partial class CheckingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://example.com/image1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://example.com/image2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://example.com/image3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://example.com/image4.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://example.com/image5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "Embark on an epic adventure with the complete first season of the beloved One Piece anime series. Join Monkey D. Luffy and his spirited crew as they set sail in search of the legendary treasure, the One Piece. Immerse yourself in a world of thrilling battles, unforgettable characters, and awe-inspiring discoveries. This DVD set captures the essence of the captivating Shonen genre, delivering heart-pounding action and boundless excitement. With a runtime of 750 minutes, you'll be captivated by the enthralling storyline and incredible animation brought to life by Toei Animation, the acclaimed studio behind this iconic series. Explore the vibrant world of One Piece as you witness the beginning of Luffy's extraordinary journey. Experience the bonds of friendship, the thrill of adventure, and the pursuit of dreams in this timeless masterpiece. The 'One Piece Season 1' DVD set is a must-have for fans and collectors alike. It features the original Japanese audio with English subtitles, allowing you to fully immerse yourself in the authentic storytelling. This Region 1 DVD edition ensures compatibility for your viewing pleasure.Don't miss your chance to own this treasure trove of entertainment. Get ready to set sail with Luffy and his crew on this remarkable voyage that has captivated audiences worldwide!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: "Immerse yourself in the thrilling world of Naruto with the first box set of the iconic anime series on DVD. This box set includes the exhilarating episodes from the early seasons, introducing you to the epic journey of Naruto Uzumaki as he aspires to become the strongest ninja in his village. Join Naruto and his friends as they navigate through challenges, uncover secrets, and face powerful adversaries. With stunning animation, captivating storytelling, and memorable characters, Naruto Box Set 1 is a must-have for every anime fan. Dive into the action-packed episodes, witness Naruto's determination, and experience the bonds of friendship that transcend limits. This DVD box set features the original Japanese audio with English subtitles, ensuring an authentic viewing experience. Get ready to embark on an unforgettable ninja adventure with Naruto Box Set 1!");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://your-url.com/naruto-image1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://your-url.com/naruto-image2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://your-url.com/naruto-image3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://your-url.com/naruto-image4.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://your-url.com/naruto-image5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "The complete first season of One Piece anime series on DVD.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: "The first box set of Naruto anime series on DVD.");
        }
    }
}
