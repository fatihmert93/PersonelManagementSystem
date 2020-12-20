using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersonelManagement.Model.Entities
{
    public class Employee : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }
}
