﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelManagement.Models;

namespace TravelManagement.Controllers
{
    public class AdminSummaryController : Controller
    {
        public IActionResult Index()
        {
            List<TripModel> tm = new List<TripModel> {
                new TripModel { Name = "Selva", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100, Completed = true, TripName="Trip To Chennai" },
                    new TripModel { Name = "Antony", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100, Completed = false, TripName="Trip To Trichy" },
                        new TripModel { Name = "Raj", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100 , Completed = true, TripName="Trip To Chennain"},
                            new TripModel { Name = "Ganapathy", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100 , Completed = false, TripName="Trip To Cuddalore"},
                            new TripModel { Name = "Ganapathy", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100 , Completed = false, TripName="Trip To Pondy"},
                            new TripModel { Name = "Ganapathy", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100 , Completed = false, TripName="Trip To Vellore"},
                            new TripModel { Name = "Ganapathy", Vehicle = "BMW", NoOfSeats = 5, Source = "Guduvancher", Destination = "TCO", Date = DateTime.Now, StartTime = DateTime.Now, EndTime = DateTime.Now, Amount = 100 , Completed = false, TripName="Trip To Villupuram"}
            };

            return View(tm);
        }
    }
}