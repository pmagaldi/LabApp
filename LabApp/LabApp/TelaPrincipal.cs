using LabAppLibrary.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class TelaPrincipal : Form
    {
        public Maquina maq;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public TelaPrincipal(string erro)
        {
            InitializeComponent();
            TextProblema.Visible = false;
            comboBoxProb.Visible = false;
            buttonEnviar.Enabled = false;
            textErro.Text = erro;
        }

        public TelaPrincipal(Maquina maquina)
        {
            InitializeComponent();
            textErro.Visible = false;
            maq = maquina;
        }

        public TelaPrincipal(Maquina maquina,string[] lista)
        {
            InitializeComponent();
            maq = maquina;
            textErro.Visible = false;
            comboBoxProb.Items.AddRange(lista);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            var texto = comboBoxProb.SelectedText;
            Program.Registro(texto);
        }
    }
}
