﻿// <auto-generated />
using System;
using APIEndpoint.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(RefhubContext))]
    partial class RefhubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("API.Models.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("APIEndpoint.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer(64)")
                        .HasColumnName("id");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text(100)")
                        .HasColumnName("cover");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("APIEndpoint.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer(64)")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .HasColumnType("text(255)")
                        .HasColumnName("author");

                    b.Property<int>("AvgRating")
                        .HasColumnType("integer(53)")
                        .HasColumnName("avg_rating");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("category_id");

                    b.Property<int>("CopyrightLimited")
                        .HasColumnType("INTEGER")
                        .HasColumnName("copyright_limited");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text(100)")
                        .HasColumnName("cover");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("text(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description_en");

                    b.Property<string>("DescriptionFa")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description_fa");

                    b.Property<string>("Document")
                        .HasColumnType("text(100)")
                        .HasColumnName("document");

                    b.Property<int>("DownloadCount")
                        .HasColumnType("integer(32)")
                        .HasColumnName("download_count");

                    b.Property<int>("Featured")
                        .HasColumnType("INTEGER")
                        .HasColumnName("featured");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("text(255)")
                        .HasColumnName("isbn");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("language_id");

                    b.Property<string>("Mirror1")
                        .HasColumnType("text(500)")
                        .HasColumnName("mirror1");

                    b.Property<string>("Mirror2")
                        .HasColumnType("text(500)")
                        .HasColumnName("mirror2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text(255)")
                        .HasColumnName("name");

                    b.Property<string>("Pages")
                        .HasColumnType("text(255)")
                        .HasColumnName("pages");

                    b.Property<string>("Publisher")
                        .HasColumnType("text(255)")
                        .HasColumnName("publisher");

                    b.Property<int>("SeriId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("seri_id");

                    b.Property<string>("Size")
                        .HasColumnType("text(255)")
                        .HasColumnName("size");

                    b.Property<int?>("SkillLevelId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("skill_level_id");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text(255)")
                        .HasColumnName("slug");

                    b.Property<string>("Thumb")
                        .IsRequired()
                        .HasColumnType("text(200)")
                        .HasColumnName("thumb");

                    b.Property<int>("ViewCount")
                        .HasColumnType("integer(32)")
                        .HasColumnName("view_count");

                    b.Property<string>("Year")
                        .HasColumnType("text(255)")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SeriId" }, "RefHubWeb_refrence_seri_id_02ed7806");

                    b.HasIndex(new[] { "CategoryId" }, "Refrence_category_id_25807a06");

                    b.HasIndex(new[] { "LanguageId" }, "Refrence_language_id_7ec81184");

                    b.HasIndex(new[] { "SkillLevelId" }, "Refrence_skill_level_id_7671a865");

                    b.HasIndex(new[] { "Slug" }, "Refrence_slug_50dad31a_like");

                    b.HasIndex(new[] { "ViewCount" }, "Refrence_view_count_idx");

                    b.ToTable("Book", (string)null);
                });

            modelBuilder.Entity("APIEndpoint.Models.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer(64)")
                        .HasColumnName("id");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("author_id");

                    b.Property<int>("RefrenceId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("refrence_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AuthorId" }, "Refrence_authors_author_id_723d106a");

                    b.HasIndex(new[] { "RefrenceId" }, "Refrence_authors_refrence_id_380b3556");

                    b.ToTable("Book_Authors", (string)null);
                });

            modelBuilder.Entity("APIEndpoint.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer(64)")
                        .HasColumnName("id");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text(100)")
                        .HasColumnName("cover");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("DescriptionFa")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description_fa");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text(100)")
                        .HasColumnName("name");

                    b.Property<string>("NameFa")
                        .IsRequired()
                        .HasColumnType("text(100)")
                        .HasColumnName("name_fa");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer(64)")
                        .HasColumnName("parent_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ParentId" }, "RefHubWeb_category_parent_id_72499e85");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("IdentityUserLogin<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("IdentityUserToken<string>");
                });

            modelBuilder.Entity("APIEndpoint.Models.Book", b =>
                {
                    b.HasOne("APIEndpoint.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("APIEndpoint.Models.BookAuthor", b =>
                {
                    b.HasOne("APIEndpoint.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .IsRequired();

                    b.HasOne("APIEndpoint.Models.Book", "Refrence")
                        .WithMany("BookAuthors")
                        .HasForeignKey("RefrenceId")
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Refrence");
                });

            modelBuilder.Entity("APIEndpoint.Models.Category", b =>
                {
                    b.HasOne("APIEndpoint.Models.Category", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIEndpoint.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("APIEndpoint.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("APIEndpoint.Models.Category", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("InverseParent");
                });
#pragma warning restore 612, 618
        }
    }
}
