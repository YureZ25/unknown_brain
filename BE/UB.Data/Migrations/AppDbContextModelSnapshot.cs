﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UB.Data;

#nullable disable

namespace UB.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UB.Data.Domain.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("Recomendation")
                        .HasColumnType("text");

                    b.Property<string>("RecomendationUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("UB.Data.Domain.Recomendation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<Guid?>("GradeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SpecializationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Recomendations");
                });

            modelBuilder.Entity("UB.Data.Domain.Specialization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("UB.Data.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("GradeId")
                        .HasColumnType("uuid");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UB.Data.Domain.WelcomeForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<Guid>("GradeId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDocWriter")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPM")
                        .HasColumnType("boolean");

                    b.Property<Guid>("SpecializationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("SpecializationId");

                    b.HasIndex("UserId");

                    b.ToTable("WelcomeForms");
                });

            modelBuilder.Entity("UB.Data.Domain.Recomendation", b =>
                {
                    b.HasOne("UB.Data.Domain.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");

                    b.HasOne("UB.Data.Domain.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId");

                    b.Navigation("Grade");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("UB.Data.Domain.User", b =>
                {
                    b.HasOne("UB.Data.Domain.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("UB.Data.Domain.WelcomeForm", b =>
                {
                    b.HasOne("UB.Data.Domain.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UB.Data.Domain.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UB.Data.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Specialization");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
