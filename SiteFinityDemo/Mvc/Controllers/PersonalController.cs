using Newtonsoft.Json;
using SitefinityWebApp.Mvc.Models;
using System;
using System.Net.Http;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Personal", Title = "Personal", SectionName = "MVCTools")]
    public class PersonalController : Controller
    {
        public ActionResult Index()
        {
            var personalInfo = new Personal();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/");
                var response = client.GetAsync("api/Personal/GetPersonalDataById?IDName=1");
                response.Wait();
                var stringResult = response.Result.Content.ReadAsStringAsync().Result;
                personalInfo = JsonConvert.DeserializeObject<Personal>(stringResult);
                return View(personalInfo);
            }
        }
    }
}