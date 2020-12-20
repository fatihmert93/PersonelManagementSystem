using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersonelManagement.Model.Entities
{
    public class EmployeeEducation : EntityBase
    {
        public int EmployeeId { get; set; }
        public int SchoolId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("ShoolId")]
        public School School { get; set; }


    }
}
