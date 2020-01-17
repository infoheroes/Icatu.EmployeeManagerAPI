using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Icatu.EmployeeManagerAPI.WebApi.Controllers;
using Icatu.EmployeeManagerAPI.WebApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icatu.EmployeeManagerAPI.Test
{
    [TestClass]
    public class EmployeeUnitTest
    {
        [TestMethod]
        public void EmployeeGetAll() {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.GetEmployees();

            //List<Employee> employees;

            //Assert.IsTrue(response.TryGetContentValue<List<Employee>>(out employees));
            //Assert.AreEqual(5, employees.Count);
        }

        [TestMethod]
        public void EmployeeGetById() {
            var controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.GetEmployee(1);

            //Employee employee;

            //Assert.IsTrue(response.TryGetContentValue<Employee>(out employee));
            //Assert.AreEqual("Fabrício Aride", employee.Name);
        }

        [TestMethod]
        public void AddEmployeeTest() {
            var controller = new EmployeeController();
            Employee employee = new Employee {
                EmployeeId = 13,
                Name = "Carla Pitangueiras",
                Department = "Financeiro",
                Email = "cpitangueiras@teste.com.br"
            };
            IHttpActionResult actionResult = controller.PostEmployee(employee);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Employee>;
            // Assert  
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.IsNotNull(createdResult.RouteValues["id"]);
        }

        [TestMethod]
        public void UpdateEmployeeTest() {
            var controller = new EmployeeController();
            Employee employee = new Employee {
                EmployeeId = 14,
                Name = "Carla Pitangueiras",
                Department = "Operações",
                Email = "cpitangueiras@teste.com.br"
            };

            IHttpActionResult actionResult = controller.PutEmployee(14, employee);
            var contentResult = actionResult as NegotiatedContentResult<Employee>;
            Assert.IsNotNull(contentResult);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
        }

        [TestMethod]
        public void DeleteEmployeeTest() {
            var controller = new EmployeeController();
            IHttpActionResult actionResult = controller.DeleteEmployee(14);
            var contentResult = actionResult as NegotiatedContentResult<Employee>;
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
        }
    }
}
