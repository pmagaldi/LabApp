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
                using (var labContext = new LaboratorioContext("RDSDBContext"))
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
            string contexto = "RDSDBContext";
            if (checkBoxNome.Checked)
            {                
                try
                {
                    using (var laboratorioContext = new LaboratorioContext(contexto))
                    {
                        var item = lab.FirstOrDefault(c => c.id == comboBoxLabs.SelectedIndex+1);
                        if (item != null)
                        {
                            item.MudarNome(textBoxNome.Text.ToString());
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
                    using (var laboratorioContext = new LaboratorioContext(contexto))
                    {
                        var item = lab.FirstOrDefault(c => c.id == comboBoxLabs.SelectedIndex+1);
                        if (item != null)
                        {
                            item.MudarQtd(Convert.ToInt32(textBoxQtd.Text.ToString()));
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
                    using (var laboratorioContext = new LaboratorioContext(contexto))
                    {
                        var item = lab.FirstOrDefault(c => c.id == comboBoxLabs.SelectedIndex+1);
                        if (item != null)
                        {
                            item.MudarGrupoErro(Convert.ToInt32(textBoxGrupo.Text.ToString()));
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
                using (var labContext = new LaboratorioContext("RDSDBContext"))
                {
                    lab = labContext.Laboratorios.ToList();
                    List<string> nomes = labContext.Laboratorios.Select(c => c.Nome).ToList();
                    string[] Lista = new string[nomes.Count];
                    int index = 0;
                    foreach (var item in nomes)
                    {
                        Lista[index] = item;
                        index++;
                    }
                    comboBoxLabs.Items.AddRange(Lista);
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
