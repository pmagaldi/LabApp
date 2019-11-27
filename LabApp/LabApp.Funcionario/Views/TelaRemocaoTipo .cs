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
    public partial class TelaRemocaoTipo : Form
    {
        public string _DB { get; set; } = "RDSDBContext";

        public TelaRemocaoTipo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxTipos.Items.Clear();
            try
            {
                using (var tipoContext = new TErrosContext(_DB))
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
                using (var tipoContext = new TErrosContext(_DB))
                {
                    var tipo = tipoContext.TiposErro.FirstOrDefault(s => s.Nome == comboBoxTipos.SelectedText);
                    tipoContext.TiposErro.Remove(tipo);
                    tipoContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                    comboBoxTipos.Items.RemoveAt(comboBoxTipos.SelectedIndex);
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
