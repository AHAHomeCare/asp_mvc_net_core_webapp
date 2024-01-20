using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ASP.Net_MVC_Core.Lib
{
	public static class QueryStringHelper
	{
		

		public static List<string> GetQuerySegment(string str, string parameterName)
		{
			if (string.IsNullOrEmpty(str)) return null;
			//var urlQuery = str.Split("=");
			if (str.Split(parameterName).Count()  <= 1) return null;
			string url = HttpUtility.UrlDecode(str.Split(parameterName)[1]);
            var segment = url.Replace("=", "").Split("/").ToList();
			return segment.Where(s => s != string.Empty).ToList();
			
		}
	}
}

