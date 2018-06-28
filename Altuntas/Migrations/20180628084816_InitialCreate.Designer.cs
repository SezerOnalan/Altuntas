﻿// <auto-generated />
using System;
using Altuntas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Altuntas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180628084816_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Altuntas.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Logo")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Altuntas.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasMaxLength(4000);

                    b.Property<int>("BuyerId");

                    b.Property<decimal?>("Commission");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<string>("ExtraFormPrice")
                        .HasMaxLength(4000);

                    b.Property<double?>("Height");

                    b.Property<double?>("Length");

                    b.Property<string>("Model");

                    b.Property<decimal>("OurSalePrice");

                    b.Property<string>("ReceivedForms")
                        .HasMaxLength(4000);

                    b.Property<int>("SellerId");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<DateTime?>("WarrantyEndDate");

                    b.Property<double>("Width");

                    b.Property<decimal?>("invoicePrice");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Altuntas.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Logo")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Altuntas.Models.Sale", b =>
                {
                    b.HasOne("Altuntas.Models.Buyer", "Buyer")
                        .WithMany("Sales")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Altuntas.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
