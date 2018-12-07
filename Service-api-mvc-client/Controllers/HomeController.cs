using EPiServer.Integration.Client.Models.Catalog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Service_api_mvc_client.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Service_api_mvc_client.Controllers
{
    public class HomeController : Controller
    {
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            
            return client;
        }

        public ActionResult Index()
        {
            Entries entries = null;
            
            return View(entries);
        }

        public ActionResult SingleEntry(string Code)
        {
            EntryViewModel viewModel = new EntryViewModel();

            return View(viewModel);
        }
    }
}