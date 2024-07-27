﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.EntityFramework;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240724072551_AddContainerAndDownTimesToDb")]
    partial class AddContainerAndDownTimesToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Container", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime?>("EngagedUntil")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("engaged_until");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<bool>("IsEngaged")
                        .HasColumnType("boolean")
                        .HasColumnName("is_engaged");

                    b.Property<string>("IsoNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("iso_number");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer")
                        .HasColumnName("type_id");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Container");
                });

            modelBuilder.Entity("Domain.DownTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_end");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_start");

                    b.Property<Guid>("HubId")
                        .HasColumnType("uuid")
                        .HasColumnName("hub_id");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("DownTime");
                });

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<double>("Costs")
                        .HasColumnType("double precision")
                        .HasColumnName("costs");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_end");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_start");

                    b.Property<Guid>("HubEndId")
                        .HasColumnType("uuid")
                        .HasColumnName("hub_end_id");

                    b.Property<Guid>("HubStartId")
                        .HasColumnType("uuid")
                        .HasColumnName("hub_start_id");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Container", b =>
                {
                    b.HasOne("Domain.Order", null)
                        .WithMany("Containers")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Domain.DownTime", b =>
                {
                    b.HasOne("Domain.Order", null)
                        .WithMany("DownTimes")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Navigation("Containers");

                    b.Navigation("DownTimes");
                });
#pragma warning restore 612, 618
        }
    }
}