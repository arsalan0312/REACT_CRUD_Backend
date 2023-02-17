using Microsoft.AspNetCore.Mvc;
using REACT_CRUD.DTO;
using REACT_CRUD.Entity;
using REACT_CRUD.Services;

namespace REACT_CRUD.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetListAsync()
        {
            try
            {
                return Ok(await _employeeService.GetListAsync());

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
                return Ok(await _employeeService.GetById(id));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] EmployeeDTO employeeModel)
        {
            try
            {
                if (employeeModel == null)
                    return BadRequest();
                var result = await _employeeService.PostAsync(employeeModel);
                return Ok(result);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync([FromBody] EmployeeDTO employeeModel, Guid id)
        {
            try
            {
                return Ok(await _employeeService.PutAsync(employeeModel, id));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            try
            {
                return Ok(await _employeeService.DeleteAsync(id));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

    }
}
