using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabAppLibary.DB;
using LabAppLibrary.Modelo;

namespace LabApp.Funcionario.Views
{
    public partial class TelaCadastroLab : Form
    {
        public TelaCadastroLab()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.ToString();
            int qtd = Convert.ToInt32(textBoxQtd.Text.ToString());
            int id = Convert.ToInt32(textBoxGrupo.Text.ToString());
            try
            {
                using (var labContext = new LaboratorioContext("RDSDBContext"))
                {
                    labContext.Laboratorios.Add(new Laboratorio(nome, qtd, id));
                    labContext.SaveChanges();
                    MessageBox.Show("Realizado com Sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
