using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManagement.Service
{
    public interface IEmployeeService
    {
        public Task Create(Employee employee);
        public Task<IEnumerable<Employee>> GetList();


    }
}
