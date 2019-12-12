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
    public partial class TelaCadastroLab : Form
    {
        public string _DB { get; set; } = "RDSDBContext";
        List<Laboratorio> lab;
        public TelaCadastroLab()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.ToString();
            int qtd = Convert.ToInt32(textBoxQtd.Text.ToString());
            int id = Convert.ToInt32(textBoxGrupo.Text.ToString());
            try
            {
                using (var labContext = new LaboratorioContext(_DB))
                {
                    labContext.Laboratorios.Add(new Laboratorio(nome, qtd, id));
                    labContext.SaveChanges();
                    MessageBox.Show("Realizado com Sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
       {
            if (checkBoxNome.Checked)
            {                
                try
                {
                    using (var laboratorioContext = new LaboratorioContext(_DB))
                    {
                        var id = lab.Where(c => c.Nome == comboBoxLabs.SelectedItem.ToString()).First().Id;
                        var item = lab.FirstOrDefault(c => c.Id == id);
                        if (item != null)
                        {
                            item.MudarNome(textBoxNome.Text.ToString());
                            laboratorioContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            laboratorioContext.SaveChanges();
                            MessageBox.Show("Realizado com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
            if(checkBoxQtd.Checked)
            {
                try
                {
                    using (var laboratorioContext = new LaboratorioContext(_DB))
                    {
                        var id = lab.Where(c => c.Nome == comboBoxLabs.SelectedItem.ToString()).First().Id;
                        var item = lab.FirstOrDefault(c => c.Id == id);
                        if (item != null)
                        {
                            item.MudarQtd(Convert.ToInt32(textBoxQtd.Text.ToString()));
                            laboratorioContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            laboratorioContext.SaveChanges();
                            MessageBox.Show("Realizado com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
            if (checkBoxId.Checked)
            {
                try
                {
                    using (var laboratorioContext = new LaboratorioContext(_DB))
                    {
                        var id = lab.Where(c => c.Nome == comboBoxLabs.SelectedItem.ToString()).First().Id;
                        var item = lab.FirstOrDefault(c => c.Id == id);
                        if (item != null)
                        {
                            item.MudarGrupoErro(Convert.ToInt32(textBoxGrupo.Text.ToString()));
                            laboratorioContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            laboratorioContext.SaveChanges();
                            MessageBox.Show("Realizado com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var labContext = new LaboratorioContext(_DB))
                {
                    comboBoxLabs.Items.Clear();
                    lab = labContext.Laboratorios.ToList();
                    //List<string> nomes = labContext.Laboratorios.Select(c => c.Nome).ToList();
                    //string[] Lista = new string[nomes.Count];
                    //int index = 0;
                    //foreach (var item in nomes)
                    //{
                    //    Lista[index] = item;
                    //    index++;
                    //}
                    comboBoxLabs.Items.AddRange(labContext.Laboratorios.Select(c => c.Nome).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            
            }
        }
    }
}
