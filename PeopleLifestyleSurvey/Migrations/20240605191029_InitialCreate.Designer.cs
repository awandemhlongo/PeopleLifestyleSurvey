﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PeopleLifestyleSurvey.Migrations
{
    [DbContext(typeof(SurveyContext))]
    [Migration("20240605191029_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int>("EatOutRating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LikesOther")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LikesPapAndWors")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LikesPasta")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LikesPizza")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesRating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RadioRating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TvRating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
