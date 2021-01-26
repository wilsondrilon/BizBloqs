﻿// <auto-generated />
using BizBloqs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BizBloqs.Entity.Migrations
{
    [DbContext(typeof(BizBloqsContext))]
    [Migration("20210125141104_store_proc_return_every_second_row")]
    partial class store_proc_return_every_second_row
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BizBloqs.Data.Entity.StoredText", b =>
                {
                    b.Property<int>("StoreTextId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreTextId");

                    b.ToTable("Rapyd_WebhookLogs", "Document");
                });
#pragma warning restore 612, 618
        }
    }
}
