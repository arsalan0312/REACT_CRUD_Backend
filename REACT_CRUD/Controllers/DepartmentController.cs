using Microsoft.AspNetCore.Mvc;
using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using REACT_CRUD.Services;

namespace REACT_CRUD.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentTypeService _departmentTypeService;
        public DepartmentController(IDepartmentTypeService departmentTypeService)
        {
            _departmentTypeService = departmentTypeService;
        }

        [HttpGet]
        public async Task<ActionResult> GetListAsync()
        {
            try
            {
                return Ok(await _departmentTypeService.GetListAsync());

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            try
            {
                return Ok(await _departmentTypeService.GetById(id));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] DepartmentTypeDTO departmentTypeModel)
        {
            try
            {
                return Ok(await _departmentTypeService.PostAsync(departmentTypeModel));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPut("{departmentTypeId}")]

        public async Task<ActionResult> PutAsync([FromBody] DepartmentTypeDTO departmentTypeModel, Guid departmentTypeId)
        {
            try
            {
                return Ok(await _departmentTypeService.PutAsync(departmentTypeModel, departmentTypeId));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        [HttpDelete("{departmentTypeId}")]

        public async Task<ActionResult> DeleteAsync(Guid departmentTypeId)
        {
            try
            {
                return Ok(await _departmentTypeService.DeleteAsync(departmentTypeId));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
