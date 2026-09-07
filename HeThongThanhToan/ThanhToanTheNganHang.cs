using System;

namespace HeThongThanhToan
{
    public class ThanhToanTheNganHang : PhuongThucThanhToan
    {
        private string _soThe = "";
        public override string TenPhuongThuc => "Thẻ ngân hàng";

        // Che 8 số đầu
        public string SoThe
        {
            get
            {
                if (_soThe.Length > 8)
                    return "********" + _soThe.Substring(8);
                return "********";
            }
            set => _soThe = value;
        }

        // Phí giao dịch 1.5%
        public override decimal TinhPhiGiaoDich(decimal soTien) => soTien * 0.015m;

        // Giả lập kiểm tra số dư: ngẫu nhiên true/false
        public override bool XacNhan()
        {
            Random rd = new Random();
            return rd.Next(2) == 1;
        }

        public override void ThongTinGiaoDich(decimal soTien)
        {
            base.ThongTinGiaoDich(soTien);
            Console.WriteLine($"Số thẻ: {SoThe}");
        }
    }
}
