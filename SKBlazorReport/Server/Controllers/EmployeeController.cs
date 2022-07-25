using Microsoft.AspNetCore.Mvc;
using SKBlazorReport.Server.Services;
using SKBlazorReport.Shared;

namespace SKBlazorReport.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeservice)
        {
            _employeeService = employeeservice;
        }

        //[HttpGet("{id}")]
        //public async Task<Filing> Get(int id)
        //{
        //    return await _context.Filing.FindAsync(id);
        //}

        //[HttpGet]
        //public List<Filing> Get()
        //{
        //    return _context.Filing
        //        .OrderBy(x => x.FilingNum).ToList();
        //}

        //[HttpGet]
        //public async Task <List<Filing>> GetFilings()
        //{
        //    return await _context.Filing.ToListAsync();
        //}

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var employees = await _employeeService.GetEmployees();

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}
