namespace LabApp
{
    partial class TelaErro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaErro));
            this.textErro = new System.Windows.Forms.Label();
            this.ErroTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textErro
            // 
            this.textErro.AutoSize = true;
            this.textErro.Location = new System.Drawing.Point(12, 9);
            this.textErro.Name = "textErro";
            this.textErro.Size = new System.Drawing.Size(102, 13);
            this.textErro.TabIndex = 2;
            this.textErro.Text = "Aconteceu Um erro!";
            // 
            // ErroTextBox
            // 
            this.ErroTextBox.Location = new System.Drawing.Point(12, 80);
            this.ErroTextBox.Multiline = true;
            this.ErroTextBox.Name = "ErroTextBox";
            this.ErroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErroTextBox.Size = new System.Drawing.Size(424, 230);
            this.ErroTextBox.TabIndex = 3;
            // 
            // TelaErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 322);
            this.Controls.Add(this.ErroTextBox);
            this.Controls.Add(this.textErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaErro";
            this.Text = "TelaErro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textErro;
        private System.Windows.Forms.TextBox ErroTextBox;
    }
}