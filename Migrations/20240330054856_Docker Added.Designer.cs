﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileStoreAPI.Data;

#nullable disable

namespace MobileStoreAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240330054856_Docker Added")]
    partial class DockerAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MobileStoreAPI.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AdminId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MobileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("MobileId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Mobile", b =>
                {
                    b.Property<int>("MobileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MobileModel")
                        .HasColumnType("longtext");

                    b.Property<string>("MobileName")
                        .HasColumnType("longtext");

                    b.Property<string>("MobilePrice")
                        .HasColumnType("longtext");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<string>("UniqueFileName")
                        .HasColumnType("longtext");

                    b.HasKey("MobileId");

                    b.HasIndex("StockId");

                    b.ToTable("mobiles");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MobileId")
                        .HasColumnType("int");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("longtext");

                    b.Property<int?>("usersUserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("MobileId");

                    b.HasIndex("usersUserId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AvailableStock")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StockId");

                    b.ToTable("stocks");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Cart", b =>
                {
                    b.HasOne("MobileStoreAPI.Models.Mobile", "mobile")
                        .WithMany()
                        .HasForeignKey("MobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileStoreAPI.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mobile");

                    b.Navigation("user");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Mobile", b =>
                {
                    b.HasOne("MobileStoreAPI.Models.Stock", "stock")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("stock");
                });

            modelBuilder.Entity("MobileStoreAPI.Models.Order", b =>
                {
                    b.HasOne("MobileStoreAPI.Models.Mobile", "mobile")
                        .WithMany()
                        .HasForeignKey("MobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileStoreAPI.Models.User", "users")
                        .WithMany()
                        .HasForeignKey("usersUserId");

                    b.Navigation("mobile");

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}