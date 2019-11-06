﻿using System;
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
    public partial class TelaRemocaoTipo : Form
    {
        public TelaRemocaoTipo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            comboBoxTipos.Items.Clear();
            try
            {
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    IList<TiposDeErro> tipos = tipoContext.TiposErro.ToList();
                    foreach (var item in tipos)
                    {
                        comboBoxTipos.Items.Add(item.Nome);
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
                using (var tipoContext = new TErrosContext("RDSDBContext"))
                {
                    var tipo = tipoContext.TiposErro.FirstOrDefault(s => s.Id == comboBoxTipos.SelectedIndex+1);
                    var id = tipo.Id - 1;
                    tipoContext.TiposErro.Remove(tipo);
                    tipoContext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Laboratorios',RESEED, @id)", new SqlParameter("@id", id));
                    tipoContext.SaveChanges();
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