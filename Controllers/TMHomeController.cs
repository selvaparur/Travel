using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelManagement.Models;

namespace TravelManagement
{

    public class TMHomeController : Controller
    {
        public ActionResult Index()
        {

            TripModel tm = new TripModel();
           
            return View(tm);
        }
    }
}
