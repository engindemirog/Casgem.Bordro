using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeForeignLanguage:IEntity
    {
        public int Id { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }
        public Employee Employee { get; set; }
    }
}
