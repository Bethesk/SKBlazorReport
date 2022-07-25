using SKBlazorReport.Shared;
using System.Net.Http.Json;

namespace SKBlazorReport.Client.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadEmployees()
        {
            Employees = await _httpClient.GetFromJsonAsync<List<Employee>>("Employee");
        }
    }
}
