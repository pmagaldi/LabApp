using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class TelaPrincipal : Form
    {
        public int Ip { get; set; }

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public TelaPrincipal(int ip)
        {
            InitializeComponent();
            Ip = ip;
        }

        public TelaPrincipal(string[] lista)
        {
            InitializeComponent();
            comboBoxProb.Items.AddRange(lista);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            //var index = comboBoxProb.SelectedIndex;
            MessageBox.Show(Ip.ToString());
        }
    }
}
