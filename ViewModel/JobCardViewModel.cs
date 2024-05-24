using Newtonsoft.Json;
using OperationManagement_UI.Model; // Import necessary namespace

namespace OperationManagement_UI.ViewModel
{
	// ViewModel class for JobCard
	public class JobCardViewModel : ViewModelBase
	{
		// Private fields
		private string? _jobCardNumber;
		private DateTime _jobCardCreatedDate;
		private DateTime _jobCardModifiedDate;
		private long? _jobNumber;
		private Customer? _customer;
		private Attention _selectedAttention;
		private JobCardStatus _jobCardStatus;

		// Readonly field for the original JobCard object
		private readonly JobCard _jobCard;

		// Property for JobCardNumber
		public string? JobCardNumber
		{
			get { return _jobCardNumber; }
			set => SetValue(ref _jobCardNumber, value, nameof(JobCardNumber)); // Set value and invoke OnPropertyChanged
		}

		// Property for JobCardCreatedDate
		public DateTime JobCardCreatedDate
		{
			get { return _jobCardCreatedDate; }
			set => SetValue(ref _jobCardCreatedDate, value, nameof(JobCardCreatedDate)); // Set value and invoke OnPropertyChanged
		}

		// Property for JobCardModifiedDate
		public DateTime JobCardModifiedDate
		{
			get { return _jobCardModifiedDate; }
			set => SetValue(ref _jobCardModifiedDate, value, nameof(JobCardModifiedDate)); // Set value and invoke OnPropertyChanged
		}

		// Property for JobNumber
		public long? JobNumber
		{
			get { return _jobNumber; }
			set => SetValue(ref _jobNumber, value, nameof(JobNumber)); // Set value and invoke OnPropertyChanged
		}

		// Property for Customer
		public Customer? Customer
		{
			get { return _customer; }
			set => SetValue(ref _customer, value, nameof(Customer)); // Set value and invoke OnPropertyChanged
		}

		//Property for SelectedAttention

		public Attention SelectedAttention
		{
			get { return _selectedAttention; }
			set => SetValue(ref _selectedAttention, value, nameof(SelectedAttention));
		}

		//Property for JobCardStatus

		public JobCardStatus JobCardStatus
		{
			get { return _jobCardStatus; }
			set => SetValue(ref _jobCardStatus, value, nameof(JobCardStatus));
		}
		// Default constructor
		public JobCardViewModel()
		{
			_jobCard = new JobCard();
			// Assign default values in constructor
			JobCardNumber = string.Empty;
			JobCardCreatedDate = DateTime.Now;
			JobCardModifiedDate = DateTime.Now;
			JobNumber = null;
			Customer = new Customer(new Guid())
			{
				Attentions = new List<Attention>()
				{
					new Attention("Mac"),
					new Attention("John"),
					new Attention("David")
				}
			};
			JobCardStatus = JobCardStatus.Created;
		}

		// Parameterized constructor
		public JobCardViewModel(JobCard jobCard)
		{
			_jobCard = jobCard;
			// Assign values from the provided jobCard parameter
			JobCardNumber = jobCard.JobCardNumber;
			JobCardCreatedDate = jobCard.JobCardCreatedDate;
			JobCardModifiedDate = jobCard.JobCardModifiedDate;
			JobNumber = jobCard.JobNumber;
			Customer = jobCard.Customer;
			JobCardStatus = jobCard.JobCardStatus;
		}

		public string GetJsonString()
		{
			_jobCard.Customer = this.Customer;
			_jobCard.Customer.SelectedAttention = SelectedAttention;
			_jobCard.JobCardNumber = this.JobCardNumber;
			_jobCard.JobCardStatus = this.JobCardStatus;

			var jsonString  = JsonConvert.SerializeObject(_jobCard);
			return jsonString;
		}
	}
}
