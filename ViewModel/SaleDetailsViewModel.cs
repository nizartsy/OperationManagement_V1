using System.Collections.ObjectModel;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;
using OperationManagement_UI.Views;

namespace OperationManagement_UI.ViewModel
{
	public class SaleDetailsViewModel : ViewModelBase
	{
		private int _slNO;
		public int SLNO
		{
			get => _slNO;
			set => SetValue(ref _slNO, value, nameof(SLNO));
		}

		private ObservableCollection<SaleDetails> _salesEntryPopupViewModel;

		public ObservableCollection<SaleDetails> SaleEntryPopupViewModel
		{
			get => _salesEntryPopupViewModel;
			set => SetValue(ref _salesEntryPopupViewModel, value, nameof(SaleEntryPopupViewModel));
		}


		//command

		public ICommand OpenSaleDetailsPopupCommand { get; }
		public ICommand EditSaleDetailsCommand { get; }
		public ICommand DeleteSaleDetailsCommand { get; }
		// Default constructor
		public SaleDetailsViewModel()
		{
			// Initialize the ObservableCollection
			SaleEntryPopupViewModel = new ObservableCollection<SaleDetails>
			{
				new("Hire Small Truck", 1, 2, 20, 40, new Guid()),
				new("Hire Dyna Truck", 1, 3, 20, 60, new Guid())
			};

			OpenSaleDetailsPopupCommand = new RelayCommand(OpenSaleDetailsEntryPopup);
			EditSaleDetailsCommand = new RelayCommand(EditSaleDetails);
			DeleteSaleDetailsCommand = new RelayCommand(DeleteSaleDetails);
		}

		private void DeleteSaleDetails(object obj)
		{
			if (obj is SaleDetails saleDetail)
				_salesEntryPopupViewModel.Remove(saleDetail);
		}

		private void EditSaleDetails(object obj)
		{
			if (obj is not SaleDetails saleDetail) return;

			var saleEntryPopupWindow = new SaleEntryPopupView(SaleEntryPopupViewModel, saleDetail);
			saleEntryPopupWindow.ShowDialog();
		}

		private void OpenSaleDetailsEntryPopup(object obj)
		{
			var saleEntryPopupWindow = new SaleEntryPopupView(SaleEntryPopupViewModel,
				new SaleDetails(string.Empty, 0, 0, 0, 0, new Guid()));

			saleEntryPopupWindow.ShowDialog();
		}
	}
}
