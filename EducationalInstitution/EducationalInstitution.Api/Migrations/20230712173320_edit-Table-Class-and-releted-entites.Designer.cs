﻿// <auto-generated />
using System;
using EducationalInstitution.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationalInstitution.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230712173320_edit-Table-Class-and-releted-entites")]
    partial class editTableClassandreletedentites
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Certificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CheckStatus")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("ExamEntranceCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamResult")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Prerequisite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tuition")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.CourseStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.DepositAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.ToTable("DepositAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.InstitutionInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLogoAddressUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InstitutionInformations");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.InterestRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BankAccountId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DepositAmountId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("DepositAmountId");

                    b.ToTable("InterestRate");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("ImageFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("MessageDeliveryStatus")
                        .HasColumnType("int");

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.MiscellaneousExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DepositDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DepositID")
                        .HasColumnType("int");

                    b.Property<string>("FeeFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("WithdrawalAmountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WithdrawalAmountId");

                    b.ToTable("MiscellaneousExpense");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.PaymentOfSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DepositDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DepositID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("SalaryAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WithdrawalAmountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WithdrawalAmountId");

                    b.ToTable("PaymentOfSalary");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.RegistrationInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CourseStudentId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DepositAmountId")
                        .HasColumnType("int");

                    b.Property<int>("DepositID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TotalNumberCourses")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalTuition")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrackingCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseStudentId");

                    b.HasIndex("DepositAmountId");

                    b.HasIndex("StudentId");

                    b.ToTable("RegistrationInvoice");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicSemester")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ExamDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Weekday")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.ScheduleCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ScheduleCourse");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.SiteAccessControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Assessment")
                        .HasColumnType("bit");

                    b.Property<bool>("BasicInformation")
                        .HasColumnType("bit");

                    b.Property<bool>("ClassInformation")
                        .HasColumnType("bit");

                    b.Property<bool>("CourseInformation")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("FinancialSector")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("RegistrationInformation")
                        .HasColumnType("bit");

                    b.Property<bool>("RelatedAnnouncements")
                        .HasColumnType("bit");

                    b.Property<bool>("Reporting")
                        .HasColumnType("bit");

                    b.Property<bool>("StudentAffairs")
                        .HasColumnType("bit");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SiteAccessControls");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("Education")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageAddressUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.WithdrawalAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.ToTable("WithdrawalAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BankAccountId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Instructor", b =>
                {
                    b.HasBaseType("EducationalInstitution.Api.Models.Entities.User");

                    b.Property<string>("Contract")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Instructor");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Student", b =>
                {
                    b.HasBaseType("EducationalInstitution.Api.Models.Entities.User");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NatioanlCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("ClassId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Class", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.Instructor", "Instructor")
                        .WithMany("Classes")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.CourseStudent", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.Student", "Student")
                        .WithMany("CourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.DepositAmount", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Transaction", "Transaction")
                        .WithMany("DepositAmounts")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.InterestRate", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.DepositAmount", "DepositAmount")
                        .WithMany("InterestRates")
                        .HasForeignKey("DepositAmountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BankAccount");

                    b.Navigation("DepositAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Message", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.MiscellaneousExpense", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.WithdrawalAmount", "WithdrawalAmount")
                        .WithMany("MiscellaneousExpenses")
                        .HasForeignKey("WithdrawalAmountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("WithdrawalAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.PaymentOfSalary", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.WithdrawalAmount", "WithdrawalAmount")
                        .WithMany("PaymentOfSalaries")
                        .HasForeignKey("WithdrawalAmountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WithdrawalAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.RegistrationInvoice", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.Course", null)
                        .WithMany("RegistrationInvoices")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EducationalInstitution.Api.Models.Entities.CourseStudent", "CourseStudent")
                        .WithMany()
                        .HasForeignKey("CourseStudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.DepositAmount", "DepositAmount")
                        .WithMany("RegistrationInvoices")
                        .HasForeignKey("DepositAmountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.Student", null)
                        .WithMany("RegistrationInvoices")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CourseStudent");

                    b.Navigation("DepositAmount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.ScheduleCourse", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.Course", "Course")
                        .WithMany("ScheduleCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EducationalInstitution.Api.Models.Entities.Schedule", "Schedule")
                        .WithMany("ScheduleCourses")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.WithdrawalAmount", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Transaction", "Transaction")
                        .WithMany("WithdrawalAmounts")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Transaction", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.BankAccount", "BankAccount")
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Student", b =>
                {
                    b.HasOne("EducationalInstitution.Api.Models.Entities.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.BankAccount", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Course", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("CourseStudents");

                    b.Navigation("RegistrationInvoices");

                    b.Navigation("ScheduleCourses");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.DepositAmount", b =>
                {
                    b.Navigation("InterestRates");

                    b.Navigation("RegistrationInvoices");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Schedule", b =>
                {
                    b.Navigation("ScheduleCourses");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.User", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.WithdrawalAmount", b =>
                {
                    b.Navigation("MiscellaneousExpenses");

                    b.Navigation("PaymentOfSalaries");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Transaction", b =>
                {
                    b.Navigation("DepositAmounts");

                    b.Navigation("WithdrawalAmounts");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Instructor", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("EducationalInstitution.Api.Models.Entities.Student", b =>
                {
                    b.Navigation("CourseStudents");

                    b.Navigation("RegistrationInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
