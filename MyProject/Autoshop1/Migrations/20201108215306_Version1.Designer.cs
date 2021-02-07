﻿// <auto-generated />
using System;
using Autoshop1.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Autoshop1.Migrations
{
    [DbContext(typeof(MainDBContext))]
    [Migration("20201108215306_Version1")]
    partial class Version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Autoshop1.Models.MainModels.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CartBuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CartPartName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CartPartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("CartSellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CartVendorId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CartItemID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeliveryType")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<double>("OrderByuingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderSellingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("ToSellDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.OrderedPart", b =>
                {
                    b.Property<int>("OrderedPartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrdBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("OrdBuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrdPartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrdPartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("OrdQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("OrdSellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalOrdBuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalOrdSellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("OrderedPartId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderedParts");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("BuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("PartId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.Order", b =>
                {
                    b.HasOne("Autoshop1.Models.MainModels.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Autoshop1.Models.MainModels.OrderedPart", b =>
                {
                    b.HasOne("Autoshop1.Models.MainModels.Order", "Order")
                        .WithMany("OrderedParts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}