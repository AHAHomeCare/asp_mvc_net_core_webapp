using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_MVC_Core.Models;
using Microsoft.AspNetCore.Authorization;
using ASP.Net_MVC_Core.Middleware;
using Hanssens.Net;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Authorization;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Net_MVC_Core.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private protected HttpContext httpContext { get; set; }
        private protected ISession _session;
        public StudentController(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext;
            _session = httpContext.Session;
        }
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
        public IActionResult Class()
        {
            var items = new List<Class>();
            items = new ClassHelper().GetItems(-1);
            return View(items);
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

        [HttpGet]
        public async Task<IActionResult> CreateStudent()
        {
            var itemsClass = new List<Class>();
            itemsClass = new ClassHelper().GetItems(1);
            TempData["class"] = itemsClass;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(IFormCollection frmItem)
        {
            var item = new Student();
            if(frmItem!=null)
            {
                item.student_code = frmItem["student_code"];
                item.name = frmItem["student_name"];
                item.class_id = string.IsNullOrEmpty(frmItem["class_id"])? 0: Convert.ToInt32(frmItem["class_id"]);

            }
            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> CreateClass()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClass(IFormCollection frmItem)
        {
            var item = new Class();
            if (frmItem != null)
            {
                item.name = frmItem["class_name"];
                item.code = frmItem["class_code"];
                var result = new ClassHelper().Create(item);
                if(result >0)
                    return RedirectToAction("Class");
            }
            return View(item);

        }
    }
}

