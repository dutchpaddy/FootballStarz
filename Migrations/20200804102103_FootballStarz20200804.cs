using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballStarz.Migrations
{
    public partial class FootballStarz20200804 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Stadiums",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StadiumImage",
                table: "Stadiums",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayerImage",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClubName",
                table: "Clubs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClubLogo",
                table: "Clubs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StadiumImage",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "PlayerImage",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ClubLogo",
                table: "Clubs");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Stadiums",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PlayerName",
                table: "Players",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Players",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClubName",
                table: "Clubs",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
