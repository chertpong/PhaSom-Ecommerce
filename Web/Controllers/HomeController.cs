using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Globalization;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index() {
            ViewBag.Message = TempData["Error"];
            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {

            if (file != null && file.ContentLength > 0) {
                String timestamp = DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                String name = file.FileName+timestamp;
                String ext = Path.GetExtension(file.FileName);
                String fname = name.GetHashCode().ToString()+ext;
               
                string path = Path.Combine(Server.MapPath("~/Images"),fname);
            file.SaveAs(path);
                TempData["Error"] = "File uploaded successfully";

        }
            else
            {
                TempData["Error"] = "You have not specified a file.";
            }
            return RedirectToAction("Index");

        }
        }
    }
