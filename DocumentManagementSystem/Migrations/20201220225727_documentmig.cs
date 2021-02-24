 using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentManagementSystem.Migrations
{
    public partial class documentmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documentFiles",
                columns: table => new
                {
                    document_file_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_file_name = table.Column<string>(nullable: true),
                    numberOf_document = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentFiles", x => x.document_file_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(nullable: true),
                    user_surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "deletedDocuments",
                columns: table => new
                {
                    deleted_document_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deleted_document_type = table.Column<string>(nullable: true),
                    deleted_document_name = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deletedDocuments", x => x.deleted_document_id);
                    table.ForeignKey(
                        name: "FK_deletedDocuments_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    document_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_type = table.Column<string>(nullable: true),
                    document_name = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    DocumentFileID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.document_id);
                    table.ForeignKey(
                        name: "FK_documents_documentFiles_DocumentFileID",
                        column: x => x.DocumentFileID,
                        principalTable: "documentFiles",
                        principalColumn: "document_file_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_documents_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_deletedDocuments_UserID",
                table: "deletedDocuments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_documents_DocumentFileID",
                table: "documents",
                column: "DocumentFileID");

            migrationBuilder.CreateIndex(
                name: "IX_documents_UserID",
                table: "documents",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deletedDocuments");

            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "documentFiles");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
