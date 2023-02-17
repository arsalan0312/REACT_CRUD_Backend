using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using REACT_CRUD.Repository;

namespace REACT_CRUD.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> DeleteAsync(Guid id)
        {
            return await _employeeRepository.DeleteAsync(id);
        }

        public async Task<Employee> GetById(Guid id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<List<Employee>> GetListAsync()
        {
            return await _employeeRepository.GetListAsync();
        }

        public async Task<Employee> PostAsync(EmployeeDTO employeeModel)
        {
            return await _employeeRepository.PostAsync(employeeModel);
        }

        public async Task<Employee> PutAsync(EmployeeDTO employeeModel, Guid id)
        {
            return await _employeeRepository.PutAsync(employeeModel, id);
        }
    }
}
