using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class PermanentEmployee : IEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        public string RegisterNumber { get; set; }

        public Employee Employee { get; set; }
    }
}
