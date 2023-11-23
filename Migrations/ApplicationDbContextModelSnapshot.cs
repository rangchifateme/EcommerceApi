﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceApi.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductIdId")
                        .HasColumnType("int");

                    b.Property<int?>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductIdId");

                    b.HasIndex("UserIdId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("EcommerceApi.Entities.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrdertIdId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductIdId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UsertIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdertIdId");

                    b.HasIndex("ProductIdId");

                    b.HasIndex("UsertIdId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EcommerceApi.Entities.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserIdId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EcommerceApi.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EcommerceApi.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LasttName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EcommerceApi.Entities.Cart", b =>
                {
                    b.HasOne("EcommerceApi.Entities.Products", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId");

                    b.HasOne("EcommerceApi.Entities.Users", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId");

                    b.Navigation("ProductId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("EcommerceApi.Entities.OrderItems", b =>
                {
                    b.HasOne("EcommerceApi.Entities.Orders", "OrdertId")
                        .WithMany()
                        .HasForeignKey("OrdertIdId");

                    b.HasOne("EcommerceApi.Entities.Products", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId");

                    b.HasOne("EcommerceApi.Entities.Users", "UsertId")
                        .WithMany()
                        .HasForeignKey("UsertIdId");

                    b.Navigation("OrdertId");

                    b.Navigation("ProductId");

                    b.Navigation("UsertId");
                });

            modelBuilder.Entity("EcommerceApi.Entities.Orders", b =>
                {
                    b.HasOne("EcommerceApi.Entities.Users", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
