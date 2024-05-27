using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationManagement_UI.Interface;

namespace OperationManagement_UI.Core
{
	public class DataAdapter : IDataAdapter
	{
		public string? FilePath { get; set; }

		public string? FileName { get; set; }

		public async void SaveData(string data)
		{
			if (FilePath == null) return;

			if (!File.Exists(FilePath))
					Directory.CreateDirectory(FilePath);

			if (FileName == null) return;
			var path = Path.Combine(FilePath, FileName);

			await File.WriteAllTextAsync(path, data).ConfigureAwait(false);
		}

		public DataAdapter()
		{

		}
	}
}
