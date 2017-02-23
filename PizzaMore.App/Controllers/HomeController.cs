namespace PizzaMore.App.Controllers
{
    using SimpleHttpServer.Models;
    using SimpleMVC.Controllers;
    using SimpleMVC.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        #region Fields
        #endregion

        #region Constructors
        public HomeController()
        {
            
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}