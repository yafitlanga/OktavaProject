using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OktavaProject.DL.Models
{
    public partial class OktavaDBContext : DbContext
    {
        public OktavaDBContext()
        {
        }

        public OktavaDBContext(DbContextOptions<OktavaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcademicDegree> AcademicDegrees { get; set; } = null!;
        public virtual DbSet<AcademicDegreeUser> AcademicDegreeUsers { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Day> Days { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<EventUpdateUser> EventUpdateUsers { get; set; } = null!;
        public virtual DbSet<Hour> Hours { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<SkillUser> SkillUsers { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentLesson> StudentLessons { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=OktavaDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicDegree>(entity =>
            {
                entity.ToTable("ACADEMIC_DEGREE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("DESC");
            });

            modelBuilder.Entity<AcademicDegreeUser>(entity =>
            {
                entity.ToTable("ACADEMIC_DEGREE_USERS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AcademicDegreeId).HasColumnName("ACADEMIC_DEGREE_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.AcademicDegree)
                    .WithMany(p => p.AcademicDegreeUsers)
                    .HasForeignKey(d => d.AcademicDegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACADEMIC___ACADE__398D8EEE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AcademicDegreeUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACADEMIC___USER___38996AB5");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Detailes)
                    .HasMaxLength(50)
                    .HasColumnName("DETAILES");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("DAYS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("DESC");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("EVENTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Hour)
                    .HasMaxLength(50)
                    .HasColumnName("HOUR");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Payment).HasColumnName("PAYMENT");

                entity.Property(e => e.ResponsibleUserId).HasColumnName("RESPONSIBLE_USER_ID");

                entity.HasOne(d => d.ResponsibleUser)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.ResponsibleUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EVENTS__RESPONSI__31EC6D26");
            });

            modelBuilder.Entity<EventUpdateUser>(entity =>
            {
                entity.ToTable("EVENT_UPDATE_USERS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Hour>(entity =>
            {
                entity.ToTable("HOURS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("DESC");

                entity.Property(e => e.Orders).HasColumnName("ORDERS");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("LESSONS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DayId).HasColumnName("DAY_ID");

                entity.Property(e => e.HourId).HasColumnName("HOUR_ID");

                entity.Property(e => e.SkillId).HasColumnName("SKILL_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LESSONS__DAY_ID__4316F928");

                entity.HasOne(d => d.Hour)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.HourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LESSONS__HOUR_ID__440B1D61");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LESSONS__SKILL_I__44FF419A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LESSONS__USER_ID__4222D4EF");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("SKILL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("DESC");
            });

            modelBuilder.Entity<SkillUser>(entity =>
            {
                entity.ToTable("SKILL_USERS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SkillId).HasColumnName("SKILL_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillUsers)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SKILL_USE__SKILL__35BCFE0A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SkillUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SKILL_USE__USER___34C8D9D1");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENT_ID");
            });

            modelBuilder.Entity<StudentLesson>(entity =>
            {
                entity.ToTable("STUDENT_LESSON");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LessonId).HasColumnName("LESSON_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.StudentLessons)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STUDENT_L__LESSO__48CFD27E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentLessons)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STUDENT_L__USER___47DBAE45");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PhoneOne)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE_ONE");

                entity.Property(e => e.PhoneTwo)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE_TWO");

                entity.Property(e => e.UsersId)
                    .HasMaxLength(50)
                    .HasColumnName("USERS_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
