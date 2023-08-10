﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.API.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0fc3776d-d081-4fe5-8262-05cdd7e5b7a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38ef95f8-bdac-437d-99f6-6355654b887b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57592ea6-b682-44b7-97fa-3d62f1667580"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c5af8af-bb5b-411c-800e-a8094e79cb8e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f4292ed-227c-42ac-8ae1-56a6701c612f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("70081581-6655-4133-b7a7-357285f439f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b915ca4-ac42-4890-83c3-0f806b449d1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ce197bc-9071-4278-ac06-3e78601d1981"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97c40757-7dee-49df-bb35-7aa241b42ae2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7672cee-d896-47dd-bb68-bdad921af656"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("1a54691c-bfd1-40f4-9c4e-43ff6d435404"), "Virginia Woolf", new DateTime(1927, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A distinctive novel by Virginia Woolf that explores the concept of time, change, and human relationships.", "To the Lighthouse" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("47c5d7b1-2323-4a65-a654-3338cb6f3128"), "Aldous Huxley", new DateTime(1932, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A science fiction novel that describes an advanced future society and how technology and institutions affect humans.", "Brave New World" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("62064eb1-5a93-4772-8b82-c74fcf5294d5"), "Herman Melville", new DateTime(1851, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic novel that describes the journey of sailors aboard the ship 'Pequod' to hunt a giant whale named Moby Dick.", "Moby-Dick" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("8a6093bb-45e1-4f16-9d6f-c278dd0ea5b7"), "J.D. Salinger", new DateTime(1951, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A famous novel that depicts teenage angst and social alienation.", "The Catcher in the Rye" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("992d461e-4317-4859-baa2-194138253e09"), "Jane Austen", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic romance novel that portrays British society in the 19th century.", "Pride and Prejudice" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("9faea490-c621-429d-9964-b5ecc835f1f8"), "C.S. Lewis", new DateTime(1950, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A series of seven fantasy novels that follow the adventures of children in the magical land of Narnia.", "The Chronicles of Narnia" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("d6d555f0-c8a8-43ce-b4ad-ec51357efd21"), "George Orwell", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dystopian and political science fiction novel that depicts a society controlled by a totalitarian government.", "1984" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("eafa5565-89ca-4101-aec0-3b791c05e4d4"), "F. Scott Fitzgerald", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A distinctive novel that portrays the social elite in the 1920s.", "The Great Gatsby" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("f832ea23-d85a-4f1c-ba61-67bd6637a8d6"), "J.R.R. Tolkien", new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic fantasy trilogy that follows the journey of Frodo Baggins and his friends to destroy the One Ring.", "The Lord of the Rings" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("fbd518e2-a6d1-4ea9-8cda-fceaf2703bcd"), "Harper Lee", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A powerful novel set in the American South during the struggle for civil rights and social justice.", "To Kill a Mockingbird" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1a54691c-bfd1-40f4-9c4e-43ff6d435404"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47c5d7b1-2323-4a65-a654-3338cb6f3128"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62064eb1-5a93-4772-8b82-c74fcf5294d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a6093bb-45e1-4f16-9d6f-c278dd0ea5b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("992d461e-4317-4859-baa2-194138253e09"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9faea490-c621-429d-9964-b5ecc835f1f8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6d555f0-c8a8-43ce-b4ad-ec51357efd21"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eafa5565-89ca-4101-aec0-3b791c05e4d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f832ea23-d85a-4f1c-ba61-67bd6637a8d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbd518e2-a6d1-4ea9-8cda-fceaf2703bcd"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("0fc3776d-d081-4fe5-8262-05cdd7e5b7a4"), "George Orwell", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dystopian and political science fiction novel that depicts a society controlled by a totalitarian government.", "1984" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("38ef95f8-bdac-437d-99f6-6355654b887b"), "Herman Melville", new DateTime(1851, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic novel that describes the journey of sailors aboard the ship 'Pequod' to hunt a giant whale named Moby Dick.", "Moby-Dick" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("57592ea6-b682-44b7-97fa-3d62f1667580"), "F. Scott Fitzgerald", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A distinctive novel that portrays the social elite in the 1920s.", "The Great Gatsby" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("6c5af8af-bb5b-411c-800e-a8094e79cb8e"), "Virginia Woolf", new DateTime(1927, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A distinctive novel by Virginia Woolf that explores the concept of time, change, and human relationships.", "To the Lighthouse" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("6f4292ed-227c-42ac-8ae1-56a6701c612f"), "J.D. Salinger", new DateTime(1951, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A famous novel that depicts teenage angst and social alienation.", "The Catcher in the Rye" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("70081581-6655-4133-b7a7-357285f439f6"), "Aldous Huxley", new DateTime(1932, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A science fiction novel that describes an advanced future society and how technology and institutions affect humans.", "Brave New World" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("7b915ca4-ac42-4890-83c3-0f806b449d1a"), "Harper Lee", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A powerful novel set in the American South during the struggle for civil rights and social justice.", "To Kill a Mockingbird" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("7ce197bc-9071-4278-ac06-3e78601d1981"), "Jane Austen", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic romance novel that portrays British society in the 19th century.", "Pride and Prejudice" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("97c40757-7dee-49df-bb35-7aa241b42ae2"), "C.S. Lewis", new DateTime(1950, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A series of seven fantasy novels that follow the adventures of children in the magical land of Narnia.", "The Chronicles of Narnia" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "ShortDescription", "Title" },
                values: new object[] { new Guid("d7672cee-d896-47dd-bb68-bdad921af656"), "J.R.R. Tolkien", new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic fantasy trilogy that follows the journey of Frodo Baggins and his friends to destroy the One Ring.", "The Lord of the Rings" });
        }
    }
}