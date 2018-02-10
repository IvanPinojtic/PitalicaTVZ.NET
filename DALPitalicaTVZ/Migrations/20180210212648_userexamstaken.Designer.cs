﻿// <auto-generated />
using DALPitalicaTVZ.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DALPitalicaTVZ.Migrations
{
    [DbContext(typeof(PitalicaContext))]
    [Migration("20180210212648_userexamstaken")]
    partial class userexamstaken
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DALPitalicaTVZ.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatorId");

                    b.Property<string>("ExamTitle");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorrectAnswer");

                    b.Property<string>("Definition");

                    b.Property<int>("ExamId");

                    b.Property<string>("QuestionText");

                    b.Property<int>("Row");

                    b.Property<int>("Score");

                    b.Property<bool>("Visibility");

                    b.Property<string>("WrongAnswers");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.QuestionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Answered");

                    b.Property<int>("CorrectAnswer");

                    b.Property<int>("QuestionId");

                    b.Property<int>("Score");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("QuestionResults");
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.UserExamTaken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("ExamId");

                    b.Property<int>("Id");

                    b.HasKey("UserId", "ExamId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("UserExamTaken");
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.Exam", b =>
                {
                    b.HasOne("DALPitalicaTVZ.Entities.User", "Creator")
                        .WithMany("ExamsCreated")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.Question", b =>
                {
                    b.HasOne("DALPitalicaTVZ.Entities.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.QuestionResult", b =>
                {
                    b.HasOne("DALPitalicaTVZ.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DALPitalicaTVZ.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DALPitalicaTVZ.Entities.UserExamTaken", b =>
                {
                    b.HasOne("DALPitalicaTVZ.Entities.Exam", "Exam")
                        .WithMany("Students")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DALPitalicaTVZ.Entities.User", "User")
                        .WithMany("ExamsTaken")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
