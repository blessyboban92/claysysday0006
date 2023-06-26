using mvcimage.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcimage.Controllers
{
    public class ImagemvcController : Controller
    {
        // GET: Imagemvc
        public ActionResult Index()
        {
            using (DBmodel dm = new DBmodel())
            {
                return View(dm.Mvcimagedbs.ToList());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Mvcimagedb tb)
        {
            string filename = Path.GetFileNameWithoutExtension(tb.ImageFile.FileName);
            string extension = Path.GetExtension(tb.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            tb.imgpath = "../images/" + filename;
            filename = Path.Combine(Server.MapPath("../images/"), filename);
            tb.ImageFile.SaveAs(filename);
            using (DBmodel dm = new DBmodel())
            {
                dm.Mvcimagedbs.Add(tb);
                dm.SaveChanges();

            }
            ModelState.Clear();
            return View();
        }

    }
}