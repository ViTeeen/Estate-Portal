﻿// <auto-generated />
using System;
using EstatePortal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstatePortal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241215030826_userstatus")]
    partial class userstatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("EstatePortal.Models.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("SellOrRent")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VideoUrls")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("EstatePortal.Models.AnnouncementFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<bool>("Elevator")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EnergyCertificate")
                        .HasColumnType("longtext");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("Furnished")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Garden")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasAirConditioning")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasAttic")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasBasement")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasElectricity")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasForest")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasGarage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasGarden")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasGas")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasInternet")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasLake")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasMountains")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasPark")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasPool")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasSea")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasSewerage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasWater")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAccessible")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("KitchenAppliances")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nature")
                        .HasColumnType("longtext");

                    b.Property<int?>("Neighborhood")
                        .HasColumnType("int");

                    b.Property<string>("Parking")
                        .HasColumnType("longtext");

                    b.Property<string>("PropertyCondition")
                        .HasColumnType("longtext");

                    b.Property<int?>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SafetyFeatures")
                        .HasColumnType("longtext");

                    b.Property<int?>("Security")
                        .HasColumnType("int");

                    b.Property<string>("Surroundings")
                        .HasColumnType("longtext");

                    b.Property<int?>("TotalFloors")
                        .HasColumnType("int");

                    b.Property<int?>("YearBuilt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId")
                        .IsUnique();

                    b.ToTable("AnnouncementFeatures");
                });

            modelBuilder.Entity("EstatePortal.Models.AnnouncementPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("AnnouncementPhotos");
                });

            modelBuilder.Entity("EstatePortal.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnouncementId")
                        .HasColumnType("int");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<string>("LastMessage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastMessageTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SellerId");

                    b.HasIndex("SenderId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("EstatePortal.Models.EmployeeInvitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.ToTable("EmployeeInvitations");
                });

            modelBuilder.Entity("EstatePortal.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EstatePortal.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AcceptTerms")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EmployerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("NIP")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<DateTime?>("PasswordLastReset")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ResetTokenExpiry")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EstatePortal.Models.Announcement", b =>
                {
                    b.HasOne("EstatePortal.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EstatePortal.Models.AnnouncementFeature", b =>
                {
                    b.HasOne("EstatePortal.Models.Announcement", "Announcement")
                        .WithOne("Features")
                        .HasForeignKey("EstatePortal.Models.AnnouncementFeature", "AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");
                });

            modelBuilder.Entity("EstatePortal.Models.AnnouncementPhoto", b =>
                {
                    b.HasOne("EstatePortal.Models.Announcement", "Announcement")
                        .WithMany("Photos")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");
                });

            modelBuilder.Entity("EstatePortal.Models.Chat", b =>
                {
                    b.HasOne("EstatePortal.Models.Announcement", "Announcement")
                        .WithMany()
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstatePortal.Models.User", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstatePortal.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstatePortal.Models.User", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstatePortal.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Announcement");

                    b.Navigation("Buyer");

                    b.Navigation("Receiver");

                    b.Navigation("Seller");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("EstatePortal.Models.EmployeeInvitation", b =>
                {
                    b.HasOne("EstatePortal.Models.User", "Employer")
                        .WithMany("EmployeeInvitations")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("EstatePortal.Models.Message", b =>
                {
                    b.HasOne("EstatePortal.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstatePortal.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("EstatePortal.Models.User", b =>
                {
                    b.HasOne("EstatePortal.Models.User", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId");

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("EstatePortal.Models.Announcement", b =>
                {
                    b.Navigation("Features")
                        .IsRequired();

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("EstatePortal.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("EstatePortal.Models.User", b =>
                {
                    b.Navigation("EmployeeInvitations");
                });
#pragma warning restore 612, 618
        }
    }
}
