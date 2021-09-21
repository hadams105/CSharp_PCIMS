using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Models
{
    public class AppliedTestObject
    {
        public int DtlNbr { get; set; }
        public int JobNbr { get; set; }
        public int SheetNbr { get; set; }
        public int LineNbr { get; set; }
        public string Marked { get; set; }
        public string Re { get; set; }
        public int TemplateId { get; set; }
        public string Test { get; set; }
        public int TestId { get; set; }
        public string Astm { get; set; }
        public string CompBy { get; set; }
        public string Result { get; set; }
        public Spec Spec { get; set; }
        public double Fee { get; set; }
        public string ReleaseId { get; set; }
        public string Note { get; set; }
    }

    public struct Spec
    {
        public double min { get; set; }
        public double max { get; set; }
    }
}
