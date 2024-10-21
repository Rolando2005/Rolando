using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Inven.Pagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            CrearTablaSiNoExiste(); // Asegúrate de que la tabla exista
            LoadData();
            // Añadir columna de CheckBox si no existe
            if (!dataGridView1.Columns.Contains("CheckBoxColumn"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "CheckBoxColumn";
                checkBoxColumn.HeaderText = "Seleccionar";
                checkBoxColumn.Width = 50; // Ajustar ancho de la columna si es necesario
                dataGridView1.Columns.Insert(0, checkBoxColumn);
            }
        }

        private void CrearTablaSiNoExiste()
        {
            string query = @"CREATE TABLE IF NOT EXISTS pagos (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                nombre TEXT NOT NULL,
                                concepto TEXT NOT NULL,
                                monto REAL NOT NULL,
                                fecha DATE NOT NULL
                             );";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM pagos";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                string query = "INSERT INTO pagos (nombre, concepto, monto, fecha) VALUES (@nombre, @concepto, @monto, @fecha)";
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@concepto", txtConcepto.Text);
                    cmd.Parameters.AddWithValue("@monto", monto); // Usa el valor convertido
                    cmd.Parameters.AddWithValue("@fecha", dateTimePickerFecha.Value.Date);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un monto válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pagos WHERE fecha BETWEEN @fechaInicio AND @fechaFin";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaInicio", dateTimePickerInicio.Value.Date);
                cmd.Parameters.AddWithValue("@fechaFin", dateTimePickerFin.Value.Date);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnCargarMensual_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pagos WHERE strftime('%m', fecha) = @mes AND strftime('%Y', fecha) = @año";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@mes", DateTime.Now.Month.ToString("00"));
                cmd.Parameters.AddWithValue("@año", DateTime.Now.Year.ToString());
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value)) // Verifica si la celda CheckBox está seleccionada
                {
                    int id = Convert.ToInt32(row.Cells["id"].Value); // Obtiene el ID del registro
                    EliminarRegistro(id);
                }
            }
            LoadData();
        }

        private void EliminarRegistro(int id)
        {
            string query = "DELETE FROM pagos WHERE id = @id";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnResetIDs_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                connection.Open();

                string query1 = @"CREATE TABLE pagos_temp (
                            id INTEGER PRIMARY KEY,
                            nombre TEXT NOT NULL,
                            concepto TEXT NOT NULL,
                            monto REAL NOT NULL,
                            fecha DATE NOT NULL
                          );";

                string query2 = @"INSERT INTO pagos_temp (id, nombre, concepto, monto, fecha)
                          SELECT ROW_NUMBER() OVER(ORDER BY id), nombre, concepto, monto, fecha FROM pagos;";

                string query3 = "DROP TABLE pagos;";

                string query4 = "ALTER TABLE pagos_temp RENAME TO pagos;";

                using (SQLiteCommand cmd = new SQLiteCommand(query1, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query2, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query3, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query4, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            LoadData(); // Recarga los datos después de la modificación
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
