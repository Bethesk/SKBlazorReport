using SKBlazorReport.Shared;

namespace SKBlazorReport.Client.Services
{
    public interface IEmployeeService 
    {
        public List<Employee> Employees { get; set; }
        Task LoadEmployees();
    }
}
