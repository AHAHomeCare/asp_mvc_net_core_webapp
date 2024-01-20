using System;
using ASP.Net_MVC_Core.DataBase;
using ASP.Net_MVC_Core.Lib;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Security.Claims;

namespace ASP.Net_MVC_Core.Models
{
	public class AccountHelper
	{
		private string _user = "admin";
		private string _pass = "admin@123";
		private readonly HttpContext http;
		private readonly ISession _session;
		public AccountHelper(HttpContext httpContext)
		{
			this.http = httpContext;
			this._session = httpContext.Session;

        }

		public async Task<bool> IsAuthenMockData(string user, string pass)
		{
			try
			{
				if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass)) return false;
				if (user != _user) return false;
				if (pass != _pass) return false;
				_session.SetString("user_id", user);
				http.Session.SetString("user_id", user);
                return true;
			}
			catch(Exception ex)
			{
				throw new ArgumentException(ex.Message);
			}
		}

        public async Task<bool> logout()
        {
            try
            {
				http.Session.Clear();
                var identity = new ClaimsIdentity(null, "noAuth");
				var principal = new ClaimsPrincipal( identity);
                http.User = principal;

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}

