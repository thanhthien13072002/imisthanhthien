using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ThietKeWebsiteBan_DienThoai_NguyenThanhThien_2001206972.Models;
namespace ThietKeWebsiteBan_DienThoai_NguyenThanhThien_2001206972.Controllers
{
    public class XiaomiController : Controller
    {
        // GET: Xiaomi
        public ActionResult Xiaomi(int page = 1)
        {
            SanphamEntities1 All = new SanphamEntities1();
            List<Sanpham> ch = All.Sanphams.Where(r => r.ThuongHieuID == "XM000").ToList();
            //paging
            int dau = 8;
            int nodau = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(ch.Count) / Convert.ToDouble(dau)));
            int cuoiskip = (page - 1) * dau;
            ViewBag.page = page;
            ViewBag.nodau = nodau;
            ch = ch.Skip(cuoiskip).Take(dau).ToList();
            return View(ch);
        }
    }
}