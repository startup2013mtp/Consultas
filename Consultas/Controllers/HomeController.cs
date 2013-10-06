using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using System.IO;
using Framawork;

namespace BootstrapMvcSample.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            Session["email"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            string email = Session["email"].ToString();
            foreach (HttpPostedFileBase file in files)
            {
                string filePath = Path.Combine(Server.MapPath("~/Content/temp/"), file.FileName);
                System.IO.File.WriteAllBytes(filePath, ReadData(file.InputStream));
                Mail.enviaEmail();
            }
            return Json("All files have been successfully stored.");
        }

        [HttpPost]
        public ActionResult UploadFilesOld(HttpPostedFileBase file, FormCollection form)
        {
            string email = form["email"];
            string filePath = Path.Combine(Server.MapPath("~/Content/temp/"), file.FileName);
            System.IO.File.WriteAllBytes(filePath, ReadData(file.InputStream));
            Mail.enviaEmail();
            return RedirectToAction("Index");
        }

        public ActionResult emailToSession(string email) {
            Session["email"] = email;
            return Json("Ok");
        }

        private byte[] ReadData(Stream stream)
        {
            byte[] buffer = new byte[16 * 1024];

            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }
    }
}
