using EmployeeSys.Web.Models;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace EmployeeSys.Web.EmployeeExtintions
{
    public static class HttpRequest
    {
        public static async Task<IEnumerable<EmployeeDto>> Request(this IEnumerable<EmployeeDto> employeesDto, string path,string subPath) 
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(subPath))
            {
                throw new ArgumentException("Path and subPath must not be null or empty.");
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage responseMessage = await client.GetAsync(path+subPath);
                if (responseMessage.IsSuccessStatusCode)
                {
                    employeesDto = await responseMessage.Content.ReadFromJsonAsync<List<EmployeeDto>>();
                    if (employeesDto == null)
                    {
                        return new List<EmployeeDto>();
                    }
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {responseMessage.StatusCode}");
                }
            }
            return employeesDto;
        }
    }
}
