using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Models
{
    public class LabReportHeaderObject
    {
        public int JobNbr { get; set; }
        public string LabNumber { get; set; }
        public DateTime ReportDate { get; set; }
        public string SDA1 { get; set; }
        public string SDA2 { get; set; }
        public string IdMarks1 { get; set; }
        public string IdMarks2 { get; set; }
        public string IdMarks3 { get; set; }
        public string IdMarks4 { get; set; }
        public string Submitted1 { get; set; }
        public string Submitted2 { get; set; }
        public int Client1 { get; set; }
        public int Client2 { get; set; }
        public int Client3 { get; set; }
        public int Client4 { get; set; }
    }
}
