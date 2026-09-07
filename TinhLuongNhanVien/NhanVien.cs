namespace TinhLuongNhanVien
{
    public class NhanVien
    {
        // • Khai báo field private: _maNV (string), _hoTen (string), _luongCoBan (decimal),_soNgayLam (int), _soNgayNghiPhep (int)

        private string _maNV;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        // Viết 3 phiên bản constructor (nạp chồng): constructor không tham số; constructor chỉ nhận mã NV và họ tên; constructor đầy đủ tham số
        public NhanVien()
        {
            _maNV = "N/A";
            _hoTen = "N/A";
            _luongCoBan = 0;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }

        public NhanVien(string maNV, string hoTen)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = 0;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }


        public NhanVien(string maNV, string hoTen, decimal luongCoBan, int soNgayLam, int soNgayNghiPhep)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = luongCoBan;
            _soNgayLam = soNgayLam;
            _soNgayNghiPhep = soNgayNghiPhep;
        }

        // Viết constructor có Optional Parameters: NhanVien(string maNV, string hoTen, decimal luong = 5_000_000, int soNgayLam = 26)
        public NhanVien(string maNV, string hoTen, decimal luongCoBan = 5000000, int soNgayLam = 26)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = luongCoBan;
            _soNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }

        // Khai báo Property: HoTen (đọc/ghi), LuongCoBan (đọc/ghi, validate >= 0), SoNgayLam (đọc/ghi, validate 0–31), LuongThucNhan (chỉ đọc, tính tự động)

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public decimal LuongCoBan
        {
            get { return _luongCoBan; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lương cơ bản phải lớn hơn hoặc bằng 0.");
                }
                _luongCoBan = value;
            }
        }

        public int SoNgayLam
        {
            get { return _soNgayLam; }
            set
            {
                if (value < 0 || value > 31)
                {
                    throw new ArgumentException("Số ngày làm phải nằm trong khoảng từ 0 đến 31.");
                }
                _soNgayLam = value;
            }
        }

        public int SoNgayNghiPhep
        {
            get { return _soNgayNghiPhep; }
            set { _soNgayNghiPhep = value; }
        }
        // Công thức LuongThucNhan = LuongCoBan / 26 × SoNgayLam − KhauTruBHXH (8% lương cơ bản)
       
        public decimal LuongThucNhan
        {
            get
            {
                decimal khauTruBHXH = _luongCoBan * 0.08m;
                return (_luongCoBan / 26) * _soNgayLam - khauTruBHXH;
            }
        }

        /*
        Viết 3 overload phương thức TinhThuong: TinhThuong() trả về 0; TinhThuong(decimal
        heSo) trả về LuongCoBan × heSo; TinhThuong(decimal heSo, bool coPhucLoi) cộng thêm
        500.000 nếu coPhucLoi = true
        */

        public decimal TinhThuong()
        {
            return 0;
        }

        public decimal TinhThuong(decimal heSo)
        {
            return _luongCoBan * heSo;
        }

        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = _luongCoBan * heSo;
            if (coPhucLoi)
            {
                thuong += 500000;
            }
            return thuong;
        }

    }
}