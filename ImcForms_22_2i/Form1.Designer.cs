namespace ImcForms_22_2i {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txPeso = new System.Windows.Forms.TextBox();
            this.txAltura = new System.Windows.Forms.TextBox();
            this.btResultado = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(30, 91);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(81, 13);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "digite seu peso:";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(30, 130);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(84, 13);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "digite sua altura:";
            // 
            // txPeso
            // 
            this.txPeso.Location = new System.Drawing.Point(130, 88);
            this.txPeso.Name = "txPeso";
            this.txPeso.Size = new System.Drawing.Size(146, 20);
            this.txPeso.TabIndex = 2;
            this.txPeso.TextChanged += new System.EventHandler(this.txPeso_TextChanged);
            // 
            // txAltura
            // 
            this.txAltura.Location = new System.Drawing.Point(130, 130);
            this.txAltura.Name = "txAltura";
            this.txAltura.Size = new System.Drawing.Size(146, 20);
            this.txAltura.TabIndex = 3;
            // 
            // btResultado
            // 
            this.btResultado.BackColor = System.Drawing.Color.Blue;
            this.btResultado.Location = new System.Drawing.Point(337, 91);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(111, 48);
            this.btResultado.TabIndex = 4;
            this.btResultado.Text = "RESULTADO";
            this.btResultado.UseVisualStyleBackColor = false;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(81, 259);
            this.lbResultado.MaximumSize = new System.Drawing.Size(100, 100);
            this.lbResultado.MinimumSize = new System.Drawing.Size(10, 10);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(29, 31);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(213, 361);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(10, 13);
            this.lbCategoria.TabIndex = 7;
            this.lbCategoria.Text = ".";
            this.lbCategoria.Click += new System.EventHandler(this.lbCategoria_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(337, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(337, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.txAltura);
            this.Controls.Add(this.txPeso);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Name = "Form1";
            this.Text = "calculo de I.M.C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.TextBox txPeso;
        private System.Windows.Forms.TextBox txAltura;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

