﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Train_project.Data;

#nullable disable

namespace Train_project.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Train_project.Core.Entities.EmployeeEntity", b =>
                {
                    b.Property<int>("EmployeeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeCode"), 1L, 1);

                    b.Property<string>("EmployeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployedFrom")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("EmployeeCode");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Train_project.Core.Entities.PublicInquiryEntity", b =>
                {
                    b.Property<int>("InquiryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InquiryId"), 1L, 1);

                    b.Property<string>("ComplainantsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplainantsPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionInquiry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusInquiry")
                        .HasColumnType("bit");

                    b.Property<int>("TreatedBy")
                        .HasColumnType("int");

                    b.HasKey("InquiryId");

                    b.ToTable("PublicInquiry");
                });

            modelBuilder.Entity("Train_project.Core.Entities.StationEntity", b =>
                {
                    b.Property<int>("StationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationID"), 1L, 1);

                    b.Property<string>("LocationGPSCoordinates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPlatforms")
                        .HasColumnType("int");

                    b.Property<string>("StationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StationCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationID");

                    b.ToTable("Station");
                });

            modelBuilder.Entity("Train_project.Core.Entities.TrainEntity", b =>
                {
                    b.Property<int>("TrainID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainID"), 1L, 1);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCars")
                        .HasColumnType("int");

                    b.Property<string>("RegularRoute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainLine")
                        .HasColumnType("int");

                    b.Property<bool>("TrainStatus")
                        .HasColumnType("bit");

                    b.HasKey("TrainID");

                    b.ToTable("Train");
                });

            modelBuilder.Entity("Train_project.Core.Entities.TrainRouteEntity", b =>
                {
                    b.Property<int>("TrainRouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainRouteId"), 1L, 1);

                    b.Property<int>("Driver")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstTrain")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastTrain")
                        .HasColumnType("datetime2");

                    b.Property<int>("Station")
                        .HasColumnType("int");

                    b.Property<int>("SubstituteDriver")
                        .HasColumnType("int");

                    b.Property<int>("Train")
                        .HasColumnType("int");

                    b.HasKey("TrainRouteId");

                    b.ToTable("TrainRoute");
                });
#pragma warning restore 612, 618
        }
    }
}
