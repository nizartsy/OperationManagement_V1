
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Interface;
using OperationManagement_UI.Views;

namespace OperationManagement_UI.ViewModel
{
	public class MainWindowViewModel : ViewModelBase
	{
		private readonly IDataAdapter _dataAdapter;


		//Command
		public ICommand OpenJobCardViewCommand { get; }
		public ICommand OpenEntryViewCommand { get; }
		public ICommand OpenReportViewCommand { get; }
		public ICommand OpenDashboardViewCommand { get; }
		public MainWindowViewModel(IDataAdapter dataAdapter)
		{
			_dataAdapter = dataAdapter;


			//Command initailization

			OpenJobCardViewCommand = new RelayCommand(OpenJobCardMainView);
			OpenEntryViewCommand = new RelayCommand(OpenEntryView);
			OpenReportViewCommand = new RelayCommand(OpenReportView);
			OpenDashboardViewCommand = new RelayCommand(OpenDashBoardView);
		}

		private void OpenDashBoardView(object obj)
		{
			var dashBoard = new DashboardView();
			dashBoard.ShowDialog();
		}

		private void OpenReportView(object obj)
		{
			var reportView = new ReportView();
			reportView.ShowDialog();
		}

		private void OpenEntryView(object obj)
		{
			var entryView = new EntryView();
			entryView.ShowDialog();
		}

		private void OpenJobCardMainView(object obj)
		{
			var jobCardMainView = new JobCardMainView()
			{
				DataContext = new JobCardMainViewModel(_dataAdapter)
			};

			jobCardMainView.ShowDialog();
		}


	}
}
