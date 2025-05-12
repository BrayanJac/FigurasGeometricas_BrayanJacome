namespace IsoscelesTrapezoid
{
    partial class frmIsoscelesTrapezoid
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
            this.txtBaseS = new System.Windows.Forms.TextBox();
            this.txtBaseI = new System.Windows.Forms.TextBox();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.lblBaseS = new System.Windows.Forms.Label();
            this.lblBaseI = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.grbProceso = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcule = new System.Windows.Forms.Button();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
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
            this.grbEntradas.Controls.Add(this.txtBaseS);
            this.grbEntradas.Controls.Add(this.txtBaseI);
            this.grbEntradas.Controls.Add(this.txtSides);
            this.grbEntradas.Controls.Add(this.lblBaseS);
            this.grbEntradas.Controls.Add(this.lblBaseI);
            this.grbEntradas.Controls.Add(this.lblSides);
            this.grbEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntradas.Location = new System.Drawing.Point(68, 49);
            this.grbEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Padding = new System.Windows.Forms.Padding(4);
            this.grbEntradas.Size = new System.Drawing.Size(416, 161);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtBaseS
            // 
            this.txtBaseS.Location = new System.Drawing.Point(192, 116);
            this.txtBaseS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseS.Name = "txtBaseS";
            this.txtBaseS.Size = new System.Drawing.Size(145, 23);
            this.txtBaseS.TabIndex = 5;
            // 
            // txtBaseI
            // 
            this.txtBaseI.Location = new System.Drawing.Point(192, 75);
            this.txtBaseI.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseI.Name = "txtBaseI";
            this.txtBaseI.Size = new System.Drawing.Size(145, 23);
            this.txtBaseI.TabIndex = 4;
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(192, 32);
            this.txtSides.Margin = new System.Windows.Forms.Padding(4);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(145, 23);
            this.txtSides.TabIndex = 3;
            // 
            // lblBaseS
            // 
            this.lblBaseS.AutoSize = true;
            this.lblBaseS.Location = new System.Drawing.Point(35, 116);
            this.lblBaseS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseS.Name = "lblBaseS";
            this.lblBaseS.Size = new System.Drawing.Size(111, 17);
            this.lblBaseS.TabIndex = 2;
            this.lblBaseS.Text = "Base Superior";
            // 
            // lblBaseI
            // 
            this.lblBaseI.AutoSize = true;
            this.lblBaseI.Location = new System.Drawing.Point(35, 79);
            this.lblBaseI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseI.Name = "lblBaseI";
            this.lblBaseI.Size = new System.Drawing.Size(106, 17);
            this.lblBaseI.TabIndex = 1;
            this.lblBaseI.Text = "Base Inferior:";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(35, 36);
            this.lblSides.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(116, 17);
            this.lblSides.TabIndex = 0;
            this.lblSides.Text = "Lateral (a) (b):";
            // 
            // grbProceso
            // 
            this.grbProceso.Controls.Add(this.btnExit);
            this.grbProceso.Controls.Add(this.btnReset);
            this.grbProceso.Controls.Add(this.btnCalcule);
            this.grbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProceso.Location = new System.Drawing.Point(68, 244);
            this.grbProceso.Margin = new System.Windows.Forms.Padding(4);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Padding = new System.Windows.Forms.Padding(4);
            this.grbProceso.Size = new System.Drawing.Size(416, 123);
            this.grbProceso.TabIndex = 1;
            this.grbProceso.TabStop = false;
            this.grbProceso.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 62);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(153, 62);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcule
            // 
            this.btnCalcule.Location = new System.Drawing.Point(32, 62);
            this.btnCalcule.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(100, 28);
            this.btnCalcule.TabIndex = 0;
            this.btnCalcule.Text = "Calcular";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimeter);
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimeter);
            this.grbSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(68, 394);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(4);
            this.grbSalidas.Size = new System.Drawing.Size(416, 124);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(192, 74);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(145, 23);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(192, 23);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(145, 23);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(35, 78);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(35, 39);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(78, 17);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // grbGrafico
            // 
            this.grbGrafico.Controls.Add(this.picCanvas);
            this.grbGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGrafico.Location = new System.Drawing.Point(524, 49);
            this.grbGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.grbGrafico.Name = "grbGrafico";
            this.grbGrafico.Padding = new System.Windows.Forms.Padding(4);
            this.grbGrafico.Size = new System.Drawing.Size(488, 469);
            this.grbGrafico.TabIndex = 3;
            this.grbGrafico.TabStop = false;
            this.grbGrafico.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(40, 55);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(401, 370);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmIsoscelesTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 569);
            this.Controls.Add(this.grbGrafico);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntradas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIsoscelesTrapezoid";
            this.Text = "TrapecioIsosceles";
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
        private System.Windows.Forms.TextBox txtBaseS;
        private System.Windows.Forms.TextBox txtBaseI;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Label lblBaseS;
        private System.Windows.Forms.Label lblBaseI;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.GroupBox grbProceso;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbGrafico;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}