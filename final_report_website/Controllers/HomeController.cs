using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_report_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//周刊首頁
        {
            return View();
        }

        public ActionResult Top()//最新文章
        {
            return View();
        }

        public ActionResult Hot()//熱門文章
        {
            return View();
        }

        public ActionResult Movies()//慧玲-影視娛樂
        {
            return View();
        }

        public ActionResult Tech()//致中-3C科技
        {
            return View();
        }

        public ActionResult Stock()//國榮-財經股市
        {
            return View();
        }

        public ActionResult Medicine()//威穎-醫藥衛生
        {
            return View();
        }

        public ActionResult Festival()//瑋呈-節日活動
        {
            return View();
        }

        
    }
}