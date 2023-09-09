using System.Reflection;

namespace Timo.Models.TinhLaiSuat
{
    public class TinhLaiSuat
    {
        public int soTien { get; set; }
        public int kyhan { get; set; }
        public double laisuat { get; set; }
        public double soTienLai { get; set; }
        public double tongsotien { get; set; }
        public TinhLaiSuat() { }
        public TinhLaiSuat(int soTien, int kyhan, double laisuat)
        {
            this.soTien = soTien;
            this.kyhan = kyhan;
            this.laisuat = laisuat;
            soTienLai = soTien * laisuat * kyhan / 100;
            tongsotien = soTien + soTienLai;
        }
    }
}
