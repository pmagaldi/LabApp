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
            pegarIdTipo();
        }

        private void pegarIdTipo()
        {
            try
            {
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    var lista = tipoContext.TiposErro.ToList();
                    foreach (var item in lista)
                    {
                        comboBoxTipos.Items.Add("Id: " + item.Id + " Nome: " + item.Nome);          
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao pegar os ripos de erro");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                int idTipo;
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    idTipo = tipoContext.TiposErro.Where(s => s.Nome == comboBoxTipos.SelectedText).FirstOrDefault().Id ;
                }
                using (var grupoContext = new GErrosContext("RDSDBContext"))
                {
                    int idGrupo = Convert.ToInt32(textBoxIdGrupo.Text.ToString());
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
