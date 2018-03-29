using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerSide_Project.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        // Search: Returns authors that match the searched string as a partial view
        public ActionResult arSearchAuthor()
        {
            return PartialView("~/Views/shared/_SearchResultView.cshtml");
        }
        // arAddAnAuthor: Returns the add author section where the user will enter info about a new author
        public ActionResult arAddAnAuthor()
        {
            return PartialView("~/Views/Author/_AddAuthorView.cshtml");
        }

        // arSaveAuthor: Saves the added author into the database
        public ActionResult arSaveAuthor()
        {
            return View();
        }
    }
}