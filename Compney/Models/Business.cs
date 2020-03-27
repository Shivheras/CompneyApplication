using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compney.Models
{
    class Business
    {
        [Key]
        public int BusinessId { get; set; }

        public string BusinessName { get; set; }

        public int CompneyId { get; set; }
    }
}
