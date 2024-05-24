using System.Collections.ObjectModel;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;
using OperationManagement_UI.Views;

namespace OperationManagement_UI.ViewModel
{
	public class TruckDetailsViewModel : ViewModelBase
	{
		private int _slNo;
		public int Slno
		{
			get => _slNo;
			set => SetValue(ref _slNo, value, nameof(Slno));
		}

		private ObservableCollection<TruckDetails>? _truckDetailsCollection;

		public ObservableCollection<TruckDetails>? TruckDetailsEntryPopupViewModel
		{
			get => _truckDetailsCollection;
			set => SetValue(ref _truckDetailsCollection, value, nameof(TruckDetailsEntryPopupViewModel));
		}


		public ICommand TruckDetailsEntryPopupCommand { get; }
		public ICommand EditTruckDetailsCommand { get; }
		public ICommand DeleteTruckDetailsCommand { get; }

		// Default constructor
		public TruckDetailsViewModel()
		{

			TruckDetailsEntryPopupCommand =
				new RelayCommand(OpenTruckDetailsEntryPopup);

			EditTruckDetailsCommand =
				new RelayCommand(EditTruckDetails);

			DeleteTruckDetailsCommand =
				new RelayCommand(DeleteTruckDetails);

			// Initialize the ObservableCollection
			TruckDetailsEntryPopupViewModel = new ObservableCollection<TruckDetails>
			{
				new()
				{
					TruckType = TruckType.Small,
					Quantity = 1,
					PlateNumber = "ABC123",
					Name = "John Doe",
					Vendor = new Vendor( new Guid(),"Vendor X","12-985-5654"),
					Mobile = "123-456-7890",
					DriverId = "D123",
					Id = Guid.NewGuid()
				},
				new()
				{
					TruckType = TruckType.Medium,
					Quantity = 2,
					PlateNumber = "DEF456",
					Name = "Jane Doe",
					Vendor = new Vendor( new Guid(),"Vendor X","12-985-5654"),
					Mobile = "987-654-3210",
					DriverId = "D456",
					Id = Guid.NewGuid()
				}
			};
		}

		private void DeleteTruckDetails(object obj)
		{
			if (obj is TruckDetails truckDetails)
			{
				_truckDetailsCollection?.Remove(truckDetails);
			}
		}

		private void EditTruckDetails(object obj)
		{
			if (obj is not TruckDetails truckDetails) return;

			if (_truckDetailsCollection == null) return;

			var truckDetailsWindow = new TruckDetailEntryPopup(_truckDetailsCollection, truckDetails);
			truckDetailsWindow.ShowDialog();
		}

		private void OpenTruckDetailsEntryPopup(object obj)
		{
			if (_truckDetailsCollection == null) return;

			var truckDetailsWindow = new TruckDetailEntryPopup(_truckDetailsCollection, new TruckDetails());
			truckDetailsWindow.ShowDialog();
		}
	}
}
