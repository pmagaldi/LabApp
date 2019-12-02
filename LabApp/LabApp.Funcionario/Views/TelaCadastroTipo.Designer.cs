namespace LabApp.Funcionario.Views
{
    partial class TelaCadastroTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroTipo));
            this.textNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.textPrioridade = new System.Windows.Forms.Label();
            this.textBoxPrio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.AutoSize = true;
            this.textNome.Location = new System.Drawing.Point(42, 51);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(38, 13);
            this.textNome.TabIndex = 0;
            this.textNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(127, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textDescricao
            // 
            this.textDescricao.AutoSize = true;
            this.textDescricao.Location = new System.Drawing.Point(42, 84);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(58, 13);
            this.textDescricao.TabIndex = 2;
            this.textDescricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(127, 81);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 3;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(83, 145);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(93, 37);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // textPrioridade
            // 
            this.textPrioridade.AutoSize = true;
            this.textPrioridade.Location = new System.Drawing.Point(42, 114);
            this.textPrioridade.Name = "textPrioridade";
            this.textPrioridade.Size = new System.Drawing.Size(57, 13);
            this.textPrioridade.TabIndex = 5;
            this.textPrioridade.Text = "Prioridade:";
            // 
            // textBoxPrio
            // 
            this.textBoxPrio.Location = new System.Drawing.Point(127, 111);
            this.textBoxPrio.Name = "textBoxPrio";
            this.textBoxPrio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrio.TabIndex = 6;
            // 
            // TelaCadastroTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 211);
            this.Controls.Add(this.textBoxPrio);
            this.Controls.Add(this.textPrioridade);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroTipo";
            this.Text = "TelaCadastroTipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label textDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label textPrioridade;
        private System.Windows.Forms.TextBox textBoxPrio;
    }
}