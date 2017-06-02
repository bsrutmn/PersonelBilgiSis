using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using PersonelBilgiSis.Areas.Admin.Models;

namespace PersonelBilgiSis
{
    public class DB : DbContext
    {
        public DB(): base()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EducationInfo> EducationInfos { get; set; }
        public DbSet<AcademicandAdministrativeDuties> AcademicandAdministrativeDuties{ get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<IdInformation> IdInformations { get; set; }
        public DbSet<JobExperience> JobExperiences { get; set; }
        public DbSet<Notices> Notices { get; set; }
        public DbSet<AcademicTitle> AcademicTitle { get; set; }
        public DbSet<GivenLessons> GivenLessons { get; set; }
        public DbSet<Biography> Biography { get; set; }
        public DbSet<ProjectApplication> ProjectApplication { get; set; }
        public DbSet<Publications> Publications { get; set; }
        public DbSet<PublicationsCategories> PublicationsCategories { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }

    }
}