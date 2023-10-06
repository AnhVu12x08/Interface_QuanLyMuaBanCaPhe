using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    internal class CaPheDongGoi: CaPhe
    {
        private string loaiBaoBi;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap vao loai bao bi: nhua hoac hopnhua ");
            loaiBaoBi = Console.ReadLine();
        }
        public override double thanhTien()
        {
            if (loaiBaoBi.ToLower() == "giay")
            {
                return soLuong * donGia * 1.1;
            }
            else if (loaiBaoBi.ToLower().Replace(" ", "") == "hopnhua")
                return soLuong * donGia * 1.2;
            else
            {
                Console.WriteLine("Loai bao bi khong hop le");
                return soLuong * donGia * 1;
            } 
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine();
        }
    }
}
