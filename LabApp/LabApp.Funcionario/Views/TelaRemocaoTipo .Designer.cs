namespace LabApp.Funcionario.Views
{
    partial class TelaRemocaoTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRemocaoTipo));
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(50, 12);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(126, 21);
            this.comboBoxTipos.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(33, 39);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(163, 35);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Pegar Lista de Tipos de Erros";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(70, 80);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 33);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // TelaRemocaoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 131);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.comboBoxTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRemocaoTipo";
            this.Text = "TelaRemocaoTipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRemover;
    }
}