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

            // • Tạo 3 nhân viên dùng các overload constructor khác nhau
            NhanVien nv1 = new NhanVien("NV001", "Nguyen Van A", 6000000, 26, 2); // Constructor đầy đủ
            NhanVien nv2 = new NhanVien("NV002", "Tran Thi B");                    // Constructor 2 tham số
            nv2.LuongCoBan = 5000000;
            nv2.SoNgayLam = 20;

            // • Dùng Named Arguments khi gọi constructor Optional Parameters
            NhanVien nv3 = new NhanVien(maNV: "NV003", hoTen: "Le Van C", soNgayLam: 22);

            Console.WriteLine("--- THÔNG TIN LƯƠNG THỰC NHẬN ---");
            Console.WriteLine($"NV1 ({nv1.HoTen}): Lương cơ bản = {nv1.LuongCoBan:N0} đ | Lương thực nhận = {nv1.LuongThucNhan:N0} đ");
            Console.WriteLine($"NV2 ({nv2.HoTen}): Lương cơ bản = {nv2.LuongCoBan:N0} đ | Lương thực nhận = {nv2.LuongThucNhan:N0} đ");
            Console.WriteLine($"NV3 ({nv3.HoTen}): Lương cơ bản = {nv3.LuongCoBan:N0} đ | Lương thực nhận = {nv3.LuongThucNhan:N0} đ\n");

            // • Gọi cả 3 overload TinhThuong và in kết quả so sánh
            decimal thuong1 = nv1.TinhThuong();                      // Overload 1: không tham số (trả về 0)
            decimal thuong2 = nv2.TinhThuong(1.2m);                  // Overload 2: có hệ số
            decimal thuong3 = nv3.TinhThuong(1.5m, coPhucLoi: true); // Overload 3: có hệ số + phúc lợi

            Console.WriteLine("--- SO SÁNH 3 OVERLOAD TÍNH THƯỞNG ---");
            Console.WriteLine($"Thưởng NV1 (không tham số)            : {thuong1:N0} đ");
            Console.WriteLine($"Thưởng NV2 (hệ số 1.2)                 : {thuong2:N0} đ");
            Console.WriteLine($"Thưởng NV3 (hệ số 1.5 + phúc lợi 500k) : {thuong3:N0} đ");

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}
