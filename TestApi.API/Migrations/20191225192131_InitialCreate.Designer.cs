﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi.API.Data;

namespace TestApi.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191225192131_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("TestApi.API.Models.Value", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("MyProperty");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
