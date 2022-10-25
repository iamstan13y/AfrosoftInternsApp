namespace AfrosoftInterns.Migrations
{
    public partial class InternsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Sex = table.Column<string>(type: "varchar(6)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Department = table.Column<string>(type: "varchar(100)", nullable: true),
                    Specialty = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interns");
        }
    }
}
