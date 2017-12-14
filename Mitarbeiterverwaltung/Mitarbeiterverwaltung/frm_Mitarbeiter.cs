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
    public partial class frm_Mitarbeiter : Form
    {
        public string username { get; set; }
        private void frm_Mitarbeiter_Load(object sender, EventArgs e)
        {
            this.Text = this.username;
        }

        public frm_Mitarbeiter()
        {
            InitializeComponent();
            tbx_KNr.Text = username;
        }

        private void btn_Schliessen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
