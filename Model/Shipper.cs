namespace OperationManagement_UI.Model
{
    public class Shipper
    {
	    // Property for ID
        public Guid Id { get; set; }

        // Property for Customer
        public Customer Customer { get; set; }

        public string? AdditionalNote { get; set; }

        // Default constructor
        public Shipper()
        {
	        AdditionalNote = string.Empty;
	        // Initialize fields if needed
            Id = Guid.NewGuid(); // Assign a new unique ID by default
            Customer = new Customer(new Guid()); // Initialize Customer object
        }
    }
}
