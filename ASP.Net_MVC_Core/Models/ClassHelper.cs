using System;
using System.Linq;
using System.Collections.Generic;
using ASP.Net_MVC_Core.DataBase;
namespace ASP.Net_MVC_Core.Models
{
	public class ClassHelper
	{
		public List<Class> GetItems(int status)
		{
			using(var db = new StudentContext())
			{
				if (status == -1)
					return db.D_CLASS.ToList();
				return db.D_CLASS.Where(s => s.status == status).ToList();
			}
		}
        public int Create(Class item)
        {
			if (item == null) return 0;
            using (var db = new StudentContext())
            {
                item.created_at = DateTime.Now;
                item.created_by = string.Empty;
                item.updated_at = DateTime.Now;
                item.updated_by = string.Empty;
                item.status = 1;
				db.D_CLASS.Add(item);
				return db.SaveChanges();
            }
        }
        public int Update(Class item)
        {
            if (item == null || item.id ==0) return 0;
            using (var db = new StudentContext())
            {
                var dataItem = db.D_CLASS.Where(s => s.id == item.id).FirstOrDefault();
                if (dataItem == null) return 0;
                dataItem.name = item.name;
                dataItem.status = item.status;
                dataItem.code = item.code;
                dataItem.updated_at = DateTime.Now;
                dataItem.updated_by = string.Empty;
                db.D_CLASS.Update(item);
                return db.SaveChanges();
            }
        }

    }
}

