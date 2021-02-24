﻿// <auto-generated />
using DocumentManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocumentManagementSystem.Migrations
{
    [DbContext(typeof(DocumentDbContext))]
    [Migration("20201220225727_documentmig")]
    partial class documentmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentManagementSystem.Models.DeletedDocument", b =>
                {
                    b.Property<int>("deleted_document_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("deleted_document_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deleted_document_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deleted_document_id");

                    b.HasIndex("UserID");

                    b.ToTable("deletedDocuments");
                });

            modelBuilder.Entity("DocumentManagementSystem.Models.Document", b =>
                {
                    b.Property<int>("document_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentFileID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("document_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("document_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("document_id");

                    b.HasIndex("DocumentFileID");

                    b.HasIndex("UserID");

                    b.ToTable("documents");
                });

            modelBuilder.Entity("DocumentManagementSystem.Models.DocumentFile", b =>
                {
                    b.Property<int>("document_file_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("document_file_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOf_document")
                        .HasColumnType("int");

                    b.HasKey("document_file_id");

                    b.ToTable("documentFiles");
                });

            modelBuilder.Entity("DocumentManagementSystem.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("user_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("DocumentManagementSystem.Models.DeletedDocument", b =>
                {
                    b.HasOne("DocumentManagementSystem.Models.User", "User")
                        .WithMany("DeletedDocuments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentManagementSystem.Models.Document", b =>
                {
                    b.HasOne("DocumentManagementSystem.Models.DocumentFile", "DocumentFile")
                        .WithMany("Documents")
                        .HasForeignKey("DocumentFileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentManagementSystem.Models.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
