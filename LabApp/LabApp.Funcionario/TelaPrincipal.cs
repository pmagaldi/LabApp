using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp.Funcionario
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroMaq_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroMaq telaCadastroMaq = new Views.TelaCadastroMaq();
            telaCadastroMaq.ShowDialog();
        }

        private void btnCadastroLab_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroLab telaCadastroLab = new Views.TelaCadastroLab();
            telaCadastroLab.ShowDialog();
        }
    }
}
