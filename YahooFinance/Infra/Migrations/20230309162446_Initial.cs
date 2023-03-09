using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetVariations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Porcentagem = table.Column<double>(type: "float", nullable: false),
                    PercentualDesdePrimeiraData = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetVariations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<int>(type: "int", nullable: false),
                    Gmtoffset = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<int>(type: "int", nullable: false),
                    Gmtoffset = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<int>(type: "int", nullable: false),
                    Gmtoffset = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regulars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Close = table.Column<double>(type: "float", nullable: false),
                    Open = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Low = table.Column<double>(type: "float", nullable: false),
                    High = table.Column<double>(type: "float", nullable: false),
                    IndicatorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Indicators_IndicatorsId",
                        column: x => x.IndicatorsId,
                        principalTable: "Indicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentTradingPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreId = table.Column<int>(type: "int", nullable: false),
                    RegularId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTradingPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentTradingPeriods_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentTradingPeriods_Pres_PreId",
                        column: x => x.PreId,
                        principalTable: "Pres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentTradingPeriods_Regulars_RegularId",
                        column: x => x.RegularId,
                        principalTable: "Regulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstrumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstTradeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegularMarketTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gmtoffset = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeTimezoneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegularMarketPrice = table.Column<double>(type: "float", nullable: false),
                    ChartPreviousClose = table.Column<double>(type: "float", nullable: false),
                    PreviousClose = table.Column<double>(type: "float", nullable: false),
                    Scale = table.Column<int>(type: "int", nullable: false),
                    PriceHint = table.Column<int>(type: "int", nullable: false),
                    CurrentTradingPeriodId = table.Column<int>(type: "int", nullable: false),
                    DataGranularity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ativos_CurrentTradingPeriods_CurrentTradingPeriodId",
                        column: x => x.CurrentTradingPeriodId,
                        principalTable: "CurrentTradingPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtivoFull",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoId = table.Column<int>(type: "int", nullable: false),
                    IndicatorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtivoFull", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtivoFull_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtivoFull_Indicators_IndicatorsId",
                        column: x => x.IndicatorsId,
                        principalTable: "Indicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradingPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<long>(type: "bigint", nullable: false),
                    Gmtoffset = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    AtivoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TradingPeriod_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValidRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtivoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidRanges_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtivoFull_AtivoId",
                table: "AtivoFull",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtivoFull_IndicatorsId",
                table: "AtivoFull",
                column: "IndicatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_CurrentTradingPeriodId",
                table: "Ativos",
                column: "CurrentTradingPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTradingPeriods_PostId",
                table: "CurrentTradingPeriods",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTradingPeriods_PreId",
                table: "CurrentTradingPeriods",
                column: "PreId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTradingPeriods_RegularId",
                table: "CurrentTradingPeriods",
                column: "RegularId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_IndicatorsId",
                table: "Quotes",
                column: "IndicatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_TradingPeriod_AtivoId",
                table: "TradingPeriod",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidRanges_AtivoId",
                table: "ValidRanges",
                column: "AtivoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetVariations");

            migrationBuilder.DropTable(
                name: "AtivoFull");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "TradingPeriod");

            migrationBuilder.DropTable(
                name: "ValidRanges");

            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Ativos");

            migrationBuilder.DropTable(
                name: "CurrentTradingPeriods");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Pres");

            migrationBuilder.DropTable(
                name: "Regulars");
        }
    }
}
