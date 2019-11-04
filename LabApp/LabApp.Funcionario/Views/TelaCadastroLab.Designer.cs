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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textAviso = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxQtd = new System.Windows.Forms.CheckBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.comboBoxLabs = new System.Windows.Forms.ComboBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(202, 85);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textAviso
            // 
            this.textAviso.AutoSize = true;
            this.textAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAviso.ForeColor = System.Drawing.Color.Red;
            this.textAviso.Location = new System.Drawing.Point(3, 9);
            this.textAviso.Name = "textAviso";
            this.textAviso.Size = new System.Drawing.Size(368, 20);
            this.textAviso.TabIndex = 2;
            this.textAviso.Text = "Para alterar selecione o laboratório na lista primeiro";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(202, 125);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(100, 20);
            this.textBoxQtd.TabIndex = 3;
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(202, 165);
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrupo.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(61, 215);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 37);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Location = new System.Drawing.Point(82, 87);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(57, 17);
            this.checkBoxNome.TabIndex = 7;
            this.checkBoxNome.Text = "Nome:";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            // 
            // checkBoxQtd
            // 
            this.checkBoxQtd.AutoSize = true;
            this.checkBoxQtd.Location = new System.Drawing.Point(32, 127);
            this.checkBoxQtd.Name = "checkBoxQtd";
            this.checkBoxQtd.Size = new System.Drawing.Size(151, 17);
            this.checkBoxQtd.TabIndex = 8;
            this.checkBoxQtd.Text = "Quantidade  de Maquinas:";
            this.checkBoxQtd.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(49, 167);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(119, 17);
            this.checkBoxId.TabIndex = 9;
            this.checkBoxId.Text = "Id do Grupo de Erro";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(202, 215);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 37);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atulaizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // comboBoxLabs
            // 
            this.comboBoxLabs.FormattingEnabled = true;
            this.comboBoxLabs.Location = new System.Drawing.Point(62, 43);
            this.comboBoxLabs.Name = "comboBoxLabs";
            this.comboBoxLabs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLabs.TabIndex = 11;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(202, 41);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 12;
            this.btnProcurar.Text = "Localizar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // TelaCadastroLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 268);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.comboBoxLabs);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.checkBoxQtd);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textAviso);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroLab";
            this.Text = "TelaCadastroLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label textAviso;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxQtd;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox comboBoxLabs;
        private System.Windows.Forms.Button btnProcurar;
    }
}