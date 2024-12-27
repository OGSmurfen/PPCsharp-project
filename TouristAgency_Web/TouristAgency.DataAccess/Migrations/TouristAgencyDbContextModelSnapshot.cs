﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TouristAgency.DataAccess.Data;

#nullable disable

namespace TouristAgency.DataAccess.Migrations
{
    [DbContext(typeof(TouristAgencyDbContext))]
    partial class TouristAgencyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TouristAgency.Models.Clients", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EGN")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("InsuranceNumber")
                        .HasColumnType("date");

                    b.Property<string>("ThreeNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("TouristAgency.Models.Excursions", b =>
                {
                    b.Property<int>("ExcursionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExcursionId"));

                    b.Property<DateOnly>("BeginDate")
                        .HasColumnType("date");

                    b.Property<string>("Destination_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination_Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<decimal?>("Price_Additional")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Price_Excursion")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Price_Transport")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ExcursionId");

                    b.ToTable("Excursions", (string)null);
                });

            modelBuilder.Entity("TouristAgency.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateIssued")
                        .HasColumnType("date");

                    b.Property<int>("ExcursionId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ExcursionId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("TouristAgency.Models.Orders", b =>
                {
                    b.HasOne("TouristAgency.Models.Clients", null)
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TouristAgency.Models.Excursions", null)
                        .WithMany()
                        .HasForeignKey("ExcursionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
