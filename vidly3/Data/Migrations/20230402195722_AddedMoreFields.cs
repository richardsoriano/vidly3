﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly3.Data.Migrations
{
    public partial class AddedMoreFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<DateTime>(
            //    name: "AddedDate",
            //    table: "Movies",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<int>(
            //    name: "NumberInStock",
            //    table: "Movies",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "ReleaseDate",
            //    table: "Movies",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "AddedDate",
            //    table: "Movies");

            //migrationBuilder.DropColumn(
            //    name: "NumberInStock",
            //    table: "Movies");

            //migrationBuilder.DropColumn(
            //    name: "ReleaseDate",
            //    table: "Movies");
        }
    }
}
