namespace CapaPresentacion
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
            txtEmpleado = new TextBox();
            txtMotivo = new TextBox();
            label1 = new Label();
            lstBitacora = new ListBox();
            label2 = new Label();
            label3 = new Label();
            btnSolicitarpermiso = new Button();
            btnVerBitacora = new Button();
            numDias = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            SuspendLayout();
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(308, 87);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(220, 27);
            txtEmpleado.TabIndex = 0;
            txtEmpleado.TextChanged += textBox1_TextChanged;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(308, 155);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(220, 27);
            txtMotivo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 25);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 2;
            label1.Text = "GESTION DE PERMISOS";
            // 
            // lstBitacora
            // 
            lstBitacora.FormattingEnabled = true;
            lstBitacora.Location = new Point(158, 379);
            lstBitacora.Name = "lstBitacora";
            lstBitacora.Size = new Size(503, 44);
            lstBitacora.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 90);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 162);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Motivo";
            // 
            // btnSolicitarpermiso
            // 
            btnSolicitarpermiso.Location = new Point(170, 306);
            btnSolicitarpermiso.Name = "btnSolicitarpermiso";
            btnSolicitarpermiso.Size = new Size(152, 44);
            btnSolicitarpermiso.TabIndex = 6;
            btnSolicitarpermiso.Text = "Solicitar permiso";
            btnSolicitarpermiso.UseVisualStyleBackColor = true;
            btnSolicitarpermiso.Click += btnSolicitarpermiso_Click;
            // 
            // btnVerBitacora
            // 
            btnVerBitacora.Location = new Point(471, 306);
            btnVerBitacora.Name = "btnVerBitacora";
            btnVerBitacora.Size = new Size(134, 44);
            btnVerBitacora.TabIndex = 7;
            btnVerBitacora.Text = "Ver bitacora";
            btnVerBitacora.UseVisualStyleBackColor = true;
            btnVerBitacora.Click += button2_Click;
            // 
            // numDias
            // 
            numDias.Location = new Point(308, 219);
            numDias.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numDias.Name = "numDias";
            numDias.Size = new Size(220, 27);
            numDias.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 226);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 9;
            label4.Text = "Numero de dias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(numDias);
            Controls.Add(btnVerBitacora);
            Controls.Add(btnSolicitarpermiso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstBitacora);
            Controls.Add(label1);
            Controls.Add(txtMotivo);
            Controls.Add(txtEmpleado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpleado;
        private TextBox txtMotivo;
        private Label label1;
        private ListBox lstBitacora;
        private Label label2;
        private Label label3;
        private Button btnSolicitarpermiso;
        private Button btnVerBitacora;
        private NumericUpDown numDias;
        private Label label4;
    }
}
