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
    public partial class TelaErro : Form
    {
        public TelaErro()
        {
            InitializeComponent();
        }

        public TelaErro(Exception ex)
        {            
            InitializeComponent();
            textErro.Text = ex.Message;
            ErroTextBox.Multiline = true;
            ErroTextBox.ScrollBars = ScrollBars.Vertical;
            ErroTextBox.Text += ex.StackTrace;
        }
    }
}
