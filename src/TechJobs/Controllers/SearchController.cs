using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller

    // TODO #1 - Create a Results action method to process 
    // search request and display results

    {
        public IActionResult Results(string searchType, string searchTerm)

        {

            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Searchtype, searchterm";
            ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm); 
            return View("Index");
        }  



        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Searchtype, searchterm";
            return View();
        }

        

    }
}
