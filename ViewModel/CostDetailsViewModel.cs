using System.Collections.ObjectModel;

namespace OperationManagement_UI.ViewModel
{
	public class CostDetailsViewModel : ViewModelBase
	{
		private int _slNO;
		public int SLNO
		{
			get { return _slNO; }
			set => SetValue(ref _slNO, value, nameof(SLNO));
		}

		private ObservableCollection<CostDetailsEntryPopupViewModel> _costDetailsEntryPopupViewModel;

		public ObservableCollection<CostDetailsEntryPopupViewModel> CostDetailsEntryPopupViewModel
		{
			get { return _costDetailsEntryPopupViewModel; }
			set => SetValue(ref _costDetailsEntryPopupViewModel, value, nameof(CostDetailsEntryPopupViewModel));
		}

		// Default constructor
		public CostDetailsViewModel()
		{
			// Initialize the ObservableCollection
			CostDetailsEntryPopupViewModel = new ObservableCollection<CostDetailsEntryPopupViewModel>();

			CostDetailsEntryPopupViewModel.Add(new CostDetailsEntryPopupViewModel
			{
				Particular = "Hire Small Truck",
				Quantity = 1,
				Unit = 2,
				Amount = 20,
				Total = 40,
				Id = Guid.NewGuid()
			});

			CostDetailsEntryPopupViewModel.Add(new CostDetailsEntryPopupViewModel
			{
				Particular = "Hire Dyna Truck",
				Quantity = 1,
				Unit = 4,
				Amount = 20,
				Total = 80,
				Id = Guid.NewGuid()
			});
		}
	}
}
