﻿// <auto-generated />
using CRUDRazorDemousingFF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDRazorDemousingFF.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20250205070202_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CRUDRazorDemousingFF.Models.Product", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProId"));

                    b.Property<string>("ProDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
