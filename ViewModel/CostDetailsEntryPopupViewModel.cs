using System.Collections.ObjectModel;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
   public class CostDetailsEntryPopupViewModel : ViewModelBase
    {
	    private Vendor? _vendor;
	    private int? _quantity;
	    private int? _unit;
	    private double? _amount;
	    private double? _total;
	    private Guid _id;

	    private ObservableCollection<CostDetails> _costDetailsCollection;

		// Property for Particular
		public Vendor? Vendor
	    {
		    get => _vendor;
		    set => SetValue(ref _vendor, value, nameof(Vendor));
	    }

	    // Property for Quantity
	    public int? Quantity
	    {
		    get => _quantity;
		    set => SetValue(ref _quantity, value, nameof(Quantity));
	    }

		// Property for Unit
		public int? Unit
	    {
		    get => _unit;
		    set => SetValue(ref _unit, value, nameof(Unit));
	    }

		// Property for Amount
		public double? Amount
	    {
		    get => _amount;
		    set => SetValue(ref _amount, value, nameof(Amount));
	    }

		// Property for Total
		public double? Total
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

	    public ICommand SaveCostDetailsCommand { get; }
	    public ICommand ClearCostDetailsFieldCommand { get; }

	    // Default constructor
	    public CostDetailsEntryPopupViewModel(ObservableCollection<CostDetails> costDetailsCollection, CostDetails costDetails)
	    {
		    _costDetailsCollection = costDetailsCollection;
		    // Initialize fields if needed
		    _vendor = costDetails.Vendor;
		    _quantity = costDetails.Quantity; // Default quantity
		    _unit = costDetails?.Unit;
		    _amount = costDetails?.Amount;
		    _total = costDetails?.Total;
		    _id = Guid.NewGuid(); // Assign a new unique ID by default

		    SaveCostDetailsCommand = new RelayCommand(SaveCostDetails);
		    ClearCostDetailsFieldCommand = new RelayCommand(ClearFields);
	    }

	    private void ClearFields(object obj)
	    {
		    Vendor = new Vendor(new Guid(), null, null);
		    Quantity = 0;
		    Unit = 0;
		    Amount = 0;
		    Total = 0;
		    Id = new Guid();
	    }

	    private void SaveCostDetails(object obj)
	    {
			var costDetails = new CostDetails(_vendor, _quantity, _unit, _amount, _total, _id);
			_costDetailsCollection.Add(costDetails);
		}
    }
}
