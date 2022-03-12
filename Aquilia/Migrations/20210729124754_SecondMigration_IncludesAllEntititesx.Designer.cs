﻿// <auto-generated />
using System;
using Aquilia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aquilia.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210729124754_SecondMigration_IncludesAllEntititesx")]
    partial class SecondMigration_IncludesAllEntititesx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aquilia.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPartID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentID");

                    b.HasIndex("ProductPartID");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("Aquilia.Models.AssignmentLog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AssignedState")
                        .HasColumnType("int");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("LogId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AssignmentLog");
                });

            modelBuilder.Entity("Aquilia.Models.Assignment_RawMaterials", b =>
                {
                    b.Property<int>("AssignmentRawMaterialsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RawMaterialID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentRawMaterialsID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("RawMaterialID");

                    b.ToTable("Assignment_RawMaterials");
                });

            modelBuilder.Entity("Aquilia.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttendentDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AtttendantEmployee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("AttendanceID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("Aquilia.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContactNo")
                        .HasColumnType("bigint");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Aquilia.Models.CustomerLedger", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ChequeNumber")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoucherNo")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerLedger");
                });

            modelBuilder.Entity("Aquilia.Models.DebitCredit", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CreditAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DebitAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("FinalProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoucherNo")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("FinalProductID");

                    b.ToTable("DebitCredits");
                });

            modelBuilder.Entity("Aquilia.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductPartsProductPartID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ProductPartsProductPartID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Aquilia.Models.FinalProduct", b =>
                {
                    b.Property<int>("FinalProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FinalProductID");

                    b.HasIndex("CustomerID");

                    b.ToTable("FinalProduct");
                });

            modelBuilder.Entity("Aquilia.Models.ProductParts", b =>
                {
                    b.Property<int>("ProductPartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CopperComposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FinalProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductPartCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPartQuantity")
                        .HasColumnType("int");

                    b.Property<string>("WaxComposition")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductPartID");

                    b.HasIndex("FinalProductID");

                    b.ToTable("ProductParts");
                });

            modelBuilder.Entity("Aquilia.Models.RawMaterials", b =>
                {
                    b.Property<int>("RawMaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNo")
                        .HasColumnType("int");

                    b.Property<long>("ChequeNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CreditAmount")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DebitAmount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.Property<int>("VoucherNo")
                        .HasColumnType("int");

                    b.HasKey("RawMaterialID");

                    b.HasIndex("VendorID");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("Aquilia.Models.Salary", b =>
                {
                    b.Property<int>("SalaryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendanceID")
                        .HasColumnType("int");

                    b.Property<string>("SalaryMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaryID");

                    b.HasIndex("AttendanceID");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("Aquilia.Models.Sales", b =>
                {
                    b.Property<int>("SalesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNo")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("FinalProductID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("FinalProductID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Aquilia.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PANNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("Aquilia.ViewModel.CustomerLedgerViewModel", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<long>("ChequeNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoucherNo")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerLedgerViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.CustomerSalesViewModel", b =>
                {
                    b.Property<int>("CustomerSalesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNo")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerContact")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerSalesID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerSalesViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.DebitAndCreditReportViewModel", b =>
                {
                    b.Property<int>("DebitCreditID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChequeNo")
                        .HasColumnType("int");

                    b.Property<decimal>("CreditAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DebitAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeName")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoucherID")
                        .HasColumnType("int");

                    b.HasKey("DebitCreditID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("DebitAndCreditReportViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.EmployeeAssignmentsViewModel", b =>
                {
                    b.Property<int>("EmployeeAssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssignedProductPart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AssignedQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("AssignmentState")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPartCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeAssignmentID");

                    b.HasIndex("AssignmentID");

                    b.ToTable("EmployeeAssignmentsViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.ProductandProductPartsViewModel", b =>
                {
                    b.Property<int>("ProductandProductPartsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FinalProductID")
                        .HasColumnType("int");

                    b.Property<string>("FinalProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPartName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaxComposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productPartCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductandProductPartsID");

                    b.HasIndex("FinalProductID");

                    b.ToTable("ProductandProductPartsViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.VendorLedgerViewModel", b =>
                {
                    b.Property<int>("VendorLedgerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<long>("ChequeNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CreditAmount")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DebitAmount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int?>("VendorID")
                        .HasColumnType("int");

                    b.Property<int>("VoucherNo")
                        .HasColumnType("int");

                    b.HasKey("VendorLedgerID");

                    b.HasIndex("VendorID");

                    b.ToTable("VendorLedgerViewModel");
                });

            modelBuilder.Entity("Aquilia.ViewModel.VendorPurchasesViewModel", b =>
                {
                    b.Property<int>("VendorPurchaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillNo")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VendorID")
                        .HasColumnType("int");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("particularName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorPurchaseID");

                    b.HasIndex("VendorID");

                    b.ToTable("VendorPurchasesViewModel");
                });

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.Property<int>("AssignmentsAssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesEmployeeID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentsAssignmentID", "EmployeesEmployeeID");

                    b.HasIndex("EmployeesEmployeeID");

                    b.ToTable("AssignmentEmployee");
                });

            modelBuilder.Entity("Aquilia.Models.Assignment", b =>
                {
                    b.HasOne("Aquilia.Models.ProductParts", "ProductParts")
                        .WithMany()
                        .HasForeignKey("ProductPartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductParts");
                });

            modelBuilder.Entity("Aquilia.Models.AssignmentLog", b =>
                {
                    b.HasOne("Aquilia.Models.Assignment", "Assignment")
                        .WithMany("AssignmentLogs")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aquilia.Models.Employee", "Employee")
                        .WithMany("AssignmentLog")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Aquilia.Models.Assignment_RawMaterials", b =>
                {
                    b.HasOne("Aquilia.Models.Assignment", "Assignment")
                        .WithMany("assignment_RawMaterials")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aquilia.Models.RawMaterials", "RawMaterials")
                        .WithMany("assignment_RawMaterials")
                        .HasForeignKey("RawMaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("RawMaterials");
                });

            modelBuilder.Entity("Aquilia.Models.Attendance", b =>
                {
                    b.HasOne("Aquilia.Models.Employee", "Employee")
                        .WithOne("Attendance")
                        .HasForeignKey("Aquilia.Models.Attendance", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Aquilia.Models.CustomerLedger", b =>
                {
                    b.HasOne("Aquilia.Models.Customer", "Customer")
                        .WithMany("CustomerLedger")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Aquilia.Models.DebitCredit", b =>
                {
                    b.HasOne("Aquilia.Models.Employee", "Employee")
                        .WithMany("DebitCredit")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aquilia.Models.FinalProduct", "FinalProduct")
                        .WithMany("DebitCredit")
                        .HasForeignKey("FinalProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("FinalProduct");
                });

            modelBuilder.Entity("Aquilia.Models.Employee", b =>
                {
                    b.HasOne("Aquilia.Models.ProductParts", "ProductParts")
                        .WithMany()
                        .HasForeignKey("ProductPartsProductPartID");

                    b.Navigation("ProductParts");
                });

            modelBuilder.Entity("Aquilia.Models.FinalProduct", b =>
                {
                    b.HasOne("Aquilia.Models.Customer", null)
                        .WithMany("FinalProducts")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("Aquilia.Models.ProductParts", b =>
                {
                    b.HasOne("Aquilia.Models.FinalProduct", "FinalProduct")
                        .WithMany("ProductParts")
                        .HasForeignKey("FinalProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinalProduct");
                });

            modelBuilder.Entity("Aquilia.Models.RawMaterials", b =>
                {
                    b.HasOne("Aquilia.Models.Vendor", "Vendor")
                        .WithMany("RawMaterials")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Aquilia.Models.Salary", b =>
                {
                    b.HasOne("Aquilia.Models.Attendance", "Attendance")
                        .WithMany()
                        .HasForeignKey("AttendanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attendance");
                });

            modelBuilder.Entity("Aquilia.Models.Sales", b =>
                {
                    b.HasOne("Aquilia.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aquilia.Models.FinalProduct", "FinalProduct")
                        .WithMany()
                        .HasForeignKey("FinalProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("FinalProduct");
                });

            modelBuilder.Entity("Aquilia.ViewModel.CustomerLedgerViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Customer", "Customer")
                        .WithMany("CustomerLedgerViewModel")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Aquilia.ViewModel.CustomerSalesViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Customer", null)
                        .WithMany("CustomerSalesViewModel")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("Aquilia.ViewModel.DebitAndCreditReportViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Employee", null)
                        .WithMany("DebitAndCreditReportViewModel")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("Aquilia.ViewModel.EmployeeAssignmentsViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Assignment", null)
                        .WithMany("EmployeeAssignmentsViewModel")
                        .HasForeignKey("AssignmentID");
                });

            modelBuilder.Entity("Aquilia.ViewModel.ProductandProductPartsViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.FinalProduct", null)
                        .WithMany("ProductandProductPartsViewModel")
                        .HasForeignKey("FinalProductID");
                });

            modelBuilder.Entity("Aquilia.ViewModel.VendorLedgerViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Vendor", null)
                        .WithMany("VendorLedgerViewModel")
                        .HasForeignKey("VendorID");
                });

            modelBuilder.Entity("Aquilia.ViewModel.VendorPurchasesViewModel", b =>
                {
                    b.HasOne("Aquilia.Models.Vendor", null)
                        .WithMany("VendorPurchasesViewModel")
                        .HasForeignKey("VendorID");
                });

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.HasOne("Aquilia.Models.Assignment", null)
                        .WithMany()
                        .HasForeignKey("AssignmentsAssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aquilia.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aquilia.Models.Assignment", b =>
                {
                    b.Navigation("assignment_RawMaterials");

                    b.Navigation("AssignmentLogs");

                    b.Navigation("EmployeeAssignmentsViewModel");
                });

            modelBuilder.Entity("Aquilia.Models.Customer", b =>
                {
                    b.Navigation("CustomerLedger");

                    b.Navigation("CustomerLedgerViewModel");

                    b.Navigation("CustomerSalesViewModel");

                    b.Navigation("FinalProducts");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Aquilia.Models.Employee", b =>
                {
                    b.Navigation("AssignmentLog");

                    b.Navigation("Attendance");

                    b.Navigation("DebitAndCreditReportViewModel");

                    b.Navigation("DebitCredit");
                });

            modelBuilder.Entity("Aquilia.Models.FinalProduct", b =>
                {
                    b.Navigation("DebitCredit");

                    b.Navigation("ProductandProductPartsViewModel");

                    b.Navigation("ProductParts");
                });

            modelBuilder.Entity("Aquilia.Models.RawMaterials", b =>
                {
                    b.Navigation("assignment_RawMaterials");
                });

            modelBuilder.Entity("Aquilia.Models.Vendor", b =>
                {
                    b.Navigation("RawMaterials");

                    b.Navigation("VendorLedgerViewModel");

                    b.Navigation("VendorPurchasesViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}
