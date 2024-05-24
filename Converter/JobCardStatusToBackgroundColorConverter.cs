
using System.Globalization;
using System.Windows.Data;
using OperationManagement_UI.Model;

namespace OperationManagement_UI.Converter
{
	public class JobCardStatusToBackgroundColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is JobCard jobCard)
			{
				return jobCard.JobCardStatus switch
				{
					JobCardStatus.Created => "#4da6ff", // Color for Created status
					JobCardStatus.Delivered => "#6fdd8a", // Color for Delivered, InvoicePrepared, and Posted statuses
					JobCardStatus.InvoicePrepared => "#34cae5",// Color for Delivered, InvoicePrepared, and Posted statuses
					JobCardStatus.Posted => "#ffca1a", // Color for Delivered, InvoicePrepared, and Posted statuses
					_ => "#98a6b3"
				};
			}

			return "#98a6b3"; // Default color if value is not a JobCard instance

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return Binding.DoNothing;
		}
	}
}
