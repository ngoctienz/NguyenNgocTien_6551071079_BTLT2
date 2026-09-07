namespace QuanLySachCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nguyễn Ngọc Tiên - 6551071079\n");

            /*
            • Tạo ít nhất 3 đối tượng Sach bằng các cách khác nhau (constructor đầy đủ, constructor
                mặc định rồi gán property, Object Initializer)
            • Gọi HienThiThongTin() cho từng đối tượng
            • Thử gán giá trị không hợp lệ cho NamXuatBan và quan sát kết quả (bắt ngoại lệ nếu cần)

            */

            Sach sach1 = new Sach("S001", "C# Programming", "Nguyen Van A", 2020, 150000);
            Sach sach2 = new Sach("S002", "Java Programming", "Tran Thi B", 2019, 120000);
            Sach sach3 = new Sach();

            sach3._maSach = "S003";
            sach3._tenSach = "Python Programming";
            sach3._tacGia = "Le Van C";
            sach3._namXuatBan = 2021;
            sach3._giaBan = 180000;

            sach1.HienThiThongTin();
            sach2.HienThiThongTin();
            sach3.HienThiThongTin();

        }
    }
}
