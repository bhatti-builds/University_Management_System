using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace university.Models;

public class NeondbContext : DbContext
{
    public NeondbContext(DbContextOptions<NeondbContext> options)
            : base(options)
        {
        }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>().HasData(
    new Student { StudentId = 1, Name = "John Doe", Email = "johndoe@example.com" },
    new Student { StudentId = 2, Name = "Jane Smith", Email = "janesmith@example.com" }
);

        modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = 1, CourseName = "Mathematics"  },
            new Course { CourseId = 2, CourseName = "Physics" }
        );

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher { TeacherId = 1, Name = "Dr. Brown", Department = "Physics" },
            new Teacher { TeacherId = 2, Name = "Dr. Green", Department = "Mathematics" }
        );
    }
}
