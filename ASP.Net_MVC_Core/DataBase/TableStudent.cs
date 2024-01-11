using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASP.Net_MVC_Core.DataBase
{
    
	public class TableStudent
	{
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<DateTime> birthday { get; set; }
        public int address_id { get; set; }
        public string address_full { get; set; }
    }
}

