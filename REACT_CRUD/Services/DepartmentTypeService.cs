using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using REACT_CRUD.Repository;
using System.Data;

namespace REACT_CRUD.Services
{
    public class DepartmentTypeService : IDepartmentTypeService
    {

        private readonly IDepartmentTypeRepository _departmentTypeRepository;

        public DepartmentTypeService(IDepartmentTypeRepository departmentTypeRepository)
        {
            _departmentTypeRepository = departmentTypeRepository;
        }
        public async Task<DepartmentType> DeleteAsync(Guid departmentTypeId)
        {
            return await _departmentTypeRepository.DeleteAsync(departmentTypeId);
        }

        public async Task<DepartmentType> GetById(Guid departmentTypeId)
        {
            return await _departmentTypeRepository.GetById(departmentTypeId);
        }

        public async Task<List<DepartmentType>> GetListAsync()
        {
            return await _departmentTypeRepository.GetListAsync();
        }

        public async Task<DepartmentType> PostAsync(DepartmentTypeDTO departmentTypeModel)
        {
            return await _departmentTypeRepository.PostAsync(departmentTypeModel);
        }

        public async Task<DepartmentType> PutAsync(DepartmentTypeDTO departmentTypeModel, Guid departmentTypeId)
        {
            return await _departmentTypeRepository.PutAsync(departmentTypeModel, departmentTypeId);
        }
    }
}
