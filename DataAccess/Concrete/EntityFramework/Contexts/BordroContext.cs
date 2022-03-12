using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class BordroContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BordroDb;Trusted_Connection=true");
        }
        public DbSet<ContractedEmployee> ContractedEmployees { get; set; }
        public DbSet<PermanentEmployee> PermanentEmployees { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<EmployeeForeignLanguage> EmployeeForeignLanguages { get; set; }


    }
}
