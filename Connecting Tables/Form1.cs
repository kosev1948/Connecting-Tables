using MySql.Data.MySqlClient;

namespace Connecting_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server=10.6.0.127;" +
        "port=3306;" +
        "user = PC1;" +
        "Password=1111;" +
        "database=trees_zaimov;";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection now open");
            string insertSQL = "Insert into trees_zaimov.rod " +
               "(`name`, `name_bg`)" +
              "Values ( @name, @name_bg)";
            MySqlCommand query = new MySqlCommand(insertSQL, connect);
            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@name_bg", txt2.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("Dobavih v tablica rod");
            connect.Close();
        }
    }
}
