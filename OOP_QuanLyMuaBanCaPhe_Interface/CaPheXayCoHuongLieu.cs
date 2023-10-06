using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    internal class CaPheXayCoHuongLieu : CaPhe
    {
        double soLuongHuongLieu;
        double giaHuongLieu;
        public CaPheXayCoHuongLieu() : base()
        {
        }
        public CaPheXayCoHuongLieu(string maCaPhe, string tenCaPhe, double soLuong, double donGia, double soLuongHuongLieu, double giaHuongLieu) : base(maCaPhe, tenCaPhe, soLuong, donGia)
        {
        this.soLuongHuongLieu = soLuongHuongLieu;
        this.giaHuongLieu = giaHuongLieu;
        }
        public override double thanhTien()
        {
            return (soLuong * donGia) + (soLuongHuongLieu * giaHuongLieu) + (soLuong*2);
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap vao so luong huong lieu: ");
            soLuongHuongLieu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia huong lieu: ");
            giaHuongLieu = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So luong huong lieu la: " + soLuongHuongLieu);
            Console.WriteLine("Gia huong lieu la: " + giaHuongLieu);
        }
    }
}
