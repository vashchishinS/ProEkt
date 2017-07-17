using SimpleSite3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SimpleSite3.Controllers
{
    public class HomeController : Controller
    {
        MusicContext db = new MusicContext();
       
      
        public ActionResult Index()
        {
            //IEnumerable<MusicContext> items = db.CatalogList;
            ViewBag.Items = db.CatalogList;
            return View();
        }
        

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Music msc, HttpPostedFileBase uploadMusic)
        //{
        //    if (ModelState.IsValid && uploadMusic != null)
        //    {
        //        byte[] musicData = null;

        //        using (var binaryReader = new BinaryReader(uploadMusic.InputStream))
        //        {
        //            musicData = binaryReader.ReadBytes(uploadMusic.ContentLength);
        //        }
        //        msc.Song = musicData;

        //        db.mainTable.Add(msc);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");

        //    }

        //    return View(msc); }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Genre()
        {
            ViewBag.Message = "All genre is here";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RockMusic()
        {
            ViewBag.Message = "sadasd";

            return View();
        }

        public ActionResult Popular()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult PopMusic()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult RepHipHop()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult SoulFolk()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Jazz()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Classic()
        {
            ViewBag.Message = "sadasd";

            return View();
        }


        public ActionResult Metal()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Reggi()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Chill()
        {
            ViewBag.Message = "sadasd";

            return View();
        }

        public ActionResult NewSong()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Electro()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Bluz()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult RnB()
        {
            ViewBag.Message = "sadasd";

            return View();
        }
        public ActionResult Indie()
        {
            ViewBag.Message = "sadasd";

            return View();
        }

        public ActionResult HitList()
        {
            ViewBag.Message = "sadasd";

            return View();
        }

       

    }
}