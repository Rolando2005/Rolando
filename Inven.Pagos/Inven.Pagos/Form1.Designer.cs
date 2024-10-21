namespace Inven.Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            dateTimePickerFecha = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            txtNombre = new TextBox();
            txtConcepto = new TextBox();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnCargarMensual = new Button();
            txtMonto = new TextBox();
            label4 = new Label();
            btnEliminar = new Button();
            btnResetIDs = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerFecha.Location = new Point(780, 87);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(200, 21);
            dateTimePickerFecha.TabIndex = 1;
            dateTimePickerFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(780, 263);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 2;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(986, 263);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(200, 23);
            dateTimePickerFin.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(986, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 21);
            txtNombre.TabIndex = 4;
            // 
            // txtConcepto
            // 
            txtConcepto.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConcepto.Location = new Point(780, 145);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(200, 21);
            txtConcepto.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(927, 174);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar: ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(947, 292);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCargarMensual
            // 
            btnCargarMensual.Location = new Point(1059, 391);
            btnCargarMensual.Name = "btnCargarMensual";
            btnCargarMensual.Size = new Size(127, 23);
            btnCargarMensual.TabIndex = 9;
            btnCargarMensual.Text = "Carga Mensual";
            btnCargarMensual.UseVisualStyleBackColor = true;
            btnCargarMensual.Click += btnCargarMensual_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(986, 145);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 21);
            txtMonto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(780, 69);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(775, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnResetIDs
            // 
            btnResetIDs.Location = new Point(856, 391);
            btnResetIDs.Name = "btnResetIDs";
            btnResetIDs.Size = new Size(93, 23);
            btnResetIDs.TabIndex = 15;
            btnResetIDs.Text = "Actualizar IDs";
            btnResetIDs.UseVisualStyleBackColor = true;
            btnResetIDs.Click += btnResetIDs_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(986, 69);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 16;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(985, 127);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 17;
            label6.Text = "Monto:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(780, 127);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 18;
            label7.Text = "Concepto:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(761, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(444, 163);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel2.Location = new Point(761, 360);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(444, 88);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel3.Location = new Point(761, 254);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(444, 68);
            flowLayoutPanel3.TabIndex = 21;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel4.Location = new Point(6, 59);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(607, 432);
            flowLayoutPanel4.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1273, 543);
            Controls.Add(btnCargarMensual);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnResetIDs);
            Controls.Add(btnEliminar);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(txtMonto);
            Controls.Add(txtConcepto);
            Controls.Add(txtNombre);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerFecha;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private TextBox txtConcepto;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnCargarMensual;
        private TextBox txtMonto;
        private Label label4;
        private Button btnEliminar;
        private Button btnResetIDs;
        private TextBox txtNombre;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
    }
}
