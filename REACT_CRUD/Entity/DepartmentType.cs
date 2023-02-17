namespace REACT_CRUD.Entity
{
    public class DepartmentType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Boolean? IsDeleted { get; set; }

        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? UpdatedDateTime { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
