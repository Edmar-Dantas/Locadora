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
    public partial class janelaFilme : Form
    {
        public janelaFilme()
        {
            InitializeComponent();
        }

        private void btnVoltarFilme_Click(object sender, EventArgs e)
        {
            this.Close();
            janelaPrincipal home = new janelaPrincipal();
            home.Show();
        }
    }
}
