namespace OperationManagement_UI.Model
{
    using System;

    public class Consignee
    {
	    // Property for ID
        public Guid ID { get; set; }

        // Property for Customer
        public Customer Customer { get; set; }

        public string AdditionalNote { get; set; }

        // Default constructor
        public Consignee()
        {
            // Initialize fields if needed
            ID = Guid.NewGuid(); // Assign a new unique ID by default
            Customer = new Customer(new Guid()); // Initialize Customer object
        }
    }

}