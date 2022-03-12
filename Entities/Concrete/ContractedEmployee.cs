using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ContractedEmployee:IEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        public double BaseSalary { get; set; }

        public Employee Employee { get; set; }
    }
}
