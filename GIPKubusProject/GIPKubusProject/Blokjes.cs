using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIPKubusProject
{
    class Blokjes
    {
        /*private List<Blokje> blokjesLst;

        public List<Blokje> BlokjesLst
        {
            get { return blokjesLst; }
        }*/

        private List<Blokje> BlokjesLst { get; set; }

        public Blokjes()
        {
            BlokjesLst = new List<Blokje>();
        }
        public static void AddBlokje(string blokjeNaam, System.Windows.Forms.Panel blokjePanel)
        {
            Blokje blokje = new Blokje(blokjeNaam, blokjePanel);
        }
    }
}
