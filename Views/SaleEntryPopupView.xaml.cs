using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using OperationManagement_UI.Model;
using OperationManagement_UI.ViewModel;

namespace OperationManagement_UI.Views
{
	/// <summary>
	/// Interaction logic for SaleEntryPopupView.xaml
	/// </summary>
	public partial class SaleEntryPopupView : Window
	{
		public SaleEntryPopupView()
		{
			InitializeComponent();
		}

		public SaleEntryPopupView(ObservableCollection<SaleDetails> saleDetailsCollection, SaleDetails saleDetails)
		{
			InitializeComponent();
			this.DataContext = new SaleEntryPopupViewModel(saleDetailsCollection, saleDetails);
		}
	}
}
