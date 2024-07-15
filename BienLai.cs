using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai5_ThuTienDien
{
    internal class BienLai
    {
        public KhachHang KhachHang { get; set; }
        public int ChiSoCu {  get; set; }
        public int ChiSoMoi { get; set; }
        public double SoTienPhaiTra => (ChiSoMoi - ChiSoCu) * 750;

        public BienLai(KhachHang khachHang, int chiSoCu, int chiSoMoi)
        {
            KhachHang = khachHang;
            ChiSoCu = chiSoCu;
            ChiSoMoi = chiSoMoi;
        }

        public override string ToString()
        {
            return $"{KhachHang}, Chi So Cu: {ChiSoCu}, Chi So Moi: {ChiSoMoi}, So Tien Phai Tra: {SoTienPhaiTra:C}";
        }
    }
}
