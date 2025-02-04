﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp1.Data;

namespace WpfApp1.Migrations
{
    [DbContext(typeof(PeopleContext))]
    [Migration("20211111102252_InitialCreatePEOPLEDB")]
    partial class InitialCreatePEOPLEDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelloWorldCore.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("HelloWorldCore.Model.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kilometers")
                        .HasColumnType("float");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("HelloWorldCore.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeAddressId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HelloWorldCore.Model.Car", b =>
                {
                    b.HasOne("HelloWorldCore.Model.Person", null)
                        .WithMany("Cars")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("HelloWorldCore.Model.Person", b =>
                {
                    b.HasOne("HelloWorldCore.Model.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId");

                    b.Navigation("HomeAddress");
                });

            modelBuilder.Entity("HelloWorldCore.Model.Person", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
