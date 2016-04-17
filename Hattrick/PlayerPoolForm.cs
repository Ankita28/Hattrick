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
    public partial class PlayerPoolForm : Form
    {
        public PlayerPoolForm()
        {
            InitializeComponent();
            playerPoolGrid.Columns[0].HeaderText = "Player ID";
            playerPoolGrid.Columns[1].HeaderText = "Name";
            playerPoolGrid.Columns[2].HeaderText = "Speciality";
            playerPoolGrid.Columns[3].HeaderText = "Base Price in Crores";
            playerPoolGrid.Columns[4].HeaderText = "Nationality";
        }

        private void PlayerPoolForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select * from playerpool";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerpool");
            DataTable sTable = sDs.Tables["playerpool"];
            connection.Close();
            playerPoolGrid.DataSource = sDs.Tables["playerpool"];
            playerPoolGrid.ReadOnly = true;
            playerPoolGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sTable;
            playerPoolGrid.DataSource = bSource;
        }

        private void PlayerPoolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
