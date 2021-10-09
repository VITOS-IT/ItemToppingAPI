﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderItemDetailAPI.Models;

namespace OrderItemDetailAPI.Migrations
{
    [DbContext(typeof(pizzaContext))]
    [Migration("20211009145111_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderItemDetailAPI.Models.ItemTopping", b =>
                {
                    b.Property<int>("ItemNumber")
                        .HasColumnType("int");

                    b.Property<int>("ToppingNumber")
                        .HasColumnType("int");

                    b.HasKey("ItemNumber", "ToppingNumber");

                    b.ToTable("ItemToppings");
                });
#pragma warning restore 612, 618
        }
    }
}