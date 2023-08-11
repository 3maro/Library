using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.API.Migrations
{
    /// <inheritdoc/>

    public partial class AddQuotes : Migration
    {    /// <inheritdoc/>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
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
        /// <inheritdoc/>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
