using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    public abstract class CaPhe
    {
        protected string maCaPhe;
        protected string tenCaPhe;
        protected double soLuong;
        protected double donGia;

        public CaPhe()
        {
            maCaPhe = "";
            tenCaPhe = "";
            soLuong = 0.0;
            donGia = 0.0;
        }

        public CaPhe(string maCaPhe, string tenCaPhe, double soLuong, double donGia)
        {
            this.maCaPhe = maCaPhe;
            this.tenCaPhe = tenCaPhe;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public abstract double thanhTien();
        public virtual void nhap()
        {
            Console.WriteLine("Nhap vao ma ca phe: ");
            maCaPhe = Console.ReadLine();
            Console.WriteLine("Nhap vao ten ca phe: ");
            tenCaPhe = Console.ReadLine();
            Console.WriteLine("Nhap vao so luong: ");
            soLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma ca phe: " + maCaPhe);
            Console.WriteLine("Ten ca phe: " + tenCaPhe);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Thanh tien: {0:f} ",thanhTien());
        }
    }
}
