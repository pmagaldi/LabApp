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
        public string _DB { get; set; } = "RDSDBContext";
        public TelaCadastroGrupo()
        {                       
            InitializeComponent();
            pegarIdTipo();
        }

        private void pegarIdTipo()
        {
            try
            {
                using (var tipoContext = new TErrosContext(_DB))
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
                using (var tipoContext = new TErrosContext(_DB))
                {
                    var index = comboBoxTipos.SelectedItem.ToString().IndexOf("Nome:") + 6;
                    var tipo = comboBoxTipos.SelectedItem.ToString().Substring(index);
                    idTipo = tipoContext.TiposErro.Where(s => s.Nome == tipo).FirstOrDefault().Id ;
                }
                using (var grupoContext = new GErrosContext(_DB))
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
