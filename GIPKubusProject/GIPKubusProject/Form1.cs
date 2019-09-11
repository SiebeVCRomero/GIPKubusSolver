using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIPKubusProject
{
    public partial class KubusSolverForm : System.Windows.Forms.Form
    {
        #region Blokjes + lijst

        List<Blokje> AlleBlokjes = new List<Blokje>();

        Blokje GCorner1 = new Blokje("GCorner1", "FrontLeftUp"),
            GEdge2 = new Blokje("GEdge2", "FrontMiddelUp"),
            GCorner3 = new Blokje("GCorner3", "FrontRightUp"),
            GEdge4 = new Blokje("GEdge4", "FrontLeftMiddle"),
            GCenter = new Blokje("GCenter", "FrontPanel"),
            GEdge6 = new Blokje("GEdge6", "FrontRightMiddle"),
            GCorner7 = new Blokje("GCorner7", "FrontLeftDown"),
            GEdge8 = new Blokje("GEdge8", "FrontMiddleDown"),
            GCorner9 = new Blokje("GCorner9", "FrontRightDown"),

            BCorner1 = new Blokje("BCorner1", "BackLeftUp"),
            BEdge2 = new Blokje("BEdge2", "BackMiddleUp"),
            BCorner3 = new Blokje("BCorner3", "BackRightUp"),
            BEdge4 = new Blokje("BEdge4", "BackLeftMiddle"),
            BCenter = new Blokje("BCenter", "BackPanel"),
            BEdge6 = new Blokje("BEdge6", "BackRightMiddle"),
            BCorner7 = new Blokje("BCorner7", "BackLeftDown"),
            BEdge8 = new Blokje("BEdge8", "BackMiddleDown"),
            BCorner9 = new Blokje("BCorner9", "BackRightDown"),

            WCorner1 = new Blokje("WCorner1", "UpLeftUp"),
            WEdge2 = new Blokje("WEdge2", "UpMiddleUp"),
            WCorner3 = new Blokje("WCorner3", "UpRightUp"),
            WEdge4 = new Blokje("WEdge4", "UpLeftMiddle"),
            WCenter = new Blokje("WCenter", "UpPanel"),
            WEdge6 = new Blokje("WEdge6", "UpRightMiddle"),
            WCorner7 = new Blokje("WCorner7", "UpLeftDown"),
            WEdge8 = new Blokje("WEdge8", "UpMiddleDown"),
            WCorner9 = new Blokje("WCorner9", "UpRightDown"),

            RCorner1 = new Blokje("RCorner1", "RightLeftUp"),
            REdge2 = new Blokje("REdge2", "RightMiddleUp"),
            RCorner3 = new Blokje("RCorner3", "RightRightUp"),
            REdge4 = new Blokje("REdge4", "RightLeftMiddle"),
            RCenter = new Blokje("RCenter", "RightPanel"),
            REdge6 = new Blokje("REdge6", "RightRightMiddle"),
            RCorner7 = new Blokje("RCorner7", "RightLeftDown"),
            REdge8 = new Blokje("REdge8", "RightMiddleDown"),
            RCorner9 = new Blokje("RCorner9", "RightRightDown"),

            YCorner1 = new Blokje("YCorner1", "DownLeftUp"),
            YEdge2 = new Blokje("YEdge2", "DownMiddleUp"),
            YCorner3 = new Blokje("YCorner3", "DownRightUp"),
            YEdge4 = new Blokje("YEdge4", "DownLeftMIddle"),
            YCenter = new Blokje("YCenter", "DownPanel"),
            YEdge6 = new Blokje("YEdge6", "DownRightMiddle"),
            YCorner7 = new Blokje("YCorner7", "DownLeftDown"),
            YEdge8 = new Blokje("YEdge8", "DownMiddleDown"),
            YCorner9 = new Blokje("YCorner9", "DownRightDown"),

            OCorner1 = new Blokje("OCorner1", "LeftLeftUp"),
            OEdge2 = new Blokje("OEdge2", "LeftMiddleUp"),
            OCorner3 = new Blokje("OCorner3", "LeftRightUp"),
            OEdge4 = new Blokje("OEdge4", "LeftLeftMiddle"),
            OCenter = new Blokje("OCenter", "LeftPanel"),
            OEdge6 = new Blokje("OEdge6", "LeftRightMiddle"),
            OCorner7 = new Blokje("OCorner7", "LeftLeftDown"),
            OEdge8 = new Blokje("OEdge8", "LeftMiddleDown"),
            OCorner9 = new Blokje("OCorner9", "LeftRightDown");

        #endregion

        /// <summary>
        /// vult de list "AlleBlokjes" in
        /// </summary>
        public void ListMaker()
        {
            AlleBlokjes.Add(GCorner1);
            AlleBlokjes.Add(GEdge2);
            AlleBlokjes.Add(GCorner3);
            AlleBlokjes.Add(GEdge4);
            AlleBlokjes.Add(GCenter);
            AlleBlokjes.Add(GEdge6);
            AlleBlokjes.Add(GCorner7);
            AlleBlokjes.Add(GEdge8);
            AlleBlokjes.Add(GCorner9);
            AlleBlokjes.Add(BCorner1);
            AlleBlokjes.Add(BEdge2);
            AlleBlokjes.Add(BCorner3);
            AlleBlokjes.Add(BEdge4);
            AlleBlokjes.Add(BCenter);
            AlleBlokjes.Add(BEdge6);
            AlleBlokjes.Add(BCorner7);
            AlleBlokjes.Add(BEdge8);
            AlleBlokjes.Add(BCorner9);
            AlleBlokjes.Add(WCorner1);
            AlleBlokjes.Add(WEdge2);
            AlleBlokjes.Add(WCorner3);
            AlleBlokjes.Add(WEdge4);
            AlleBlokjes.Add(WCenter);
            AlleBlokjes.Add(WEdge6);
            AlleBlokjes.Add(WCorner7);
            AlleBlokjes.Add(WEdge8);
            AlleBlokjes.Add(WCorner9);
            AlleBlokjes.Add(RCorner1);
            AlleBlokjes.Add(REdge2);
            AlleBlokjes.Add(RCorner3);
            AlleBlokjes.Add(REdge4);
            AlleBlokjes.Add(RCenter);
            AlleBlokjes.Add(REdge6);
            AlleBlokjes.Add(RCorner7);
            AlleBlokjes.Add(REdge8);
            AlleBlokjes.Add(RCorner9);
            AlleBlokjes.Add(YCorner1);
            AlleBlokjes.Add(YEdge2);
            AlleBlokjes.Add(YCorner3);
            AlleBlokjes.Add(YEdge4);
            AlleBlokjes.Add(YCenter);
            AlleBlokjes.Add(YEdge6);
            AlleBlokjes.Add(YCorner7);
            AlleBlokjes.Add(YEdge8);
            AlleBlokjes.Add(YCorner9);
            AlleBlokjes.Add(OCorner1);
            AlleBlokjes.Add(OEdge2);
            AlleBlokjes.Add(OCorner3);
            AlleBlokjes.Add(OEdge4);
            AlleBlokjes.Add(OCenter);
            AlleBlokjes.Add(OEdge6);
            AlleBlokjes.Add(OCorner7);
            AlleBlokjes.Add(OEdge8);
            AlleBlokjes.Add(OCorner9);
        }

        private void Colorer(List<Blokje> lijstBlokjes)
        {
            //Adres geven
            //FRONT - GREEN
            FrontLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontLeftUp").KleurBlokje;
            FrontMiddelUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontMiddelUp").KleurBlokje;
            FrontRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontRightUp").KleurBlokje;
            FrontLeftMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontLeftMiddle").KleurBlokje;
            FrontPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontPanel").KleurBlokje;
            FrontRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontRightMiddle").KleurBlokje;
            FrontLeftDown.BackColor  = lijstBlokjes.Find(c => c.AdresBlokje == "FrontLeftDown").KleurBlokje;
            FrontMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontMiddleDown").KleurBlokje;
            FrontRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "FrontRightDown").KleurBlokje;
            //BACK - BLAUW
            BackLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackLeftUp").KleurBlokje;
            BackMiddleUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackMiddleUp").KleurBlokje;
            BackRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackRightUp").KleurBlokje;
            BackLeftMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackLeftMiddle").KleurBlokje;
            BackPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackPanel ").KleurBlokje;
            BackRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackRightMiddle").KleurBlokje;
            BackLeftDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackLeftDown").KleurBlokje;
            BackMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackMiddleDown").KleurBlokje;
            BackRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "BackRightDown").KleurBlokje;
            //UP - WHITE
            UpLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpLeftUp").KleurBlokje;
            UpMiddleUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpMiddleUp").KleurBlokje;
            UpRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpRightUp").KleurBlokje;
            UpLeftMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpLeftMiddle").KleurBlokje;
            UpPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpPanel").KleurBlokje;
            UpRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpRightMiddle").KleurBlokje;
            UpLeftDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpLeftDown").KleurBlokje;
            UpMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpMiddleDown").KleurBlokje;
            UpRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "UpRightDown").KleurBlokje;
            //RIGHT - RED
            RightLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightLeftUp").KleurBlokje;
            RightMiddleUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightMiddleUp").KleurBlokje;
            RightRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightRightUp").KleurBlokje;
            RightLeftMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightLeftMiddle").KleurBlokje;
            RightPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightPanel").KleurBlokje;
            RightRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightRightMiddle").KleurBlokje;
            RightLeftDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightLeftDown").KleurBlokje;
            RightMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightMiddleDown").KleurBlokje;
            RightRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "RightRightDown").KleurBlokje;
            //DOWN - YELLOW
            DownLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownLeftUp").KleurBlokje;
            DownMiddleUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownMiddleUp").KleurBlokje;
            DownRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownRightUp").KleurBlokje;
            DownLeftMIddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownLeftMIddle").KleurBlokje;
            DownPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownPanel").KleurBlokje;
            DownRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownRightMiddle").KleurBlokje;
            DownLeftDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownLeftDown").KleurBlokje;
            DownMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownMiddleDown").KleurBlokje;
            DownRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "DownRightDown").KleurBlokje;
            //LEFT - ORANGE
            LeftLeftUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftLeftUp").KleurBlokje;
            LeftMiddleUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftMiddleUp").KleurBlokje;
            LeftRightUp.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftRightUp").KleurBlokje;
            LeftLeftMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftLeftMiddle").KleurBlokje;
            LeftPanel.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftPanel").KleurBlokje;
            LeftRightMiddle.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftRightMiddle").KleurBlokje;
            LeftLeftDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftLeftDown").KleurBlokje;
            LeftMiddleDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftMiddleDown").KleurBlokje;
            LeftRightDown.BackColor = lijstBlokjes.Find(c => c.AdresBlokje == "LeftRightDown").KleurBlokje;



            Blokje OCorner1  = lijstBlokjes.Find(c => c.AdresBlokje == "OCorner1");
            Blokje OEdge2    = lijstBlokjes.Find(c => c.AdresBlokje == "OEdge2 ");
            Blokje OCorner3  = lijstBlokjes.Find(c => c.AdresBlokje == "OCorner3");
            Blokje OEdge4    = lijstBlokjes.Find(c => c.AdresBlokje == "OEdge4 ");
            Blokje OCenter   = lijstBlokjes.Find(c => c.AdresBlokje == "OCenter");
            Blokje OEdge6    = lijstBlokjes.Find(c => c.AdresBlokje == "OEdge6 ");
            Blokje OCorner7 = lijstBlokjes.Find(c => c.AdresBlokje == "OCorner7");
            Blokje OEdge8 = lijstBlokjes.Find(c => c.AdresBlokje == "OEdge8");
            Blokje OCorner9 = lijstBlokjes.Find(c => c.AdresBlokje == "OCorner9");


        }

        public KubusSolverForm()
        {
            InitializeComponent();
        }

        public void KubusSolverForm_Load(object sender, EventArgs e)
        {
            ListMaker();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Colorer(Turns.U(AlleBlokjes));
        }
    }
}