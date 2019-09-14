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
        public string AdresBlokje { get; set; }
        /// <summary>
        /// Kleur van het blokje
        /// </summary>
        public Color KleurBlokje { get; set; }
        #endregion


        public Blokje(string naam, string adresBlokje)
        {
            switch (naam.Substring(0,1))
            {
                case "G":
                    KleurBlokje = Color.FromArgb(11,238,50);
                    break;

                case "B":
                    KleurBlokje =  Color.FromArgb(33,96,112); //Logo Kleur
                    break;

                case "O":
                    KleurBlokje = Color.FromArgb(240,78,0);
                    break;

                case "R":
                    KleurBlokje = Color.FromArgb(173,19,19); //Logo Kleur
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
