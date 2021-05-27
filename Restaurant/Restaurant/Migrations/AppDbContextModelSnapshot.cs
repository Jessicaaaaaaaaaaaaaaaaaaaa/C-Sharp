﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.Models;

namespace Restaurant.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kjielkje & Schmaunt Fat",
                            Price = 14.99
                        },
                        new
                        {
                            Id = 2,
                            Name = "Plumi Moos",
                            Price = 7.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vereniki",
                            Price = 12.99
                        });
                });

            modelBuilder.Entity("Restaurant.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 5, 27, 16, 24, 52, 184, DateTimeKind.Local).AddTicks(2808),
                            Name = "John Klassen"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2021, 5, 27, 16, 24, 52, 187, DateTimeKind.Local).AddTicks(7942),
                            Name = "Margaret Froese"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2021, 5, 27, 16, 24, 52, 187, DateTimeKind.Local).AddTicks(7980),
                            Name = "Anna Giesbrecht"
                        });
                });

            modelBuilder.Entity("Restaurant.Models.ReservationMenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationMenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuItemId = 1,
                            ReservationId = 1
                        },
                        new
                        {
                            Id = 2,
                            MenuItemId = 2,
                            ReservationId = 2
                        },
                        new
                        {
                            Id = 3,
                            MenuItemId = 3,
                            ReservationId = 3
                        });
                });

            modelBuilder.Entity("Restaurant.Models.MenuItem", b =>
                {
                    b.HasOne("Restaurant.Models.Reservation", null)
                        .WithMany("MenuItems")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("Restaurant.Models.ReservationMenuItem", b =>
                {
                    b.HasOne("Restaurant.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Restaurant.Models.Reservation", b =>
                {
                    b.Navigation("MenuItems");
                });
#pragma warning restore 612, 618
        }
    }
}