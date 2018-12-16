namespace CodificacionCesar
{
    partial class TexBoxTexto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTexto = new System.Windows.Forms.Label();
            this.textBoxTex = new System.Windows.Forms.TextBox();
            this.panelCesar = new System.Windows.Forms.Panel();
            this.textBoxCifr = new System.Windows.Forms.TextBox();
            this.labelCifrado = new System.Windows.Forms.Label();
            this.labelCesar = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.panelnversa = new System.Windows.Forms.Panel();
            this.textBoxInv = new System.Windows.Forms.TextBox();
            this.labelnverso = new System.Windows.Forms.Label();
            this.panelTransGr = new System.Windows.Forms.Panel();
            this.labelGru = new System.Windows.Forms.Label();
            this.textBoxGru = new System.Windows.Forms.TextBox();
            this.labelnxGru = new System.Windows.Forms.Label();
            this.despazaUpDown = new System.Windows.Forms.NumericUpDown();
            this.gruposUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelCesar.SuspendLayout();
            this.panelnversa.SuspendLayout();
            this.panelTransGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despazaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(151, 38);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(34, 13);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Texto";
            // 
            // textBoxTex
            // 
            this.textBoxTex.Location = new System.Drawing.Point(201, 25);
            this.textBoxTex.Multiline = true;
            this.textBoxTex.Name = "textBoxTex";
            this.textBoxTex.Size = new System.Drawing.Size(277, 39);
            this.textBoxTex.TabIndex = 1;
            this.textBoxTex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelCesar
            // 
            this.panelCesar.Controls.Add(this.despazaUpDown);
            this.panelCesar.Controls.Add(this.textBoxCifr);
            this.panelCesar.Controls.Add(this.labelCifrado);
            this.panelCesar.Controls.Add(this.labelCesar);
            this.panelCesar.Controls.Add(this.labelDes);
            this.panelCesar.Location = new System.Drawing.Point(12, 91);
            this.panelCesar.Name = "panelCesar";
            this.panelCesar.Size = new System.Drawing.Size(173, 173);
            this.panelCesar.TabIndex = 2;
            // 
            // textBoxCifr
            // 
            this.textBoxCifr.Location = new System.Drawing.Point(24, 76);
            this.textBoxCifr.Multiline = true;
            this.textBoxCifr.Name = "textBoxCifr";
            this.textBoxCifr.Size = new System.Drawing.Size(133, 86);
            this.textBoxCifr.TabIndex = 4;
            // 
            // labelCifrado
            // 
            this.labelCifrado.AutoSize = true;
            this.labelCifrado.Location = new System.Drawing.Point(21, 60);
            this.labelCifrado.Name = "labelCifrado";
            this.labelCifrado.Size = new System.Drawing.Size(70, 13);
            this.labelCifrado.TabIndex = 3;
            this.labelCifrado.Text = "Texto Cifrado";
            // 
            // labelCesar
            // 
            this.labelCesar.AutoSize = true;
            this.labelCesar.Location = new System.Drawing.Point(54, 12);
            this.labelCesar.Name = "labelCesar";
            this.labelCesar.Size = new System.Drawing.Size(88, 13);
            this.labelCesar.TabIndex = 2;
            this.labelCesar.Text = "Encriptado Cesar";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(3, 39);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(82, 13);
            this.labelDes.TabIndex = 1;
            this.labelDes.Text = "Desplazamiento";
            // 
            // panelnversa
            // 
            this.panelnversa.Controls.Add(this.textBoxInv);
            this.panelnversa.Controls.Add(this.labelnverso);
            this.panelnversa.Location = new System.Drawing.Point(229, 91);
            this.panelnversa.Name = "panelnversa";
            this.panelnversa.Size = new System.Drawing.Size(178, 173);
            this.panelnversa.TabIndex = 3;
            // 
            // textBoxInv
            // 
            this.textBoxInv.Location = new System.Drawing.Point(15, 76);
            this.textBoxInv.Multiline = true;
            this.textBoxInv.Name = "textBoxInv";
            this.textBoxInv.Size = new System.Drawing.Size(140, 86);
            this.textBoxInv.TabIndex = 1;
            // 
            // labelnverso
            // 
            this.labelnverso.AutoSize = true;
            this.labelnverso.Location = new System.Drawing.Point(44, 12);
            this.labelnverso.Name = "labelnverso";
            this.labelnverso.Size = new System.Drawing.Size(96, 13);
            this.labelnverso.TabIndex = 0;
            this.labelnverso.Text = "Encriptado Inverso";
            // 
            // panelTransGr
            // 
            this.panelTransGr.Controls.Add(this.gruposUpDown);
            this.panelTransGr.Controls.Add(this.labelGru);
            this.panelTransGr.Controls.Add(this.textBoxGru);
            this.panelTransGr.Controls.Add(this.labelnxGru);
            this.panelTransGr.Location = new System.Drawing.Point(436, 91);
            this.panelTransGr.Name = "panelTransGr";
            this.panelTransGr.Size = new System.Drawing.Size(162, 173);
            this.panelTransGr.TabIndex = 4;
            // 
            // labelGru
            // 
            this.labelGru.AutoSize = true;
            this.labelGru.Location = new System.Drawing.Point(26, 7);
            this.labelGru.Name = "labelGru";
            this.labelGru.Size = new System.Drawing.Size(123, 13);
            this.labelGru.TabIndex = 3;
            this.labelGru.Text = "Transposición por Grupo";
            this.labelGru.Click += new System.EventHandler(this.labelGru_Click);
            // 
            // textBoxGru
            // 
            this.textBoxGru.Location = new System.Drawing.Point(17, 76);
            this.textBoxGru.Multiline = true;
            this.textBoxGru.Name = "textBoxGru";
            this.textBoxGru.Size = new System.Drawing.Size(132, 86);
            this.textBoxGru.TabIndex = 2;
            // 
            // labelnxGru
            // 
            this.labelnxGru.AutoSize = true;
            this.labelnxGru.Location = new System.Drawing.Point(40, 26);
            this.labelnxGru.Name = "labelnxGru";
            this.labelnxGru.Size = new System.Drawing.Size(89, 13);
            this.labelnxGru.TabIndex = 1;
            this.labelnxGru.Text = "Invertir por Grupo";
            this.labelnxGru.Click += new System.EventHandler(this.labelnxGru_Click);
            // 
            // despazaUpDown
            // 
            this.despazaUpDown.Location = new System.Drawing.Point(92, 39);
            this.despazaUpDown.Name = "despazaUpDown";
            this.despazaUpDown.Size = new System.Drawing.Size(65, 20);
            this.despazaUpDown.TabIndex = 5;
            // 
            // gruposUpDown
            // 
            this.gruposUpDown.Location = new System.Drawing.Point(43, 42);
            this.gruposUpDown.Name = "gruposUpDown";
            this.gruposUpDown.Size = new System.Drawing.Size(67, 20);
            this.gruposUpDown.TabIndex = 4;
            // 
            // TexBoxTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 285);
            this.Controls.Add(this.panelTransGr);
            this.Controls.Add(this.panelnversa);
            this.Controls.Add(this.panelCesar);
            this.Controls.Add(this.textBoxTex);
            this.Controls.Add(this.labelTexto);
            this.Name = "TexBoxTexto";
            this.Text = "Form1";
            this.panelCesar.ResumeLayout(false);
            this.panelCesar.PerformLayout();
            this.panelnversa.ResumeLayout(false);
            this.panelnversa.PerformLayout();
            this.panelTransGr.ResumeLayout(false);
            this.panelTransGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despazaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.TextBox textBoxTex;
        private System.Windows.Forms.Panel panelCesar;
        private System.Windows.Forms.Label labelCifrado;
        private System.Windows.Forms.Label labelCesar;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Panel panelnversa;
        private System.Windows.Forms.Label labelnverso;
        private System.Windows.Forms.Panel panelTransGr;
        private System.Windows.Forms.Label labelnxGru;
        private System.Windows.Forms.TextBox textBoxCifr;
        private System.Windows.Forms.TextBox textBoxInv;
        private System.Windows.Forms.TextBox textBoxGru;
        private System.Windows.Forms.Label labelGru;
        private System.Windows.Forms.NumericUpDown despazaUpDown;
        private System.Windows.Forms.NumericUpDown gruposUpDown;
    }
}

