namespace OperationManagement_UI.ViewModel
{
   public class CostDetailsEntryPopupViewModel : ViewModelBase
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

	    // Default constructor
	    public CostDetailsEntryPopupViewModel()
	    {
		    // Initialize fields if needed
		    _particular = "Hire Truck"; // Default truck type
		    _quantity = 1; // Default quantity
		    _unit = 2;
		    _amount = 20;
		    _total = 40;
		    _id = Guid.NewGuid(); // Assign a new unique ID by default
	    }
	}
}
