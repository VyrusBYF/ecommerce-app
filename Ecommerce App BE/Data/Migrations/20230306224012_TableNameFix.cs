using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce_App_BE.Migrations
{
    /// <inheritdoc />
    public partial class TableNameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products.Product_Shopping.Cart_CartID",
                table: "Products.Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users.User",
                table: "Users.User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shopping.Cart",
                table: "Shopping.Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products.Product",
                table: "Products.Product");

            migrationBuilder.EnsureSchema(
                name: "Shopping");

            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.EnsureSchema(
                name: "Users");

            migrationBuilder.RenameTable(
                name: "Users.User",
                newName: "User",
                newSchema: "Users");

            migrationBuilder.RenameTable(
                name: "Shopping.Cart",
                newName: "Cart",
                newSchema: "Shopping");

            migrationBuilder.RenameTable(
                name: "Products.Product",
                newName: "Product",
                newSchema: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Products.Product_CartID",
                schema: "Products",
                table: "Product",
                newName: "IX_Product_CartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "Users",
                table: "User",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                schema: "Shopping",
                table: "Cart",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                schema: "Products",
                table: "Product",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Cart_CartID",
                schema: "Products",
                table: "Product",
                column: "CartID",
                principalSchema: "Shopping",
                principalTable: "Cart",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Cart_CartID",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "Users",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                schema: "Shopping",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Users",
                newName: "Users.User");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Products",
                newName: "Products.Product");

            migrationBuilder.RenameTable(
                name: "Cart",
                schema: "Shopping",
                newName: "Shopping.Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CartID",
                table: "Products.Product",
                newName: "IX_Products.Product_CartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users.User",
                table: "Users.User",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products.Product",
                table: "Products.Product",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shopping.Cart",
                table: "Shopping.Cart",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products.Product_Shopping.Cart_CartID",
                table: "Products.Product",
                column: "CartID",
                principalTable: "Shopping.Cart",
                principalColumn: "ID");
        }
    }
}
