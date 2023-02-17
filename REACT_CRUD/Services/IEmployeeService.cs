using REACT_CRUD.DTO;
using REACT_CRUD.Entity;

namespace REACT_CRUD.Services
{
    public interface IEmployeeService
    {
        public Task<Employee> PostAsync(EmployeeDTO employeeModel);
        public Task<Employee> PutAsync(EmployeeDTO employeeModel, Guid id);
        public Task<Employee> DeleteAsync(Guid id);
        public Task<Employee> GetById(Guid id);
        public Task<List<Employee>> GetListAsync();
    }
}
 