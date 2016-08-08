using Guan.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guan.Web.Controllers
{

   
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        [Route]
        public ActionResult Demo()
        {

            return View();
        }
       
        public ActionResult Main()
        {

            return View();
        }

       
        public ActionResult Add()
        {
            return View();
        }

        [Route("{id:int}/edit")]
        public ActionResult Edit(int? id = null)
        {
            ItemViewModel<int?> model = new ItemViewModel<int?>();
            model.Item = id;
            return View(model);
        }
    }
}