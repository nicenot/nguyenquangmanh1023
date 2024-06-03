using NQMBaiDanhGiaGiuaKy.Models;
using NQMBaiDanhGiaGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LvhBaiDanhGiaGiuaKy.Controllers
{
    public class NQMProductController : Controller
    {
        private static List<NQMProduct> lvhProducts = new List<NQMProduct>()
        {
            new NQMProduct(){NQMId=106,NQMFullName="NGUYỄN QUANG MẠNH ",NQMImage="1234",NQMQuantity=10,NQMPrice=1000000,NQMIsActive=true},
            new NQMProduct(){NQMId=1,NQMFullName="Đỗ MINH HUY",NQMImage="1235",NQMQuantity=11,NQMPrice=2000000,NQMIsActive=true},

        };
       
        public ActionResult NQMIndex()
        {
            return View(NQMProducts);
        }
        public ActionResult NQMCreate()
        {
            var NQMModel = new NQMProduct();
            return View(NQMModel);
        }
        [HttpPost]
        public ActionResult NQMCreate(NQMProduct NQMProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(NQMProduct);
            }
            NQMProducts.Add(NQMProduct);
            return RedirectToAction("NQMIndex");
        }
        public ActionResult NQMEdit(int id)
        {
            var product = NQMProducts.Find(p => p.NQMId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult NQMDetails(int id)
        {
            var product = NQMProducts.Find(p => p.NQMId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NQMEdit(NQMProduct NQMProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(NQMProduct);
            }

            var product = NQMProducts.Find(p => p.NQMId == NQMProduct.NQMId);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.NQMFullName = NQMProduct.NQMFullName;
            product.NQMImage = NQMProduct.NQMImage;
            product.NQMQuantity = NQMProduct.NQMQuantity;
            product.NQMPrice = NQMProduct.NQMPrice;
            product.NQMIsActive = NQMProduct.NQMIsActive;

            return RedirectToAction("LvhIndex");
        }
        
    }
}
