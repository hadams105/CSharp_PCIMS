using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Models
{
    public class LabFeeObject
    {
        public int TestID { get; set; }
        public string TestDesc { get; set; }
        public decimal Fee { get; set; }
        public string ASTM { get; set; }
    }
}
