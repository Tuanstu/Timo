using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Timo.Models.TinhLaiSuat;

namespace Timo.Controllers
{
    public class TInhLaiSuat : Controller
    {
        public IActionResult TinhLaiSuat()
        {
            TinhLaiSuat view = new TinhLaiSuat();
            return View(view);
        }
        [HttpPost]
        public IActionResult TinhLaiSuat(TinhLaiSuat input)
        {
            TinhLaiSuat model = new TinhLaiSuat(input.soTien, input.kyhan, input.laisuat);
            //ViewData["soTien"] = soTien;
            //ViewData["kyHan"] = kyhan;
            //ViewData["laiSuat"] = laisuat;
            //ViewData["SoTienLai"] = soTienLai;
            //ViewData["TongSoTien"] = tongsotien;
            return View(model);
        }


    }
}
