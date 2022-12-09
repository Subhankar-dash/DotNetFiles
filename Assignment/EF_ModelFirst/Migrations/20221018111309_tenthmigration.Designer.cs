﻿// <auto-generated />
using EF_ModelFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_ModelFirst.Migrations
{
    [DbContext(typeof(InfoDbContext))]
    [Migration("20221018111309_tenthmigration")]
    partial class tenthmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerId", "OrdersOrderId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("CustomersOrders", (string)null);
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Category", b =>
                {
                    b.Property<int>("CategoryRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryRowId"), 1L, 1);

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.HasKey("CategoryRowId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("OrderItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Person", b =>
                {
                    b.Property<int>("PersonUniqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonUniqueId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonID")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PersonUniqueId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Product", b =>
                {
                    b.Property<int>("ProductRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductRowId"), 1L, 1);

                    b.Property<int>("CategoryRowId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.HasKey("ProductRowId");

                    b.HasIndex("CategoryRowId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.ProductionUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ReleaseYear")
                        .HasMaxLength(700)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductionUnits");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductionUnit");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fees")
                        .HasColumnType("int");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Staff");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Doctor", b =>
                {
                    b.HasBaseType("EF_ModelFirst.Model.Staff");

                    b.Property<int>("PatienceCount")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Doctor");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            Contact = 567,
                            Department = "heart",
                            Education = "mbbs",
                            Name = "sk",
                            StaffCategory = "doctor",
                            fees = 56,
                            PatienceCount = 10
                        });
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Movies", b =>
                {
                    b.HasBaseType("EF_ModelFirst.Model.ProductionUnit");

                    b.Property<double>("BoxOfficeCollection")
                        .HasColumnType("float");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayDuration")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dr.No",
                            ReleaseYear = 1963,
                            BoxOfficeCollection = 12222.0,
                            Category = "Spy",
                            PlayDuration = 150
                        },
                        new
                        {
                            Id = 2,
                            Name = "Golmal",
                            ReleaseYear = 1976,
                            BoxOfficeCollection = 122.0,
                            Category = "Comedy",
                            PlayDuration = 180
                        });
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Nurse", b =>
                {
                    b.HasBaseType("EF_ModelFirst.Model.Staff");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Nurse");

                    b.HasData(
                        new
                        {
                            StaffId = 2,
                            Contact = 567,
                            Department = "heart",
                            Education = "bbs",
                            Name = "fg",
                            StaffCategory = "nurse",
                            fees = 56,
                            RoomCount = 10
                        });
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Technician", b =>
                {
                    b.HasBaseType("EF_ModelFirst.Model.Staff");

                    b.Property<int>("MachineCount")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Technician");

                    b.HasData(
                        new
                        {
                            StaffId = 3,
                            Contact = 567,
                            Department = "heart",
                            Education = "ghj",
                            Name = "ghj",
                            StaffCategory = "technician",
                            fees = 45,
                            MachineCount = 7
                        });
                });

            modelBuilder.Entity("EF_ModelFirst.Model.WebSeries", b =>
                {
                    b.HasBaseType("EF_ModelFirst.Model.ProductionUnit");

                    b.Property<int>("EpisodPerSeason")
                        .HasColumnType("int");

                    b.Property<int>("Seasons")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("WebSeries");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Ramayan",
                            ReleaseYear = 1986,
                            EpisodPerSeason = 100,
                            Seasons = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "House of Cards",
                            ReleaseYear = 2005,
                            EpisodPerSeason = 50,
                            Seasons = 6
                        });
                });

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.HasOne("EF_ModelFirst.Model.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_ModelFirst.Model.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Product", b =>
                {
                    b.HasOne("EF_ModelFirst.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryRowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EF_ModelFirst.Model.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}