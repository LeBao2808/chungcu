using chungcu.DaTa;
using chungcu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chungcu.XuLyDuLieu
{
    public class Xulydulieukhudat
    {
        DLDD dl = new DLDD();
        public Xulydulieukhudat(DLDD dl)
        {
            this.dl = dl;
        }
        public void ADDkhudat(KhuDat khudat)
        {
            dl.KhuDats.Add(khudat);
        }
        public List<KhuDat> laydulieukhudat()
        {
            return dl.KhuDats;
        }
    }
}
