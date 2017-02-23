namespace PizzaMore.App.Controllers
{
    using SimpleMVC.Controllers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        #region Fields
        private SignInManager signInManager;
        #endregion

        #region Constructors
        public HomeController()
        {
            signInManager = new SignInManager(new PizzaMoreContext());
        }
        #endregion

        public IActionResult<HomeIndexButtonsViewModel> Index(HttpSession session)
        {
            var viewModel = new HomeIndexButtonsViewModel();

            if (signInManager.IsAuthenticated(session))
            {
                viewModel.LoggedIn = true;
            }
            else
            {
                viewModel.LoggedIn = false;
            }

            return View(viewModel);
        }
    }
}