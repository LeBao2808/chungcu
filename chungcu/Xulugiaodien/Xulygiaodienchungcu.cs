using chungcu.Model;
using chungcu.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu.Xulugiaodien
{
    public class Xulygiaodienchungcu
    {
          Xulydulieuchungcu chungcu;
        public Xulygiaodienchungcu(Xulydulieuchungcu xl) {
            this.chungcu = xl;
        }
        private ChungCu nhapdulieuchungcu()
        {
            ChungCu cc = new ChungCu();
            Console.WriteLine("nhap ma chung cu : ");
            cc.machungcu = Console.ReadLine();
            Console.WriteLine("nhap dia chi chung cu : ");
            cc.diachi = Console.ReadLine();
            return cc;
        }
        public void nhapdulieucc(ChungCu cc)
        {
            cc = nhapdulieuchungcu();
            chungcu.ADDchungcu(cc);
        }
        public void xuatdulieucc(ChungCu cc)
        {
            Console.WriteLine("Xuat du lieu chung cu : ");
            Console.WriteLine("Ma chung cu : " + cc.machungcu);
            Console.WriteLine("Dia chi chung cu : " + cc.diachi);
        }
    }
}
