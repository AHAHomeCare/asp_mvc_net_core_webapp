using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_MVC_Core.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Net_MVC_Core.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            var studentHelper = new StudentHelper();
            List<Student> dataItems = new List<Student>();
            if(id==0)
                dataItems = studentHelper.initStudent();
            else
                 dataItems = studentHelper.getStudentItem(id);

            return View(dataItems);
        }
        public IActionResult Info(int id)
        {
            var item = new Student(id);
            return View(item);
        }
        public IActionResult class_student(int id)
        {
            return View();
        }
        public IActionResult course(int id)
        {
            return View();
        }
        public IActionResult point(int id)
        {
            return View();
        }
        public IActionResult edu_result(int id)
        {
            return View();
        }
    }
}

