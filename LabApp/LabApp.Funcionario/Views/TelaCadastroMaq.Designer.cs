namespace LabApp.Funcionario.Views
{
    partial class TelaCadastroMaq
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLab = new System.Windows.Forms.TextBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxLab = new System.Windows.Forms.CheckBox();
            this.checkBoxIp = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(191, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(111, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxLab
            // 
            this.textBoxLab.Location = new System.Drawing.Point(191, 93);
            this.textBoxLab.Name = "textBoxLab";
            this.textBoxLab.Size = new System.Drawing.Size(111, 20);
            this.textBoxLab.TabIndex = 2;
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(191, 135);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(111, 20);
            this.textBoxIp.TabIndex = 4;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(68, 191);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(92, 36);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Location = new System.Drawing.Point(44, 50);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(116, 17);
            this.checkBoxNome.TabIndex = 7;
            this.checkBoxNome.Text = "Nome da Máquina:";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            // 
            // checkBoxLab
            // 
            this.checkBoxLab.AutoSize = true;
            this.checkBoxLab.Location = new System.Drawing.Point(44, 95);
            this.checkBoxLab.Name = "checkBoxLab";
            this.checkBoxLab.Size = new System.Drawing.Size(82, 17);
            this.checkBoxLab.TabIndex = 8;
            this.checkBoxLab.Text = "Laboratório:";
            this.checkBoxLab.UseVisualStyleBackColor = true;
            // 
            // checkBoxIp
            // 
            this.checkBoxIp.AutoSize = true;
            this.checkBoxIp.Location = new System.Drawing.Point(44, 137);
            this.checkBoxIp.Name = "checkBoxIp";
            this.checkBoxIp.Size = new System.Drawing.Size(75, 17);
            this.checkBoxIp.TabIndex = 9;
            this.checkBoxIp.Text = "IP tipo V4:";
            this.checkBoxIp.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(210, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TelaCadastroMaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 239);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkBoxIp);
            this.Controls.Add(this.checkBoxLab);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.textBoxLab);
            this.Controls.Add(this.textBoxNome);
            this.Name = "TelaCadastroMaq";
            this.Text = "TelaCadastroMaq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxLab;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxLab;
        private System.Windows.Forms.CheckBox checkBoxIp;
        private System.Windows.Forms.Button btnUpdate;
    }
}