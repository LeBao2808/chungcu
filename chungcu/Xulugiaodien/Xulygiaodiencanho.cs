using chungcu.Model;
using chungcu.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu.Xulugiaodien
{
    public class Xulygiaodiencanho
    {
        Xulydulieucanho xl;
        public Xulygiaodiencanho(Xulydulieucanho xl) 
        { this.xl = xl; }
        private CanHo nhapdulieucanho()
        {
            CanHo ch = new CanHo();
            Console.WriteLine("nhap ma can ho : ");
            ch.macanho = Console.ReadLine();
            Console.WriteLine("nhap dia chi can ho : ");
            ch.diachi = Console.ReadLine();
            return ch;
        }
        public void nhapdulieu(CanHo ch)
        {
            ch = nhapdulieucanho();
            xl.ADDcanho(ch);
        }
        public void xuat(CanHo ch) {
            Console.WriteLine("xuat du lieu can ho ---->");
            Console.WriteLine("Ma can ho : " + ch.macanho);
            Console.WriteLine("Dia chi can ho : " + ch.diachi);
        }

    }
}
