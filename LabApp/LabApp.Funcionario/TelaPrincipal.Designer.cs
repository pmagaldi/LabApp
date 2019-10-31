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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCadastroMaq = new System.Windows.Forms.Button();
            this.btnCadastroLab = new System.Windows.Forms.Button();
            this.btnCadastroTipo = new System.Windows.Forms.Button();
            this.btnCadastroGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(94, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // btnCadastroMaq
            // 
            this.btnCadastroMaq.Location = new System.Drawing.Point(70, 113);
            this.btnCadastroMaq.Name = "btnCadastroMaq";
            this.btnCadastroMaq.Size = new System.Drawing.Size(167, 24);
            this.btnCadastroMaq.TabIndex = 1;
            this.btnCadastroMaq.Text = "Cadastrar\\Alterar Maquina";
            this.btnCadastroMaq.UseVisualStyleBackColor = true;
            this.btnCadastroMaq.Click += new System.EventHandler(this.btnCadastroMaq_Click);
            // 
            // btnCadastroLab
            // 
            this.btnCadastroLab.Location = new System.Drawing.Point(70, 143);
            this.btnCadastroLab.Name = "btnCadastroLab";
            this.btnCadastroLab.Size = new System.Drawing.Size(167, 24);
            this.btnCadastroLab.TabIndex = 2;
            this.btnCadastroLab.Text = "Cadastrar\\Alterar Laboratório";
            this.btnCadastroLab.UseVisualStyleBackColor = true;
            // 
            // btnCadastroTipo
            // 
            this.btnCadastroTipo.Location = new System.Drawing.Point(70, 173);
            this.btnCadastroTipo.Name = "btnCadastroTipo";
            this.btnCadastroTipo.Size = new System.Drawing.Size(167, 23);
            this.btnCadastroTipo.TabIndex = 3;
            this.btnCadastroTipo.Text = "Add\\Alterar Tipo de Erro";
            this.btnCadastroTipo.UseVisualStyleBackColor = true;
            // 
            // btnCadastroGrupo
            // 
            this.btnCadastroGrupo.Location = new System.Drawing.Point(70, 202);
            this.btnCadastroGrupo.Name = "btnCadastroGrupo";
            this.btnCadastroGrupo.Size = new System.Drawing.Size(167, 23);
            this.btnCadastroGrupo.TabIndex = 4;
            this.btnCadastroGrupo.Text = "Add\\Alterar Grupo de Erro";
            this.btnCadastroGrupo.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 243);
            this.Controls.Add(this.btnCadastroGrupo);
            this.Controls.Add(this.btnCadastroTipo);
            this.Controls.Add(this.btnCadastroLab);
            this.Controls.Add(this.btnCadastroMaq);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "LabApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCadastroMaq;
        private System.Windows.Forms.Button btnCadastroLab;
        private System.Windows.Forms.Button btnCadastroTipo;
        private System.Windows.Forms.Button btnCadastroGrupo;
    }
}

