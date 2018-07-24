using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreatureArena.UI.Controllers
{
    public class DirectoryController : Controller
    {
        // GET: Directory
        public ActionResult AllCreatures()
        {
            return View();
        }

        public ActionResult Creature(int id)
        {
            return View();
        }
    }
}