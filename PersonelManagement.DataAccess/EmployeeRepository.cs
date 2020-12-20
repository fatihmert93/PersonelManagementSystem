using PersonelManagement.DataAccess.Abstract;
using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManagement.DataAccess
{
    public class EmployeeRepository : GenericRepositoryBase<Employee>, IEmployeeRepository
    {
        
    }
}
