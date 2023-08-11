using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.API.Migrations
{
    /// <inheritdoc/>
 
    public partial class AddQuotesBookNameProp : Migration
    {
        /// <inheritdoc/>

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("26544032-e96a-4a9a-85e7-d3588eb118e2"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("2f2ec6fa-1abb-45b4-9316-c036ac5d3edf"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("77dbddd4-ce23-47e6-9985-e4b3c6db47dc"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8a2c39eb-9b18-4b06-be4c-3af87cd7b51d"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("966847b6-7eda-4615-9aeb-641443db2565"));

            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "Quotes",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "BookName", "Content" },
                values: new object[] { new Guid("11101f0e-8462-43df-a767-77b4eaaa484b"), "Book 5", "Believe you can and you're halfway there." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "BookName", "Content" },
                values: new object[] { new Guid("4e911f05-db30-472e-9336-23e027707908"), "Book 3", "The future belongs to those who believe in the beauty of their dreams." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "BookName", "Content" },
                values: new object[] { new Guid("577d161d-363e-4225-84dc-2d960fb15ace"), "Book 2", "Innovation distinguishes between a leader and a follower." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "BookName", "Content" },
                values: new object[] { new Guid("7cbf153b-c55c-421a-9e14-f98b326f8250"), "Book 4", "The only limit to our realization of tomorrow will be our doubts of today." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "BookName", "Content" },
                values: new object[] { new Guid("d11cb1ef-c154-4233-a568-cb197174ac41"), "Book 1", "The only way to do great work is to love what you do." });
        }
        /// <inheritdoc/>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("11101f0e-8462-43df-a767-77b4eaaa484b"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("4e911f05-db30-472e-9336-23e027707908"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("577d161d-363e-4225-84dc-2d960fb15ace"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7cbf153b-c55c-421a-9e14-f98b326f8250"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("d11cb1ef-c154-4233-a568-cb197174ac41"));

            migrationBuilder.DropColumn(
                name: "BookName",
                table: "Quotes");

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("26544032-e96a-4a9a-85e7-d3588eb118e2"), "Innovation distinguishes between a leader and a follower." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("2f2ec6fa-1abb-45b4-9316-c036ac5d3edf"), "The only limit to our realization of tomorrow will be our doubts of today." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("77dbddd4-ce23-47e6-9985-e4b3c6db47dc"), "The future belongs to those who believe in the beauty of their dreams." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("8a2c39eb-9b18-4b06-be4c-3af87cd7b51d"), "The only way to do great work is to love what you do." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("966847b6-7eda-4615-9aeb-641443db2565"), "Believe you can and you're halfway there." });
        }
    }
}
