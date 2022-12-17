﻿// <auto-generated />
using System;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20221217022828_MigrationName")]
    partial class MigrationName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("API.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacebookLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InstaLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkinLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("API.Models.Questions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("API.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("API.Services.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PointCost")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.Models.Questions", b =>
                {
                    b.HasOne("API.Services.Product", null)
                        .WithMany("Questions")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("API.Models.Request", b =>
                {
                    b.HasOne("API.Services.Product", null)
                        .WithMany("Requests")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("API.Services.Product", b =>
                {
                    b.HasOne("API.Models.Profile", null)
                        .WithMany("MyListingProduct")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("API.Models.Profile", b =>
                {
                    b.Navigation("MyListingProduct");
                });

            modelBuilder.Entity("API.Services.Product", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
