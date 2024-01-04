using System;
namespace ASP.Net_MVC_Core.Models
{
	public class Student
	{
		public int id { get; set; }
		public string name { get; set; }
		public Nullable<DateTime> birthday { get; set; }
		public int address_id { get; set; }
		public string address_full { get; set; }

		public Student()
		{
			this.id = 0;
			this.name = string.Empty;
			this.birthday = new DateTime(1900, 01, 01);
			this.address_id = 0;
			this.address_full = string.Empty;
		}
        public Student(int id)
        {

			this.id = id;

            this.name = string.Empty;
            this.birthday = new DateTime(1900, 01, 01);
            this.address_id = 0;
            this.address_full = string.Empty;
        }
    }
}

