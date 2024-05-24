namespace OperationManagement_UI.Model
{
	public class JobCard
	{
		public string? JobCardNumber { get; set; }

		public DateTime JobCardCreatedDate { get; private set; }

		public DateTime JobCardModifiedDate { get; private set; }

		public long JobNumber { get; set; }

		public Customer? Customer { get; set; }

		public JobCardStatus JobCardStatus { get; set; }

		public JobCard()
		{

		}

		public JobCard(long jobNumber, Customer? customer, JobCardStatus jobCardStatus)
		{
			JobCardNumber = Guid.NewGuid().ToString();
			JobCardCreatedDate = DateTime.Now;
			JobCardModifiedDate = DateTime.Now;

			JobNumber = jobNumber;
			Customer = customer;
			JobCardStatus = jobCardStatus;
		}
	}

	public enum JobCardStatus
	{
		Created,
		Delivered,
		InvoicePrepared,
		Posted
	}
}
