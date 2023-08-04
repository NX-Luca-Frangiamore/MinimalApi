﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalApi.Model;

#nullable disable

namespace MinimalApi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("MinimalApi.Model.NEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("utenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("nemail");
                });

            modelBuilder.Entity("MinimalApi.Model.NTelefono", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("utenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("ntelefono");
                });

            modelBuilder.Entity("MinimalApi.Model.Utente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("indirizzo")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("utente");
                });
#pragma warning restore 612, 618
        }
    }
}
