 using tieuluan_ban_giay.Models;
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.Mvc;
 using tieuluan_ban_giay.Models.DTO;

namespace tieuluan_ban_giay.Controllers
{
    public class DanhGiaController : Controller
    {
        QLBangiayyEntities db = new QLBangiayyEntities();
        public ActionResult Index()
        {
            
            return View();
        }
        
        [HttpPost]
        public ActionResult ThemDanhGia(FormCollection f, Danh_Gia cmt)
        {
            
            var so_sao = f["SoSao"];
            var Danh_Gia = f["Danh_Gia"];
            var Ten = f["Ten"];
            var MaKhachHang = f["Ma_kh"];
            var MaSanPham = f["Ma_SP"];
            if ( Danh_Gia == null || Ten == null)
            {
                ViewBag.ThongBao1 = "Xin vui lòng nhập đủ thông tin";
            }
            else
            {
                cmt.So_Sao =Convert.ToInt32( so_sao);
                cmt.Noi_Dung = Danh_Gia;
                cmt.Ngay_Danh_Gia = DateTime.Now;
                cmt.ID_Khach_Hang =Convert.ToInt32( MaKhachHang);
                cmt.Ten_Khach_Hang = Ten ;
                cmt.ID_San_Pham =Convert.ToInt32( MaSanPham);
                db.Danh_Gia.Add(cmt);
                db.SaveChanges();

            }
            return RedirectToAction("Index","Home");
        }
    }
}