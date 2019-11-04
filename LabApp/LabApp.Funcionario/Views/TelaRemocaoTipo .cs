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
    public partial class TelaRemocaoTipo : Form
    {
        public TelaRemocaoTipo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    IList<TiposDeErro> tipos = tipoContext.TiposErro.ToList();
                    foreach (var item in tipos)
                    {
                        comboBoxTipos.Items.Add(item.Nome);
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
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    var tipo = tipoContext.TiposErro.FirstOrDefault(s => s.Nome == comboBoxTipos.SelectedText);
                    tipoContext.TiposErro.Remove(tipo);
                    tipoContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
