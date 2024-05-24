using Newtonsoft.Json;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
    public class ShipperDetailsViewModel : ViewModelBase
    {
        // Backing fields for properties
        private Guid _id;
        private Customer _customer;
        private string? _additionalNote;

        private readonly Shipper? _shipper;

        // Property for ID
        public Guid ID
        {
            get { return _id; }
            set => SetValue(ref _id, value, nameof(ID));
        }

        // Property for Customer
        public Customer Customer
        {
            get { return _customer; }
            set => SetValue(ref _customer, value, nameof(Customer));
        }

        public string? AdditionalNote
        {
            get { return _additionalNote; }
            set => SetValue(ref _additionalNote, value, nameof(AdditionalNote));
        }

        // Default constructor
        public ShipperDetailsViewModel()
        {
            // Initialize fields if needed
            _id = Guid.NewGuid(); // Assign a new unique ID by default
            _customer = new Customer(new Guid()); // Initialize Customer object
        }
        public ShipperDetailsViewModel(Shipper? shipper)
        {
            _shipper = shipper;
            _id = shipper.Id;
            _customer = shipper.Customer;
            _additionalNote = shipper.AdditionalNote;
        }

        public string GetJsonString()
        {
            _shipper.Customer = this.Customer;
            _shipper.AdditionalNote = this.AdditionalNote;

            var jsonString = JsonConvert.SerializeObject(_shipper);
            return jsonString;
        }
    }
}
