﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int numTimes, int ID)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes +",ID:"+ ID);
        }
    }
}