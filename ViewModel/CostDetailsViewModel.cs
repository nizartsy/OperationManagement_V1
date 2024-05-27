using System.Collections.ObjectModel;
using System.Windows.Input;
using Newtonsoft.Json;
using OperationManagement_UI.Command;
using OperationManagement_UI.Model;
using OperationManagement_UI.Views;

namespace OperationManagement_UI.ViewModel
{
	public class CostDetailsViewModel : ViewModelBase
	{
		private ObservableCollection<CostDetails>? _costDetailsCollection;

		public ObservableCollection<CostDetails>? CostDetailsCollection
		{
			get => _costDetailsCollection;
			set => SetValue(ref _costDetailsCollection, value, nameof(CostDetailsCollection));
		}

		// Default constructor
		public CostDetailsViewModel()
		{
			// Initialize the ObservableCollection
			CostDetailsCollection = new ObservableCollection<CostDetails>
			{
				new(new Vendor(new Guid(),"ABC RoadWays",null),1,2,20,40,Guid.NewGuid()),
				new(new Vendor(new Guid(),"ABC RoadWays",null),1,4,20,80,Guid.NewGuid())
			};

			OpenCostEditPopupWindowCommand = new RelayCommand(OpenCostEditPopup);
			EditCostDetailsCommand = new RelayCommand(EditCostDetails);
			DeleteCostDetailsCommand = new RelayCommand(DeleteCostDetails);
		}

		private void DeleteCostDetails(object obj)
		{
			if (obj is CostDetails costDetails)
			{
				_costDetailsCollection?.Remove(costDetails);
			}
		}

		private void EditCostDetails(object obj)
		{
			if (obj is not CostDetails costDetails) return;

			var costDetailsWindow = new CostEntryPopupView(_costDetailsCollection, costDetails);
			costDetailsWindow.ShowDialog();
		}

		private void OpenCostEditPopup(object obj)
		{
			var costDetailsWindow = new CostEntryPopupView(_costDetailsCollection,new CostDetails());
			costDetailsWindow.ShowDialog();
		}

		public ICommand OpenCostEditPopupWindowCommand { get; }
		public ICommand EditCostDetailsCommand { get; }
		public ICommand DeleteCostDetailsCommand { get; }

		public string GetJsonString()
		{
			return _costDetailsCollection != null ? JsonConvert.SerializeObject(_costDetailsCollection) : string.Empty;
		}

		public void GetObjectFromString(string jsonString)
		{
			var costDetailsCollection = JsonConvert.DeserializeObject(jsonString);

			if (costDetailsCollection is not ObservableCollection<CostDetails> costDetailsViewModel) return;

			_costDetailsCollection = new ObservableCollection<CostDetails>(costDetailsViewModel);
		}
	}
}
