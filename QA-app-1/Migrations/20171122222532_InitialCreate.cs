using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QAapp1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassroomModel",
                columns: table => new
                {
                    classroomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    school = table.Column<string>(nullable: true),
                    subject = table.Column<string>(nullable: true),
                    subjectRate = table.Column<int>(nullable: false),
                    timeStamp = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomModel", x => x.classroomId);
                });

            migrationBuilder.CreateTable(
                name: "ResponseModel",
                columns: table => new
                {
                    responseType = table.Column<string>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    likeCount = table.Column<int>(nullable: false),
                    timeStamp = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseModel", x => x.responseType);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassroomModel");

            migrationBuilder.DropTable(
                name: "ResponseModel");
        }
    }
}
