using Microsoft.EntityFrameworkCore;
using REACT_CRUD.ContextDB;
using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using System.Data;

namespace REACT_CRUD.Repository
{
    public class DepartmentTypeRepository : IDepartmentTypeRepository
    {
        private readonly TestDBContext _contextapp;

        public DepartmentTypeRepository(TestDBContext contextapp)
        {
            _contextapp = contextapp;
        }
        public async Task<DepartmentType> DeleteAsync(Guid departmentTypeId)
        {
            var result = await _contextapp.DepartmentTypes.FirstOrDefaultAsync(x => x.Id == departmentTypeId);
            if (result != null)
            {
                result.IsDeleted = true;
                _contextapp.DepartmentTypes.Update(result);
                _contextapp.SaveChanges();
            }
            return result;
        }

        public async Task<DepartmentType> GetById(Guid departmentTypeId)
        {
            return await _contextapp.DepartmentTypes.FirstOrDefaultAsync(x => x.Id == departmentTypeId);
        }

        public async Task<List<DepartmentType>> GetListAsync()
        {
            return await _contextapp.DepartmentTypes.Where(x => x.IsDeleted != true).ToListAsync();
        }

        public async Task<DepartmentType> PostAsync(DepartmentTypeDTO departmentTypeModel)
        {
            if (departmentTypeModel != null)
            {
                DepartmentType departmentType = new DepartmentType();

                departmentType.Id = Guid.NewGuid();
                departmentType.Name = departmentTypeModel.Name;
                departmentType.Description = departmentTypeModel.Description;
                departmentType.CreatedDateTime = DateTime.Now;
                departmentType.UpdatedDateTime = DateTime.Now;
                departmentType.IsDeleted = false;
                _contextapp.DepartmentTypes.Add(departmentType);
                _contextapp.SaveChanges();

                return departmentType;
            }
            return null;
        }

        public async Task<DepartmentType> PutAsync(DepartmentTypeDTO departmentTypeModel, Guid departmentTypeId)
        {
            var departmentTypeExist = await _contextapp.DepartmentTypes.FindAsync(departmentTypeId);

            if (departmentTypeExist != null)
            {
                departmentTypeExist.Name = departmentTypeModel.Name;
                departmentTypeExist.Description = departmentTypeModel.Description;
                departmentTypeExist.IsDeleted= false;
                _contextapp.DepartmentTypes.Update(departmentTypeExist);
                _contextapp.SaveChanges();

                return departmentTypeExist;

            }

            return null;
        }
    }
}
