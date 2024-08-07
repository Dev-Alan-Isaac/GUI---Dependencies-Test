
using System.Data;
using System.Data.SqlClient;

namespace GUI___Dependencies_Test
{
    public partial class Tables : UserControl
    {
        public Tables()
        {
            InitializeComponent();
        }

     
        private void Tables_Load(object sender, EventArgs e)
        {
            // Connection string to your database
            string connectionString = "Server=Sistemas;Database=Test;User ID=Remote;Password=122;";

            // SQL query to select data from table1
            string query = "SELECT * FROM table1";

            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);
            }

            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = dataTable;
        }

    }
}
