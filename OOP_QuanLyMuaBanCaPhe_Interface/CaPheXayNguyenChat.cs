using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    public class CaPheXayNguyenChat : CaPhe, IHoTro
    {
        public CaPheXayNguyenChat() : base()
        {
        }
        public CaPheXayNguyenChat(string maCaPhe, string tenCaPhe, double soLuong, double donGia) : base(maCaPhe, tenCaPhe, soLuong, donGia)
        {
        }
        public double congXay()
        {
            if (soLuong < 100)
            {
                return 100*soLuong;
            }
            else
            {
                return 95*soLuong;
            }
        }
        public override double thanhTien()
        {
            return (soLuong * donGia) + congXay();
        }
        public double IkinhPhiHoTro()
        {
            return soLuong * 12;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Kinh phi ho tro la: " + IkinhPhiHoTro());
        }
    }
}
