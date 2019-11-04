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
    public partial class TelaCadastroTipo : Form
    {
        public TelaCadastroTipo()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    string nome = textBoxNome.Text.ToString();
                    string descricao = textBoxDescricao.Text.ToString();
                    tipoContext.TiposErro.Add(new TiposDeErro(nome, descricao));
                    tipoContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
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
