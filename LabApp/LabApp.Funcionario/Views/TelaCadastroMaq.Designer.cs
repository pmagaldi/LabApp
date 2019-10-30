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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxLab = new System.Windows.Forms.TextBox();
            this.labelLab = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(191, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(111, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(51, 51);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(97, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome da Máquina:";
            // 
            // textBoxLab
            // 
            this.textBoxLab.Location = new System.Drawing.Point(191, 93);
            this.textBoxLab.Name = "textBoxLab";
            this.textBoxLab.Size = new System.Drawing.Size(111, 20);
            this.textBoxLab.TabIndex = 2;
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Location = new System.Drawing.Point(51, 100);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(63, 13);
            this.labelLab.TabIndex = 3;
            this.labelLab.Text = "Laboratório:";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(191, 135);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(111, 20);
            this.textBoxIp.TabIndex = 4;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(51, 142);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(56, 13);
            this.labelIp.TabIndex = 5;
            this.labelIp.Text = "IP tipo V4:";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(140, 191);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(92, 36);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // TelaCadastroMaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 239);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.labelLab);
            this.Controls.Add(this.textBoxLab);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "TelaCadastroMaq";
            this.Text = "TelaCadastroMaq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxLab;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Button btnCadastro;
    }
}