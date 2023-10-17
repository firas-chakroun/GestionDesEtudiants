﻿using Microsoft.EntityFrameworkCore;

namespace GestionDesEtudiants.Models.ViewModels
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
