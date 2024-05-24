namespace OperationManagement_UI.Model
{
	public class Customer
	{
		public Customer(Guid? customerId)
		{
			CustomerId = customerId;
		}

		public Guid? CustomerId { get; }

		public string? Name { get; set; }

		public string? Address { get; set; }


		public string? ContactNumber { get; set; }

		public Attention? SelectedAttention { get; set; }


		//To do seperate this, find via company id. 
		public IEnumerable<Attention>? Attentions { get; set; }
	}

	public class Attention
	{
		public string Name { get; set; }

		public Guid Id { get; }

		public Attention(string name)
		{
			Name = name;
			Id = Guid.NewGuid();
		}
	}
}
