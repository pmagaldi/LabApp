namespace LabApp.Funcionario.Views
{
    partial class TelaCadastroGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroGrupo));
            this.textId = new System.Windows.Forms.Label();
            this.textBoxIdGrupo = new System.Windows.Forms.TextBox();
            this.textIdTipo = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.AutoSize = true;
            this.textId.Location = new System.Drawing.Point(24, 53);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(88, 13);
            this.textId.TabIndex = 0;
            this.textId.Text = "Id Grupo de Erro:";
            // 
            // textBoxIdGrupo
            // 
            this.textBoxIdGrupo.Location = new System.Drawing.Point(118, 50);
            this.textBoxIdGrupo.Name = "textBoxIdGrupo";
            this.textBoxIdGrupo.Size = new System.Drawing.Size(113, 20);
            this.textBoxIdGrupo.TabIndex = 1;
            // 
            // textIdTipo
            // 
            this.textIdTipo.AutoSize = true;
            this.textIdTipo.Location = new System.Drawing.Point(24, 100);
            this.textIdTipo.Name = "textIdTipo";
            this.textIdTipo.Size = new System.Drawing.Size(80, 13);
            this.textIdTipo.TabIndex = 2;
            this.textIdTipo.Text = "Id Tipo de Erro:";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(78, 138);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(93, 37);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(110, 97);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipos.TabIndex = 5;
            // 
            // TelaCadastroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 200);
            this.Controls.Add(this.comboBoxTipos);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textIdTipo);
            this.Controls.Add(this.textBoxIdGrupo);
            this.Controls.Add(this.textId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroGrupo";
            this.Text = "TelaCadastroGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textId;
        private System.Windows.Forms.TextBox textBoxIdGrupo;
        private System.Windows.Forms.Label textIdTipo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ComboBox comboBoxTipos;
    }
}