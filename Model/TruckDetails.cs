namespace OperationManagement_UI.Model
{
    public enum TruckType
    {
        Small,
        Medium,
        Large
    }

    public class TruckDetails
    {
	    // Property for TruckType
        public TruckType TruckType { get; set; }

        // Property for Quantity
        public int Quantity { get; set; }

        // Property for PlateNumber
        public string PlateNumber { get; set; }

        // Property for Name
        public string Name { get; set; }

        // Property for Vendor
        public Vendor Vendor { get; set; }

        // Property for Mobile
        public string Mobile { get; set; }

        // Property for DriverId
        public string DriverId { get; set; }

        // Property for ID
        public Guid Id { get; set; }

        // Default constructor
        public TruckDetails()
        {
            // Initialize fields if needed
            TruckType = TruckType.Small; // Default truck type
            Quantity = 1; // Default quantity
            PlateNumber = string.Empty;
            Name = string.Empty;
            Vendor = new Vendor(new Guid(), null, null); // Initialize Vendor object
            Mobile = string.Empty;
            DriverId = string.Empty;
            Id = Guid.NewGuid(); // Assign a new unique ID by default
        }
    }

    public class Vendor
    {
	    public Vendor(Guid id, string? name, string? contactNumber)
	    {
		    Id = id;
		    Name = name;
		    ContactNumber = contactNumber;
	    }

	    public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ContactNumber { get; set; }
    }
}
