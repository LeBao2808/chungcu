using chungcu.DaTa;
using chungcu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu.XuLyDuLieu
{
    public class Xulydulieucanho
    {
        DLDD dl = new DLDD();
        public Xulydulieucanho(DLDD dl) {
            this.dl = dl;
        }
        public void ADDcanho(CanHo canHo)
        {
            dl.CanHos.Add(canHo);
        }
        public List<CanHo> laydulieucanho()
        {
            return dl.CanHos;
        }
    }
}
