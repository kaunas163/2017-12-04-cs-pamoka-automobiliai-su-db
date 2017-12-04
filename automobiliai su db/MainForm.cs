using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace automobiliai_su_db
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private SqlConnection _connection;

        public MainForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager
                .ConnectionStrings["automobiliai_su_db.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (_connection = new SqlConnection(_connectionString)) // prisijungimas prie db
            using (var adapter = new SqlDataAdapter("select * from Cars", _connection)) // duomenu apdorojimas is db
            {
                //_connection.Open(); // adapteris pats atidaro connection prie db

                var carsTable = new DataTable(); // tuscia duomenu lentele
                adapter.Fill(carsTable); // duomenu lentele uzpildys duomenimis is db

                dataGridView1.DataSource = carsTable; // atvaizduoja duomenis formoje

                // _connection.Close(); // kadangi usinge tai nereikia rasyti
            }
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
