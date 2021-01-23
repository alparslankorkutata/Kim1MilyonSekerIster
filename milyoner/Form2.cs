using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim1MilyonSekerIster
{
    public partial class frmTelefon : Form
    {
        public frmTelefon()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmSoruEkranı soruekranı = new frmSoruEkranı();
            this.Close();
            soruekranı.tmrZaman.Start();
            
        }
    }
}
