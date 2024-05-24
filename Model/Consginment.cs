namespace OperationManagement_UI.Model
{
    // Model class for Consignment
    public class Consignment
    {
        // Backing fields for properties

        // Origin of the consignment
        public string Origin { get; set; }

        // Destination of the consignment
        public string Destination { get; set; }

        // Number of items in the consignment
        public int NumberOfItems { get; set; }

        // Air Waybill (AWB) or Bill of the consignment
        public string AwbOrBill { get; set; }

        // Unique identifier for the consignment
        public Guid Id { get; set; }

        // Default constructor
        public Consignment()
        {
            // Initialize fields if needed
            Origin = string.Empty;
            Destination = string.Empty;
            NumberOfItems = 0;
            AwbOrBill = string.Empty;
            Id = new Guid();
        }

        // Parameterized constructor
        public Consignment(string origin, string destination, int numberOfItems, string awbOrBill, Guid id)
        {
            // Assign values from parameters to fields
            Origin = origin;
            Destination = destination;
            NumberOfItems = numberOfItems;
            AwbOrBill = awbOrBill;
            Id = id;
        }
    }
}