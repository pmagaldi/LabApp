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
    public partial class TelaRemocaoLab : Form
    {
        public string _DB { get; set; } = "RDSDBContext";
        public TelaRemocaoLab()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxLabs.Items.Clear();
            try
            {
                using (var labContext = new LaboratorioContext(_DB))
                {
                    IList<Laboratorio> labs = labContext.Laboratorios.ToList();
                    foreach (var item in labs)
                    {
                        comboBoxLabs.Items.Add(item.Nome);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                using (var labContext = new LaboratorioContext(_DB))
                {
                    var id = labContext.Laboratorios.Where(s => s.Nome == comboBoxLabs.SelectedItem.ToString()).FirstOrDefault().Id;
                    var lab = labContext.Laboratorios.Where(s => s.Id == id).FirstOrDefault();
                    labContext.Laboratorios.Remove(lab);
                    labContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                    comboBoxLabs.Items.RemoveAt(comboBoxLabs.SelectedIndex);
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
