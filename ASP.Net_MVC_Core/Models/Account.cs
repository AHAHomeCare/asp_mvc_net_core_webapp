using System;
using System.ComponentModel.DataAnnotations;
namespace ASP.Net_MVC_Core.Models
{
	public class Account
	{
		[Key]
		public int id { get; set; }
		public string user_name { get; set; }
		public string password { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public int status { get; set; }
		public Nullable<DateTime> created_at { get; set; }
		public string created_by { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        public string updated_by { get; set; }
    }
}

