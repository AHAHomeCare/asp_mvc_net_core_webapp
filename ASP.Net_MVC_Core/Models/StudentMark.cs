using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Net_MVC_Core.Models
{
	public class StudentMark
	{
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("student_id")]
        public string student_id { get; set; }
        public virtual Student student { get; set; }

        [ForeignKey("subject_id")]
        public string subject_id { get; set; }
        public virtual Subject subject { get; set; }

        [Column(TypeName = "decimal(2, 2)")]
        public decimal mark { get; set; }
        public int status { get; set; }
        public Nullable<DateTime> created_at { get; set; }
        public string created_by { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        public string updated_by { get; set; }
    }
}

