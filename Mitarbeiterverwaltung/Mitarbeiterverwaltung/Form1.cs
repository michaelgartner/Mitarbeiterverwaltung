using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();

            team05Entities me = new team05Entities();

                Mitarbeiter ma = new Mitarbeiter();

            /*    ma.Name = "Gartner";
                ma.Vorname = "Michael";
                ma.GKlasse = "X1";
                ma.Kontonummer = "010101";
                ma.UeBest = true;
                ma.Verdienst = 0;
                ma.Passwort = "Test1!";
                ma.Benutzername = "MiGa";

            me.Mitarbeiter.Add(ma);

            me.SaveChanges();*/

            me.Dispose();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbx_bName_TextChanged(object sender, EventArgs e)
        {
            if(tbx_bName.Text == "(Benutzername)")
            {
                tbx_bName.Text = "";
            }
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            team05Entities me = new team05Entities();
            Mitarbeiter ma = new Mitarbeiter();
            string bn = tbx_bName.Text;
            string bp1 = tbx_bPasswort.Text;
            string bp2 = me.Mitarbeiter.FirstOrDefault(c => c.Benutzername == bn).Passwort;
            Int32 mid = -1;
            try
            {
                mid = me.Mitarbeiter.FirstOrDefault(c => c.Benutzername == bn).Id;
            }
            catch
            {

            }

            if(mid >= 0)
            {
                //MessageBox.Show(bp1 + "    " + bp2);
                if (string.Equals(bp1.Trim(), bp2.Trim()))
                {
                    //MessageBox.Show("Erfolg!");
                    frm_Login.ActiveForm.Visible = false;
                    frm_Mitarbeiter m = new frm_Mitarbeiter();
                    m.Visible = true;
                }
            }
            //MessageBox.Show(mid.ToString());
        }
    }
}
