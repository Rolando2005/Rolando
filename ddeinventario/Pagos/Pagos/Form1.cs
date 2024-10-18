using System.Data;
using System.Data.SQLite;

namespace Pagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM pagos";
            using (SQLiteConection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pagos (nombre, concepto, monto, fecha) VALUES (@nombre, @concepto, @monto, @fecha)";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=pagos.db;Version=3;"))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@concepto", txtConcepto.Text);
                cmd.Parameters.AddWithValue("@monto", txtMonto.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePickerFecha.Value.Date);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
