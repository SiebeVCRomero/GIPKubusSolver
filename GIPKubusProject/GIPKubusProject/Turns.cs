using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GIPKubusProject
{

    public class Turns
    {
        #region Normaal

        public static List<Blokje> U(List<Blokje> lstBlokjes)
        {
            //WIT
            Blokje WCorner1 = lstBlokjes.Find(x => x.AdresBlokje == "UpLeftUp");
            int WCorner1i = lstBlokjes.IndexOf(WCorner1);
            Blokje WEdge2 = lstBlokjes.Find(x => x.AdresBlokje == "UpMiddleUp");
            int WEdge2i = lstBlokjes.IndexOf(WEdge2);
            Blokje WCorner3 = lstBlokjes.Find(x => x.AdresBlokje == "UpRightUp");
            int WCorner3i = lstBlokjes.IndexOf(WCorner3);
            Blokje WEdge4 = lstBlokjes.Find(x => x.AdresBlokje == "UpLeftMiddle");
            int WEdge4i = lstBlokjes.IndexOf(WEdge4);
            Blokje WEdge6 = lstBlokjes.Find(x => x.AdresBlokje == "UpRightMiddle");
            int WEdge6i = lstBlokjes.IndexOf(WEdge6);
            Blokje WCorner7 = lstBlokjes.Find(x => x.AdresBlokje == "UpLeftDown");
            int WCorner7i = lstBlokjes.IndexOf(WCorner7);
            Blokje WEdge8 = lstBlokjes.Find(x => x.AdresBlokje == "UpMiddleDown");
            int WEdge8i = lstBlokjes.IndexOf(WEdge8);
            Blokje WCorner9 = lstBlokjes.Find(x => x.AdresBlokje == "UpRightDown");
            int WCorner9i = lstBlokjes.IndexOf(WCorner9);


            //BLAUW
            Blokje BCorner1 = lstBlokjes.Find(x => x.AdresBlokje == "BackLeftUp");
            int BCorner1i = lstBlokjes.IndexOf(BCorner1);
            Blokje BEdge2 = lstBlokjes.Find(x => x.AdresBlokje == "BackMiddleUp");
            int BEdge2i = lstBlokjes.IndexOf(BEdge2);
            Blokje BCorner3 = lstBlokjes.Find(x => x.AdresBlokje == "BackRightUp");
            int BCorner3i = lstBlokjes.IndexOf(BCorner3);


            //ROOD
            Blokje RCorner1 = lstBlokjes.Find(x => x.AdresBlokje == "RightLeftUp");
            int RCorner1i = lstBlokjes.IndexOf(RCorner1);
            Blokje REdge2 = lstBlokjes.Find(x => x.AdresBlokje == "RightMiddleUp");
            int REdge2i = lstBlokjes.IndexOf(REdge2);
            Blokje RCorner3 = lstBlokjes.Find(x => x.AdresBlokje == "RightRightUp");
            int RCorner3i = lstBlokjes.IndexOf(RCorner3);


            //GROEN
            Blokje GEdge2 = lstBlokjes.Find(x => x.AdresBlokje == "FrontLeftUp");
            int GEdge2i = lstBlokjes.IndexOf(GEdge2);
            Blokje GCorner3 = lstBlokjes.Find(x => x.AdresBlokje == "FrontMiddelUp");
            int GCorner3i = lstBlokjes.IndexOf(GCorner3);
            Blokje GCorner1 = lstBlokjes.Find(x => x.AdresBlokje == "FrontRightUp");
            int GCorner1i = lstBlokjes.IndexOf(GCorner1);


            //ORANJE
            Blokje OCorner1 = lstBlokjes.Find(x => x.AdresBlokje == "LeftLeftUp");
            int OCorner1i = lstBlokjes.IndexOf(OCorner1);
            Blokje OEdge2 = lstBlokjes.Find(x => x.AdresBlokje == "LeftMiddleUp");
            int OEdge2i = lstBlokjes.IndexOf(OEdge2);
            Blokje OCorner3 = lstBlokjes.Find(x => x.AdresBlokje == "LeftMiddleUp");
            int OCorner3i = lstBlokjes.IndexOf(OCorner3);

            //Wit vlak draaien
            //Corners
            string onthoudWCorner = WCorner1.AdresBlokje;
            WCorner1.AdresBlokje = WCorner3.AdresBlokje;
            WCorner3.AdresBlokje = WCorner7.AdresBlokje;
            WCorner9.AdresBlokje = WCorner7.AdresBlokje;
            WCorner7.AdresBlokje = onthoudWCorner;

            string onthoud1 = RCorner1.AdresBlokje;
            string onthoud3 = RCorner3.AdresBlokje;


            //Zijkant
            RCorner1.AdresBlokje = GCorner1.AdresBlokje;
            RCorner3.AdresBlokje = GCorner3.AdresBlokje;

            GCorner1.AdresBlokje = OCorner1.AdresBlokje;
            GCorner3.AdresBlokje = OCorner3.AdresBlokje;

            OCorner1.AdresBlokje = BCorner1.AdresBlokje;
            OCorner3.AdresBlokje = BCorner3.AdresBlokje;

            BCorner1.AdresBlokje = onthoud1;
            BCorner3.AdresBlokje = onthoud3;


            //Edges
            string onthoudWEdge = WEdge2.AdresBlokje;
            

            WEdge2.AdresBlokje = WEdge6.AdresBlokje;
            WEdge6.AdresBlokje = WEdge8.AdresBlokje;
            WEdge8.AdresBlokje = WEdge4.AdresBlokje;
            WEdge4.AdresBlokje = onthoudWEdge;

            //Edges zijkant
            string onthoud2 = REdge2.AdresBlokje;
            REdge2.AdresBlokje = GEdge2.AdresBlokje;
            GEdge2.AdresBlokje = OEdge2.AdresBlokje;
            OEdge2.AdresBlokje = BEdge2.AdresBlokje;
            BEdge2.AdresBlokje = onthoud2;

            //List aanpassen
            lstBlokjes[WCorner1i] = WCorner1;
            lstBlokjes[WEdge2i] = WEdge2;
            lstBlokjes[WCorner3i] = WCorner3;
            lstBlokjes[WEdge4i] = WEdge4;
            lstBlokjes[WEdge6i] = WEdge6;
            lstBlokjes[WCorner7i] = WCorner7;
            lstBlokjes[WEdge8i] = WEdge8;
            lstBlokjes[WCorner9i] = WCorner9;
            lstBlokjes[BCorner1i] = BCorner1;
            lstBlokjes[BEdge2i] = BEdge2;
            lstBlokjes[BCorner3i] = BCorner3;
            lstBlokjes[RCorner1i] = RCorner1;
            lstBlokjes[REdge2i] = REdge2;
            lstBlokjes[RCorner3i] = RCorner3;
            lstBlokjes[GCorner1i] = GCorner1;
            lstBlokjes[GEdge2i] = GEdge2;
            lstBlokjes[GCorner3i] = GCorner3;
            lstBlokjes[OCorner1i] = OCorner1;
            lstBlokjes[OEdge2i] = OEdge2;
            lstBlokjes[OCorner3i] = OCorner3;

            return lstBlokjes;
        }
        public bool D()
        {   
            return true;
        }

        public bool F()
        {

            return true;
        }

        public bool B()
        {

            return true;
        }

        public bool R()
        {

            return true;
        }

        public bool L()
        {

            return true;
        }

        #endregion

        #region Prime

        public bool UPrime()
        {
            return true;
        }

        public bool DPrime()
        {

            return true;
        }

        public bool FPrime()
        {

            return true;
        }

        public bool BPrime()
        {

            return true;
        }

        public bool RPrime()
        {

            return true;
        }

        public bool LPrime()
        {

            return true;
        }

        #endregion
    }
}

