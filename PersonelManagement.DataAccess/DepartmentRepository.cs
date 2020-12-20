using PersonelManagement.DataAccess.Abstract;
using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.DataAccess
{
    public class DepartmentRepository : GenericRepositoryBase<Department>, IDepartmentRepository
    {
    }
}
