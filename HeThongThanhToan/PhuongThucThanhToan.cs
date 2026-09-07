using System;

namespace HeThongThanhToan
{
    public abstract class PhuongThucThanhToan
    {
        // Property chỉ đọc
        public abstract string TenPhuongThuc { get; }

        public decimal SoTien { get; set; }

        // Abstract method
        public abstract decimal TinhPhiGiaoDich(decimal soTien);
        public abstract bool XacNhan();

        // Non-abstract method gọi các abstract method bên trong
        public virtual void ThongTinGiaoDich(decimal soTien)
        {
            SoTien = soTien;
            decimal phi = TinhPhiGiaoDich(soTien);
            decimal tongTien = soTien + phi;
            bool hopLe = XacNhan();

            Console.WriteLine($"--- Phương thức: {TenPhuongThuc} ---");
            Console.WriteLine($"Số tiền: {soTien:N0} đ | Phí giao dịch: {phi:N0} đ | Tổng trả: {tongTien:N0} đ");
            Console.WriteLine($"Xác nhận: {(hopLe ? "Thành công" : "Thất bại")}");
        }
    }
}
