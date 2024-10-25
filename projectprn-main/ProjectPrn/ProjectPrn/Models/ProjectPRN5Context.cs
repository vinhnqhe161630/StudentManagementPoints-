using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectPrn.Models
{
    public partial class ProjectPRN5Context : DbContext
    {
        public ProjectPRN5Context()
        {
        }

        public ProjectPRN5Context(DbContextOptions<ProjectPRN5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseGrade> CourseGrades { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentClass> StudentClasses { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-R6K7MTN\\KTEAM;Initial Catalog=ProjectPRN5;User ID=sa;Password=123123;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Semester).HasColumnName("semester");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TeacherId).HasColumnName("teacherId");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Classes__courseI__34C8D9D1");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Classes__teacher__35BCFE0A");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<CourseGrade>(entity =>
            {
                entity.Property(e => e.CourseGradeId).HasColumnName("courseGradeId");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gradeName");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseGrades)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__CourseGra__cours__412EB0B6");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");

                entity.Property(e => e.GradeId).HasColumnName("gradeId");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.CourseGradeId).HasColumnName("courseGradeId");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Grade__classId__31EC6D26");

                entity.HasOne(d => d.CourseGrade)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.CourseGradeId)
                    .HasConstraintName("FK__Grade__courseGra__33D4B598");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Grade__studentID__32E0915F");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {
                entity.ToTable("Student_classes");

                entity.Property(e => e.StudentClassId).HasColumnName("student_class_id");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Student_c__class__300424B4");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentClasses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Student_c__stude__30F848ED");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherId).HasColumnName("teacherId");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
