using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCmovie.Controllers
{
    public class HomeController1 : Controller
    {
        // GET: /<controller>/
        public string index()
        {
            return "This is my default action from HelloWorld...";
        }
        //public string welcome()
        //{
            //return "this is so boring and i am hungry";
        //
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
