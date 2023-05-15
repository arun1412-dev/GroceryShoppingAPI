﻿// <auto-generated />
using FoodOrderApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodOrderApi.Migrations
{
    [DbContext(typeof(FoodApiDbContext))]
    [Migration("20230511140221_FoodOrderApi")]
    partial class FoodOrderApi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("FoodOrderApi.Model.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductPrice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("FoodOrderApi.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodOrderApi.Model.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RestaurantLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RestaurantPhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RestaurantType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}