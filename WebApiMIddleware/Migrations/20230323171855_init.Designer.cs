﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiMIddleware.Data;

#nullable disable

namespace WebApiMIddleware.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230323171855_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("WebApiMIddleware.Models.ErrorLogger", b =>
                {
                    b.Property<int>("LoggerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ErrorDetails")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("TEXT");

                    b.HasKey("LoggerId");

                    b.ToTable("ErrorLogger");
                });
#pragma warning restore 612, 618
        }
    }
}
