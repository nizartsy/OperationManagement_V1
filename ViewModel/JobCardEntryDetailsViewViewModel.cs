using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.ViewModel
{
	public class JobCardEntryDetailsViewViewModel : ViewModelBase
	{
		private int _slNO;
		public int SLNO
		{
			get { return _slNO; }
			set => SetValue(ref _slNO, value, nameof(SLNO));
		}

		private ObservableCollection<JobCard> _jobCards;

		public ObservableCollection<JobCard> JobCards
		{
			get { return _jobCards; }
			set => SetValue(ref _jobCards, value, nameof(JobCardViewModel));
		}

		public JobCardEntryDetailsViewViewModel()
		{
			JobCards = new ObservableCollection<JobCard>();

			for (var i = 0; i < 10; i++)
			{
				var status = (JobCardStatus)(i % 4); // Loop through the statuses cyclically

				var jobNumber = (long)1255224552 + i;
				var customer = new Customer(new Guid())
				{
					Name = "ABC Cargo",
					Address = "XYZ City Jiddha",
					Attentions = new List<Attention>()
					{
						new Attention("Sam John")
					},
				};

				var jobCard = new JobCard(jobNumber, customer, status)
				{
					JobCardNumber = $"{i + 1}/122/2025"
				};

				JobCards.Add(jobCard);

			}
		}
	}
}
