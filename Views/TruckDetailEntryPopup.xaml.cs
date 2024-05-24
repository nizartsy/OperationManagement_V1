using System.Collections.ObjectModel;
using System.Windows;
using OperationManagement_UI.Model;
using OperationManagement_UI.ViewModel;

namespace OperationManagement_UI.Views
{
	/// <summary>
	/// Interaction logic for TruckDetailEntryPopup.xaml
	/// </summary>
	public partial class TruckDetailEntryPopup : Window
	{
		public TruckDetailEntryPopup()
		{
			InitializeComponent();
			
		}

		public TruckDetailEntryPopup(ObservableCollection<TruckDetails> truckDetailsCollection, TruckDetails truckDetails)
		{
			InitializeComponent();
			this.DataContext = new TruckDetailsEntryPopupViewModel(truckDetailsCollection, truckDetails);
		}
	}
}
