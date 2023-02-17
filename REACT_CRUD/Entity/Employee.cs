using System.Data;

namespace REACT_CRUD.Entity
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public Boolean? IsDeleted { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTimeOffset? UpdatedDateTime { get; set; }
        public Guid? DepartmentTypeId { get; set; }
        public DepartmentType DepartmentTypes { get; set; }
    }
}
