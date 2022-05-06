using Lap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap2.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Show(){
            model m = new model();
            List<people>  list = m.Show();
            return View(list);
        }

        [HttpGet]
        public ActionResult Delete(string ID){
            model m = new model();
            if (m.Delete(ID))
                return Redirect("/People/Show");
            return Redirect("/People/Show");
        }
        [HttpGet]
        public ActionResult Create(){return View();}

        [HttpPost]
        public ActionResult Create(string HoTen,string NgaySinh){
            people p = new people(HoTen, NgaySinh);
            model m = new model();
            if (m.Create(p))
                return Redirect("/People/Show");
            return Redirect("/People/Show");
        }
        [HttpGet]
        public ActionResult Edit(string ID,string HoTen,string NgaySinh, string none){
            people p = new people(int.Parse(ID),HoTen, NgaySinh);
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(string ID,string HoTen,string NgaySinh){
            model m = new model();
            people p = new people(int.Parse(ID), HoTen, NgaySinh);
            if(m.Edit(p))
                return Redirect("/People/Show");
            return Content("Xóa thất bại!");
        }
    }
    //  @Html.ActionLink("Edit", "Edit", new { id = item.ID,HoTen=item.HoTen,NgaySinh=item.NgaySinh }) |
    //  [DisplayName("ID")]
    //  public int ID { get; set; }
}