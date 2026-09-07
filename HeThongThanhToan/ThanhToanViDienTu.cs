using System;

namespace HeThongThanhToan
{
    public class ThanhToanViDienTu : PhuongThucThanhToan
    {
        public override string TenPhuongThuc => "Ví điện tử";

        public string TenVi { get; set; } = "MoMo";

        // Phí 0.5% nhưng tối thiểu 2.000đ
        public override decimal TinhPhiGiaoDich(decimal soTien)
        {
            decimal phi = soTien * 0.005m;
            return phi < 2000 ? 2000 : phi;
        }

        // Luôn true nếu số tiền <= 10.000.000đ
        public override bool XacNhan()
        {
            return SoTien <= 10000000;
        }

        public override void ThongTinGiaoDich(decimal soTien)
        {
            base.ThongTinGiaoDich(soTien);
            Console.WriteLine($"Tên ví: {TenVi}");
        }
    }
}
