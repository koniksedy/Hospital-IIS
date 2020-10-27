﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nemocnice.Data;

namespace Nemocnice.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nemocnice.Data.ActivityPricingPerDiagnosis", b =>
                {
                    b.Property<int>("ActivityPricingPerDiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int>("MedicallActivityPriceId")
                        .HasColumnType("int");

                    b.HasKey("ActivityPricingPerDiagnosisId");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("MedicallActivityPriceId");

                    b.ToTable("ActivityPricingPerDiagnosisT");
                });

            modelBuilder.Entity("Nemocnice.Data.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZIP")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("AddressT");
                });

            modelBuilder.Entity("Nemocnice.Data.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OutsorceCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminT");
                });

            modelBuilder.Entity("Nemocnice.Data.Allergy", b =>
                {
                    b.Property<int>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AllergyId");

                    b.ToTable("AllergyT");
                });

            modelBuilder.Entity("Nemocnice.Data.AllergysOfPatient", b =>
                {
                    b.Property<int>("AllergysOfPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AllergyId")
                        .HasColumnType("int");

                    b.Property<int>("HealthConditionId")
                        .HasColumnType("int");

                    b.HasKey("AllergysOfPatientId");

                    b.HasIndex("AllergyId");

                    b.HasIndex("HealthConditionId");

                    b.ToTable("AllergysOfPatientT");
                });

            modelBuilder.Entity("Nemocnice.Data.CheckupTicket", b =>
                {
                    b.Property<int>("CheckupTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedByICZ")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IncludePicDescript")
                        .HasColumnType("bit");

                    b.Property<bool>("IncludePicRes")
                        .HasColumnType("bit");

<<<<<<< HEAD
                    b.Property<int>("PatientID")
=======
                    b.Property<int>("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToDoctorICZ")
                        .HasColumnType("int");

                    b.HasKey("CheckupTicketId");

                    b.HasIndex("CreatedByICZ");

<<<<<<< HEAD
                    b.HasIndex("PatientID");
=======
                    b.HasIndex("PatientId");
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac

                    b.HasIndex("ToDoctorICZ");

                    b.ToTable("CheckupTicketT");
                });

            modelBuilder.Entity("Nemocnice.Data.CureProgress", b =>
                {
                    b.Property<int>("CureProgressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int>("MedicallReportId")
                        .HasColumnType("int");

                    b.Property<string>("StateOfTreatment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CureProgressId");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("MedicallReportId");

                    b.ToTable("CureProgressT");
                });

            modelBuilder.Entity("Nemocnice.Data.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosisId");

                    b.ToTable("DiagnosisT");
                });

            modelBuilder.Entity("Nemocnice.Data.Doctor", b =>
                {
                    b.Property<int>("ICZ")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ICZ");

                    b.ToTable("DoctorT");
                });

            modelBuilder.Entity("Nemocnice.Data.HealthCondition", b =>
                {
                    b.Property<int>("HealthConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<DateTime>("LastCheckupDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SocialSecurityNum")
                        .HasColumnType("bigint");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("HealthConditionId");

                    b.ToTable("HealthConditionT");
                });

            modelBuilder.Entity("Nemocnice.Data.InsureEmp", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Possition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalId");

                    b.ToTable("InsureEmpT");
                });

            modelBuilder.Entity("Nemocnice.Data.Login", b =>
                {
                    b.Property<string>("CurrentLogin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleCode")
                        .HasColumnType("int");

                    b.HasKey("CurrentLogin");

                    b.ToTable("LoginT");
                });

            modelBuilder.Entity("Nemocnice.Data.MedicallActivityPrice", b =>
                {
                    b.Property<int>("MedicallActivityPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicallActivityPriceId");

                    b.ToTable("MedicallActivityPriceT");
                });

            modelBuilder.Entity("Nemocnice.Data.MedicallBill", b =>
                {
                    b.Property<int>("MedicallBillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorICZ")
                        .HasColumnType("int");

                    b.Property<int>("MedicallActivityPriceId")
                        .HasColumnType("int");

                    b.Property<long>("SocialSecurityNum")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicallBillId");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("DoctorICZ");

                    b.HasIndex("MedicallActivityPriceId");

                    b.ToTable("MedicallBillT");
                });

            modelBuilder.Entity("Nemocnice.Data.MedicallReport", b =>
                {
                    b.Property<int>("MedicallReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorICZ")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IncludePic")
                        .HasColumnType("bit");

                    b.Property<int?>("OwnerICZ")
                        .HasColumnType("int");

<<<<<<< HEAD
                    b.Property<int>("PatientID")
=======
                    b.Property<int>("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .HasColumnType("int");

                    b.HasKey("MedicallReportId");

                    b.HasIndex("AuthorICZ");

                    b.HasIndex("OwnerICZ");

<<<<<<< HEAD
                    b.HasIndex("PatientID");
=======
                    b.HasIndex("PatientId");
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac

                    b.ToTable("MedicallReportT");
                });

            modelBuilder.Entity("Nemocnice.Data.Patient", b =>
                {
<<<<<<< HEAD
                    b.Property<int>("PatientID")
=======
                    b.Property<int>("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HealthConditionId")
                        .HasColumnType("int");

                    b.Property<int>("HomeAddressAddressId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceCompany")
                        .HasColumnType("int");

                    b.Property<long>("SocialSecurityNum")
                        .HasColumnType("bigint");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

<<<<<<< HEAD
                    b.HasKey("PatientID");
=======
                    b.HasKey("PatientId");
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac

                    b.HasIndex("HealthConditionId");

                    b.HasIndex("HomeAddressAddressId");

                    b.ToTable("PatientT");
                });

            modelBuilder.Entity("Nemocnice.Data.PatientTreatmentLog", b =>
                {
                    b.Property<int>("PatientTreatmentLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndOfTreatment")
                        .HasColumnType("datetime2");

<<<<<<< HEAD
                    b.Property<int>("PatientID")
=======
                    b.Property<int>("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .HasColumnType("int");

                    b.Property<DateTime>("StartOfTreatment")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientTreatmentLogId");

                    b.HasIndex("DiagnosisId");

<<<<<<< HEAD
                    b.HasIndex("PatientID");
=======
                    b.HasIndex("PatientId");
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac

                    b.ToTable("PatientTreatmentLogT");
                });

            modelBuilder.Entity("Nemocnice.Data.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("CurrentPicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SocialSecurityNum")
                        .HasColumnType("bigint");

                    b.Property<int?>("ToAllergyAllergyId")
                        .HasColumnType("int");

                    b.Property<int?>("ToCheckupTicketCheckupTicketId")
                        .HasColumnType("int");

                    b.Property<int?>("ToMedicalReportMedicallReportId")
                        .HasColumnType("int");

                    b.HasKey("PictureId");

                    b.HasIndex("ToAllergyAllergyId");

                    b.HasIndex("ToCheckupTicketCheckupTicketId");

                    b.HasIndex("ToMedicalReportMedicallReportId");

                    b.ToTable("PictureT");
                });

            modelBuilder.Entity("Nemocnice.Data.TicketPerDiagnosis", b =>
                {
                    b.Property<int>("TicketPerDiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckupTicketId")
                        .HasColumnType("int");

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.HasKey("TicketPerDiagnosisId");

                    b.HasIndex("CheckupTicketId");

                    b.HasIndex("DiagnosisId");

                    b.ToTable("TicketPerDiagnosisT");
                });

            modelBuilder.Entity("Nemocnice.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginCurrentLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkAddressAddressId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("LoginCurrentLogin");

                    b.HasIndex("WorkAddressAddressId");

                    b.ToTable("UserT");
                });

            modelBuilder.Entity("Nemocnice.Data.ActivityPricingPerDiagnosis", b =>
                {
                    b.HasOne("Nemocnice.Data.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.MedicallActivityPrice", "MedicallActivityPrice")
                        .WithMany()
                        .HasForeignKey("MedicallActivityPriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.AllergysOfPatient", b =>
                {
                    b.HasOne("Nemocnice.Data.Allergy", "Allergy")
                        .WithMany()
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.HealthCondition", "HealthCondition")
                        .WithMany()
                        .HasForeignKey("HealthConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.CheckupTicket", b =>
                {
                    b.HasOne("Nemocnice.Data.Doctor", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByICZ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Patient", "Patient")
                        .WithMany()
<<<<<<< HEAD
                        .HasForeignKey("PatientID")
=======
                        .HasForeignKey("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Doctor", "ToDoctor")
                        .WithMany()
                        .HasForeignKey("ToDoctorICZ");
                });

            modelBuilder.Entity("Nemocnice.Data.CureProgress", b =>
                {
                    b.HasOne("Nemocnice.Data.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.MedicallReport", "MedicallReport")
                        .WithMany()
                        .HasForeignKey("MedicallReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.MedicallBill", b =>
                {
                    b.HasOne("Nemocnice.Data.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorICZ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.MedicallActivityPrice", "MedicallActivityPrice")
                        .WithMany()
                        .HasForeignKey("MedicallActivityPriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.MedicallReport", b =>
                {
                    b.HasOne("Nemocnice.Data.Doctor", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorICZ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Doctor", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerICZ");

                    b.HasOne("Nemocnice.Data.Patient", "Patient")
                        .WithMany()
<<<<<<< HEAD
                        .HasForeignKey("PatientID")
=======
                        .HasForeignKey("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.Patient", b =>
                {
                    b.HasOne("Nemocnice.Data.HealthCondition", "HealthCondition")
                        .WithMany()
                        .HasForeignKey("HealthConditionId");

                    b.HasOne("Nemocnice.Data.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.PatientTreatmentLog", b =>
                {
                    b.HasOne("Nemocnice.Data.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Patient", "Patient")
                        .WithMany()
<<<<<<< HEAD
                        .HasForeignKey("PatientID")
=======
                        .HasForeignKey("PatientId")
>>>>>>> 1f99c343045d8f88e3676a1b024eb6503bbe5bac
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.Picture", b =>
                {
                    b.HasOne("Nemocnice.Data.Allergy", "ToAllergy")
                        .WithMany()
                        .HasForeignKey("ToAllergyAllergyId");

                    b.HasOne("Nemocnice.Data.CheckupTicket", "ToCheckupTicket")
                        .WithMany()
                        .HasForeignKey("ToCheckupTicketCheckupTicketId");

                    b.HasOne("Nemocnice.Data.MedicallReport", "ToMedicalReport")
                        .WithMany()
                        .HasForeignKey("ToMedicalReportMedicallReportId");
                });

            modelBuilder.Entity("Nemocnice.Data.TicketPerDiagnosis", b =>
                {
                    b.HasOne("Nemocnice.Data.CheckupTicket", "CheckupTicket")
                        .WithMany()
                        .HasForeignKey("CheckupTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nemocnice.Data.User", b =>
                {
                    b.HasOne("Nemocnice.Data.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginCurrentLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nemocnice.Data.Address", "WorkAddress")
                        .WithMany()
                        .HasForeignKey("WorkAddressAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
