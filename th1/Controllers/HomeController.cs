using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using th1.Models;

namespace th1.Controllers
{
    public class HomeController : Controller
    {
        private QLBanSachEntities1 db = new QLBanSachEntities1();

        public ActionResult Index()
        {
            var books = db.SACHes.Include("CHUDE").Include("NHAXUATBAN").ToList();
            return View(books);
            //return View();
        }

        public ActionResult HangHoa(int id)
        {
            var books = db.SACHes.Where(b => b.MaCD == id).ToList(); // Lấy sách theo chủ đề
            return View(books); // Trả về view chứa danh sách sách theo chủ đề
        }
    }
}