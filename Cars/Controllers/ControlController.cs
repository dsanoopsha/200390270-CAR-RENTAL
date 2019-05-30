
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cars.Models;


namespace Cars.Controllers
{
    public class ControlController : Controller
    {
        // GET: Control
        public ActionResult Index()
        {
            return View(carList);
        }
        List<Car> carList = new List<Car>()
        {
         new Car {Id = 1, Brand = "Toyota", Model="Corrola", Type="Compact", Year = 2017},
         new Car {Id = 2, Brand = "Ford", Model="F-150", Type="Suv", Year = 2017},
         new Car {Id = 3, Brand = "Toyota", Model="Camery", Type="Sedan", Year = 2013},
         new Car {Id = 4, Brand = "Dodge", Model="Caravan", Type="minivan", Year = 2013}


        };

        public ActionResult Detail(int? id)

        {
            if (id == null || id > carList.Count)
            {
                return Content("invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }

    }
}