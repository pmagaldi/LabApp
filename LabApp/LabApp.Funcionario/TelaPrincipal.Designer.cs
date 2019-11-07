namespace LabApp.Funcionario
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btnCadastroMaq = new System.Windows.Forms.Button();
            this.btnCadastroLab = new System.Windows.Forms.Button();
            this.btnCadastroTipo = new System.Windows.Forms.Button();
            this.btnCadastroGrupo = new System.Windows.Forms.Button();
            this.btnRemoverMaq = new System.Windows.Forms.Button();
            this.btnRemoverLab = new System.Windows.Forms.Button();
            this.btnRemoverTipo = new System.Windows.Forms.Button();
            this.btnRemoverGrupo = new System.Windows.Forms.Button();
            this.checkedListBoxRegistro = new System.Windows.Forms.CheckedListBox();
            this.btnRegistroFinalizado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroMaq
            // 
            this.btnCadastroMaq.Location = new System.Drawing.Point(37, 113);
            this.btnCadastroMaq.Name = "btnCadastroMaq";
            this.btnCadastroMaq.Size = new System.Drawing.Size(167, 24);
            this.btnCadastroMaq.TabIndex = 1;
            this.btnCadastroMaq.Text = "Cadastrar\\Alterar Maquina";
            this.btnCadastroMaq.UseVisualStyleBackColor = true;
            this.btnCadastroMaq.Click += new System.EventHandler(this.btnCadastroMaq_Click);
            // 
            // btnCadastroLab
            // 
            this.btnCadastroLab.Location = new System.Drawing.Point(37, 143);
            this.btnCadastroLab.Name = "btnCadastroLab";
            this.btnCadastroLab.Size = new System.Drawing.Size(167, 24);
            this.btnCadastroLab.TabIndex = 2;
            this.btnCadastroLab.Text = "Cadastrar\\Alterar Laboratório";
            this.btnCadastroLab.UseVisualStyleBackColor = true;
            this.btnCadastroLab.Click += new System.EventHandler(this.btnCadastroLab_Click);
            // 
            // btnCadastroTipo
            // 
            this.btnCadastroTipo.Location = new System.Drawing.Point(37, 173);
            this.btnCadastroTipo.Name = "btnCadastroTipo";
            this.btnCadastroTipo.Size = new System.Drawing.Size(167, 23);
            this.btnCadastroTipo.TabIndex = 3;
            this.btnCadastroTipo.Text = "Adicionar Tipo de Erro";
            this.btnCadastroTipo.UseVisualStyleBackColor = true;
            this.btnCadastroTipo.Click += new System.EventHandler(this.btnCadastroTipo_Click);
            // 
            // btnCadastroGrupo
            // 
            this.btnCadastroGrupo.Location = new System.Drawing.Point(37, 202);
            this.btnCadastroGrupo.Name = "btnCadastroGrupo";
            this.btnCadastroGrupo.Size = new System.Drawing.Size(167, 23);
            this.btnCadastroGrupo.TabIndex = 4;
            this.btnCadastroGrupo.Text = "Adicionar Grupo de Erro";
            this.btnCadastroGrupo.UseVisualStyleBackColor = true;
            this.btnCadastroGrupo.Click += new System.EventHandler(this.btnCadastroGrupo_Click);
            // 
            // btnRemoverMaq
            // 
            this.btnRemoverMaq.Location = new System.Drawing.Point(232, 114);
            this.btnRemoverMaq.Name = "btnRemoverMaq";
            this.btnRemoverMaq.Size = new System.Drawing.Size(128, 23);
            this.btnRemoverMaq.TabIndex = 5;
            this.btnRemoverMaq.Text = "Remover Maquina";
            this.btnRemoverMaq.UseVisualStyleBackColor = true;
            this.btnRemoverMaq.Click += new System.EventHandler(this.btnRemoverMaq_Click);
            // 
            // btnRemoverLab
            // 
            this.btnRemoverLab.Location = new System.Drawing.Point(232, 144);
            this.btnRemoverLab.Name = "btnRemoverLab";
            this.btnRemoverLab.Size = new System.Drawing.Size(128, 23);
            this.btnRemoverLab.TabIndex = 6;
            this.btnRemoverLab.Text = "Remover Laboratório";
            this.btnRemoverLab.UseVisualStyleBackColor = true;
            this.btnRemoverLab.Click += new System.EventHandler(this.btnRemoverLab_Click);
            // 
            // btnRemoverTipo
            // 
            this.btnRemoverTipo.Location = new System.Drawing.Point(232, 173);
            this.btnRemoverTipo.Name = "btnRemoverTipo";
            this.btnRemoverTipo.Size = new System.Drawing.Size(128, 23);
            this.btnRemoverTipo.TabIndex = 7;
            this.btnRemoverTipo.Text = "Remover Tipo de Erro";
            this.btnRemoverTipo.UseVisualStyleBackColor = true;
            this.btnRemoverTipo.Click += new System.EventHandler(this.btnRemoverTipo_Click);
            // 
            // btnRemoverGrupo
            // 
            this.btnRemoverGrupo.Location = new System.Drawing.Point(232, 202);
            this.btnRemoverGrupo.Name = "btnRemoverGrupo";
            this.btnRemoverGrupo.Size = new System.Drawing.Size(128, 23);
            this.btnRemoverGrupo.TabIndex = 8;
            this.btnRemoverGrupo.Text = "Remover Grupo de Erro";
            this.btnRemoverGrupo.UseVisualStyleBackColor = true;
            this.btnRemoverGrupo.Click += new System.EventHandler(this.btnRemoverGrupo_Click);
            // 
            // checkedListBoxRegistro
            // 
            this.checkedListBoxRegistro.FormattingEnabled = true;
            this.checkedListBoxRegistro.Location = new System.Drawing.Point(37, 12);
            this.checkedListBoxRegistro.Name = "checkedListBoxRegistro";
            this.checkedListBoxRegistro.ScrollAlwaysVisible = true;
            this.checkedListBoxRegistro.Size = new System.Drawing.Size(224, 94);
            this.checkedListBoxRegistro.TabIndex = 9;
            // 
            // btnRegistroFinalizado
            // 
            this.btnRegistroFinalizado.Location = new System.Drawing.Point(267, 43);
            this.btnRegistroFinalizado.Name = "btnRegistroFinalizado";
            this.btnRegistroFinalizado.Size = new System.Drawing.Size(109, 26);
            this.btnRegistroFinalizado.TabIndex = 10;
            this.btnRegistroFinalizado.Text = "Registro Finalizado";
            this.btnRegistroFinalizado.UseVisualStyleBackColor = true;
            this.btnRegistroFinalizado.Click += new System.EventHandler(this.btnRegistroFinalizado_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 249);
            this.Controls.Add(this.btnRegistroFinalizado);
            this.Controls.Add(this.checkedListBoxRegistro);
            this.Controls.Add(this.btnRemoverGrupo);
            this.Controls.Add(this.btnRemoverTipo);
            this.Controls.Add(this.btnRemoverLab);
            this.Controls.Add(this.btnRemoverMaq);
            this.Controls.Add(this.btnCadastroGrupo);
            this.Controls.Add(this.btnCadastroTipo);
            this.Controls.Add(this.btnCadastroLab);
            this.Controls.Add(this.btnCadastroMaq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "LabApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastroMaq;
        private System.Windows.Forms.Button btnCadastroLab;
        private System.Windows.Forms.Button btnCadastroTipo;
        private System.Windows.Forms.Button btnCadastroGrupo;
        private System.Windows.Forms.Button btnRemoverMaq;
        private System.Windows.Forms.Button btnRemoverLab;
        private System.Windows.Forms.Button btnRemoverTipo;
        private System.Windows.Forms.Button btnRemoverGrupo;
        private System.Windows.Forms.CheckedListBox checkedListBoxRegistro;
        private System.Windows.Forms.Button btnRegistroFinalizado;
    }
}

