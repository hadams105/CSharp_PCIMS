namespace PCIMS_Software.Models
{
    public class JobObject
	{
		public int JobNbr { get; set; }
		public int CustomerId { get; set; }
		public string OrderDateTime { get; set; }
		public string TakenBy { get; set; }
		public int JobType { get; set; }
		public string OrderBy { get; set; }
		public string DateSampled { get; set; }
		public string SubmissionId { get; set; }
		public string Terminal { get; set; }
		public string Location { get; set; }
		public string Cargo { get; set; }
		public int SampleQty { get; set; }
		public string DateInLab { get; set; }
		public string DateCompleted { get; set; }
		public string Reports { get; set; }
		public int Splits { get; set; }
		public string Dist1 { get; set; }
		public int Subs { get; set; }
		public string Dist2 { get; set; }
		public string LD { get; set; }
	}
}
