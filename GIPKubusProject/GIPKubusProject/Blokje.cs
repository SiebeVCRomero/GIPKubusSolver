using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GIPKubusProject
{
    /// <summary>
    /// Class bokjes, Er zijn 27 objecten van nodig
    /// </summary>
    public class Blokje
    {
        #region Properties

        //Adres is het paneel van waar het blokje zich bevind
        /// <summary>
        /// Adres van het blokje
        /// </summary>
        public System.Windows.Forms.Panel AdresBlokje { get; set; }
        /// <summary>
        /// Kleur van het blokje
        /// </summary>
        public Color KleurBlokje { get; set; }
        #endregion


        public Blokje(string naam, System.Windows.Forms.Panel adresBlokje)
        {
            switch (naam.Substring(0,1))
            {
                case "G":
                    KleurBlokje = Color.Green;
                    break;

                case "B":
                    KleurBlokje = Color.Blue;
                    break;

                case "O":
                    KleurBlokje = Color.Orange;
                    break;

                case "R":
                    KleurBlokje = Color.Red;
                    break;

                case "Y":
                    KleurBlokje = Color.Yellow;
                    break;

                default:
                    KleurBlokje = Color.White;
                    break;
            }

            AdresBlokje = adresBlokje;
        }
    }
}
