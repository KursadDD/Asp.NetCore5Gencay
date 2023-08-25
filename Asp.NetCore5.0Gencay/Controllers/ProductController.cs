using Asp.NetCore5Gencay.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5Gencay.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product {Id=1, ProductName="A", Quantity=10},
                new Product {Id=2, ProductName="B", Quantity=15},
                new Product {Id=3, ProductName="C", Quantity=20},
            }; 
            #region Model bazlı veri gönderimi
            //return View(products);
            #endregion
            #region ViewBag
            ViewBag.products = products;
            #endregion

            #region ViewData
            ViewData["products"] = products;
            #endregion

            #region TempData
            TempData["products"] = products;
            #endregion
            return View();

        }

    }
}
