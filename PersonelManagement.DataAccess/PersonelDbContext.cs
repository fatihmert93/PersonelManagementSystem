using Microsoft.EntityFrameworkCore;
using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.DataAccess
{
    public class PersonelDbContext : DbContext
    {

        public DbSet<Department> Departements { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }

    }
}
