﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PropertyManager.DataStore.Data;

namespace PropertyManager.DataStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PropertyManager.DataModel.Model.Property", b =>
                {
                    b.Property<int>("PropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("prop_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<int>("RentCost")
                        .HasColumnType("integer")
                        .HasColumnName("rent_cost");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text")
                        .HasColumnName("street_address");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer")
                        .HasColumnName("zip_code");

                    b.HasKey("PropId");

                    b.ToTable("property");
                });

            modelBuilder.Entity("PropertyManager.DataModel.Model.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("TenantId");

                    b.ToTable("tenant");
                });
#pragma warning restore 612, 618
        }
    }
}
