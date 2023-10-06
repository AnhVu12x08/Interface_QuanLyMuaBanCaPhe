using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyMuaBanCaPhe_Interface
{
    class program
    {
        static void Main(string[] args)
        {
            CaPheHat caPheHat = new CaPheHat();
            caPheHat.nhap();
            caPheHat.xuat();

            CaPheXayNguyenChat caPheXayNguyenChat = new CaPheXayNguyenChat();
            caPheXayNguyenChat.nhap();
            caPheXayNguyenChat.xuat();

            CaPheXayCoHuongLieu caPheXayCoHuongLieu = new CaPheXayCoHuongLieu();
            caPheXayCoHuongLieu.nhap();
            caPheXayCoHuongLieu.xuat();

            CaPheDongGoi caPheDongGoi = new CaPheDongGoi();
            caPheDongGoi.nhap();
            caPheDongGoi.xuat();
            
        }
    }
}