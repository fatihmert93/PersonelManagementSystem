using PersonelManagement.DataAccess;
using PersonelManagement.DataAccess.Abstract;
using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManagement.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICacheManager _cacheManager;

        private readonly string employeeListKey = "employees";

        public EmployeeService(IEmployeeRepository employeeRepository, ICacheManager cacheManager)
        {
            _employeeRepository = employeeRepository;
            _cacheManager = cacheManager;
        }


        public async Task<IEnumerable<Employee>> GetList()
        {
            var existsInCache = _cacheManager.IsExists(employeeListKey);

            if (existsInCache)
            {
                return (IEnumerable<Employee>)_cacheManager.Get<IEnumerable<Employee>>(employeeListKey);
            }

            var list = await _employeeRepository.GetList();

            _cacheManager.Set(employeeListKey, list);

            return list;

        }

        public async Task Create(Employee employee)
        {
            await _employeeRepository.Create(employee);
        }
    }
}
