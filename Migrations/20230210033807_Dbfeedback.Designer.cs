﻿// <auto-generated />
using System;
using Feedback_Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace feedbackService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230210033807_Dbfeedback")]
    partial class Dbfeedback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Feedback_Service.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("RatingValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TitleId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ratings", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
