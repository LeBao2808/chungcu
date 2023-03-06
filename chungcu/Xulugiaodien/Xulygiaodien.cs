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
    public class Xulygiaodien
    {
        DLDD dtxl = new DLDD();
        public Xulygiaodien(DLDD dtxl)
        {
            this.dtxl = dtxl;
        }
        public void giaodien()
        {
            trove:
            do
            {
                Console.WriteLine("nhap 1 de nhap khu dat \n nhap 2 de xuat \n nhap 3 de dung  ");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                if(n == 1)
                {
                    nhapkhudat();
                }
                if(n == 2)
                {
                    xuatkhudat();
                }
                if(n == 3)
                {
                    Console.WriteLine("nhap tiep can ho cho khu dat");
                    break;
                }
            }while(true);
            do
            {
                Console.WriteLine("nhap 1 de them can ho cho khu dat \n nhap 2 de xuat \n nhap 3 de dung ");
                int m = int.Parse(Console.ReadLine());  
                Console.Clear();
                if(m == 1)
                {
                    themkhudatchocanho();
                }
                if(m == 2)
                {
                    xuat();
                }
                if(m == 3)
                {
                    break;
                }

            }while(true);
            do
            {
                Console.WriteLine("nhap 1 de them chung cu cho can ho \n nhap 2 de xuat \n nhap 3 de dung \n nhap 4 de quay tro lai nhap khu datttttt  ");
                int m = int.Parse(Console.ReadLine());
                Console.Clear();
                if (m == 1)
                {
                   themcanhochokhudat();
                }
                if (m == 2)
                {
                    xuat();
                }
                if (m == 3)
                {
                    Console.WriteLine(" dung lai thoi dumemay");
                    break;
                }
                if(m == 4)
                {
                    Console.WriteLine("quay ve nhap them khu dat ");
                    goto trove;
                }

            } while (true);
        }
        public void themkhudatchocanho()
        {
            Console.WriteLine("nhap ma khu dat can them");
            string makhudat = Console.ReadLine();
            foreach (var i in dtxl.KhuDats)
            {
                if (makhudat == i.makhudat)
                {
                   nhapcanho();
                }
            }
        }
        public void themcanhochokhudat()
        {
            Console.WriteLine("nhap ma can ho can them ");
            string macanho = Console.ReadLine();
            foreach(var i in dtxl.CanHos)
            {
                if(macanho == i.macanho)
                {
                    nhapchungcu();
                }
            }
        }
        public void nhapkhudat()
        {
            Xulydulieukhudat dlkd = new Xulydulieukhudat(dtxl);
            Xulygiaodienkhudat gdkd = new Xulygiaodienkhudat(dlkd);
            KhuDat khudat = new KhuDat();
            gdkd.nhapdulieukhudat(khudat);
        }
        public void nhapcanho()
        {
            Xulydulieucanho dlch = new Xulydulieucanho(dtxl);
            Xulygiaodiencanho gdch = new Xulygiaodiencanho(dlch);
            CanHo canho = new CanHo();
            gdch.nhapdulieu(canho);
        }
        public void nhapchungcu()
        {
           Xulydulieuchungcu dlcc = new Xulydulieuchungcu(dtxl);
           Xulygiaodienchungcu gdcc = new Xulygiaodienchungcu(dlcc);
            ChungCu chungcu = new ChungCu();
            gdcc.nhapdulieucc(chungcu);

        }
        public void xuat()
        {
            xuatkhudat();
            xuatcanho();
            xuatchungcu();
        }
        public void xuatkhudat()
        {
            Xulydulieukhudat dlkd = new Xulydulieukhudat(dtxl);
            Xulygiaodienkhudat gdkd = new Xulygiaodienkhudat(dlkd);
            foreach(var i in dtxl.KhuDats)
            {
                gdkd.xuat(i);
            }
        }
        public void xuatcanho()
        {
            Xulydulieucanho dlch = new Xulydulieucanho(dtxl);
            Xulygiaodiencanho gdch = new Xulygiaodiencanho(dlch);
            foreach(var i in dtxl.CanHos)
            {
                gdch.xuat(i);
            }
        }
        public void xuatchungcu()
        {
            Xulydulieuchungcu dlcc = new Xulydulieuchungcu(dtxl);
            Xulygiaodienchungcu gdcc = new Xulygiaodienchungcu(dlcc);
           foreach(var i in dtxl.ChungCus)
            {
                gdcc.xuatdulieucc(i);
            }
        }
    }
}
