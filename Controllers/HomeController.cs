using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using HouseDemo.Models;

namespace HouseDemo.Controllers
{
    public class HomeController : Controller
    {
        public int RefreshPeriod { get; set; } = 300;
        public AppConfig AppConfigs { get; }

        public HomeController(IOptions<AppConfig> configs)
        {
            AppConfigs = configs.Value;
                       
        }

        public IActionResult Index()
        {

            ViewData["PingDataOut"] = "10.0";
            ViewData["PingDataIn"] = "20.0";
            Response.Headers.Add("Refresh", "1");

            return View();
        }

        

        public IActionResult Error()
        {
            return View();
        }
    }
}
