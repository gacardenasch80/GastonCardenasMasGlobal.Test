using GastonCardenasMasGlobal.Test.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GastonCardenasMasGlobal.Test.Core.Infrastructure
{
    /// <summary>
    /// Clase que se encarga que devolver el objeto de lista de empleados
    /// </summary>
    public static class ExtMethods
    {
        public static List<Employee> ToEmployeeList(this string jsonString)
        {
            return JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        }
    }
}
