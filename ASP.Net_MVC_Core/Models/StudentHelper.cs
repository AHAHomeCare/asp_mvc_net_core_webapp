using System;
using System.Linq;
using System.Collections.Generic;
namespace ASP.Net_MVC_Core.Models
{
	public class StudentHelper
	{
		public List<Student> initStudent()
		{
			var items = new List<Student>();
			for (int i = 0; i < 10; i++)
			{
				items.Add(new Student()
				{
					id = i,
					name = $"Nguyen Van {i}",
					address_id = i ,
					address_full = $"Quan {i}, HCM",
					birthday = new DateTime(1980, 01, 01)
				});
			}

			items = items.OrderByDescending(o => o.id).ToList();
			return items;

		}

        public List<Student> getStudentItem(int id)
        {
			var items = initStudent();
			var data = items.Where(w => w.id == id).ToList();

            return data;

        }


    }
}

