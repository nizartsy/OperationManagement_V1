using System.Windows.Input;
using OperationManagement_UI.Command;
using OperationManagement_UI.Helper;

namespace OperationManagement_UI.ViewModel
{
	public class JobCardMainViewModel : ViewModelBase
	{
		public JobCardViewModel JobCardViewModel { get; }
		public ConsigneeDetailsViewModel ConsigneeDetailsViewModel { get; }
		public ConsignmentDetailsViewModel ConsignmentDetailsViewModel { get; }
		public ShipperDetailsViewModel ShippingDetailsViewModel;
		public CostDetailsViewModel CostDetailsViewModel { get; }
		public SaleDetailsViewModel SaleDetailsViewModel { get; }

		public TruckDetailsViewModel TruckDetailsViewModel;
		private TruckDetailsViewModel _truckDetails;
		public TruckDetailsViewModel TruckDetails
		{
			get => _truckDetails;
			set => SetValue(ref _truckDetails, value, nameof(TruckDetails));
		}

		public JobCardMainViewModel(
			JobCardViewModel jobCardViewModel, 
			ConsigneeDetailsViewModel consigneeDetailsViewModel, 
			ConsignmentDetailsViewModel consignmentDetailsViewModel,
			ShipperDetailsViewModel shipperDetailsViewModel, 
			TruckDetailsViewModel truckDetailsViewModel, 
			TruckDetailsViewModel truckDetails, 
			SaleDetailsViewModel saleDetailsViewModel,
			CostDetailsViewModel costDetailsViewModel
			)
		{
			JobCardViewModel = jobCardViewModel;
			ConsigneeDetailsViewModel = consigneeDetailsViewModel;
			ConsignmentDetailsViewModel = consignmentDetailsViewModel;
			ShippingDetailsViewModel = shipperDetailsViewModel;
			TruckDetailsViewModel = truckDetailsViewModel;
			SaleDetailsViewModel = saleDetailsViewModel;
			CostDetailsViewModel = costDetailsViewModel;
			_truckDetails = truckDetails;

			TruckDetails = new TruckDetailsViewModel();

			SaveJobCard = new RelayCommand(SaveJobCardDetails);
		}

		private void SaveJobCardDetails(object jobCard)
		{
			if (JobCardViewModel == null)
				return;

			var jobCardJson = JsonHelper.GenerateJson(JobCardViewModel);
			var consigneeJson = JsonHelper.GenerateJson(ConsigneeDetailsViewModel);
			var consignmentJson = JsonHelper.GenerateJson(ConsignmentDetailsViewModel);
			var shippingDetailsJson = JsonHelper.GenerateJson(ShippingDetailsViewModel);
			var truckDetails = JsonHelper.GenerateJson(TruckDetailsViewModel);
			var saleDetailsJson = JsonHelper.GenerateJson(SaleDetailsViewModel);
			var costDetailsJson = JsonHelper.GenerateJson(CostDetailsViewModel);
		}

		public JobCardMainViewModel()
		{
			ConsigneeDetailsViewModel = new ConsigneeDetailsViewModel();
			ConsignmentDetailsViewModel = new ConsignmentDetailsViewModel();
			ShippingDetailsViewModel = new ShipperDetailsViewModel();
			TruckDetailsViewModel = new TruckDetailsViewModel();
			JobCardViewModel = new JobCardViewModel();
			TruckDetails = new TruckDetailsViewModel();

			SaveJobCard = new RelayCommand(SaveJobCardDetails);
		}

		#region Command

		public ICommand SaveJobCard { get; }
		#endregion

	}
}
