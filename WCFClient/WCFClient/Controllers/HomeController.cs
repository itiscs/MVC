using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WCFClient.MyWCFServiceReference;

namespace WCFClient.Controllers
{
    public class HomeController : Controller
    {
        Service1Client service = new Service1Client();
        
        public ActionResult Index()
        {
            CompositeType ob = new CompositeType()
            { BoolValue = true, StringValue = "Text" };
            ViewBag.StringFromService = service.GetData(500);

            ob = service.GetDataUsingDataContract(ob);

            ViewBag.CompositeType = ob;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //HttpClient client = new HttpClient();

            //var resp = client.GetAsync("http://localhost:53674/api/products");



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}