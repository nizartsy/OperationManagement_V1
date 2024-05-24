using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using OperationManagement_UI.ViewModel;
using OperationManagement_UI.Views;

namespace OperationManagement_UI
{
	/// <summary>
	/// Interaction logic for JobCardMainView.xaml
	/// </summary>
	public partial class JobCardMainView : Window
	{
		public JobCardMainView()
		{
			InitializeComponent();
			this.DataContext = new JobCardMainViewModel();
		}
	}
}
