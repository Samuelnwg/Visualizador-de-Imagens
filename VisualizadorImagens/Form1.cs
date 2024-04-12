using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorImagens
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFoto1_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.foto01;
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.foto02;
        }

        private void btnFoto3_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.foto03;
        }

        private void btnFoto4_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.foto04;
        }

        private void btnFoto5_Click(object sender, EventArgs e)
        {
            picFoto.Image = Properties.Resources.foto06;
        }

        private void rdbCorBotao1_CheckedChanged(object sender, EventArgs e)
        {
            btnFoto1.BackColor = Color.Gray;
            btnFoto2.BackColor = Color.Gray;
            btnFoto3.BackColor = Color.Gray;
            btnFoto4.BackColor = Color.Gray;
            btnFoto5.BackColor = Color.Gray;

        }

        private void rdbCorbotao2_CheckedChanged(object sender, EventArgs e)
        {
            btnFoto1.BackColor = Color.Orange;
            btnFoto2.BackColor = Color.Orange;
            btnFoto3.BackColor = Color.Orange;
            btnFoto4.BackColor = Color.Orange;
            btnFoto5.BackColor = Color.Orange;
        }

        private void rdbCorBotao3_CheckedChanged(object sender, EventArgs e)
        {
            btnFoto1.BackColor = Color.Violet;
            btnFoto2.BackColor = Color.Violet;
            btnFoto3.BackColor = Color.Violet;
            btnFoto4.BackColor = Color.Violet;
            btnFoto5.BackColor = Color.Violet;
        }
    }
}
