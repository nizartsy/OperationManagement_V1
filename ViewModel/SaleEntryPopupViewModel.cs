using System.Collections.ObjectModel;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
	public class SaleEntryPopupViewModel : ViewModelBase
	{
		private string _particular;
		private int _quantity;
		private int _unit;
		private double _amount;
		private double _total;
		private Guid _id;

		// Property for Particular
		public string Particular
		{
			get => _particular;
			set => SetValue(ref _particular, value, nameof(Particular));
		}

		// Property for Quantity
		public int Quantity
		{
			get => _quantity;
			set => SetValue(ref _quantity, value, nameof(Quantity));
		}

		// Property for Unit
		public int Unit
		{
			get => _unit;
			set => SetValue(ref _unit, value, nameof(Unit));
		}

		// Property for Amount
		public double Amount
		{
			get => _amount;
			set => SetValue(ref _amount, value, nameof(Amount));
		}

		// Property for Total
		public double Total
		{
			get => _total;
			set => SetValue(ref _total, value, nameof(Total));
		}

		// Property for ID
		public Guid Id
		{
			get => _id;
			set => SetValue(ref _id, value, nameof(Id));
		}


		private readonly ObservableCollection<SaleDetails> _saleDetailsCollection;


		//Command

		public ICommand SaveSaleDetailsCommand {get;}
		public ICommand ClearFieldCommand {get;}
		// Default constructor
		public SaleEntryPopupViewModel(ObservableCollection<SaleDetails> saleDetailsCollection, SaleDetails saleDetails)
		{
			_saleDetailsCollection = saleDetailsCollection;

			// Initialize fields if needed
			_particular = saleDetails.Particular;
			_quantity = saleDetails.Quantity;
			_unit = saleDetails.Unit;
			_amount = saleDetails.Amount;
			_total = saleDetails.Total;
			_id = saleDetails.Id;


			SaveSaleDetailsCommand = new RelayCommand(SaveSaleDetails);
			ClearFieldCommand = new RelayCommand(ClearFields);
		}

		private void ClearFields(object obj)
		{
			Particular = string.Empty;
			Quantity = 0;
			Unit = 0;
			Amount = 0;
			Total = 0;
			Id = new Guid();
		}

		private void SaveSaleDetails(object obj)
		{
			var saleDetails = new SaleDetails(_particular, _quantity, _unit, _amount, _total, _id);
			_saleDetailsCollection.Add(saleDetails);
		}
	}
}
