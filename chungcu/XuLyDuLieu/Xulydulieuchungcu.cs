using chungcu.DaTa;
using chungcu.Model;
using System.Collections.Generic;

namespace chungcu.XuLyDuLieu
{
    public class Xulydulieuchungcu
    {
        DLDD dl = new DLDD();
        public Xulydulieuchungcu(DLDD dl) { 
            this.dl = dl;
        }
       
      
        public void ADDchungcu(ChungCu chungcu)
        {
            dl.ChungCus.Add(chungcu);
        }
       
        public List<ChungCu> laydulieuchungcu()
        {
            return dl.ChungCus;
        }
        
    }
}
