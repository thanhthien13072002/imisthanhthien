using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using ThietKeWebsiteBan_DienThoai_NguyenThanhThien_2001206972.Models;

namespace ThietKeWebsiteBan_DienThoai_NguyenThanhThien_2001206972.Controllers
{
    public class TrangChuController : Controller
    {
        //login
        public ActionResult Dangnhap()
        {
            return View();
        }
        public ActionResult Dangky()
        {
            return View();
        }
        // GET: TrangChu
        public ActionResult Home(string sortPrice = "", int page = 1)
        {
            SanphamEntities1 All = new SanphamEntities1();
            List<Sanpham> ch = All.Sanphams.ToList();
            Sanpham sp = new Sanpham();
            ViewBag.Gia = All.Sanphams.ToList();
            switch (sortPrice)
            {
                case "1":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where( r => r.Gia < 3000000 ).ToList();

                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where( r => r.Giakhuyenmai < 3000000).ToList();
                    }
                    break;
                case "2":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where(r => (r.Gia >= 3000000) && (r.Gia <= 5000000)).ToList();
                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where(r => (r.Giakhuyenmai >= 3000000) && (r.Giakhuyenmai <= 5000000)).ToList();
                    }

                    break;
                case "3":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where(r => (r.Gia >= 5000000) && (r.Gia <= 10000000)).ToList();
                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where(r => (r.Giakhuyenmai >= 5000000) && (r.Giakhuyenmai <= 10000000)).ToList();
                    }

                    break;
                case "4":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where(r => (r.Gia >= 10000000) && (r.Gia <= 20000000)).ToList();
                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where(r => (r.Giakhuyenmai >= 10000000) && (r.Giakhuyenmai <= 20000000)).ToList();
                    }

                    break;
                case "5":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where(r => (r.Gia >= 20000000) && (r.Gia <= 30000000)).ToList();
                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where(r => (r.Giakhuyenmai >= 20000000) && (r.Giakhuyenmai <= 30000000)).ToList();
                    }

                    break;
                case "6":
                    if (sp.Giakhuyenmai == null)
                    {
                        ch = ch.Where(r => r.Gia > 30000000).ToList();
                    }
                    if (sp.Giakhuyenmai != null)
                    {
                        ch = ch.Where(r => r.Giakhuyenmai > 30000000).ToList();
                    }
                    break;

                default:
                    break;
            }
            //paging
            int dau = 12;
            int nodau = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(ch.Count) / Convert.ToDouble(dau)));
            int cuoiskip = (page - 1) * dau;
            ViewBag.page = page;
            ViewBag.nodau = nodau;
            ch = ch.Skip(cuoiskip).Take(dau).ToList();
            return View(ch);
        }
        public string SaveFileImage(HttpPostedFileBase Url_anh)
        {
            Url_anh.SaveAs(Server.MapPath("~/Img/" + Url_anh.FileName));
            return Url_anh.FileName;

        }
        public ActionResult CTSP(int id)
        {
            SanphamEntities1 All = new SanphamEntities1();
            Sanpham DS = All.Sanphams.Where(row => row.id_sanpham == id).FirstOrDefault();
            return View(DS);
        }
        public ActionResult Create()
        {
            SanphamEntities1 sp = new SanphamEntities1();
            ViewBag.Sanpham = sp.Sanphams.ToList();
            ViewBag.Thuonghieu = sp.ThuongHieux.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sanpham sp)
        {
            SanphamEntities1 All = new SanphamEntities1();
            All.Sanphams.Add(sp);
            All.SaveChanges();
            return RedirectToAction("Home");
        }
        public ActionResult Edit(int id)
        {
            SanphamEntities1 All = new SanphamEntities1();
            Sanpham DS = All.Sanphams.Where(row => row.id_sanpham == id).FirstOrDefault();
            ViewBag.Sanpham = All.Sanphams.ToList();
            ViewBag.Thuonghieu = All.ThuongHieux.ToList();
            return View(DS);
        }
        [HttpPost]
        public ActionResult Edit(Sanpham sp)
        {
            SanphamEntities1 All = new SanphamEntities1();
            Sanpham DS = All.Sanphams.Where(row => row.id_sanpham == sp.id_sanpham).FirstOrDefault();
            DS.Name = sp.Name;
            DS.Gia = sp.Gia;
            DS.Giakhuyenmai = sp.Giakhuyenmai;
            DS.Motasanpham = sp.Motasanpham;
            DS.Tinhtrang = sp.Tinhtrang;
            DS.Chitiet = sp.Chitiet;
            DS.Khuyenmai = sp.Khuyenmai;
            DS.ThuongHieuID = sp.ThuongHieuID;
            DS.Url_anh = sp.Url_anh;
            All.SaveChanges();
            return RedirectToAction("Home");
        }
        public ActionResult Delete(int id)
        {
            SanphamEntities1 All = new SanphamEntities1();
            Sanpham DS = All.Sanphams.Where(row => row.id_sanpham == id).FirstOrDefault();
            return View(DS);
        }
        [HttpPost]
        public ActionResult Delete(int id, Sanpham sp)
        {
            SanphamEntities1 All = new SanphamEntities1();
            Sanpham DS = All.Sanphams.Where(row => row.id_sanpham == id).FirstOrDefault();
            All.Sanphams.Remove(DS);
            All.SaveChanges();
            return RedirectToAction("Home");
        }
        public ActionResult Cart()
        {
             return View();
        }
    }
}