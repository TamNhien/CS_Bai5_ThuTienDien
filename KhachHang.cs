using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai5_ThuTienDien
{
    internal class KhachHang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongTo { get; set; }

        public KhachHang(string hoTenChuHo, string soNha, string maSoCongTo)
        {
            HoTenChuHo = hoTenChuHo;
            SoNha = soNha;
            MaSoCongTo = maSoCongTo;
        }

        public override string ToString()
        {
            return $"Ho Ten Chu Ho: {HoTenChuHo}, So Nha: {SoNha}, Ma So Cong To: {MaSoCongTo}";
        }
    }
}
