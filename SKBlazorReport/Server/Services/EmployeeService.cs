using Microsoft.EntityFrameworkCore;
using SKBlazorReport.Server.Data;
using SKBlazorReport.Shared;

namespace SKBlazorReport.Server.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        //public List<Filing> Filings { get; set; } = new List<Filing>{
        //        new Filing { FilingId=1, FilingName="ABC", FilingNum="1234567"},
        //        new Filing { FilingId=2, FilingName="DEF", FilingNum="56789"},
        //        new Filing { FilingId = 3, FilingName = "GHI", FilingNum = "20002344" }
        //    };

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
            //return  Filings;
        }
    }
}
