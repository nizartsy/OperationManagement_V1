namespace OperationManagement_UI.Model
{
	public class CostDetails
	{
		// Property for Particular
		public CostDetails(Vendor? vendor, int? quantity, int? unit, double? amount, double? total, Guid id)
		{
			Vendor = vendor;
			Quantity = quantity;
			Unit = unit;
			Amount = amount;
			Total = total;
			Id = id;
		}

		public CostDetails()
		{
			
		}

		public Vendor? Vendor { get; set; }
		// Property for Quantity
		public int? Quantity { get; set; }

		// Property for Unit
		public int? Unit { get; set; }

		// Property for Amount
		public double? Amount { get; set; }

		// Property for Total
		public double? Total { get; set; }

		// Property for ID
		public Guid? Id { get; set; }
	}
}