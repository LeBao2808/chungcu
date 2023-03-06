using chungcu.DaTa;
using chungcu.Model;
using chungcu.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu.Xulugiaodien
{
    public class Xulygiaodienkhudat
    {
        Xulydulieukhudat xulydulieukhudat;
        public Xulygiaodienkhudat(Xulydulieukhudat xulydulieukhudat) {
            this.xulydulieukhudat= xulydulieukhudat;
        }
        private KhuDat nhapdulieukhudats()
        {
            KhuDat kd = new KhuDat();
            Console.WriteLine("Nhap ma khu dat : ");
            kd.makhudat= Console.ReadLine();
            Console.WriteLine("Nhap dia chi khu dat : ");
            kd.diachi= Console.ReadLine();
            return kd;
        }
        public void nhapdulieukhudat(KhuDat kd)
        {
            kd = nhapdulieukhudats();
            xulydulieukhudat.ADDkhudat(kd);
        }
        public void xuat(KhuDat kd)
        {
            Console.WriteLine("Xuat khu dat ---->");
            Console.WriteLine("ma khu dat " + kd.makhudat);
            Console.WriteLine("dia chi khu dat " + kd.diachi);
        }
        
    }
}
