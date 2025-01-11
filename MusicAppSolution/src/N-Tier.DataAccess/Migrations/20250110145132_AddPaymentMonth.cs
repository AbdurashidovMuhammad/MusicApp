﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N_Tier.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentMonth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentMonth",
                table: "PaymentHistories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMonth",
                table: "PaymentHistories");
        }
    }
}
