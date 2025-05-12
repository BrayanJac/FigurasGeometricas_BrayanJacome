namespace Diamond
{
    partial class frmDiamond
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
            this.grbEntradas = new System.Windows.Forms.GroupBox();
            this.txtDiagonalI = new System.Windows.Forms.TextBox();
            this.txtDiagonalS = new System.Windows.Forms.TextBox();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblDiagonalI = new System.Windows.Forms.Label();
            this.lblDiagonalS = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.grbProceso = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.grbGrafico = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbEntradas.SuspendLayout();
            this.grbProceso.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.txtDiagonalI);
            this.grbEntradas.Controls.Add(this.txtDiagonalS);
            this.grbEntradas.Controls.Add(this.txtSide);
            this.grbEntradas.Controls.Add(this.lblDiagonalI);
            this.grbEntradas.Controls.Add(this.lblDiagonalS);
            this.grbEntradas.Controls.Add(this.lblSide);
            this.grbEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntradas.Location = new System.Drawing.Point(29, 13);
            this.grbEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Padding = new System.Windows.Forms.Padding(4);
            this.grbEntradas.Size = new System.Drawing.Size(389, 160);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtDiagonalI
            // 
            this.txtDiagonalI.Location = new System.Drawing.Point(213, 121);
            this.txtDiagonalI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagonalI.Name = "txtDiagonalI";
            this.txtDiagonalI.Size = new System.Drawing.Size(113, 23);
            this.txtDiagonalI.TabIndex = 5;
            // 
            // txtDiagonalS
            // 
            this.txtDiagonalS.Location = new System.Drawing.Point(213, 80);
            this.txtDiagonalS.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagonalS.Name = "txtDiagonalS";
            this.txtDiagonalS.Size = new System.Drawing.Size(113, 23);
            this.txtDiagonalS.TabIndex = 4;
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(213, 43);
            this.txtSide.Margin = new System.Windows.Forms.Padding(4);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(113, 23);
            this.txtSide.TabIndex = 3;
            // 
            // lblDiagonalI
            // 
            this.lblDiagonalI.AutoSize = true;
            this.lblDiagonalI.Location = new System.Drawing.Point(45, 121);
            this.lblDiagonalI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagonalI.Name = "lblDiagonalI";
            this.lblDiagonalI.Size = new System.Drawing.Size(129, 17);
            this.lblDiagonalI.TabIndex = 2;
            this.lblDiagonalI.Text = "Diagonal Inferior";
            // 
            // lblDiagonalS
            // 
            this.lblDiagonalS.AutoSize = true;
            this.lblDiagonalS.Location = new System.Drawing.Point(45, 84);
            this.lblDiagonalS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagonalS.Name = "lblDiagonalS";
            this.lblDiagonalS.Size = new System.Drawing.Size(139, 17);
            this.lblDiagonalS.TabIndex = 1;
            this.lblDiagonalS.Text = "Diagonal Superior";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(45, 52);
            this.lblSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(44, 17);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado";
            // 
            // grbProceso
            // 
            this.grbProceso.Controls.Add(this.btnSalir);
            this.grbProceso.Controls.Add(this.btnResetear);
            this.grbProceso.Controls.Add(this.btnCalcular);
            this.grbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProceso.Location = new System.Drawing.Point(29, 181);
            this.grbProceso.Margin = new System.Windows.Forms.Padding(4);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Padding = new System.Windows.Forms.Padding(4);
            this.grbProceso.Size = new System.Drawing.Size(389, 123);
            this.grbProceso.TabIndex = 1;
            this.grbProceso.TabStop = false;
            this.grbProceso.Text = "Proceso";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 55);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(145, 55);
            this.btnResetear.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(100, 28);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 55);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimeter);
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimetro);
            this.grbSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(29, 323);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Size = new System.Drawing.Size(377, 143);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(201, 87);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(113, 23);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(201, 46);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(113, 23);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(55, 87);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(55, 46);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(78, 17);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perímetro";
            // 
            // grbGrafico
            // 
            this.grbGrafico.Controls.Add(this.picCanvas);
            this.grbGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGrafico.Location = new System.Drawing.Point(426, 13);
            this.grbGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.grbGrafico.Name = "grbGrafico";
            this.grbGrafico.Padding = new System.Windows.Forms.Padding(4);
            this.grbGrafico.Size = new System.Drawing.Size(499, 437);
            this.grbGrafico.TabIndex = 3;
            this.grbGrafico.TabStop = false;
            this.grbGrafico.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(21, 36);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(470, 393);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmDiamond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 483);
            this.Controls.Add(this.grbGrafico);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntradas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiamond";
            this.Text = "Rombo";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProceso.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.TextBox txtDiagonalI;
        private System.Windows.Forms.TextBox txtDiagonalS;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblDiagonalI;
        private System.Windows.Forms.Label lblDiagonalS;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.GroupBox grbProceso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbGrafico;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}