using EmployeeSys.Web.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace EmployeeSys.Web.EmployeeExtintions
{
    public static class EmployeRequest
    {
        public async static Task<EmployeeDto> request(this EmployeeDto employee,string path, string subPath) 
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(subPath))
            {
                throw new ArgumentException("Path and subPath must not be null or empty.");
            }
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{path}/");
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //string url = path + subPath;
                HttpContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync(path + subPath,content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    if (employee == null)
                    {
                        return new EmployeeDto();
                    }
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {responseMessage.StatusCode}");
                }
            }
            return employee;

        }
    }
}
