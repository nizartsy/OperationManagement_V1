using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OperationManagement_UI.Views;

namespace OperationManagement_UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var jobCardView = new JobCardMainView();
			jobCardView.ShowDialog();
		}

		private void View_Entries(object sender, RoutedEventArgs e)
		{
			var entryView = new EntryView();
			entryView.ShowDialog();
		}

		private void ViewReport_Click(object sender, RoutedEventArgs e)
		{
			var reportView = new ReportView();
			reportView.ShowDialog();
		}

		private void View_Dashboard(object sender, RoutedEventArgs e)
		{
			var dashBoard = new DashboardView();
			dashBoard.ShowDialog();
        }
    }
}