using System.Web.Mvc;
using Domain.Managers;
using MyWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var manager = new StartUpManager();
            var domainModel = manager.Execute();
            var viewModel = new IndexShow
            {
                PageTitle = domainModel.PageTitle,
                TitleContent = domainModel.TitleContent,
                Links = new List<Links>()
            };

            domainModel.Links.ToList().ForEach(item => viewModel.Links.Add(new Links { Name = item.Name, Url = item.Url }));

            return View("Index", viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}