﻿// <auto-generated />
using FruitUserApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FruitUserApi.Migrations
{
    [DbContext(typeof(FruitVendorContext))]
    [Migration("20210529161906_Role")]
    partial class Role
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FruitUserApi.Models.Author", b =>
                {
                    b.Property<int>("aId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("mobNum")
                        .HasColumnType("bigint");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aId");

                    b.ToTable("Authers");
                });

            modelBuilder.Entity("FruitUserApi.Models.Cart", b =>
                {
                    b.Property<int>("cId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("aId")
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<int>("cQty")
                        .HasColumnType("int");

                    b.Property<int>("fId")
                        .HasColumnType("int");

                    b.HasKey("cId");

                    b.HasIndex("aId");

                    b.HasIndex("fId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FruitUserApi.Models.Fruit", b =>
                {
                    b.Property<int>("fId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fPrice")
                        .HasColumnType("float");

                    b.Property<int>("fQty")
                        .HasColumnType("int");

                    b.HasKey("fId");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("FruitUserApi.Models.Order", b =>
                {
                    b.Property<int>("oId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fId")
                        .HasColumnType("int");

                    b.Property<string>("placeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("uId")
                        .HasColumnType("int");

                    b.HasKey("oId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FruitUserApi.Models.Cart", b =>
                {
                    b.HasOne("FruitUserApi.Models.Author", "author")
                        .WithMany("CartRel")
                        .HasForeignKey("aId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FruitUserApi.Models.Fruit", "fruit")
                        .WithMany("CartRel")
                        .HasForeignKey("fId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("fruit");
                });

            modelBuilder.Entity("FruitUserApi.Models.Author", b =>
                {
                    b.Navigation("CartRel");
                });

            modelBuilder.Entity("FruitUserApi.Models.Fruit", b =>
                {
                    b.Navigation("CartRel");
                });
#pragma warning restore 612, 618
        }
    }
}
