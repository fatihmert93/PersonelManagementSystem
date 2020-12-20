using Microsoft.AspNetCore.Mvc;
using PersonelManagement.DataAccess;
using PersonelManagement.Model.Entities;
using PersonelManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelManagement.Api.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> GetList()
        {
            var list = await _employeeService.GetList();
            return Ok(list);
        }


        public IActionResult Create(Employee employee)
        {
            return Ok();
        }
    }
}
