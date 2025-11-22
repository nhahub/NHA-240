//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//namespace Estately.Infrastructure.Data
//{
//    public partial class AppDBContext : IdentityDbContext<ApplicationUser>
//    {
//        public AppDBContext()
//        {
//        }

//        public AppDBContext(DbContextOptions<AppDBContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<LkpAppointmentStatus> LkpAppointmentStatuses { get; set; }

//        public virtual DbSet<LkpDocumentType> LkpDocumentTypes { get; set; }

//        public virtual DbSet<LkpPropertyHistoryType> LkpPropertyHistoryTypes { get; set; }

//        public virtual DbSet<LkpPropertyStatus> LkpPropertyStatuses { get; set; }

//        public virtual DbSet<LkpPropertyType> LkpPropertyTypes { get; set; }

//        public virtual DbSet<LkpUserType> LkpUserTypes { get; set; }

//        public virtual DbSet<TblAppointment> TblAppointments { get; set; }

//        public virtual DbSet<TblBranch> TblBranches { get; set; }

//        public virtual DbSet<TblBranchDepartment> TblBranchDepartments { get; set; }

//        public virtual DbSet<TblCity> TblCities { get; set; }

//        public virtual DbSet<TblClientProfile> TblClientProfiles { get; set; }

//        public virtual DbSet<TblClientPropertyInterest> TblClientPropertyInterests { get; set; }

//        public virtual DbSet<TblDepartment> TblDepartments { get; set; }

//        public virtual DbSet<TblDeveloperProfile> TblDeveloperProfiles { get; set; }

//        public virtual DbSet<TblEmployee> TblEmployees { get; set; }

//        public virtual DbSet<TblEmployeeClient> TblEmployeeClients { get; set; }

//        public virtual DbSet<TblFavorite> TblFavorites { get; set; }

//        public virtual DbSet<TblJobTitle> TblJobTitles { get; set; }

//        public virtual DbSet<TblProperty> TblProperties { get; set; }

//        public virtual DbSet<TblPropertyDocument> TblPropertyDocuments { get; set; }

//        public virtual DbSet<TblPropertyFeature> TblPropertyFeatures { get; set; }

//        public virtual DbSet<TblPropertyFeaturesMapping> TblPropertyFeaturesMappings { get; set; }

//        public virtual DbSet<TblPropertyHistory> TblPropertyHistories { get; set; }

//        public virtual DbSet<TblPropertyImage> TblPropertyImages { get; set; }

//        //public virtual DbSet<TblUser> TblUsers { get; set; }

//        public virtual DbSet<TblZone> TblZones { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//        }
////        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
////            => optionsBuilder.UseSqlServer("Data Source=Belal-2004;Initial Catalog=EstatelyDB;Integrated Security=True;Encrypt=True");

////        protected override void OnModelCreating(ModelBuilder modelBuilder)
////        {
////            modelBuilder.Entity<LkpAppointmentStatus>(entity =>
////            {
////                entity.HasKey(e => e.StatusId).HasName("PK_TblAppointmentStatus");
////            });

////            modelBuilder.Entity<LkpDocumentType>(entity =>
////            {
////                entity.HasKey(e => e.DocumentTypeID).HasName("PK__TblDocum__DBA390C11FF5415F");
////            });

////            modelBuilder.Entity<LkpPropertyHistoryType>(entity =>
////            {
////                entity.HasKey(e => e.HistoryTypeID).HasName("PK__LKPPrope__38069EDD6924C02B");
////            });

////            modelBuilder.Entity<LkpPropertyStatus>(entity =>
////            {
////                entity.HasKey(e => e.StatusID).HasName("PK_TblPropertyStatus");
////            });

////            modelBuilder.Entity<LkpPropertyType>(entity =>
////            {
////                entity.HasKey(e => e.PropertyTypeID).HasName("PK_TblPropertyTypes");
////            });

////            modelBuilder.Entity<LkpUserType>(entity =>
////            {
////                entity.HasKey(e => e.UserTypeID).HasName("PK_TblUserType");
////            });

////            modelBuilder.Entity<TblAppointment>(entity =>
////            {
////                entity.HasOne(d => d.Property).WithMany(p => p.TblAppointments)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblAppointments_TblProperties");

////                entity.HasOne(d => d.Status).WithOne(p => p.TblAppointment)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblAppointments_TblAppointmentStatus");
////            });

////            modelBuilder.Entity<TblBranchDepartment>(entity =>
////            {
////                entity.HasKey(e => e.BranchDepartmentID).HasName("PK__TblBranc__DE88E11B8EFCE25B");

////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "ZF_TblBranchDepartments");

////                entity.HasOne(d => d.Branch).WithMany(p => p.TblBranchDepartments)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblBranch__Branc__10566F31");

////                entity.HasOne(d => d.Department).WithMany(p => p.TblBranchDepartments)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblBranch__Depar__114A936A");
////            });

