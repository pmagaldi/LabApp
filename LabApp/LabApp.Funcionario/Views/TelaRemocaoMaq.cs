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
        public TelaRemocaoMaq()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxMaqs.Items.Clear();
            try
            {
                using (var maqContext = new MaquinaContext("RDSDBContext"))
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
                using (var maqContext = new MaquinaContext("RDSDBContext"))
                {
                    var Maq = maqContext.Maquinas.FirstOrDefault(s => s.id == comboBoxMaqs.SelectedIndex+1);
                    var id = Maq.id - 1;
                    maqContext.Maquinas.Remove(Maq);
                    maqContext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Laboratorios',RESEED, @id)", new SqlParameter("@id", id));
                    maqContext.SaveChanges();
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
