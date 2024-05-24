using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OperationManagement_UI.ViewModel;

namespace OperationManagement_UI.Helper
{
	public static class JsonHelper
	{
		public static string GenerateJson(object model)
		{
			if (model is null) return JsonConvert.Null;

			return JsonConvert.SerializeObject(model);
		}

		public static object? GenerateObjectFromJson<T>(string json)
		{
			if (string.IsNullOrEmpty(json)) return null;

			var obj = JsonConvert.DeserializeObject(json);

			if (obj is T expectedType)
			{
				return expectedType;
			}

			return null;
		}

	}
}
