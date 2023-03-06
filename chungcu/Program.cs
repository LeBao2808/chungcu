using chungcu.DaTa;
using chungcu.Xulugiaodien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLDD dtxl = new DLDD();
            Xulygiaodien xl = new Xulygiaodien(dtxl);
            xl.giaodien();
            Console.ReadLine();
        }
    }
}
