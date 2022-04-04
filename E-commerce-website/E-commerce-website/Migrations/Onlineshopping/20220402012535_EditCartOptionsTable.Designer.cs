﻿// <auto-generated />
using System;
using E_commerce_website.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_commerce_website.Migrations.Onlineshopping
{
    [DbContext(typeof(OnlineshoppingContext))]
    [Migration("20220402012535_EditCartOptionsTable")]
    partial class EditCartOptionsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_commerce_website.Models.CartItem", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("UserID", "ProductID");

                    b.HasIndex(new[] { "ProductID" }, "IX_CartItems_ProductID");

                    b.HasIndex(new[] { "UserID" }, "IX_CartItems_UserID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("E_commerce_website.Models.CartItemsOption", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("OptionID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "ProductID", "OptionID")
                        .HasName("PK_CartItemsOptions_1");

                    b.HasIndex("OptionID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItemsOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.Option", b =>
                {
                    b.Property<int>("OptionID")
                        .HasColumnType("int");

                    b.Property<int>("OptionGroupID")
                        .HasColumnType("int");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OptionID");

                    b.HasIndex(new[] { "OptionGroupID" }, "IX_Options_OptionGroupID");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("E_commerce_website.Models.OptionGroup", b =>
                {
                    b.Property<int>("OptionGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OptionGroupName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OptionGroupID");

                    b.ToTable("OptionGroups");
                });

            modelBuilder.Entity("E_commerce_website.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("OrderAmount")
                        .HasColumnType("money");

                    b.Property<string>("OrderCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("OrderCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<string>("OrderEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrderPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte?>("OrderStatus")
                        .HasColumnType("tinyint");

                    b.Property<int?>("OrderTrakingNumber")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex(new[] { "UserID" }, "IX_Orders_UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_commerce_website.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Quanity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex(new[] { "OrderID" }, "IX_OrderDetails_DetailOrderID");

                    b.HasIndex(new[] { "ProductID" }, "IX_OrderDetails_DetailProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("E_commerce_website.Models.OrderItemsOption", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("OptionID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "UserID", "ProductID");

                    b.HasIndex("OptionID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("OrderItemsOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProductLongDes")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("money");

                    b.Property<string>("ProductShortDes")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ProductUpdateDate")
                        .HasColumnType("datetime");

                    b.Property<double?>("ProductWeight")
                        .HasColumnType("float");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex(new[] { "ProductCategoryID" }, "IX_Products_ProductCategoryID");

                    b.HasIndex(new[] { "VendorID" }, "IX_Products_VendorID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_commerce_website.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("E_commerce_website.Models.ProductOption", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OptionID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex(new[] { "OptionID" }, "IX_ProductOptions_OptionID");

                    b.HasIndex(new[] { "ProductID" }, "IX_ProductOptions_ProductID");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<string>("UserCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<byte>("UserEmailVerfied")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UserRegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserVerficationCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_commerce_website.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VendorAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VendorCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VendorCountry")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<string>("VendorEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VendorPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<string>("VendorPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("VendorRegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("VendorVerficationCode")
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("E_commerce_website.Models.CartItem", b =>
                {
                    b.HasOne("E_commerce_website.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_CartItems_Products")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.User", "User")
                        .WithMany("CartItems")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_CartItems_Users")
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce_website.Models.CartItemsOption", b =>
                {
                    b.HasOne("E_commerce_website.Models.Option", "Option")
                        .WithMany("CartItemsOptions")
                        .HasForeignKey("OptionID")
                        .HasConstraintName("FK_CartItemsOptions_Options")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Product", "Product")
                        .WithMany("CartItemsOptions")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_CartItemsOptions_Products")
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce_website.Models.Option", b =>
                {
                    b.HasOne("E_commerce_website.Models.OptionGroup", "OptionGroup")
                        .WithMany("Options")
                        .HasForeignKey("OptionGroupID")
                        .HasConstraintName("FK_Options_OptionGroups")
                        .IsRequired();

                    b.Navigation("OptionGroup");
                });

            modelBuilder.Entity("E_commerce_website.Models.Order", b =>
                {
                    b.HasOne("E_commerce_website.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_Orders_Users")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce_website.Models.OrderDetail", b =>
                {
                    b.HasOne("E_commerce_website.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .HasConstraintName("FK_OrderDetails_Orders")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_OrderDetails_Products")
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce_website.Models.OrderItemsOption", b =>
                {
                    b.HasOne("E_commerce_website.Models.Option", "Option")
                        .WithMany("OrderItemsOptions")
                        .HasForeignKey("OptionID")
                        .HasConstraintName("FK_OrderItemsOptions_Options")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Order", "Order")
                        .WithMany("OrderItemsOptions")
                        .HasForeignKey("OrderID")
                        .HasConstraintName("FK_OrderItemsOptions_Orders")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Product", "Product")
                        .WithMany("OrderItemsOptions")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_OrderItemsOptions_Products")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.User", "User")
                        .WithMany("OrderItemsOptions")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_OrderItemsOptions_Users")
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce_website.Models.Product", b =>
                {
                    b.HasOne("E_commerce_website.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryID")
                        .HasConstraintName("FK_Products_ProductCategories")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorID")
                        .HasConstraintName("FK_Products_Vendor")
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("E_commerce_website.Models.ProductOption", b =>
                {
                    b.HasOne("E_commerce_website.Models.Option", "Option")
                        .WithMany("ProductOptions")
                        .HasForeignKey("OptionID")
                        .HasConstraintName("FK_ProductOptions_Options")
                        .IsRequired();

                    b.HasOne("E_commerce_website.Models.Product", "Product")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_ProductOptions_Products")
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce_website.Models.Option", b =>
                {
                    b.Navigation("CartItemsOptions");

                    b.Navigation("OrderItemsOptions");

                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.OptionGroup", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("E_commerce_website.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("OrderItemsOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("CartItemsOptions");

                    b.Navigation("OrderDetails");

                    b.Navigation("OrderItemsOptions");

                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("E_commerce_website.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_commerce_website.Models.User", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItemsOptions");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("E_commerce_website.Models.Vendor", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}