////            modelBuilder.Entity<TblClientProfile>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblClientProfiles");

////                entity.HasOne(d => d.User).WithOne(p => p.TblClientProfile)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblClientProfiles_TblUsers");
////            });

////            modelBuilder.Entity<TblClientPropertyInterest>(entity =>
////            {
////                entity.HasOne(d => d.ClientProfile).WithMany(p => p.TblClientPropertyInterests)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblClientPropertyInterests_TblClientProfiles");

////                entity.HasOne(d => d.Property).WithMany(p => p.TblClientPropertyInterests)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblClientPropertyInterests_TblProperties");
////            });

////            modelBuilder.Entity<TblDepartment>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "BF_TblDepartments");
////            });

////            modelBuilder.Entity<TblDeveloperProfile>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "CF_TblDeveloperProfiles");

////                entity.HasOne(d => d.User).WithOne(p => p.TblDeveloperProfile)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblDeveloperProfiles_TblUsers");
////            });

////            modelBuilder.Entity<TblEmployee>(entity =>
////            {
////                entity.Property(e => e.HireDate)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblEmployees_DateTime");

////                entity.HasOne(d => d.BranchDepartment).WithMany(p => p.TblEmployees).HasConstraintName("FK_TblEmployees_TblBranchDepartments");

////                entity.HasOne(d => d.JobTitle).WithMany(p => p.TblEmployees)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK_TblEmployees_TblJobTitle");

////                entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation).HasConstraintName("FK_TblEmployees_TblEmployees");
////            });

////            modelBuilder.Entity<TblEmployeeClient>(entity =>
////            {
////                entity.Property(e => e.AssignmentDate)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblEmployeeClients");
////            });

////            modelBuilder.Entity<TblFavorite>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblFavorites");
////            });

////            modelBuilder.Entity<TblJobTitle>(entity =>
////            {
////                entity.HasKey(e => e.JobTitleId).HasName("PK_TblJobTitle");
////            });

////            modelBuilder.Entity<TblProperty>(entity =>
////            {
////                entity.Property(e => e.IsDeleted)
////                    .HasDefaultValue(false)
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblProperties_IsDeleted");
////                entity.Property(e => e.ListingDate)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblProperties");
////                entity.Property(e => e.StatusId)
////                    .HasDefaultValue(1)
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblProperties_StatusId");

////                entity.HasOne(d => d.Agent).WithMany(p => p.TblProperties).HasConstraintName("FK_TblProperties_TblEmployees");

////                entity.HasOne(d => d.DeveloperProfile).WithMany(p => p.TblProperties).OnDelete(DeleteBehavior.Cascade);

////                entity.HasOne(d => d.PropertyType).WithMany(p => p.TblProperties).HasConstraintName("FK_TblProperties_TblPropertyTypes_PropertyTypeID");

////                entity.HasOne(d => d.Status).WithMany(p => p.TblProperties).HasConstraintName("FK_TblProperties_LkpPropertyStatus");
////            });

////            modelBuilder.Entity<TblPropertyDocument>(entity =>
////            {
////                entity.HasKey(e => e.DocumentID).HasName("PK__TblPrope__1ABEEF6F103F101F");

////                entity.Property(e => e.UploadedAt).HasDefaultValueSql("(getdate())");

////                entity.HasOne(d => d.DocumentType).WithMany(p => p.TblPropertyDocuments)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblProper__Docum__214BF109");

////                entity.HasOne(d => d.Property).WithMany(p => p.TblPropertyDocuments)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblProper__Prope__1F63A897");

////                entity.HasOne(d => d.User).WithMany(p => p.TblPropertyDocuments).HasConstraintName("FK__TblProper__UserI__1F98B2C1");
////            });

////            modelBuilder.Entity<TblPropertyFeature>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "ZF_TblPropertyFeatures");
////                entity.Property(e => e.IsAmenity)
////                    .HasDefaultValue(false)
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblPropertyFeatures_IsAmenity");
////            });

////            modelBuilder.Entity<TblPropertyHistory>(entity =>
////            {
////                entity.HasKey(e => e.HistoryID).HasName("PK__TblPrope__4D7B4ADDF535279D");

////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF__TblProper__Creat__16CE6296");

////                entity.HasOne(d => d.HistoryType).WithMany(p => p.TblPropertyHistories)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblProper__Histo__19AACF41");

////                entity.HasOne(d => d.Property).WithMany(p => p.TblPropertyHistories)
////                    .OnDelete(DeleteBehavior.ClientSetNull)
////                    .HasConstraintName("FK__TblProper__Prope__17C286CF");

////                entity.HasOne(d => d.User).WithMany(p => p.TblPropertyHistories).HasConstraintName("FK__TblProper__UserI__18B6AB08");
////            });

