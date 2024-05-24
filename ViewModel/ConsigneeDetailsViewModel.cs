using Newtonsoft.Json;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
    public class ConsigneeDetailsViewModel : ViewModelBase
    {
        // Backing fields for properties
        private Guid _id;
        private Customer _customer;
        private string _additionalNote;

        private readonly Consignee _consignee;

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

        public string AdditionalNote
        {
            get { return _additionalNote; }
            set => SetValue(ref _additionalNote, value, nameof(AdditionalNote));
        }

        // Default constructor
        public ConsigneeDetailsViewModel()
        {
            _consignee = new Consignee();
            // Initialize fields if needed
            _id = Guid.NewGuid(); // Assign a new unique ID by default
            _customer = new Customer(new Guid()); // Initialize Customer object
        }

        public ConsigneeDetailsViewModel(Consignee consignee)
        {
            _consignee = consignee;
            _id = _consignee.ID;
            _customer = _consignee.Customer;
            _additionalNote = _consignee.AdditionalNote;
        }

        public string GetJsonString()
        {
            _consignee.Customer = this.Customer;
            _consignee.AdditionalNote = this.AdditionalNote;

            var jsonString = JsonConvert.SerializeObject(_consignee);
            return jsonString;
        }
    }
}
