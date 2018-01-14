using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektC_sharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        class Osoba
        {
            string ime, prezime, spol, drzava, mjestoRodenja;
            DateTime datumRodenja;
            public Osoba(string ime, string prezime, string spol, DateTime datumRodenja, string drzava, string mjestoRodenja)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.spol = spol;
                this.datumRodenja = datumRodenja;
                this.drzava = drzava;
                this.mjestoRodenja = mjestoRodenja;
            }
        }
    }
}
