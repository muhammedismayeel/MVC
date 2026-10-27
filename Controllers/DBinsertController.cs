using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class DBinsertController : Controller
    {
        MVC1Entities dbobj = new MVC1Entities();
        // GET: DBinsert
        public ActionResult insert_pageload()
        {
            return View();
        }
        public ActionResult insert_click(insertcls clsobj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_inserttab(clsobj.Name, clsobj.age,clsobj.Email);
                clsobj.msg = "Inserted";
                return View("insert_pageload", clsobj);
            }
            return View("insert_pageload", clsobj);
        }
    }
}