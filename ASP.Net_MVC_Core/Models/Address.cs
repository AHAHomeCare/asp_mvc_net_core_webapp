using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Net_MVC_Core.Models
{
	public class Address
	{
		[Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
		public int province_id { get; set; }
		public string province_name { get; set; }
		public int district_id { get; set; }
		public string district_name { get; set; }
		public int ward_id { get; set; }
		public string ward_name { get; set; }
		public string number { get; set; }
		public int status { get; set; }
        public Nullable<DateTime> created_at { get; set; }
        public string created_by { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        
    }
}

