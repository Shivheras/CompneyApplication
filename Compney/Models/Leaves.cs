using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compney.Models
{
    class Leaves
    {
        [Key]
        public int LeaveId { get; set; }
        public string Descriptions { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int EmployeeId { get; set; }
        
    }
}
