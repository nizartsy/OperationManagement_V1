using System.IO;
using System.Text;
using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Helper;
using OperationManagement_UI.Interface;

namespace OperationManagement_UI.ViewModel
{
	public class JobCardMainViewModel : ViewModelBase
	{
		private readonly IDataAdapter _dataAdapter;

		public JobCardViewModel? JobCardViewModel { get; }

		public ConsigneeDetailsViewModel? ConsigneeDetailsViewModel { get; }

		public ConsignmentDetailsViewModel? ConsignmentDetailsViewModel { get; }

		public ShipperDetailsViewModel? ShipperDetailsViewModel { get; }

		public CostDetailsViewModel? CostDetailsViewModel { get; }

		public SaleDetailsViewModel? SaleDetailsViewModel { get; }

		public TruckDetailsViewModel? TruckDetailsViewModel { get; }

		public JobCardMainViewModel(
			JobCardViewModel jobCardViewModel,
			ConsigneeDetailsViewModel consigneeDetailsViewModel,
			ConsignmentDetailsViewModel consignmentDetailsViewModel,
			ShipperDetailsViewModel shipperDetailsViewModel,
			TruckDetailsViewModel truckDetailsViewModel,
			SaleDetailsViewModel saleDetailsViewModel,
			CostDetailsViewModel costDetailsViewModel,
			IDataAdapter dataAdapter
			)
		{
			_dataAdapter = dataAdapter;

			JobCardViewModel = jobCardViewModel;

			ConsignmentDetailsViewModel = consignmentDetailsViewModel;

			ConsigneeDetailsViewModel = consigneeDetailsViewModel;
			ShipperDetailsViewModel = shipperDetailsViewModel;

			TruckDetailsViewModel = truckDetailsViewModel;
			SaleDetailsViewModel = saleDetailsViewModel;
			CostDetailsViewModel = costDetailsViewModel;

			SaveJobCard = new RelayCommand(SaveJobCardDetails);
		}

		private void SaveJobCardDetails(object jobCard)
		{
			var jsonString = new StringBuilder();

			jsonString = jsonString.Append(JobCardViewModel?.GetJsonString());
			jsonString = jsonString.Append(ConsigneeDetailsViewModel?.GetJsonString());
			jsonString = jsonString.Append(ConsignmentDetailsViewModel?.GetJsonString());
			jsonString = jsonString.Append(ShipperDetailsViewModel?.GetJsonString());
			jsonString = jsonString.Append(TruckDetailsViewModel?.GetJsonString());
			jsonString = jsonString.Append(SaleDetailsViewModel?.GetJsonString());
			jsonString = jsonString.Append(CostDetailsViewModel?.GetJsonString());

			_dataAdapter.FileName = Path.GetTempFileName();
			_dataAdapter.FilePath = Path.GetTempPath();

			_dataAdapter.SaveData(jsonString.ToString());
		}

		public JobCardMainViewModel(IDataAdapter dataAdapter)
		{
			_dataAdapter = dataAdapter;

			JobCardViewModel = new JobCardViewModel();

			ConsignmentDetailsViewModel = new ConsignmentDetailsViewModel();

			ShipperDetailsViewModel = new ShipperDetailsViewModel();
			ConsigneeDetailsViewModel = new ConsigneeDetailsViewModel();

			TruckDetailsViewModel = new TruckDetailsViewModel();
			CostDetailsViewModel = new CostDetailsViewModel();
			SaleDetailsViewModel = new SaleDetailsViewModel();


			SaveJobCard = new RelayCommand(SaveJobCardDetails);
		}

		#region Command

		public ICommand SaveJobCard { get; }
		#endregion

	}
}
