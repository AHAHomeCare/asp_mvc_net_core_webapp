using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Net_MVC_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Net_MVC_Core.Controllers
{
    public class AccountController : Controller
    {
        private protected HttpContext httpContext { get; set; }
        public AccountController(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext;
        }
            

        // GET: /<controller>/
        public IActionResult login()
        {
            var user = new User();
            return View(user);
        }
        public IActionResult denied()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult authent( User user)
        {
          
            if (ModelState.IsValid)
            {
                if (user == null)
                    return RedirectToAction("denied");
                var userName = user.UserName;
                var userPass = user.PassWord;
                string query = httpContext.Request.QueryString.Value;
                string url = string.Empty;
                if (!string.IsNullOrEmpty(query) && query.Split("=").Count() > 1)
                    url = query.Split("=")[1];
                if (!string.IsNullOrEmpty(url) && url.Split("/").Count() > 1)
                {
                    string controller = url.Split("/")[0];
                    string action = url.Split("/")[1];
                    return RedirectToAction(action, controller);
                }
                return RedirectToAction("index", "home");
               
            }
            return RedirectToAction("denied");

        }
    }
}

