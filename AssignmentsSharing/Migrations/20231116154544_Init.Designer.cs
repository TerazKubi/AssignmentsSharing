﻿// <auto-generated />
using System;
using AssignmentsSharing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentsSharing.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231116154544_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("AssignmentsSharing.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DeveloperId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("IssueId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TimeCost")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("IssueId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Developer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DeveloperId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pseudonym")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("Pseudonym")
                        .IsUnique();

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AssignmentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("OccuranceTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("DeveloperIssue", b =>
                {
                    b.Property<Guid>("DevelopersId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IssuesId")
                        .HasColumnType("TEXT");

                    b.HasKey("DevelopersId", "IssuesId");

                    b.HasIndex("IssuesId");

                    b.ToTable("DeveloperIssue");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Assignment", b =>
                {
                    b.HasOne("AssignmentsSharing.Models.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId");

                    b.HasOne("AssignmentsSharing.Models.Issue", "Issue")
                        .WithMany("Assignments")
                        .HasForeignKey("IssueId");

                    b.Navigation("Developer");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Developer", b =>
                {
                    b.HasOne("AssignmentsSharing.Models.Developer", null)
                        .WithMany("Developers")
                        .HasForeignKey("DeveloperId");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Status", b =>
                {
                    b.HasOne("AssignmentsSharing.Models.Assignment", "Assignment")
                        .WithMany("Statuses")
                        .HasForeignKey("AssignmentId");

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("DeveloperIssue", b =>
                {
                    b.HasOne("AssignmentsSharing.Models.Developer", null)
                        .WithMany()
                        .HasForeignKey("DevelopersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssignmentsSharing.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Assignment", b =>
                {
                    b.Navigation("Statuses");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Developer", b =>
                {
                    b.Navigation("Developers");
                });

            modelBuilder.Entity("AssignmentsSharing.Models.Issue", b =>
                {
                    b.Navigation("Assignments");
                });
#pragma warning restore 612, 618
        }
    }
}
