﻿// <auto-generated />
using System;
using CFI_Track3_Squad3_Backend.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CFI_Track3_Squad3_Backend.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CFI_Track3_Squad3_Backend.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Account_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("account_CreationDate");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit")
                        .HasColumnName("account_IsBlocked");

                    b.Property<decimal>("Money")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("account_Money");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("account_UserId");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2023, 12, 15, 18, 37, 6, 579, DateTimeKind.Local).AddTicks(4968),
                            IsBlocked = false,
                            Money = 1000.00m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2023, 12, 15, 18, 37, 6, 579, DateTimeKind.Local).AddTicks(4983),
                            IsBlocked = false,
                            Money = 2000.00m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2023, 12, 15, 18, 37, 6, 579, DateTimeKind.Local).AddTicks(4984),
                            IsBlocked = true,
                            Money = 1500.50m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            DateTime = new DateTime(2023, 12, 15, 18, 37, 6, 579, DateTimeKind.Local).AddTicks(4984),
                            IsBlocked = false,
                            Money = 3000.75m,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CFI_Track3_Squad3_Backend.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DeletedTimeUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("role_deletedTimeUtc");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role_description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("role_isDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role_name");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator",
                            IsDeleted = false,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Consultant",
                            IsDeleted = false,
                            Name = "Consultant"
                        });
                });

            modelBuilder.Entity("CFI_Track3_Squad3_Backend.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DeletedTimeUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedTimeUtc");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasColumnName("IsDelete");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RolId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            IsDelete = false,
                            LastName = "Administrador",
                            Password = "eeec7cf230a0eb1c9e6be4aede189d43fdb5f86a6225cebef897fbb871b29d61",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@gmail.com",
                            FirstName = "User",
                            IsDelete = false,
                            LastName = "UserTest",
                            Password = "3260fa4b67859cffb492b7fe25752e910478832f0dcdf4e7891db1eb10f28f1f",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("CFI_Track3_Squad3_Backend.Entities.User", b =>
                {
                    b.HasOne("CFI_Track3_Squad3_Backend.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}