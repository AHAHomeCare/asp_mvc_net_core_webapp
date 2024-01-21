using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Net_MVC_Core.Models
{
	public class StudentCalendar
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("subject_id")]
        public int subject_id { get; set;}

		[NotMapped]
		public Subject Subject { get; set; }

        [ForeignKey("student_id")]
        public int student_id { get; set; }

		[NotMapped]
		public  Student Student { get; set; }

		public DateTime date { get; set; }
		public int status { get; set; }
		public string created_by { get; set; }
		public DateTime created_at { get; set; }

	}
}

