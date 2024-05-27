using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationManagement_UI.Interface
{
	public interface IDataAdapter
	{

		string? FilePath {get; set; }

		string? FileName {get; set; }
		void SaveData(string data);
	}
}
