using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabAppLibary.DB;
using LabAppLibrary.Modelo;

namespace LabApp.Funcionario.Views
{
    public partial class TelaRemocaoGrupo : Form
    {
        public string _DB { get; set; } = "RDSDBContext";
        public TelaRemocaoGrupo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxGrupos.Items.Clear();
            try
            {
                using (var grupoContext = new GErrosContext(_DB))
                {
                    IList<GruposDeErro> Grupos = grupoContext.GruposErro.ToList();
                    foreach (var item in Grupos)
                    {
                        comboBoxGrupos.Items.Add("IdGrupo: "+item.IdGrupo+" IdTipo: "+item.IdTipoErro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                using (var grupoContext = new GErrosContext(_DB))
                {
                    var texto = comboBoxGrupos.SelectedItem.ToString();
                    var idGrupo = Convert.ToInt32(texto.Substring(9, 1));
                    var idTipo = Convert.ToInt32(texto.Substring(19,1));
                    var grupo = grupoContext.GruposErro.Where(s => s.IdGrupo == idGrupo && s.IdTipoErro == idTipo).FirstOrDefault();
                    grupoContext.GruposErro.Remove(grupo);
                    grupoContext.SaveChanges();
                    MessageBox.Show("Realizado com Sucesso!");
                    comboBoxGrupos.Items.RemoveAt(comboBoxGrupos.SelectedIndex);
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
