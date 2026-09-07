using System;
using System.Text;

namespace HeThongThanhToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            decimal hoaDon = 500000;

            // 1. Tạo mảng chứa cả 3 phương thức thanh toán
            PhuongThucThanhToan[] danhSach = new PhuongThucThanhToan[]
            {
                new ThanhToanTienMat { TienKhachDua = 600000 },
                new ThanhToanTheNganHang { SoThe = "9704220012345678" },
                new ThanhToanViDienTu { TenVi = "MoMo" }
            };

            Console.WriteLine($"HÓA ĐƠN: {hoaDon:N0} đ\n");

            // 2. Gọi ThongTinGiaoDich() cho từng phương thức (tính đa hình)
            foreach (var pt in danhSach)
            {
                pt.ThongTinGiaoDich(hoaDon);
                Console.WriteLine();
            }

            // 3. Tìm phương thức có phí thấp nhất
            PhuongThucThanhToan minPt = danhSach[0];
            foreach (var pt in danhSach)
            {
                if (pt.TinhPhiGiaoDich(hoaDon) < minPt.TinhPhiGiaoDich(hoaDon))
                {
                    minPt = pt;
                }
            }

            Console.WriteLine($"=> Phương thức có phí thấp nhất: {minPt.TenPhuongThuc} ({minPt.TinhPhiGiaoDich(hoaDon):N0} đ)");
        }
    }
}
