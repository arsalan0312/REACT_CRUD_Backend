using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using System.Data;

namespace REACT_CRUD.Repository
{
    public interface IDepartmentTypeRepository
    {
        public Task<DepartmentType> PostAsync(DepartmentTypeDTO departmentTypeModel);
        public Task<DepartmentType> PutAsync(DepartmentTypeDTO departmentTypeModel, Guid departmentTypeId);
        public Task<DepartmentType> DeleteAsync(Guid departmentTypeId);
        public Task<DepartmentType> GetById(Guid departmentTypeId);
        public Task<List<DepartmentType>> GetListAsync();
    }
}
