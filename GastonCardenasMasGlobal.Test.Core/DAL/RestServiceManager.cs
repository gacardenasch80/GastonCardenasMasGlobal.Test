using GastonCardenasMasGlobal.Test.Core.Models;
using GastonCardenasMasGlobal.Test.Core.Infrastructure;
using RestSharp;
using System.Collections.Generic;

namespace GastonCardenasMasGlobal.Test.Core.DAL
{
    public static class RestServiceManager
    {
        public static List<Employee> GetEmployees(RestEndPointModel model)
        {
            var client = new RestClient(model.BaseUrl);

            var request = new RestRequest(model.EmployeeResName, Method.GET);

            var response = client.Execute(request);

            return response.Content.ToEmployeeList();
        }
    }
}
