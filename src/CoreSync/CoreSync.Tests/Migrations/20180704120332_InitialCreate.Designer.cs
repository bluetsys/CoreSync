﻿// <auto-generated />
using System;
using CoreSync.Tests.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreSync.Tests.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20180704120332_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSync.Tests.Data.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorEmail");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("PostId");

                    b.Property<Guid?>("ReplyToId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorEmail");

                    b.HasIndex("PostId");

                    b.HasIndex("ReplyToId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EfSync.Tests.Data.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorEmail");

                    b.Property<int>("Claps");

                    b.Property<string>("Content");

                    b.Property<float>("Stars");

                    b.Property<string>("Title");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("AuthorEmail");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EfSync.Tests.Data.User", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EfSync.Tests.Data.Comment", b =>
                {
                    b.HasOne("EfSync.Tests.Data.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorEmail");

                    b.HasOne("EfSync.Tests.Data.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("EfSync.Tests.Data.Comment", "ReplyTo")
                        .WithMany()
                        .HasForeignKey("ReplyToId");
                });

            modelBuilder.Entity("EfSync.Tests.Data.Post", b =>
                {
                    b.HasOne("EfSync.Tests.Data.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorEmail");
                });
#pragma warning restore 612, 618
        }
    }
}
