using Microsoft.EntityFrameworkCore;
using REACT_CRUD.ContextDB;
using REACT_CRUD.DTO;
using REACT_CRUD.Entity;

namespace REACT_CRUD.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TestDBContext _contextapp;

        public EmployeeRepository(TestDBContext contextapp)
        {
            _contextapp = contextapp;
        }

        public async Task<Employee> PostAsync(EmployeeDTO employeeModel)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id= Guid.NewGuid();
                employee.FirstName = employeeModel.FirstName;
                employee.LastName = employeeModel.LastName;
                employee.Address = employeeModel.Address;
                employee.PhoneNumber = employeeModel.PhoneNumber;
                employee.CreatedDateTime = employeeModel.CreatedDateTime;
                employee.UpdatedDateTime = employeeModel.UpdatedDateTime;
                employee.Email = employeeModel.Email;
                employee.IsDeleted = false;
                employee.DepartmentTypeId = employeeModel?.DepartmentTypeId.Value;


                _contextapp.Employees.Add(employee);
                _contextapp.SaveChanges();

                return employee;


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Employee> PutAsync(EmployeeDTO employeeModel, Guid id)
        {
            var employeeExist = await _contextapp.Employees.FindAsync(id);

            if (employeeExist != null)
            {
                employeeExist.FirstName = employeeModel.FirstName;
                employeeExist.LastName = employeeModel.LastName;
                employeeExist.Address = employeeModel.Address;
                employeeExist.PhoneNumber = employeeModel.PhoneNumber;
                employeeExist.CreatedDateTime = DateTime.Now;
                employeeExist.UpdatedDateTime = DateTime.Now;
                employeeExist.Email = employeeModel.Email;
                employeeExist.IsDeleted = false;
                employeeExist.DepartmentTypeId = employeeModel.DepartmentTypeId;
                _contextapp.Employees.Update(employeeExist);
                await _contextapp.SaveChangesAsync();

                return employeeExist;

            }
            return employeeExist;
        }

        public async Task<Employee> DeleteAsync(Guid id)
        {
            var result = await _contextapp.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                result.IsDeleted = true;
                _contextapp.Employees.Update(result);
                _contextapp.SaveChanges();
            }
            return result;
        }

        public async Task<Employee> GetById(Guid id) => await _contextapp.Employees.FirstOrDefaultAsync(x => x.Id == id);


        public async Task<List<Employee>> GetListAsync()
        {
            return await _contextapp.Employees.Where(x=>x.IsDeleted != true).Include(x => x.DepartmentTypes).ToListAsync();
        }
    }
}
