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

namespace WF_Autok_Adatbazis
{
    public partial class Form_Autok_Nyito : Form
    {
        //-- MySqlConnection Represents an open connection to a MySQL Server database. This class cannot be inherited.
        MySqlConnection mysqlConnection = null;

        //-- MySqlCommand Represents a SQL statement to execute against a MySQL database. This class cannot be inherited.
        MySqlCommand mysqlCommand = null;

        public Form_Autok_Nyito()
        {
            InitializeComponent();
        }
         
        private void Form_Autok_Nyito_Load(object sender, EventArgs e)
        {
            //-- MySqlConnectionStringBuilder Provides a base class for strongly typed connection string builders over MySQL connections.
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "autok";
            sb.CharacterSet = "utf8";
            sb.SslMode = 0;
            mysqlConnection = new MySqlConnection(sb.ToString());
            //sqlCommand = connection.CreateCommand();
            mysqlCommand = new MySqlCommand(sb.Server, mysqlConnection);
            AutokAdatainakBetolteseAdatbazisbol();
            
        }

        private void AutokAdatainakBetolteseAdatbazisbol()
        {
            listBox_Autok.Items.Clear();
            try
            {
                mysqlConnection.Open();
                mysqlCommand.CommandText = "SELECT `id`, `rendszam`, `gyartmany`, `tipus` FROM `autok` WHERE 1;";
                using (MySqlDataReader dr = mysqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Auto auto = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetString("gyartmany"), dr.GetString("tipus"));
                        listBox_Autok.Items.Add(auto);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
