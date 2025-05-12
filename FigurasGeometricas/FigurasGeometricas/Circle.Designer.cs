namespace Vnetanas
{
    partial class frmCircle
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReseat = new System.Windows.Forms.Button();
            this.btnCalculater = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbInputs.SuspendLayout();
            this.grbButtons.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtRadius);
            this.grbInputs.Controls.Add(this.lblRadio);
            this.grbInputs.Location = new System.Drawing.Point(29, 27);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbInputs.Size = new System.Drawing.Size(267, 123);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(84, 36);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(132, 22);
            this.txtRadius.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(9, 36);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(44, 16);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnExit);
            this.grbButtons.Controls.Add(this.btnReseat);
            this.grbButtons.Controls.Add(this.btnCalculater);
            this.grbButtons.Location = new System.Drawing.Point(29, 172);
            this.grbButtons.Margin = new System.Windows.Forms.Padding(4);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Padding = new System.Windows.Forms.Padding(4);
            this.grbButtons.Size = new System.Drawing.Size(317, 71);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            this.grbButtons.Text = "Botones";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 25);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReseat
            // 
            this.btnReseat.Location = new System.Drawing.Point(108, 25);
            this.btnReseat.Margin = new System.Windows.Forms.Padding(4);
            this.btnReseat.Name = "btnReseat";
            this.btnReseat.Size = new System.Drawing.Size(100, 28);
            this.btnReseat.TabIndex = 1;
            this.btnReseat.Text = "Resetear";
            this.btnReseat.UseVisualStyleBackColor = true;
            this.btnReseat.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculater
            // 
            this.btnCalculater.Location = new System.Drawing.Point(0, 25);
            this.btnCalculater.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculater.Name = "btnCalculater";
            this.btnCalculater.Size = new System.Drawing.Size(100, 28);
            this.btnCalculater.TabIndex = 0;
            this.btnCalculater.Text = "Calcular";
            this.btnCalculater.UseVisualStyleBackColor = true;
            this.btnCalculater.Click += new System.EventHandler(this.btnCalculater_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Location = new System.Drawing.Point(29, 268);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutputs.Size = new System.Drawing.Size(267, 123);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(9, 75);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(9, 43);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(65, 16);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perimetro";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(84, 75);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(132, 22);
            this.txtArea.TabIndex = 1;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(84, 43);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(132, 22);
            this.txtPerimeter.TabIndex = 0;
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.picCanvas);
            this.grbImagen.Location = new System.Drawing.Point(379, 27);
            this.grbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Padding = new System.Windows.Forms.Padding(4);
            this.grbImagen.Size = new System.Drawing.Size(589, 402);
            this.grbImagen.TabIndex = 3;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(37, 36);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(531, 343);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 456);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbInputs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCircle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circulo";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbButtons.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReseat;
        private System.Windows.Forms.Button btnCalculater;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
    }
}