﻿using System;
using GastonCardenasMasGlobal.Test.Core.BL;
using GastonCardenasMasGlobal.Test.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GastonCardenasMasGlobal.Test.UTests
{
    [TestClass]
    public class GetEmployeesTest
    {
        readonly string BaseUrl = "http://masglobaltestapi.azurewebsites.net/api/";
        readonly string EmployeeRes = "Employees";

        [TestMethod]
        public void WhenEmployeeIdDontExistsTheReturnedListMustBeEmpty()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);

            var rnd = new Random(888);
            var id = rnd.Next(888, 99999);

            var employee = EmployeeBl.GetEmployees(restInfo, id);

            Assert.AreEqual(0, employee.Count);
        }

        [TestMethod]
        public void WhenEmployeeIdExistsTheReturnedList()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);            
            var id = 1;
            var employee = EmployeeBl.GetEmployees(restInfo, id);
            Assert.AreEqual(1, employee.Count);
        }
    }
}
