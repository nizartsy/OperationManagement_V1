using Newtonsoft.Json;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
	public class ConsignmentDetailsViewModel : ViewModelBase
	{
		// Backing fields for properties
		private string _origin;
		private string _destination;
		private int _numberOfItems;
		private string _awbOrBill;
		private Guid _id;

		private readonly Consignment _consignment;

		// Property for Origin
		public string Origin
		{
			get { return _origin; }
			set => SetValue(ref _origin, value, nameof(Origin));
		}

		// Property for Destination
		public string Destination
		{
			get { return _destination; }
			set => SetValue(ref _destination, value, nameof(Destination));
		}

		// Property for NumberOfItems
		public int NumberOfItems
		{
			get { return _numberOfItems; }
			set => SetValue(ref _numberOfItems, value, nameof(NumberOfItems));
		}

		// Property for AwbOrBill
		public string AwbOrBill
		{
			get { return _awbOrBill; }
			set => SetValue(ref _awbOrBill, value, nameof(AwbOrBill));
		}

		// Property for Id
		public Guid Id
		{
			get { return _id; }
			set => SetValue(ref _id, value, nameof(Id));
		}

		// Default constructor
		public ConsignmentDetailsViewModel()
		{
			_consignment = new Consignment();
			// Initialize fields if needed
			_origin = string.Empty;
			_destination = string.Empty;
			_numberOfItems = 0;
			_awbOrBill = string.Empty;
			_id = new Guid();
		}

		// Parameterized constructor
		public ConsignmentDetailsViewModel(Consignment consignment)
		{
			// Assign values from parameters to fields
			_consignment = consignment;
			_origin = _consignment.Origin;
			_destination = _consignment.Destination;
			_numberOfItems = _consignment.NumberOfItems;
			_awbOrBill = _consignment.AwbOrBill;
			_id = _consignment.Id;
		}

		public string GetJsonString()
		{
			//to do check if it update or create
			_consignment.AwbOrBill = this.AwbOrBill;
			_consignment.Destination = this.Destination;
			_consignment.NumberOfItems = this.NumberOfItems;
			_consignment.Origin = this.Origin;

			var jsonString = JsonConvert.SerializeObject(_consignment);
			return jsonString;
		}
	}
}
