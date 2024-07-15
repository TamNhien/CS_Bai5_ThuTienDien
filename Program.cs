using CS_Bai5_ThuTienDien;

class Program
{
    static List<BienLai> bienLais = new List<BienLai>();

    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong ho su dung dien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            NhapThongTinBienLai();
        }

        Console.WriteLine("\nThong tin cac bien lai da nhap: ");
        HienThiThongTinBienLai();
    }

    static void NhapThongTinBienLai()
    {
        Console.WriteLine("Nhap ho ten chu ho: ");
        string hoTenChuHo = Console.ReadLine();

        Console.WriteLine("Nhap so nha: ");
        string soNha = Console.ReadLine();

        Console.WriteLine("Nhap ma so cong to: ");
        string maSoCongTo = Console.ReadLine();

        KhachHang khachHang = new KhachHang(hoTenChuHo, soNha, maSoCongTo);

        Console.WriteLine("Nhap chi so cu: ");
        int chiSoCu = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap chi so moi: ");
        int chiSoMoi = int.Parse(Console.ReadLine());

        BienLai bienLai = new BienLai(khachHang, chiSoCu, chiSoMoi);
        bienLais.Add(bienLai);
        Console.WriteLine("Da them thong tin bien lai thanh cong");
    }

    static void HienThiThongTinBienLai()
    {
        foreach (var bienLai in bienLais)
        {
            Console.WriteLine(bienLai);
        }
    }
}