using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compney.Models
{
    class Compneys
    {
        [Key]
        public int CompneyId { get; set; }

        public string CompneyName { get; set; }

    }
}