////            modelBuilder.Entity<TblUser>(entity =>
////            {
////                entity.Property(e => e.CreatedAt)
////                    .HasDefaultValueSql("(getdate())")
////                    .HasAnnotation("Relational:DefaultConstraintName", "BF_TblUsers");
////                entity.Property(e => e.UserTypeID)
////                    .HasDefaultValue(1)
////                    .HasAnnotation("Relational:DefaultConstraintName", "DF_TblUsers_UserTypeID");

////                entity.HasOne(d => d.UserType).WithMany(p => p.TblUsers).HasConstraintName("FK_TblUsers_TblUserType");
////            });

////            OnModelCreatingPartial(modelBuilder);
////        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
// AppDBContext.cs
// Generated from scratch for Estately project (Identity with int keys)
// Reference diagram (uploaded): sandbox:/mnt/data/0e7a6b29-8569-46cf-a6c9-3a8b49c84aec.png
using Microsoft.EntityFrameworkCore.Design;

namespace Estately.Infrastructure.Data
{
    public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {
        public AppDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();

            var connectionString =
                "Server=Belal-2004;Database=EstatelyDB;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDBContext(optionsBuilder.Options);
        }
    }

    public partial class AppDBContext
      : IdentityDbContext<
          ApplicationUser,
          ApplicationRole,
          int,
          ApplicationUserClaim,
          ApplicationUserRole,
          ApplicationUserLogin,
          ApplicationRoleClaim,
          ApplicationUserToken>
    {
        public AppDBContext() { }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) { }

        #region DbSets
        public virtual DbSet<LkpAppointmentStatus> LkpAppointmentStatuses { get; set; }
        public virtual DbSet<LkpDocumentType> LkpDocumentTypes { get; set; }
        public virtual DbSet<LkpPropertyHistoryType> LkpPropertyHistoryTypes { get; set; }
        public virtual DbSet<LkpPropertyStatus> LkpPropertyStatuses { get; set; }
        public virtual DbSet<LkpPropertyType> LkpPropertyTypes { get; set; }
        public virtual DbSet<LkpUserType> LkpUserTypes { get; set; }

        public virtual DbSet<TblAppointment> TblAppointments { get; set; }
        public virtual DbSet<TblBranch> TblBranches { get; set; }
        public virtual DbSet<TblBranchDepartment> TblBranchDepartments { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblClientProfile> TblClientProfiles { get; set; }
        public virtual DbSet<TblClientPropertyInterest> TblClientPropertyInterests { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblDeveloperProfile> TblDeveloperProfiles { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEmployeeClient> TblEmployeeClients { get; set; }
        public virtual DbSet<TblFavorite> TblFavorites { get; set; }
        public virtual DbSet<TblJobTitle> TblJobTitles { get; set; }
        public virtual DbSet<TblProperty> TblProperties { get; set; }
        public virtual DbSet<TblPropertyDocument> TblPropertyDocuments { get; set; }
        public virtual DbSet<TblPropertyFeature> TblPropertyFeatures { get; set; }
        public virtual DbSet<TblPropertyFeaturesMapping> TblPropertyFeaturesMappings { get; set; }
        public virtual DbSet<TblPropertyHistory> TblPropertyHistories { get; set; }
        public virtual DbSet<TblPropertyImage> TblPropertyImages { get; set; }
        public virtual DbSet<TblZone> TblZones { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===============================
            // IDENTITY TABLES
            // ===============================
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");
            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("AspNetUserRoles");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("AspNetUserLogins");
            modelBuilder.Entity<ApplicationRoleClaim>().ToTable("AspNetRoleClaims");
            modelBuilder.Entity<ApplicationUserToken>().ToTable("AspNetUserTokens");

            // ===============================
            // ONE-TO-ONE PROFILES
            // ===============================

            // Client Profile (1:1)
            modelBuilder.Entity<TblClientProfile>()
                .HasOne(p => p.User)
                .WithOne(u => u.ClientProfile)
                .HasForeignKey<TblClientProfile>(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // Developer Profile (1:1)
            modelBuilder.Entity<TblDeveloperProfile>()
                .HasOne(p => p.User)
                .WithOne(u => u.DeveloperProfile)
                .HasForeignKey<TblDeveloperProfile>(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee Profile (1:1)
            modelBuilder.Entity<TblEmployee>()
                .HasOne(e => e.User)
                .WithOne(u => u.EmployeeProfile)
                .HasForeignKey<TblEmployee>(e => e.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // ===============================
            // USER TYPE (ONE-TO-MANY)
            // ===============================
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.UserType)
                .WithMany(t => t.Users)
                .HasForeignKey(u => u.UserTypeID)
                .OnDelete(DeleteBehavior.Restrict);

            // ===============================
            // ONE-TO-MANY Documents & History
            // ===============================
            modelBuilder.Entity<TblPropertyDocument>()
                .HasOne(d => d.User)
                .WithMany(u => u.PropertyDocuments)
                .HasForeignKey(d => d.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TblPropertyHistory>()
                .HasOne(h => h.User)
                .WithMany(u => u.PropertyHistories)
                .HasForeignKey(h => h.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
