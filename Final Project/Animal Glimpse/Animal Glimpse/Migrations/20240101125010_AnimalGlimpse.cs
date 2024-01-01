using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animal_Glimpse.Migrations
{
    /// <inheritdoc />
    public partial class AnimalGlimpse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "Reactions",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "aquire_date",
                table: "Instances",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Commentss",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Color",
                table: "Reacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Reactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Instances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Instances",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Instances");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Reactions",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Instances",
                newName: "aquire_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Commentss",
                newName: "CommentId");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Reacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
