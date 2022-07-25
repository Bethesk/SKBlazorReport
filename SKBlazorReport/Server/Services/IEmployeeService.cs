using SKBlazorReport.Shared;

namespace SKBlazorReport.Server.Services
{
    public interface IEmployeeService 
    {
        Task<List<Employee>> GetEmployees();
    }
}
