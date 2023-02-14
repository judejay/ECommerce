﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using easygroceries.Data;

#nullable disable

namespace easygroceries.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("easygroceries.Data.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerSecondName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseNumberName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MembershipId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Postcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Town")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Active = false,
                            Country = "UK",
                            CustomerFirstName = "Bill",
                            CustomerSecondName = "Gates",
                            HouseNumberName = "222",
                            MembershipId = 0,
                            Postcode = "NW5 8MM",
                            StreetName = "High street",
                            Town = "Newark"
                        },
                        new
                        {
                            CustomerId = 2,
                            Active = false,
                            Country = "UK",
                            CustomerFirstName = "Jon",
                            CustomerSecondName = "Snow",
                            HouseNumberName = "1",
                            MembershipId = 0,
                            Postcode = "SW1 1LP",
                            StreetName = "Main street",
                            Town = "London"
                        });
                });

            modelBuilder.Entity("easygroceries.Data.Grocery", b =>
                {
                    b.Property<int>("GroceryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.HasKey("GroceryId");

                    b.ToTable("Groceries");

                    b.HasData(
                        new
                        {
                            GroceryId = 1,
                            Description = "Juicy apples",
                            Image = "https://images.pexels.com/photos/1453713/pexels-photo-1453713.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Apples",
                            Price = 1.50m,
                            Quantity = 50,
                            Slug = "apples"
                        },
                        new
                        {
                            GroceryId = 2,
                            Description = "Fresh bananas",
                            Image = "https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Bananas",
                            Price = 3.50m,
                            Quantity = 50,
                            Slug = "bananas"
                        },
                        new
                        {
                            GroceryId = 3,
                            Description = "Juicy watermelon",
                            Image = "https://images.pexels.com/photos/1313267/pexels-photo-1313267.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Watermelon",
                            Price = 2.50m,
                            Quantity = 50,
                            Slug = "watermelon"
                        },
                        new
                        {
                            GroceryId = 4,
                            Description = "Juicy grapefruit",
                            Image = "https://images.pexels.com/photos/2247211/pexels-photo-2247211.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Grapefruit",
                            Price = 2m,
                            Quantity = 50,
                            Slug = "grapefruit"
                        },
                        new
                        {
                            GroceryId = 5,
                            Description = "The best of cows",
                            Image = "https://images.pexels.com/photos/248412/pexels-photo-248412.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Milk",
                            Price = 1.99m,
                            Quantity = 50,
                            Slug = "milk"
                        },
                        new
                        {
                            GroceryId = 6,
                            Description = "Easy toast",
                            Image = "https://images.pexels.com/photos/166021/pexels-photo-166021.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Bread",
                            Price = 1.99m,
                            Quantity = 50,
                            Slug = "bread"
                        },
                        new
                        {
                            GroceryId = 7,
                            Description = "Wild chicken",
                            Image = "https://images.pexels.com/photos/600615/pexels-photo-600615.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Eggs",
                            Price = 1.99m,
                            Quantity = 50,
                            Slug = "eggs"
                        });
                });

            modelBuilder.Entity("easygroceries.Data.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType(" decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("PurchaseOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 2,
                            TotalPrice = 40m
                        });
                });

            modelBuilder.Entity("easygroceries.Data.PurchaseOrder", b =>
                {
                    b.HasOne("easygroceries.Data.Customer", "Customer")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("easygroceries.Data.Customer", b =>
                {
                    b.Navigation("PurchaseOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
