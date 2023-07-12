﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriGuide.DataAccessLayer.Concrets;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    [DbContext(typeof(NutriGuideContext))]
    [Migration("20230712112410_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodKullanici", b =>
                {
                    b.Property<int>("FoodsFoodId")
                        .HasColumnType("int");

                    b.Property<int>("KullanicilarKullaniciId")
                        .HasColumnType("int");

                    b.HasKey("FoodsFoodId", "KullanicilarKullaniciId");

                    b.HasIndex("KullanicilarKullaniciId");

                    b.ToTable("FoodKullanici");
                });

            modelBuilder.Entity("NutriGuide.Entity.Data.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cins")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kalorisi")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<int>("KullaniciTipi")
                        .HasColumnType("int");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Ad = "Elma",
                            Cins = "Meyve",
                            Kalorisi = 52.0,
                            KarbonhidratMiktari = 13.800000000000001,
                            KullaniciTipi = 0,
                            ProteinMiktari = 0.29999999999999999,
                            YagMiktari = 0.40000000000000002
                        },
                        new
                        {
                            FoodId = 2,
                            Ad = "Muz",
                            Cins = "Meyve",
                            Kalorisi = 96.0,
                            KarbonhidratMiktari = 22.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 1.1000000000000001,
                            YagMiktari = 0.20000000000000001
                        },
                        new
                        {
                            FoodId = 3,
                            Ad = "Tavuk Göğsü",
                            Cins = "Et",
                            Kalorisi = 95.0,
                            KarbonhidratMiktari = 0.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 20.800000000000001,
                            YagMiktari = 1.3999999999999999
                        },
                        new
                        {
                            FoodId = 4,
                            Ad = "Patates",
                            Cins = "Sebze",
                            Kalorisi = 77.0,
                            KarbonhidratMiktari = 17.5,
                            KullaniciTipi = 0,
                            ProteinMiktari = 2.0,
                            YagMiktari = 0.10000000000000001
                        },
                        new
                        {
                            FoodId = 5,
                            Ad = "Somon Balığı",
                            Cins = "Balık",
                            Kalorisi = 206.0,
                            KarbonhidratMiktari = 0.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 20.399999999999999,
                            YagMiktari = 6.5999999999999996
                        },
                        new
                        {
                            FoodId = 6,
                            Ad = "Ekmek",
                            Cins = "Tahıl",
                            Kalorisi = 265.0,
                            KarbonhidratMiktari = 49.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 8.0999999999999996,
                            YagMiktari = 1.0
                        },
                        new
                        {
                            FoodId = 7,
                            Ad = "Yoğurt",
                            Cins = "Süt Ürünü",
                            Kalorisi = 61.0,
                            KarbonhidratMiktari = 4.7000000000000002,
                            KullaniciTipi = 0,
                            ProteinMiktari = 3.5,
                            YagMiktari = 3.2999999999999998
                        },
                        new
                        {
                            FoodId = 8,
                            Ad = "Brokoli",
                            Cins = "Sebze",
                            Kalorisi = 31.0,
                            KarbonhidratMiktari = 6.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 2.7999999999999998,
                            YagMiktari = 0.40000000000000002
                        },
                        new
                        {
                            FoodId = 9,
                            Ad = "Kırmızı Et",
                            Cins = "Et",
                            Kalorisi = 250.0,
                            KarbonhidratMiktari = 0.0,
                            KullaniciTipi = 0,
                            ProteinMiktari = 26.0,
                            YagMiktari = 17.0
                        },
                        new
                        {
                            FoodId = 10,
                            Ad = "Marul",
                            Cins = "Sebze",
                            Kalorisi = 14.0,
                            KarbonhidratMiktari = 2.2000000000000002,
                            KullaniciTipi = 0,
                            ProteinMiktari = 1.2,
                            YagMiktari = 0.20000000000000001
                        });
                });

            modelBuilder.Entity("NutriGuide.Entity.Data.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciId"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Boyu")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("HedefKilosu")
                        .HasColumnType("int");

                    b.Property<int>("Kilosu")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciTipi")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("FoodKullanici", b =>
                {
                    b.HasOne("NutriGuide.Entity.Data.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriGuide.Entity.Data.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("KullanicilarKullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
