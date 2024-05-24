using System.Collections.ObjectModel;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
	public class TruckDetailsEntryPopupViewModel : ViewModelBase
	{
		// Backing fields for properties
		private TruckType _truckType;
		private int _quantity;
		private string _plateNumber;
		private string _name;
		private Vendor _vendor;
		private string _mobile;
		private string _driverId;
		private Guid _id;

		private ObservableCollection<TruckDetails> _truckDetailsCollection;

		public TruckDetails TruckDetails { get; set; }

		// Property for TruckType
		public TruckType TruckType
		{
			get => _truckType;
			set => SetValue(ref _truckType, value, nameof(TruckType));
		}

		// Property for Quantity
		public int Quantity
		{
			get => _quantity;
			set => SetValue(ref _quantity, value, nameof(Quantity));
		}

		// Property for PlateNumber
		public string PlateNumber
		{
			get => _plateNumber;
			set => SetValue(ref _plateNumber, value, nameof(PlateNumber));
		}

		// Property for Name
		public string Name
		{
			get => _name;
			set => SetValue(ref _name, value, nameof(Name));
		}

		// Property for Vendor
		public Vendor Vendor
		{
			get => _vendor;
			set => SetValue(ref _vendor, value, nameof(Vendor));
		}

		// Property for Mobile
		public string Mobile
		{
			get => _mobile;
			set => SetValue(ref _mobile, value, nameof(Mobile));
		}

		// Property for DriverId
		public string DriverId
		{
			get => _driverId;
			set => SetValue(ref _driverId, value, nameof(DriverId));
		}

		// Property for ID
		public Guid Id
		{
			get => _id;
			set => SetValue(ref _id, value, nameof(Id));
		}

		//Command

		public ICommand SaveTruckDetailsCommand { get; }
		public ICommand ClearTruckDetailsCommand { get; }

		// constructor
		public TruckDetailsEntryPopupViewModel(ObservableCollection<TruckDetails> truckDetailsCollection, TruckDetails truckDetails)
		{
			_truckType = truckDetails.TruckType;
			_quantity = truckDetails.Quantity;
			_plateNumber = truckDetails.PlateNumber;
			_name = truckDetails.Name;
			_vendor = truckDetails.Vendor;
			_mobile = truckDetails.Mobile;
			_driverId = truckDetails.DriverId;
			_id = truckDetails.Id;

			SaveTruckDetailsCommand = new RelayCommand(SaveTruckDetails);
			ClearTruckDetailsCommand = new RelayCommand(ClearFields);
			_truckDetailsCollection = truckDetailsCollection;
			TruckDetails = truckDetails;
		}

		private void ClearFields(object obj)
		{
			TruckType = TruckType.Small;
			Quantity = 1;
			PlateNumber = string.Empty;
			Name = string.Empty;
			Vendor = new Vendor(new Guid(), null, null);
			Mobile = string.Empty;
			DriverId = string.Empty;
			Id = new Guid();
		}

		private void SaveTruckDetails(object obj)
		{
			var truckDetails = new TruckDetails()
			{
				TruckType = _truckType,
				Quantity = _quantity,
				PlateNumber = _plateNumber,
				Name = _name,
				Vendor = _vendor,
				Mobile = _mobile,
				DriverId = _driverId,
				Id = _id
			};

			_truckDetailsCollection.Add(truckDetails);
		}


	}
}
