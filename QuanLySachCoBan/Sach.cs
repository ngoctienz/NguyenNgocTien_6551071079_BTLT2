namespace QuanLySachCoBan
{
    
// Khai báo các field private: _maSach (string), _tenSach (string), _tacGia (string),_namXuatBan (int), _giaBan (double)
    public class Sach
    {
        
        public string _maSach { get; set; }
        public string _tenSach { get; set; }
        public string _tacGia { get; set; }
        public int _namXuatBan { get; set; }
        public double _giaBan { get; set; }

        public Sach()
        {
           _maSach = "N/A";
            _tenSach = "N/A";
            _tacGia = "N/A";
            _namXuatBan = 0;
            _giaBan = 0.0;
        }

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            _tenSach = tenSach;
            _tacGia = tacGia;
            _namXuatBan = namXuatBan;
            _giaBan = giaBan;
        }

// Khai báo Property public cho từng field: TenSach (đọc/ghi, validate không rỗng),
// NamXuatBan (đọc/ghi, validate từ 1900 đến năm hiện tại), GiaBan (chỉ đọc từ ngoài),
// MaSach (chỉ đọc)

        public string TenSach
        {
            get { return _tenSach; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("Tên sách không được rỗng.");
                }
            }
        }

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Năm xuất bản phải từ 1900 đến năm hiện tại.");
                }
            }
        }

        public double GiaBan
        {
            get { return _giaBan; }
            private set { _giaBan = value; }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã sách: {_maSach}");
            Console.WriteLine($"Tên sách: {_tenSach}");
            Console.WriteLine($"Tác giả: {_tacGia}");
            Console.WriteLine($"Năm xuất bản: {_namXuatBan}");
            Console.WriteLine($"Giá bán: {_giaBan}");
        }

        public override string? ToString()
        {
            return $"{_maSach} - {_tenSach} - {_tacGia} - {_namXuatBan} - {_giaBan}";
        }
    }


}