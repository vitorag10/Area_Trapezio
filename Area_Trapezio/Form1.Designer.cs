namespace Area_Trapezio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdcalcular = new System.Windows.Forms.Button();
            this.lblBasemaior = new System.Windows.Forms.Label();
            this.txtBasemaior = new System.Windows.Forms.TextBox();
            this.txtbasemenor = new System.Windows.Forms.TextBox();
            this.lblbasemenor = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblaltura = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaltura);
            this.groupBox1.Controls.Add(this.lblaltura);
            this.groupBox1.Controls.Add(this.txtresultado);
            this.groupBox1.Controls.Add(this.lblresultado);
            this.groupBox1.Controls.Add(this.txtbasemenor);
            this.groupBox1.Controls.Add(this.lblbasemenor);
            this.groupBox1.Controls.Add(this.txtBasemaior);
            this.groupBox1.Controls.Add(this.lblBasemaior);
            this.groupBox1.Controls.Add(this.cmdcalcular);
            this.groupBox1.Location = new System.Drawing.Point(91, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AreaTrapezio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdcalcular
            // 
            this.cmdcalcular.Location = new System.Drawing.Point(229, 178);
            this.cmdcalcular.Name = "cmdcalcular";
            this.cmdcalcular.Size = new System.Drawing.Size(94, 29);
            this.cmdcalcular.TabIndex = 0;
            this.cmdcalcular.Text = "Calcular";
            this.cmdcalcular.UseVisualStyleBackColor = true;
            this.cmdcalcular.Click += new System.EventHandler(this.cmdcalcular_Click);
            // 
            // lblBasemaior
            // 
            this.lblBasemaior.AutoSize = true;
            this.lblBasemaior.Location = new System.Drawing.Point(77, 70);
            this.lblBasemaior.Name = "lblBasemaior";
            this.lblBasemaior.Size = new System.Drawing.Size(48, 20);
            this.lblBasemaior.TabIndex = 1;
            this.lblBasemaior.Text = "Base1";
            // 
            // txtBasemaior
            // 
            this.txtBasemaior.Location = new System.Drawing.Point(44, 93);
            this.txtBasemaior.Name = "txtBasemaior";
            this.txtBasemaior.Size = new System.Drawing.Size(125, 27);
            this.txtBasemaior.TabIndex = 2;
            // 
            // txtbasemenor
            // 
            this.txtbasemenor.Location = new System.Drawing.Point(247, 93);
            this.txtbasemenor.Name = "txtbasemenor";
            this.txtbasemenor.Size = new System.Drawing.Size(125, 27);
            this.txtbasemenor.TabIndex = 4;
            // 
            // lblbasemenor
            // 
            this.lblbasemenor.AutoSize = true;
            this.lblbasemenor.Location = new System.Drawing.Point(281, 70);
            this.lblbasemenor.Name = "lblbasemenor";
            this.lblbasemenor.Size = new System.Drawing.Size(52, 20);
            this.lblbasemenor.TabIndex = 3;
            this.lblbasemenor.Text = "base 2";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(223, 266);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(162, 27);
            this.txtresultado.TabIndex = 6;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(258, 243);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(75, 20);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(466, 93);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(125, 27);
            this.txtaltura.TabIndex = 8;
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(498, 70);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(49, 20);
            this.lblaltura.TabIndex = 7;
            this.lblaltura.Text = "Altura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtresultado;
        private Label lblresultado;
        private TextBox txtbasemenor;
        private Label lblbasemenor;
        private TextBox txtBasemaior;
        private Label lblBasemaior;
        private Button cmdcalcular;
        private TextBox txtaltura;
        private Label lblaltura;
    }
}