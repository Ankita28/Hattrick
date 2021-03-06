﻿using System;
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
        string teamId;
        string connectionString = "your_connection_string";
        public PlayerPoolForm(string teamId)
        {
            InitializeComponent();
            playerPoolGrid.Columns[0].HeaderText = "Player ID";
            playerPoolGrid.Columns[1].HeaderText = "Name";
            playerPoolGrid.Columns[2].HeaderText = "Speciality";
            playerPoolGrid.Columns[3].HeaderText = "Base Price in Crores";
            playerPoolGrid.Columns[4].HeaderText = "Nationality";
            this.teamId = teamId;
        }

        private void PlayerPoolForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select * from playerinfo where teamid is null";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "playerinfo");
            DataTable sTable = sDs.Tables["playerinfo"];
            connection.Close();
            playerPoolGrid.DataSource = sDs.Tables["playerinfo"];
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

        private void addButton_Click(object sender, EventArgs e)
        {
            string sql = "call setTeam('" + teamId +"','" + playerTextBox.Text+"');";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            sCommand.ExecuteNonQuery();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OwnerScreen(getTeamName()).Show();
        }

        private string getTeamName()
        {
            string sql = "select teamname from teaminfo where teamid=\"" + teamId + "\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            return (string)sCommand.ExecuteScalar();
        }

    }
}
