using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;
using System;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Index(double height, double length, double width, double weight)
        {
            double[] dimensions = {height, length, width};
            Parcel myParcel = new Parcel(dimensions, weight);
            double[] values = myParcel.GetValues();
            return View(values);
        }
    }
}