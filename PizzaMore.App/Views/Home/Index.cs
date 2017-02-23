namespace PizzaMore.App.Views.Home
{
    using SimpleMVC.Interfaces;
    using SimpleMVC.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Index : IRenderable
    {
        public string Render()
        {
            string page = FileRead.HtmlDocument("../../Content/home.html");

            return page;
        }
    }
}