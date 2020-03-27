using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compney.Models
{
    class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int EmployeType { get; set; }
    }
}
