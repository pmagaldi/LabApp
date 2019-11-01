namespace LabApp.Funcionario.Views
{
    partial class TelaCadastroLab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroLab));
            this.textNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textQtd = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.Label();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.AutoSize = true;
            this.textNome.Location = new System.Drawing.Point(81, 46);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(38, 13);
            this.textNome.TabIndex = 0;
            this.textNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(179, 43);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textQtd
            // 
            this.textQtd.AutoSize = true;
            this.textQtd.Location = new System.Drawing.Point(36, 86);
            this.textQtd.Name = "textQtd";
            this.textQtd.Size = new System.Drawing.Size(129, 13);
            this.textQtd.TabIndex = 2;
            this.textQtd.Text = "Quantidade de Maquinas:";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(179, 83);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(100, 20);
            this.textBoxQtd.TabIndex = 3;
            // 
            // textId
            // 
            this.textId.AutoSize = true;
            this.textId.Location = new System.Drawing.Point(49, 129);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(103, 13);
            this.textId.TabIndex = 4;
            this.textId.Text = "Id do Grupo de Erro:";
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(179, 126);
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrupo.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(117, 172);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 37);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaCadastroLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 236);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textQtd);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroLab";
            this.Text = "TelaCadastroLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label textQtd;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.Label textId;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.Button btnCadastrar;
    }
}