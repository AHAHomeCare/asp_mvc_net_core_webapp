using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ASP.Net_MVC_Core.Models
{

    public class Student
	{
		[Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
		public string student_code { get; set; }
		public string name { get; set; }
		public Nullable<DateTime> birthday { get; set; }
		public string cccd { get; set; }
		
		[NotMapped]
		public string address_full { get; set; }
		public int status { get; set; }
		public Nullable<DateTime> created_at { get; set; }
		public string created_by { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        public string updated_by { get; set; }
        [ForeignKey("address_id")]
        public int address_id { get; set; }
        public virtual Address address { get; set; }

		public virtual ICollection<StudentMark> StudentMarks { get; set; }

		public Student()
		{
			this.id = 0;
			this.student_code = string.Empty;
			this.name = string.Empty;
			this.birthday = new DateTime(1900, 01, 01);
			this.cccd = string.Empty;
			this.address_id = 0;
			this.address_full = string.Empty;
		}

        public Student(int id)
        {
            this.id = 0;
            this.name = string.Empty;
            this.birthday = new DateTime(1900, 01, 01);
            this.address_id = 0;
            this.address_full = string.Empty;
        }
    }
}

