using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_App.Migrations
{
    public partial class updateQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionPosted",
                table: "Questions",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionPosted",
                table: "Questions");
        }
    }
}
