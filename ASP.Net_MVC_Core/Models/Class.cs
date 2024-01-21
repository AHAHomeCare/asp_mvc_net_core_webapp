using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Net_MVC_Core.Models
{
	public class Class
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
		public int status { get; set; }

		public Nullable<DateTime> created_at { get; set; }
		public string created_by { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        public string updated_by { get; set; }
    }
}

