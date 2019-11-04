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
    public partial class TelaCadastroGrupo : Form
    {
        public TelaCadastroGrupo()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                using (var grupoContext = new GErrosContext("RDSDBContext"))
                {
                    int idGrupo = Convert.ToInt32(textBoxIdGrupo.Text.ToString());
                    int idTipo = Convert.ToInt32(textBoxIdTipo.Text.ToString());
                    grupoContext.GruposErro.Add(new GruposDeErro(idGrupo, idTipo));
                    grupoContext.SaveChanges();
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
