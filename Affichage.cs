using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemeTelethon
{
    public partial class AffichageTelethon : Form
    {
        public string textAffiche;
        public AffichageTelethon()
        {
            InitializeComponent();
        }

        private void textAffichage_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AffichageTelethon_Load(object sender, EventArgs e)
        {
            textAffichage.Text = textAffiche;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
