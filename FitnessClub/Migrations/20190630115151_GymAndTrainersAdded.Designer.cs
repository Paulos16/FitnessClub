﻿// <auto-generated />
using System;
using FitnessClub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FitnessClub.Migrations
{
    [DbContext(typeof(FitnessClubContext))]
    [Migration("20190630115151_GymAndTrainersAdded")]
    partial class GymAndTrainersAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FitnessClub.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<int>("IdGym");

                    b.Property<int>("IdMembershipPlan");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("IdCustomer");

                    b.HasIndex("IdGym");

                    b.HasIndex("IdMembershipPlan");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FitnessClub.Models.Gym", b =>
                {
                    b.Property<int>("IdGym")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(480);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(480);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.Property<string>("WorkingHours")
                        .IsRequired()
                        .HasMaxLength(240);

                    b.HasKey("IdGym");

                    b.ToTable("Gyms");
                });

            modelBuilder.Entity("FitnessClub.Models.MembershipPlan", b =>
                {
                    b.Property<int>("IdMembershipPlan")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("IdMembershipPlan");

                    b.ToTable("MembershipPlans");
                });

            modelBuilder.Entity("FitnessClub.Models.Trainer", b =>
                {
                    b.Property<int>("IdTrainer")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements")
                        .IsRequired()
                        .HasMaxLength(960);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<int>("IdGym");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("Qualifications")
                        .IsRequired()
                        .HasMaxLength(960);

                    b.HasKey("IdTrainer");

                    b.HasIndex("IdGym");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FitnessClub.Models.Customer", b =>
                {
                    b.HasOne("FitnessClub.Models.Gym", "Gym")
                        .WithMany("Customers")
                        .HasForeignKey("IdGym")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessClub.Models.MembershipPlan", "MembershipPlan")
                        .WithMany("Customers")
                        .HasForeignKey("IdMembershipPlan")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessClub.Models.Trainer", b =>
                {
                    b.HasOne("FitnessClub.Models.Gym", "Gym")
                        .WithMany("Trainers")
                        .HasForeignKey("IdGym")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
