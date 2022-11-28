using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7857), "C# programlama dili ile ilgili makaleler", true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7858), "C#", "C# kategorisi." },
                    { 2, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7862), "Javascript programlama dili ile ilgili makaleler", true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7863), "Javascript", "Javascript kategorisi." },
                    { 3, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7867), "React Js programlama dili ile ilgili makaleler", true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7868), "React Js", "React Js kategorisi." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2865), "admin rolü tüm haklara sahiptir.", true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2866), "Admin", "Bu, admin rolüdür." },
                    { 2, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2870), "user rolü tüm haklara sahiptir.", true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2871), "User", "Bu, user rolüdür." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7564), "İlk admin kullanıcısı", "denizgezen@gmail.com", "Deniz", true, false, "Gezen", "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7565), "Admin kullanıcısı.", new byte[] { 50, 48, 48, 56, 50, 48, 101, 51, 50, 50, 55, 56, 49, 53, 101, 100, 49, 55, 53, 54, 97, 54, 98, 53, 51, 49, 101, 55, 101, 48, 100, 50 }, "https://www.teknozum.com/wp-content/uploads/2019/12/whatsapp-profil-foto%C4%9Fraflar%C4%B1-17-1024x1024.jpg", 1, "denizgezen" },
                    { 2, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7588), "İlk user kullanıcısı", "yusufonan@gmail.com", "Yusuf", true, false, "Onan", "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7589), "User kullanıcısı.", new byte[] { 52, 54, 102, 57, 52, 99, 56, 100, 101, 49, 52, 102, 98, 51, 54, 54, 56, 48, 56, 53, 48, 55, 54, 56, 102, 102, 49, 98, 55, 102, 50, 97 }, "https://tasarimfikir.com/wp-content/uploads/profil-fotografi-tasarimi-min.jpg", 2, "yusufonan" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5658), new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5655), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5659), "C# 11.0 Yenilikleri", "Deniz Gezen", "C# 11.0 Yenilikleri", "C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core", "default.jpg", "C# 11.0 Yenilikleri", 1, 116 },
                    { 2, 2, 1, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5664), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5666), "Modern Javascript", "Deniz Gezen", "Modern Javascript", "ECMA Script, map, filter, reduce, arrow, function", "default.jpg", "Modern Javascript", 1, 193 },
                    { 3, 3, 1, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.", "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5672), new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5671), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5673), "React Component Yapısı", "Yusuf Onan", "React Component Yapısı", "React, React Js, component, class component, function component", "default.jpg", "React Component Yapısı", 2, 225 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1154), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1156), "C# 11.0 yenilikleri ile ilgili yorum.", "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham." },
                    { 2, 2, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1160), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1161), "Modern Javascript ile ilgili yorum.", "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham." },
                    { 3, 3, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1164), true, false, "InitialCreated", new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1165), "React ile ilgili yorum.", "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
