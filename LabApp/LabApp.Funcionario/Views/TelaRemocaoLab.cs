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
    public partial class TelaRemocaoLab : Form
    {
        public TelaRemocaoLab()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxLabs.Items.Clear();
            try
            {
                using (var labContext = new LaboratorioContext("RDSDBContext"))
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
                using (var labContext = new LaboratorioContext("RDSDBContext"))
                {
                    var lab = labContext.Laboratorios.FirstOrDefault(s => s.Id == comboBoxLabs.SelectedIndex + 1);
                    if(lab != null)
                    {
                        labContext.Laboratorios.Remove(lab);
                        labContext.SaveChanges();
                        MessageBox.Show("Realizado com sucesso!");
                    }
                    else
                    {
                        lab = labContext.Laboratorios.FirstOrDefault(s => s.Nome == comboBoxLabs.Text);
                        labContext.Laboratorios.Remove(lab);
                        labContext.SaveChanges();
                        MessageBox.Show("Realizado com sucesso!");
                    }
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
