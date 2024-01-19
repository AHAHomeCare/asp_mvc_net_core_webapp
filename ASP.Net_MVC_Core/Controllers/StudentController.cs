using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_MVC_Core.Models;
using Microsoft.AspNetCore.Authorization;
using ASP.Net_MVC_Core.Middleware;
//using Microsoft.AspNetCore.Authorization;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Net_MVC_Core.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var studentHelper = new StudentHelper();
            var dataItems = studentHelper.getStudentItems();
            return View(dataItems);
        }
        public IActionResult Info(int id)
        {
            if (id != 0 && id != null)
            {
                var studentHelper = new StudentHelper();
                var dataItem = studentHelper.getStudentItem(id);
                return View(dataItem);
            }
            ViewBag.msg = "Không tìm thấy data";
            return View();
            
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

