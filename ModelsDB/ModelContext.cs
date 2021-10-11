using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlazorApp.ModelsDB
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoanType> LoanTypes { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<TypeLoan> TypeLoans { get; set; }
        public virtual DbSet<VLoanStaffDetail> VLoanStaffDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PSU_LOAN")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<LoanType>(entity =>
            {
                entity.ToTable("LOAN_TYPE");

                entity.Property(e => e.LoanTypeId)
                    .HasPrecision(3)
                    .HasColumnName("LOAN_TYPE_ID");

                entity.Property(e => e.Active)
                    .HasPrecision(1)
                    .HasColumnName("ACTIVE");

                entity.Property(e => e.LoanInterest)
                    .HasColumnType("FLOAT")
                    .HasColumnName("LOAN_INTEREST");

                entity.Property(e => e.LoanMaxAmount)
                    .HasColumnType("NUMBER(10,2)")
                    .HasColumnName("LOAN_MAX_AMOUNT");

                entity.Property(e => e.LoanParentId)
                    .HasPrecision(3)
                    .HasColumnName("LOAN_PARENT_ID");

                entity.Property(e => e.LoanParentName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_PARENT_NAME");

                entity.Property(e => e.LoanPeriod)
                    .HasPrecision(2)
                    .HasColumnName("LOAN_PERIOD");

                entity.Property(e => e.LoanTypeName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_TYPE_NAME");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.ToTable("SAMPLE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BIRTH_DATE");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUST_FIRST_NAME");

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUST_LAST_NAME");
            });

            modelBuilder.Entity<TypeLoan>(entity =>
            {
                entity.HasKey(e => e.LoanTypeId)
                    .HasName("TYPE_LOAN_PK");

                entity.ToTable("TYPE_LOAN");

                entity.Property(e => e.LoanTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOAN_TYPE_ID");

                entity.Property(e => e.Active)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FileName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.LoanInterate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_INTERATE");

                entity.Property(e => e.LoanMaxAmount)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOAN_MAX_AMOUNT");

                entity.Property(e => e.LoanParentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOAN_PARENT_ID");

                entity.Property(e => e.LoanParentName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_PARENT_NAME");

                entity.Property(e => e.LoanPeriod)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOAN_PERIOD");

                entity.Property(e => e.LoanTypeName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_TYPE_NAME");

                entity.Property(e => e.PathFile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PATH_FILE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");
            });

            modelBuilder.Entity<VLoanStaffDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LOAN_STAFF_DETAIL");

                entity.Property(e => e.CampId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CAMP_ID");

                entity.Property(e => e.CampNameThai)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CAMP_NAME_THAI");

                entity.Property(e => e.CampusId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CAMPUS_ID");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_ID");

                entity.Property(e => e.DeptNameEng)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME_ENG");

                entity.Property(e => e.DeptNameThai)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME_THAI");

                entity.Property(e => e.FacId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAC_ID");

                entity.Property(e => e.FacNameEng)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FAC_NAME_ENG");

                entity.Property(e => e.FacNameThai)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FAC_NAME_THAI");

                entity.Property(e => e.GradId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRAD_ID");

                entity.Property(e => e.GradNameThai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GRAD_NAME_THAI");

                entity.Property(e => e.JobId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL_NAME");

                entity.Property(e => e.MarriedId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MARRIED_ID");

                entity.Property(e => e.MarriedNameThai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARRIED_NAME_THAI");

                entity.Property(e => e.NetSalary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NET_SALARY");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PLAN_ID");

                entity.Property(e => e.PosId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("POS_ID");

                entity.Property(e => e.PosNameThai)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("POS_NAME_THAI");

                entity.Property(e => e.PosType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("POS_TYPE");

                entity.Property(e => e.ProvNameThai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROV_NAME_THAI");

                entity.Property(e => e.ReligionId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION_ID");

                entity.Property(e => e.ReligionNameThai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION_NAME_THAI");

                entity.Property(e => e.SectId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SECT_ID");

                entity.Property(e => e.SexId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEX_ID");

                entity.Property(e => e.SexNameThai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEX_NAME_THAI");

                entity.Property(e => e.StaffAcceptDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_ACCEPT_DATE");

                entity.Property(e => e.StaffBirthDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_BIRTH_DATE");

                entity.Property(e => e.StaffDateOut)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_DATE_OUT");

                entity.Property(e => e.StaffDepart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_DEPART");

                entity.Property(e => e.StaffEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_EMAIL");

                entity.Property(e => e.StaffEnd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_END");

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_ID");

                entity.Property(e => e.StaffNameEng)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_NAME_ENG");

                entity.Property(e => e.StaffNameThai)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_NAME_THAI");

                entity.Property(e => e.StaffOut)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_OUT");

                entity.Property(e => e.StaffSeatId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_SEAT_ID");

                entity.Property(e => e.StaffSnameEng)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_SNAME_ENG");

                entity.Property(e => e.StaffSnameThai)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_SNAME_THAI");

                entity.Property(e => e.StaffType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_TYPE");

                entity.Property(e => e.StaffTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_TYPE_NAME");

                entity.Property(e => e.SubunitId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUBUNIT_ID");

                entity.Property(e => e.Title2NameEng)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TITLE2_NAME_ENG");

                entity.Property(e => e.TitleId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_ID");

                entity.Property(e => e.TitleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME");

                entity.Property(e => e.TitleName2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME2");

                entity.Property(e => e.TitleName3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME3");

                entity.Property(e => e.TitleName3Eng)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME3_ENG");

                entity.Property(e => e.TitleNameLect)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME_LECT");

                entity.Property(e => e.TitleNameThai)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TITLE_NAME_THAI");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_ID");
            });

            modelBuilder.HasSequence("DEPT_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
