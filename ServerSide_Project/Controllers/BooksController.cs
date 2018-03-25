using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerSide_Project.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        //Search: Returns books that match the searched string as a partial view
        public ActionResult SearchBook()
        {
            return PartialView("~/Views/shared/_SearchResultView.cshtml");
        }
        //AddABook: Returns the add book section where the user will enter info about a new book
        public ActionResult AddABook()
        {
            return PartialView("~/Views/Books/_AddBookView.cshtml");
        }

        //SaveBook: Saves the added book into the database
        public ActionResult SaveBook()
        {
            return View();
        }
    }
}