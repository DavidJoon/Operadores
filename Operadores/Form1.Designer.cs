
namespace Operadores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonOperadores = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFormatacao = new System.Windows.Forms.Button();
            this.labelFormatacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(53, 29);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 15);
            this.labelA.TabIndex = 0;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(53, 68);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 15);
            this.labelB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(53, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(146, 116);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(62, 15);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado:";
            // 
            // buttonOperadores
            // 
            this.buttonOperadores.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonOperadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOperadores.Location = new System.Drawing.Point(53, 172);
            this.buttonOperadores.Name = "buttonOperadores";
            this.buttonOperadores.Size = new System.Drawing.Size(155, 23);
            this.buttonOperadores.TabIndex = 4;
            this.buttonOperadores.Text = "Mais Operadores";
            this.buttonOperadores.UseVisualStyleBackColor = false;
            this.buttonOperadores.Click += new System.EventHandler(this.buttonOperadores_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 94);
            this.listBox1.TabIndex = 5;
            // 
            // buttonFormatacao
            // 
            this.buttonFormatacao.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFormatacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormatacao.Location = new System.Drawing.Point(280, 172);
            this.buttonFormatacao.Name = "buttonFormatacao";
            this.buttonFormatacao.Size = new System.Drawing.Size(141, 23);
            this.buttonFormatacao.TabIndex = 6;
            this.buttonFormatacao.Text = "Formatação";
            this.buttonFormatacao.UseVisualStyleBackColor = false;
            this.buttonFormatacao.Click += new System.EventHandler(this.buttonFormatacao_Click);
            // 
            // labelFormatacao
            // 
            this.labelFormatacao.BackColor = System.Drawing.Color.Turquoise;
            this.labelFormatacao.Location = new System.Drawing.Point(280, 201);
            this.labelFormatacao.Name = "labelFormatacao";
            this.labelFormatacao.Size = new System.Drawing.Size(141, 94);
            this.labelFormatacao.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFormatacao);
            this.Controls.Add(this.buttonFormatacao);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOperadores);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonOperadores;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFormatacao;
        private System.Windows.Forms.Label labelFormatacao;
    }
}

