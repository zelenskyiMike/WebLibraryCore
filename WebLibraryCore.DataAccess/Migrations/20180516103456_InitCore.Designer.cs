﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebLibraryCore.DataAccess;

namespace WebLibraryCore.DataAccess.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20180516103456_InitCore")]
    partial class InitCore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleGenreID");

                    b.Property<string>("ArticleName")
                        .IsRequired();

                    b.Property<DateTime>("DateOfArticlePublish");

                    b.HasKey("ArticleID");

                    b.HasIndex("ArticleGenreID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.ArticleAuthor", b =>
                {
                    b.Property<int>("ArticleID");

                    b.Property<int>("AuthorID");

                    b.HasKey("ArticleID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("ArticleAuthor");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.ArticleGenre", b =>
                {
                    b.Property<int>("ArticleGenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleGenreName");

                    b.HasKey("ArticleGenreID");

                    b.ToTable("ArticleGenres");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorName")
                        .IsRequired();

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookName")
                        .IsRequired();

                    b.Property<int>("GenreID");

                    b.Property<int>("YearOfPublish");

                    b.HasKey("BookID");

                    b.HasIndex("GenreID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.BookAuthor", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<int>("AuthorID");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.BookGenre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreName");

                    b.HasKey("GenreID");

                    b.ToTable("BookGenres");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Magazine", b =>
                {
                    b.Property<int>("MagazineID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfMagazinePublish");

                    b.Property<int>("MagazineGenreID");

                    b.Property<string>("MagazineName")
                        .IsRequired();

                    b.HasKey("MagazineID");

                    b.HasIndex("MagazineGenreID");

                    b.ToTable("Magazines");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.MagazineAuthor", b =>
                {
                    b.Property<int>("MagazineID");

                    b.Property<int>("AuthorID");

                    b.HasKey("MagazineID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("MagazineAuthor");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.MagazineGenre", b =>
                {
                    b.Property<int>("MagazineGenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MagazineGenreName")
                        .IsRequired();

                    b.HasKey("MagazineGenreID");

                    b.ToTable("MagazineGenres");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Publication", b =>
                {
                    b.Property<int>("PublicationID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfPublicationPublish");

                    b.Property<int>("PublicationGenreID");

                    b.Property<string>("PublicationName")
                        .IsRequired();

                    b.HasKey("PublicationID");

                    b.HasIndex("PublicationGenreID");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.PublicationAuthor", b =>
                {
                    b.Property<int>("PublicationID");

                    b.Property<int>("AuthorID");

                    b.HasKey("PublicationID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("PublicationAuthor");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.PublicationGenre", b =>
                {
                    b.Property<int>("PublicationGenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PublicationGenreName")
                        .IsRequired();

                    b.HasKey("PublicationGenreID");

                    b.ToTable("PublicationGenres");
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Article", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.ArticleGenre", "ArticleGenres")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleGenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.ArticleAuthor", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.Article", "Articles")
                        .WithMany("ArticleAuthors")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebLibraryCore.Entities.Entities.Author", "Authors")
                        .WithMany("ArticleAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Book", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.BookGenre", "Genres")
                        .WithMany("Books")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.BookAuthor", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.Author", "Authors")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebLibraryCore.Entities.Entities.Book", "Books")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Magazine", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.MagazineGenre", "MagazineGenres")
                        .WithMany("Magazines")
                        .HasForeignKey("MagazineGenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.MagazineAuthor", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.Author", "Authors")
                        .WithMany("MagazineAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebLibraryCore.Entities.Entities.Magazine", "Magazines")
                        .WithMany("MagazineAuthors")
                        .HasForeignKey("MagazineID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.Publication", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.PublicationGenre", "PublicationGenres")
                        .WithMany("Publications")
                        .HasForeignKey("PublicationGenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebLibraryCore.Entities.Entities.PublicationAuthor", b =>
                {
                    b.HasOne("WebLibraryCore.Entities.Entities.Author", "Authors")
                        .WithMany("PublicationAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebLibraryCore.Entities.Entities.Publication", "Publications")
                        .WithMany("PublicationAuthors")
                        .HasForeignKey("PublicationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
