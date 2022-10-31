using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projtrial.Models;

namespace projtrial.Controllers
{
    public class LoginMController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Userlogin loginDetails)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            var postTask = client.PostAsJsonAsync<Userlogin>("api/LoginA/login", loginDetails);
            postTask.Wait();
            var Result = postTask.Result;
            if (!Result.IsSuccessStatusCode)
            {
                return BadRequest("User wrong");
            }
            return RedirectToAction("Dashboard","LoginM");
        }
       
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Userlogin user2)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            var postTask = client.PostAsJsonAsync("api/LoginA/Register", user2);
            postTask.Wait();
            var Result = postTask.Result;
            if (Result.IsSuccessStatusCode)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "LoginM");
        }
    }

}

