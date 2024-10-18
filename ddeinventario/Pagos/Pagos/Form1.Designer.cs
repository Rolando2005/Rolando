namespace Pagos
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dateTimePickerFecha = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            txtMonto = new TextBox();
            txtConcepto = new TextBox();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(265, 354);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(493, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(493, 246);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(472, 370);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 3;
            button3.Text = "CARGAMENSUAL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(335, 39);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(200, 23);
            dateTimePickerFecha.TabIndex = 4;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(335, 217);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 5;
            dateTimePickerInicio.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(541, 217);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(200, 23);
            dateTimePickerFin.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(541, 68);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 23);
            txtMonto.TabIndex = 7;
            txtMonto.Text = "Monto: ";
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(335, 68);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(200, 23);
            txtConcepto.TabIndex = 8;
            txtConcepto.Text = " Concepto: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(541, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 9;
            txtNombre.Text = "Nombre: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtConcepto);
            Controls.Add(txtMonto);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePickerFecha;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private TextBox txtMonto;
        private TextBox txtConcepto;
        private TextBox txtNombre;
    }
}
