using CreatureArena.Data.Factories;
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
            var repo = CreatureRepoFactory.GetRepo();
            var model = repo.GetCreatureDirectory().ToList();
            return View(model);
        }

        public ActionResult Creature(int id)
        {
            return View();
        }
    }
}