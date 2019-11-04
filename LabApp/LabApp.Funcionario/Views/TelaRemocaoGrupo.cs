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
    public partial class TelaRemocaoGrupo : Form
    {
        public TelaRemocaoGrupo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var grupoContext = new GErrosContext("RDSDBContext"))
                {
                    IList<GruposDeErro> Grupos = grupoContext.GruposErro.ToList();
                    foreach (var item in Grupos)
                    {
                        comboBoxGrupos.Items.Add("IdGrupo: "+item.IdGrupo+" Id:Tipo: "+item.IdTipoErro);
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
                using (var grupoContext = new GErrosContext("RDSDBContext"))
                {
                    var grupo = grupoContext.GruposErro.FirstOrDefault(c => c.Id == comboBoxGrupos.SelectedIndex);
                    grupoContext.GruposErro.Remove(grupo);
                    grupoContext.SaveChanges();
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
