using System;
using System.Linq;
using System.Collections.Generic;
using ASP.Net_MVC_Core.DataBase;
using ASP.Net_MVC_Core.Models;
using System.Net;

namespace ASP.Net_MVC_Core.Models
{
    // Studenthelper - Student Bussiness Logic
    // Use linq to entity framework
    public class StudentHelper
	{
        
		// init new student data
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

        // Add student item
        // Create
        public int create(Student item)
        {
            if (item == null) return 0;
            using (var db = new StudentContext())
            {
                db.D_ADDRESS.Add(item.address);
                var resultAdd = db.SaveChanges();
                if (resultAdd == 0) return 0;
                item.address_id = item.address.id;
                db.D_STUDENT.Add(item);
                var resultStudent = db.SaveChanges();
                if (resultStudent == 0) return 0;
                return 1;

            }
        }


        // Get All Items Student
        // Read
        public List<Student> getStudentItems()
        {
            try
            {
                using (var db = new StudentContext())
                {
                    var items = db.D_STUDENT
                                .Join(db.D_ADDRESS,
                                    a => a.address_id,
                                    b => b.id,
                                    (a, b) => new { a, b })
                                .Select(s => new Student()
                                {
                                    id = s.a.id,
                                    student_code = s.a.student_code,
                                    name = s.a.name,
                                    birthday = s.a.birthday,
                                    cccd = s.a.cccd,
                                    address_id = s.a.address_id,
                                    address_full = getAddress(s.b),
                                    address = s.b,
                                    status = s.a.status,
                                    created_at = s.a.created_at,
                                    created_by = s.a.created_by

                                })
                                .ToList();
                    return items;
                }
            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

		// Get 1 item student
		// Read
        public Student getStudentItem(int id)
        {
            using (var db = new StudentContext())
            {
                var item = db.D_STUDENT
								.Join(db.D_ADDRESS,
								a=> a.address_id,
								b=>b.id,
								(a,b)=> new {a,b})
							.Where(w => w.a.id == id)
							.Select(s=> new Student()
							{
								id = s.a.id,
                                student_code = s.a.student_code,
								name = s.a.name,
                                birthday = s.a.birthday,
                                cccd = s.a.cccd,
								address_id = s.a.address_id,
								address_full = getAddress(s.b),
								address = s.b,
								status = s.a.status,
								created_at = s.a.created_at,
								created_by = s.a.created_by
							 
                            })
							.FirstOrDefault();
                return item;
            }

        }

        // Update
		public int update (Student item)
        {
            if (item == null) return 0;
            using (var db = new StudentContext())
            {
                var dataItemStu = db.D_STUDENT.Where(s => s.id == item.id).FirstOrDefault();
                if (dataItemStu == null) return 0;
                dataItemStu.student_code = item.student_code;
                dataItemStu.name = item.name;
                db.D_STUDENT.Update(dataItemStu);

                // Find Address and update
                var dataItemAdd = db.D_ADDRESS.Where(s => s.id == dataItemStu.address_id).FirstOrDefault();
                if (dataItemAdd == null) return 1;
                dataItemAdd.number = item.address.number;
                dataItemAdd.province_id = item.address.province_id;
                dataItemAdd.district_id = item.address.district_id;
                dataItemAdd.ward_id = item.address.ward_id;
                db.D_ADDRESS.Update(dataItemAdd);
                var result = db.SaveChanges();
                if (result == 0) return 0;
                return 1;
            }
        }

		// Delete
        public int delete(Student item)
        {
            if (item == null) return 0;
            using (var db = new StudentContext())
            {
				var dataItem = db.D_STUDENT.Where(s => s.id == item.id).FirstOrDefault();
				if (dataItem == null) return 0;
                db.D_STUDENT.Remove(dataItem);
                var resultStu = db.SaveChanges();
                if (resultStu == 0) return 0;
				var dataItemAdd = db.D_ADDRESS.Where(s => s.id == dataItem.address_id).FirstOrDefault();
				if (dataItemAdd == null) return 1;
				db.D_ADDRESS.Remove(dataItemAdd);
                var resultAdd = db.SaveChanges();
                return 1;

            }
        }


        private static string getAddress(Address item)
		{
			string addr = $"{item.number}, {item.ward_name}, {item.district_name}, {item.province_name}";
			return addr;
						
		}
    }
}

