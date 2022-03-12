using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }

        public ContractedEmployee? ContractedEmployee { get; set; }
        public PermanentEmployee? PermanentEmployee { get; set; }
    }
}

