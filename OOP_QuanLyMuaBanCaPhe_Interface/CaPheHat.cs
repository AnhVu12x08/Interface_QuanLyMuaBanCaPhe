using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    public class CaPheHat : CaPhe, IHoTro
    {
        public CaPheHat():base()
        {
        }
        public CaPheHat(string maCaPhe, string tenCaPhe, double soLuong, double donGia) : base(maCaPhe, tenCaPhe, soLuong, donGia)
        {
        }
        public override double thanhTien()
        {
            return donGia * soLuong;
        }
        public double IkinhPhiHoTro()
        {
            return soLuong * 10;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Kinh phi ho tro la: "+IkinhPhiHoTro());
        }
    }
}
