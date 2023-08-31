﻿// <auto-generated />
using System;
using CMPG_323_Project_2_30297079.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMPG_323_Project_2_30297079.Migrations
{
    [DbContext(typeof(cmpg323proj2Context))]
    partial class cmpg323proj2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Customer", b =>
                {
                    b.Property<short>("CustomerId")
                        .HasColumnType("smallint");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerSurname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerTitle")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Order", b =>
                {
                    b.Property<short>("OrderId")
                        .HasColumnType("smallint");

                    b.Property<short>("CustomerId")
                        .HasColumnType("smallint");

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.OrderDetail", b =>
                {
                    b.Property<short>("OrderDetailsId")
                        .HasColumnType("smallint")
                        .HasColumnName("OrderDetailsID");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<short>("OrderId")
                        .HasColumnType("smallint");

                    b.Property<short>("ProductId")
                        .HasColumnType("smallint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Product", b =>
                {
                    b.Property<short>("ProductId")
                        .HasColumnType("smallint");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Order", b =>
                {
                    b.HasOne("CMPG_323_Project_2_30297079.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Customers");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.OrderDetail", b =>
                {
                    b.HasOne("CMPG_323_Project_2_30297079.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("CMPG_323_Project_2_30297079.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Products1");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("CMPG_323_Project_2_30297079.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
