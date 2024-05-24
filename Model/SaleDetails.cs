namespace OperationManagement_UI.Model
{
	public class SaleDetails
	{
		// Property for Particular
		public SaleDetails(string particular, int quantity, int unit, double amount, double total, Guid id)
		{
			Particular = particular;
			Quantity = quantity;
			Unit = unit;
			Amount = amount;
			Total = total;
			Id = id;
		}

		public string Particular { get; set; }

		// Property for Quantity
		public int Quantity { get; set; }

		// Property for Unit
		public int Unit { get; set; }

		// Property for Amount
		public double Amount { get; set; }

		// Property for Total
		public double Total { get; set; }

		// Property for ID
		public Guid Id { get; set; }
	}
}
