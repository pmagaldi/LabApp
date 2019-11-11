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
    public partial class TelaCadastroMaq : Form
    {
        public string _DB { get; set; } = "RDSDBContext";
        Maquina maq;
        public TelaCadastroMaq()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.ToString();
            string ip = textBoxIp.Text.ToString();
            int id = Convert.ToInt32(textBoxLab.Text.ToString());
            try
            {
                using (var maqContext = new MaquinaContext(_DB))
                {
                    maqContext.Maquinas.Add(maq = new Maquina(nome, ip, id));
                    maqContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            if(checkBoxNome.Checked)
            {
                try
                {
                    using (var maqContext = new MaquinaContext(_DB))
                    {
                        var item = maqContext.Maquinas.FirstOrDefault(c => c.Ip == textBoxIp.Text.ToString());
                        if(item != null)
                        {
                            item.MudarNome(textBoxNome.Text.ToString());
                            maqContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            maqContext.SaveChanges();
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
            if (checkBoxLab.Checked)
            {
                try
                {
                    using (var maqContext = new MaquinaContext(_DB))
                    {
                        var item = maqContext.Maquinas.FirstOrDefault(c => c.Ip == textBoxIp.Text.ToString());
                        if (item != null)
                        {                            
                            item.MudarIdLab(Convert.ToInt32(textBoxLab.Text.ToString()));
                            maqContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            maqContext.SaveChanges();
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
            if (checkBoxIp.Checked)
            {
                try
                {
                    using (var maqContext = new MaquinaContext(_DB))
                    {
                        var item = maqContext.Maquinas.FirstOrDefault(c => c.Nome == textBoxNome.Text.ToString());
                        if (item != null)
                        {
                            item.MudarIp(textBoxIp.Text.ToString());
                            maqContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            maqContext.SaveChanges();
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
    }
}
