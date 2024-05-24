using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OperationManagement_UI.ViewModel;

namespace OperationManagement_UI.Views
{
	/// <summary>
	/// Interaction logic for CostDetailsView.xaml
	/// </summary>
	public partial class CostDetailsView : UserControl
	{
		public CostDetailsView()
		{
			InitializeComponent();
			this.DataContext = new CostDetailsViewModel();
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			var vendorEntryPopup = new CostEntryPopupView();
			vendorEntryPopup.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			vendorEntryPopup.ShowDialog();
		}
	}
}
