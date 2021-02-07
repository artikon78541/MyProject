using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autoshop1.Models;
using Autoshop1.Models.Interfaces;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using Autoshop1.Models.Identity;

namespace Autoshop1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IParts _parts;



        public HomeController(IParts iparts)
        {
            _parts = iparts;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ListParts(string searchline)
        {
            //var parts = _parts.Partslistsearch(searchline);
            List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);

            PartRepository partRepository = new PartRepository();
            partRepository.FillList((List<SearchPart>)parts);

            return View(parts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
