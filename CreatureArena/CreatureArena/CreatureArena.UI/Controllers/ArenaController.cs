using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreatureArena.UI.Controllers
{
    public class ArenaController : Controller
    {
        // GET: Arena
        public ActionResult Index()
        {
            return View();
        }
    }
}