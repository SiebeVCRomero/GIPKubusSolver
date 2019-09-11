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
        public KubusSolverForm()
        {
            InitializeComponent();
        }

        private void KubusSolverForm_Load(object sender, EventArgs e)
        {
            #region Blokjes genereren

            Blokjes.AddBlokje()























            Blokje GCorner1 = new Blokje("GCorner1", FrontLeftUp);
            Blokje GEdge2 = new Blokje("GEdge2", FrontMiddelUp);
            Blokje GCorner3 = new Blokje("GCorner3", FrontRightUp);
            Blokje GEdge4 = new Blokje("GEdge4", FrontLeftMiddle);
            Blokje GCenter = new Blokje("GCenter", FrontPanel);
            Blokje GEdge6 = new Blokje("GEdge6", FrontRightMiddle);
            Blokje GCorner7 = new Blokje("GCorner7", FrontLeftDown);
            Blokje GEdge8 = new Blokje("GEdge8", FrontMiddleDown);
            Blokje GCorner9 = new Blokje("GCorner9", FrontRightDown);
            Blokje BCorner1 = new Blokje("BCorner1",BackLeftUp);
            Blokje BEdge2 = new Blokje("BEdge2", BackMiddleUp);
            Blokje BCorner3 = new Blokje("BCorner3", BackRightUp);
            Blokje BEdge4 = new Blokje("BEdge4", BackLeftMiddle);
            Blokje BCenter = new Blokje("BCenter", BackPanel);
            Blokje BEdge6 = new Blokje("BEdge6", BackRightMiddle);
            Blokje BCorner7 = new Blokje("BCorner7", BackLeftDown);
            Blokje BEdge8 = new Blokje("BEdge8", BackMiddleDown);
            Blokje BCorner9 = new Blokje("BCorner9", BackRightDown);
            Blokje WCorner1 = new Blokje("WCorner1", UpLeftUp);
            Blokje WEdge2 = new Blokje("WEdge2", UpMiddleUp);
            Blokje WCorner3 = new Blokje("WCorner3", UpRightUp);
            Blokje WEdge4 = new Blokje("WEdge4", UpLeftMiddle);
            Blokje WCenter = new Blokje("WCenter", UpPanel);
            Blokje WEdge6 = new Blokje("WEdge6", UpRightMiddle);
            Blokje WCorner7 = new Blokje("WCorner7", UpLeftDown);
            Blokje WEdge8 = new Blokje("WEdge8", UpMiddleDown);
            Blokje WCorner9 = new Blokje("WCorner9", UpRightDown);
            Blokje RCorner1 = new Blokje("RCorner1", RightLeftUp);
            Blokje REdge2 = new Blokje("REdge2", RightMiddleUp);
            Blokje RCorner3 = new Blokje("RCorner3", RightRightUp);
            Blokje REdge4 = new Blokje("REdge4", RightLeftMiddle);
            Blokje RCenter = new Blokje("RCenter", RightPanel);
            Blokje REdge6 = new Blokje("REdge6", RightRightMiddle);
            Blokje RCorner7 = new Blokje("RCorner7", RightLeftDown);
            Blokje REdge8 = new Blokje("REdge8", RightMiddleDown);
            Blokje RCorner9 = new Blokje("RCorner9", RightRightDown);
            Blokje YCorner1 = new Blokje("YCorner1", DownLeftUp);
            Blokje YEdge2 = new Blokje("YEdge2", DownMiddleUp);
            Blokje YCorner3 = new Blokje("YCorner3", DownRightUp);
            Blokje YEdge4 = new Blokje("YEdge4", DownLeftMIddle);
            Blokje YCenter = new Blokje("YCenter", DownPanel);
            Blokje YEdge6 = new Blokje("YEdge6", DownRightMiddle);
            Blokje YCorner7 = new Blokje("YCorner7", DownLeftDown);
            Blokje YEdge8 = new Blokje("YEdge8", DownMiddleDown);
            Blokje YCorner9 = new Blokje("YCorner9", DownRightDown);
            Blokje OCorner1 = new Blokje("OCorner1", LeftLeftUp);
            Blokje OEdge2 = new Blokje("OEdge2", LeftMiddleUp);
            Blokje OCorner3 = new Blokje("OCorner3", LeftRightUp);
            Blokje OEdge4 = new Blokje("OEdge4", LeftLeftMiddle);
            Blokje OCenter = new Blokje("OCenter", LeftPanel);
            Blokje OEdge6 = new Blokje("OEdge6", LeftRightMiddle);
            Blokje OCorner7 = new Blokje("OCorner7", LeftLeftDown);
            Blokje OEdge8 = new Blokje("OEdge8", LeftMiddleDown);
            Blokje OCorner9 = new Blokje("OCorner9", LeftRightDown);
            #endregion
            
        }
    }
}