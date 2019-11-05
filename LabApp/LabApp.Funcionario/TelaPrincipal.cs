﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp.Funcionario
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public TelaPrincipal(string[] lista)
        {
            listBoxRegistro.Items.AddRange(lista);
            InitializeComponent();
        }

        private void btnCadastroMaq_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroMaq telaCadastroMaq = new Views.TelaCadastroMaq();
            telaCadastroMaq.ShowDialog();
        }

        private void btnCadastroLab_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroLab telaCadastroLab = new Views.TelaCadastroLab();
            telaCadastroLab.ShowDialog();
        }

        private void btnCadastroTipo_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroTipo telaCadastroTipo = new Views.TelaCadastroTipo();
            telaCadastroTipo.ShowDialog();
        }

        private void btnCadastroGrupo_Click(object sender, EventArgs e)
        {
            Views.TelaCadastroGrupo telaCadastroGrupo = new Views.TelaCadastroGrupo();
            telaCadastroGrupo.ShowDialog();
        }

        private void btnRemoverMaq_Click(object sender, EventArgs e)
        {
            Views.TelaRemocaoMaq telaRemocaoMaq = new Views.TelaRemocaoMaq();
            telaRemocaoMaq.ShowDialog();
        }

        private void btnRemoverLab_Click(object sender, EventArgs e)
        {
            Views.TelaRemocaoLab telaRemocaoLab = new Views.TelaRemocaoLab();
            telaRemocaoLab.ShowDialog();
        }

        private void btnRemoverTipo_Click(object sender, EventArgs e)
        {
            Views.TelaRemocaoTipo telaRemocaoTipo = new Views.TelaRemocaoTipo();
            telaRemocaoTipo.ShowDialog();
        }

        private void btnRemoverGrupo_Click(object sender, EventArgs e)
        {
            Views.TelaRemocaoGrupo telaRemocaoGrupo = new Views.TelaRemocaoGrupo();
            telaRemocaoGrupo.ShowDialog();
        }
    }
}
