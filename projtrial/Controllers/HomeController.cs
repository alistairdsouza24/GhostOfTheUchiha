using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using projtrial.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace projtrial.Controllers
{
/*public IConfiguration MyPropcoferty { get; set; }*/
    public class HomeController : Controller
    {
        public HomeController(IConfiguration config)
        {

        }
        public async Task<IActionResult> ViewEmployee()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            List<Employeesdetail>? employee = new List<Employeesdetail>();

            HttpResponseMessage res = await client.GetAsync("api/Values/get");
            if (res.IsSuccessStatusCode)
            {
                var Result = res.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<List<Employeesdetail>>(Result);
            }
            return View(employee);
        }
        
       

            public async Task<ActionResult> create()
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7214");
                List<Mdesignation>? designationTemp = new List<Mdesignation>();

                HttpResponseMessage res = await client.GetAsync("api/Designation");

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    designationTemp = JsonConvert.DeserializeObject<List<Mdesignation>>(result);
                    ViewData["designationtemp"] = designationTemp;
                }
                return View();
            }
            
        
        [HttpPost]
        public async Task<IActionResult> create(Employeesdetail emp)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");

            HttpResponseMessage postTask = client.PostAsJsonAsync("api/Values/Post", emp).Result;


            if (postTask.IsSuccessStatusCode)
            {
                return RedirectToAction("ViewEmployee");
            }
            return View();

           
            List<Mdesignation>? designationTemp = new List<Mdesignation>();

            HttpResponseMessage res = await client.GetAsync("api/Designation");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                designationTemp = JsonConvert.DeserializeObject<List<Mdesignation>>(result);
                ViewData["designationtemp"] = designationTemp;
            }
            return View();
        }

        public async Task<IActionResult> Delete(string UserName)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            await client.DeleteAsync($"api/Values/delete/{UserName}");
            return RedirectToAction("ViewEmployee");


        }
        
        [HttpGet]
        public async Task<ActionResult> Edit(string username)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            List<Mdesignation>? designationTemp = new List<Mdesignation>();

            HttpResponseMessage des = await client.GetAsync("api/Designation");

            if (des.IsSuccessStatusCode)
            {
                var result = des.Content.ReadAsStringAsync().Result;
                designationTemp = JsonConvert.DeserializeObject<List<Mdesignation>>(result);
                ViewData["designationtemp"] = designationTemp;
            }




            Employeesdetail employee = new Employeesdetail();

            HttpResponseMessage res = await client.GetAsync($"api/Values/get/{username}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<Employeesdetail>(result);
            }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> edit(Employeesdetail emp)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            List<Mdesignation>? designationTemp = new List<Mdesignation>();

            HttpResponseMessage des = await client.GetAsync("api/Designation");

            if (des.IsSuccessStatusCode)
            {
                var result = des.Content.ReadAsStringAsync().Result;
                designationTemp = JsonConvert.DeserializeObject<List<Mdesignation>>(result);
                ViewData["designationtemp"] = designationTemp;
            }
            HttpResponseMessage postTask = client.PostAsJsonAsync("api/Values/edit", emp).Result;


            if (postTask.IsSuccessStatusCode)
            {
                return RedirectToAction("ViewEmployee");
            }
            return View();
        }
        public ActionResult designation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Designation( Mdesignation designationClass)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            var postTask = client.PostAsJsonAsync<Mdesignation>("api/Designation/designation", designationClass);

            /*  var postTask = client.PostAsJsonAsync<DesignationClass>("api/Designation/Designation", designationClass)*/
            postTask.Wait();
            var Result = postTask.Result;
            if (Result.IsSuccessStatusCode)
            {
                return RedirectToAction("DashBoard","LoginM");
            }
            return View();
        }
        public async Task<IActionResult> ViewDesignation()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214");
            List<Employeesdetail>? employee = new List<Employeesdetail>();

            HttpResponseMessage res = await client.GetAsync("api/designation/get");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<List<Employeesdetail>>(result);
            }
            return View(employee);

        }
        /*
        public IActionResult Login(string ReturnUrl)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Employeesdetail emp)
        {
            if (true)
            {
                var claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, Convert.ToString("admin")),
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Role,"admin"),
                    new Claim("FavoriteDrink", "Tea")
                };
                //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
                var principal = new ClaimsPrincipal(identity);
                //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties());

        }

            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            //SignOutAsync is Extension method for SignOut    
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //Redirect to home page    
            return LocalRedirect("/");
        }*/
    }




    }
