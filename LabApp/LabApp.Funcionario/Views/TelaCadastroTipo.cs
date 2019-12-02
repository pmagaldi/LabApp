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
        public string _DB { get; set; } = "RDSDBContext";
        public TelaCadastroTipo()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tipoContext = new TErrosContext(_DB))
                {
                    string nome = textBoxNome.Text.ToString();
                    string descricao = textBoxDescricao.Text.ToString();
                    int prioridade = Convert.ToInt32(textBoxPrio.Text.ToString());
                    tipoContext.TiposErro.Add(new TiposDeErro(nome, descricao,prioridade));
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
