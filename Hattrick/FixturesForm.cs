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
    public partial class FixturesForm : Form
    {
        public FixturesForm()
        {
            InitializeComponent();
            initResult();
            resultGrid.Columns[0].HeaderText = "Home Team";
            resultGrid.Columns[0].Width = 140;
            resultGrid.Columns[1].HeaderText = "Away Team";
            resultGrid.Columns[1].Width = 140;
            resultGrid.Columns[2].HeaderText = "Result";
            resultGrid.Columns[2].Width = 252;
        }

        private void FixturesForm_Load(object sender, EventArgs e)
        {

        }

        private void initResult()
        {
            string connectionString = "server=Lenovo-PC;uid=anuraag;pwd=razerbeats296;database=hattrick;";
            string sql = "select hometeamid, awayteamid, winning_innings, result from fixtures";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "fixtures");
            DataTable sTable = sDs.Tables["fixtures"];
            connection.Close();
            var hometeamid = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("hometeamid")).ToList();
            var awayteamid = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("awayteamid")).ToList();
            var winning_innings = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("winning_innings")).ToList();
            var result = sTable.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("result")).ToList();
            List<Result> resultList = new List<Result>();
            for (int i = 0; i < hometeamid.Count(); i++)
            {
                resultList.Add(new Result() { homeTeam = getName(hometeamid[i]), awayTeam = getName(awayteamid[i]), result = getResult(result[i], winning_innings[i], hometeamid[i], awayteamid[i]) });

            }
            var bindingList = new BindingList<Result>(resultList);
            var bindingSource = new BindingSource(resultList, null);
            resultGrid.DataSource = bindingSource;
        }

        public string getName(string id)
        {
            switch (id)
            {
                case "1A":
                    return "Rising Pune Supergiants";
                case "1B":
                    return "Sunrisers Hyderabad";
                case "1C":
                    return "Kings XI Punjab";
                case "1D":
                    return "Royal Challengers Bangalore";
                case "1E":
                    return "Delhi Daredevils";
                case "1F":
                    return "Mumbai Indians";
                case "1G":
                    return "Kolkata Knight Riders";
                case "1H":
                    return "Gujarat Lions";

            }
            return null;
        }

        public string getResult(int result, int innings, string hometeam, string awayteam)
        {
            if (innings == 1)
                return getName(hometeam) + " won by " + result + " runs";
            else if (innings == 2)
                return getName(awayteam) + " won by " + result + " wickets";
            else if (innings == 4)
                return getName(awayteam) + " won in Super Over";
            else if (innings == 0)
                return "No Result";
            return null;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new GuestForm().Show();
        }
    }
}
