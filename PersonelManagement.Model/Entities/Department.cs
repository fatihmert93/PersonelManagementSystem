using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.Model.Entities
{
    public class Department : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
