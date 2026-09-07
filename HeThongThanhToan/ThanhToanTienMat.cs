using System;

namespace HeThongThanhToan
{
    public class ThanhToanTienMat : PhuongThucThanhToan
    {
        public override string TenPhuongThuc => "Tiền mặt";

        public decimal TienKhachDua { get; set; }

        // Tiền thừa tính tự động
        public decimal TienThua => TienKhachDua - SoTien;

        // Không có phí
        public override decimal TinhPhiGiaoDich(decimal soTien) => 0;

        // Luôn trả về true
        public override bool XacNhan() => true;

        public override void ThongTinGiaoDich(decimal soTien)
        {
            base.ThongTinGiaoDich(soTien);
            Console.WriteLine($"Tiền khách đưa: {TienKhachDua:N0} đ | Tiền thừa: {TienThua:N0} đ");
        }
    }
}
