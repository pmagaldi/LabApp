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
    public partial class TelaRemocaoMaq : Form
    {
        public string _DB { get; set; } = "RDSDBContext";
        public TelaRemocaoMaq()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxMaqs.Items.Clear();
            try
            {
                using (var maqContext = new MaquinaContext(_DB))
                {
                    IList<Maquina> maquinas = maqContext.Maquinas.ToList();
                    foreach (var item in maquinas)
                    {
                        comboBoxMaqs.Items.Add(item.Nome);
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
                using (var maqContext = new MaquinaContext(_DB))
                {
                    var Maq = maqContext.Maquinas.FirstOrDefault(s => s.Nome == comboBoxMaqs.SelectedText);
                    maqContext.Maquinas.Remove(Maq);
                    maqContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                    comboBoxMaqs.Items.RemoveAt(comboBoxMaqs.SelectedIndex);
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
