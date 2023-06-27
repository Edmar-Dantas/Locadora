
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class janelaPrincipal : Form
    {
        public janelaPrincipal()
        {
            InitializeComponent();
        }

        janelaFilme janelafilme = new janelaFilme();
        janelaSerie janelaserie = new janelaSerie();
        private void button1_Click(object sender, EventArgs e)
        {
            janelafilme.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            janelaserie.Show();
            this.Hide();
        }
    }
}
