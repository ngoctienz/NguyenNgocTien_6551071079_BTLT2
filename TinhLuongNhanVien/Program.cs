namespace TinhLuongNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nguyễn Ngọc Tiên - 6551071079\n");

            /*
            • Tạo 3 nhân viên dùng các overload constructor khác nhau
• Dùng Named Arguments khi gọi constructor Optional Parameters (ví dụ: new
NhanVien(maNV: "NV001", hoTen: "An", soNgayLam: 20))
• Gọi cả 3 overload TinhThuong và in kết quả so sánh
            */

            NhanVien nv1 = new NhanVien("NV001", "Nguyen Van A", 6000000, 26, 2);
            NhanVien nv2 = new NhanVien("NV002", "Tran Thi B", 5000000, 20, 1);
            NhanVien nv3 = new NhanVien(maNV: "NV003", hoTen: "Le Van C", soNgayLam: 22);

            decimal thuong1 = nv1.TinhThuong();
            decimal thuong2 = nv2.TinhThuong();
            decimal thuong3 = nv3.TinhThuong();

            Console.WriteLine($"Thưởng nhân viên 1: {thuong1}");
            Console.WriteLine($"Thưởng nhân viên 2: {thuong2}");
            Console.WriteLine($"Thưởng nhân viên 3: {thuong3}");

        }
    }
}
