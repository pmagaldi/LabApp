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
            using (var maqContext = new MaquinaContext("RDSDBContext"))
            {
                maqContext.Maquinas.Add(maq = new Maquina(nome, ip, id));
                maqContext.SaveChanges();
                MessageBox.Show("Realizado com sucesso!");
            }
        }
    }
}
