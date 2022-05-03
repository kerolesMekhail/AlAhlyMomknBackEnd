using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlAhlyMomkn.Repository.Migrations
{
    public partial class SeeRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "AspNetRoles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[] { Guid.NewGuid().ToString(), "User", "User".ToUpper(), Guid.NewGuid().ToString() }
           );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }
            );

           // migrationBuilder.InsertData(
           //    table: "AspNetUsers",
           //    columns: new[] { "Id",
           //                     "FirstName ",
           //                     "LastName ",
           //                     "Email", 
           //                     "NormalizedEmail",
           //                     "UserName",
           //                     "NormalizedUserName",
           //                     "PhoneNumber",
           //                     "EmailConfirmed",
           //                     "PhoneNumberConfirmed ",
           //                     "SecurityStamp " },
           //    values: new object[] { Guid.NewGuid().ToString(),
           //                           "Keroles", 
           //                           "Ibraim",
           //                           "kmekhail22@gmail.com",
           //                           "KMEKHAIL22@GMAIL.COM",
           //                           "KerolesIbrahim",
           //                           "KEROLESIBRAHIM",
           //                           "+01282779982",
           //                           true,
           //                           true,
           //                           Guid.NewGuid().ToString()
           //    }
           //);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
           // migrationBuilder.Sql("DELETE FROM [AspNetUsers]");
        }
    }
}
