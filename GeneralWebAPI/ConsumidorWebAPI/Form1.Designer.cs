namespace ConsumidorWebAPI
{
    partial class Form1
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
            this.btnTesteImagem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCaminhoImagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTesteImagem
            // 
            this.btnTesteImagem.Location = new System.Drawing.Point(123, 51);
            this.btnTesteImagem.Name = "btnTesteImagem";
            this.btnTesteImagem.Size = new System.Drawing.Size(86, 32);
            this.btnTesteImagem.TabIndex = 0;
            this.btnTesteImagem.Text = "Enviar Imagem";
            this.btnTesteImagem.UseVisualStyleBackColor = true;
            this.btnTesteImagem.Click += new System.EventHandler(this.btnTesteImagem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(197, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // btnCaminhoImagem
            // 
            this.btnCaminhoImagem.Location = new System.Drawing.Point(212, 25);
            this.btnCaminhoImagem.Name = "btnCaminhoImagem";
            this.btnCaminhoImagem.Size = new System.Drawing.Size(27, 20);
            this.btnCaminhoImagem.TabIndex = 2;
            this.btnCaminhoImagem.Text = "...";
            this.btnCaminhoImagem.UseVisualStyleBackColor = true;
            this.btnCaminhoImagem.Click += new System.EventHandler(this.btnCaminhoImagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho Imagem:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaminhoImagem);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnTesteImagem);
            this.Name = "Form1";
            this.Text = "Menu de Testes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTesteImagem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnCaminhoImagem;
        private System.Windows.Forms.Label label1;
    }
}

