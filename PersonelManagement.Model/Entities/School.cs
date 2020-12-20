using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.Model.Entities
{
    public class School : EntityBase
    {
        public string SchoolName { get; set; }
        public string City { get; set; }

        public string DepartmentName { get; set; }

    }
}
