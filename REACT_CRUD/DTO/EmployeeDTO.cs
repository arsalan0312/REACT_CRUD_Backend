using REACT_CRUD.Entity;

namespace REACT_CRUD.DTO
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTimeOffset? UpdatedDateTime { get; set; }
        public Guid? DepartmentTypeId { get; set; }
    }
}
