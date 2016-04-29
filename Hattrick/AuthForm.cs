using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hattrick
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = usernameTextBox;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginCheck(usernameTextBox.Text, passwordTextBox.Text))
            {
                string team = getTeam(usernameTextBox.Text);
                this.Close();
                OwnerScreen ownerScreen = new OwnerScreen(team);
                ownerScreen.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

        private bool loginCheck(string username, string password)
        {
            int index = 999;
            string connectionString = "your_connection_string";
            string sql = "select username, password from users";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "users");
            DataTable sTable = sDs.Tables["users"];
            connection.Close();
            var usernames = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("username")).ToList();
            var passwords = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("password")).ToList();
            for (int i = 0; i < usernames.Count(); i++)
            {
                if (usernames[i] == username)
                {
                    index = i;
                    break;
                }
            }
            if (index == 999)
                return false;
            if (passwords[index] == password)
                return true;
            return false;
        }

        private string getTeam(string username)
        {
            string connectionString = "your_connection_string";
            string sql = "select teamname from users natural join teaminfo where username=\""+username+"\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }
    }
}
