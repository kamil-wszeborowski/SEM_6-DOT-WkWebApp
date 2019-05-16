using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WkWebApp.Models.DAL
{
    public class OnlineGradeBookContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<FinalMark> FinalMarks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubiectTeacher> SubiectTeachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
