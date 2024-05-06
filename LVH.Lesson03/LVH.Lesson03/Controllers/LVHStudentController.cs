using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVH.Lesson03.Controllers
{
    /// <summary>
    /// Author: Lê Vinh Huy
    /// Class: K22CNT1
    /// </summary>
    public class LVHStudentController : Controller
    {
        // GET: LVHStudent
        public ActionResult Index()
        {
            //Truyền dữ liệu từ Controller -> View
            ViewBag.fullName = "Lê Vinh Huy";
            ViewData["Birthday"] = "20/01/2004";
            TempData["Phone"] = "911";
            return View();
        }
        public ActionResult Details()
        {
            string lvhStr = "";
            lvhStr += "<h3> Họ và tên: Lê Vinh Huy </h3>";
            lvhStr += "<p> Mã số: 106";
            lvhStr += "<p> Lớp: CNT1";

            ViewBag.Details = lvhStr;


            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Văn B", "Lê Văn C", "Đỗ Thị D" };
            ViewBag.names = names;
            return View();

        }
        // HTMLHelper
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //Lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string lvhStr = "<h3>" + fullname + "</h3>";
            lvhStr += "<p>" + masv;
            lvhStr += "<p>" + TaiKhoan;
            lvhStr += "<p>" + MatKhau;

            ViewBag.info = lvhStr;

            return View("KetQua");
        }

    }
}