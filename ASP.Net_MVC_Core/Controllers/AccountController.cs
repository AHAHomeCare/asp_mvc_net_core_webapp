using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Net_MVC_Core.Lib;
using ASP.Net_MVC_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.Net_MVC_Core.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private protected HttpContext httpContext { get; set; }
        private protected ISession _session;
        public AccountController(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext;
            _session = httpContext.Session;
        }
            

        // GET: /<controller>/
        public IActionResult login(string returnUrl)
        {
            this.ViewData["ReturnUrl"] = returnUrl;
            var user = new User();
            return View(user);
        }
        public IActionResult denied()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> authent( User user)
        {
            if (ModelState.IsValid)
            {
                if (user == null)
                    return RedirectToAction("denied");
                var userName = user.UserName;
                var userPass = user.PassWord;
                httpContext.Request.Headers["user"] = userName;
               var accountHelper = new AccountHelper(httpContext);
               if(!await accountHelper.IsAuthenMockData(userName, userPass))
                    return RedirectToAction("denied");

                string url = httpContext.Request.Headers["Referer"].ToString();
                var returnUrl = QueryStringHelper.GetQuerySegment(url, "ReturnUrl");
                if(returnUrl.Count()>1)
                {
                    string controller = returnUrl[0];
                    string action = returnUrl[1];
                    return RedirectToAction(action, controller);
                }
                if (returnUrl.Count() == 1)
                {
                    string controller = returnUrl[0];
                    string action = "index";
                    return RedirectToAction(action, controller);
                }
                return RedirectToAction("index", "home");
               
            }
            return RedirectToAction("denied");

        }
        public async Task<IActionResult> logout()
        {
            var accountHelper = new AccountHelper(httpContext);
            await accountHelper.logout();
            return RedirectToAction("index", "home");
        }
    }
}

