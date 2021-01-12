﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tp_Freelance.Data;

namespace Tp_Freelance.Migrations
{
    [DbContext(typeof(FreelanceContext))]
    partial class FreelanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Tp_Freelance.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id")
                        .UseIdentityColumn();

                    b.Property<int>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("cat_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("customer_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("customer_name");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Tp_Freelance.Models.CustomerCat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("Text")
                        .HasColumnName("cat_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("cat_name");

                    b.HasKey("Id");

                    b.ToTable("customers_cats");
                });

            modelBuilder.Entity("Tp_Freelance.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("job_id")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("job_description");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2")
                        .HasColumnName("job_end");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2")
                        .HasColumnName("job_start");

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("job_stat");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("job_title");

                    b.HasKey("Id");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("Tp_Freelance.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("quote_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("quote_date");

                    b.Property<int>("FinalAmount")
                        .HasColumnType("int")
                        .HasColumnName("quote_final_amount");

                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("job_id");

                    b.Property<DateTime>("QuoteFinalDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("quote_final_date");

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("quote_state");

                    b.Property<int>("amount")
                        .HasColumnType("int")
                        .HasColumnName("quote_amount");

                    b.HasKey("Id");

                    b.ToTable("quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
