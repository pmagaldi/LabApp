namespace LabApp
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
            this.TextPrincipal = new System.Windows.Forms.Label();
            this.comboBoxLabs = new System.Windows.Forms.ComboBox();
            this.TextLab = new System.Windows.Forms.Label();
            this.comboBoxMaq = new System.Windows.Forms.ComboBox();
            this.TextMaquina = new System.Windows.Forms.Label();
            this.comboBoxProb = new System.Windows.Forms.ComboBox();
            this.TextProblema = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextPrincipal
            // 
            this.TextPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPrincipal.AutoSize = true;
            this.TextPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrincipal.Location = new System.Drawing.Point(39, 9);
            this.TextPrincipal.Name = "TextPrincipal";
            this.TextPrincipal.Size = new System.Drawing.Size(381, 20);
            this.TextPrincipal.TabIndex = 0;
            this.TextPrincipal.Text = "labApp - Aplicativo de Agendamento de Manutenção";
            // 
            // comboBoxLabs
            // 
            this.comboBoxLabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLabs.FormattingEnabled = true;
            this.comboBoxLabs.Location = new System.Drawing.Point(186, 65);
            this.comboBoxLabs.Name = "comboBoxLabs";
            this.comboBoxLabs.Size = new System.Drawing.Size(150, 21);
            this.comboBoxLabs.TabIndex = 1;
            // 
            // TextLab
            // 
            this.TextLab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLab.AutoSize = true;
            this.TextLab.Location = new System.Drawing.Point(102, 68);
            this.TextLab.Name = "TextLab";
            this.TextLab.Size = new System.Drawing.Size(78, 13);
            this.TextLab.TabIndex = 2;
            this.TextLab.Text = "Nº Laboratório:";
            // 
            // comboBoxMaq
            // 
            this.comboBoxMaq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMaq.FormattingEnabled = true;
            this.comboBoxMaq.Location = new System.Drawing.Point(186, 111);
            this.comboBoxMaq.Name = "comboBoxMaq";
            this.comboBoxMaq.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMaq.TabIndex = 3;
            // 
            // TextMaquina
            // 
            this.TextMaquina.AutoSize = true;
            this.TextMaquina.Location = new System.Drawing.Point(99, 114);
            this.TextMaquina.Name = "TextMaquina";
            this.TextMaquina.Size = new System.Drawing.Size(81, 13);
            this.TextMaquina.TabIndex = 4;
            this.TextMaquina.Text = "Nº da Maquina:";
            // 
            // comboBoxProb
            // 
            this.comboBoxProb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProb.FormattingEnabled = true;
            this.comboBoxProb.Location = new System.Drawing.Point(185, 163);
            this.comboBoxProb.Name = "comboBoxProb";
            this.comboBoxProb.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProb.TabIndex = 5;
            // 
            // TextProblema
            // 
            this.TextProblema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextProblema.AutoSize = true;
            this.TextProblema.Location = new System.Drawing.Point(87, 166);
            this.TextProblema.Name = "TextProblema";
            this.TextProblema.Size = new System.Drawing.Size(93, 13);
            this.TextProblema.TabIndex = 6;
            this.TextProblema.Text = "Tipo de Problema:";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnviar.Location = new System.Drawing.Point(157, 214);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(129, 45);
            this.buttonEnviar.TabIndex = 7;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.ButtonEnviar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 298);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.TextProblema);
            this.Controls.Add(this.comboBoxProb);
            this.Controls.Add(this.TextMaquina);
            this.Controls.Add(this.comboBoxMaq);
            this.Controls.Add(this.TextLab);
            this.Controls.Add(this.comboBoxLabs);
            this.Controls.Add(this.TextPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "LabApp";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPrincipal;
        private System.Windows.Forms.ComboBox comboBoxLabs;
        private System.Windows.Forms.Label TextLab;
        private System.Windows.Forms.ComboBox comboBoxMaq;
        private System.Windows.Forms.Label TextMaquina;
        private System.Windows.Forms.ComboBox comboBoxProb;
        private System.Windows.Forms.Label TextProblema;
        private System.Windows.Forms.Button buttonEnviar;
    }
}

