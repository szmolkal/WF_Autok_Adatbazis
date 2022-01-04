using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            //sb.Server = "localhost";
            //sb.UserID = "root";
            //sb.Password = "";
            //sb.Database = "autok";
            //sb.CharacterSet = "utf8";
            //sb.SslMode = 0;
            //mysqlConnection = new MySqlConnection(sb.ToString());
            ////sqlCommand = connection.CreateCommand();
            //mysqlCommand = new MySqlCommand(sb.Server, mysqlConnection);
            AutokAdatainakBetolteseAdatbazisbol();

        }


        #region //-- Módszer1
        //private void AutokAdatainakBetolteseAdatbazisbol()
        //{
        //    listBox_Autok.Items.Clear();
        //    try
        //    {
        //        mysqlConnection.Open();
        //        mysqlCommand.CommandText = "SELECT `id`, `rendszam`, `gyartmany`, `tipus` FROM `autok` WHERE 1;";
        //        using (MySqlDataReader dr = mysqlCommand.ExecuteReader())
        //        {
        //            while (dr.Read())
        //            {
        //                Auto auto = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetString("gyartmany"), dr.GetString("tipus"));
        //                listBox_Autok.Items.Add(auto);
        //            }
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion

        #region //-- Módszer2
        // private void AutokAdatainakBetolteseAdatbazisbol()
        // {
        //     MySqlConnection mysqlConnection;
        //     MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
        //     stringBuilder.Server = "localhost";
        //     stringBuilder.UserID = "root";
        //     stringBuilder.Password = "";
        //     stringBuilder.CharacterSet = "utf8";
        //     stringBuilder.SslMode = 0;
        //     stringBuilder.Database = "autok";
        //     mysqlConnection = new MySqlConnection(stringBuilder.ToString());
        //     try
        //     {
        //         mysqlConnection.Open();
        //         string SQLString = "SELECT * FROM autok WHERE 1";
        //         MySqlCommand mysqlCommand = mysqlConnection.CreateCommand();
        //         mysqlCommand.CommandText = SQLString;
        //         //mysqlCommand = new MySqlCommand(SQLString, mysqlConnection);
        //         try
        //         {
        //             using (MySqlDataReader dataReader = mysqlCommand.ExecuteReader())
        //             {
        //                 while (dataReader.Read())
        //                 {
        //                     Auto auto = new Auto(dataReader.GetInt32("id"), dataReader.GetString("rendszam"), dataReader.GetString("gyartmany"), dataReader.GetString("tipus"));

        //                     listBox_Autok.Items.Add(auto);
        //                 }
        //             }
        //         }
        //         catch (MySqlException ex)
        //         {
        //             MessageBox.Show(ex.Message);
        //         }            }
        //     catch (MySqlException ex)
        //     {
        //         MessageBox.Show(ex.Message);
        //         //this.DialogResult = DialogResult.Cancel;
        //         return;
        //     }


        //     mysqlConnection.Close();
        //}
        #endregion

        #region //-- Módszer2 újra1
        //private void AutokAdatainakBetolteseAdatbazisbol()
        //{
        //    //-- Connection objektum
        //    MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        //    mySqlConnectionStringBuilder.Server = "localhost";
        //    mySqlConnectionStringBuilder.UserID = "root";
        //    mySqlConnectionStringBuilder.Password = "";
        //    mySqlConnectionStringBuilder.SslMode = 0;
        //    mySqlConnectionStringBuilder.Database = "autok";
        //    mySqlConnectionStringBuilder.CharacterSet = "utf8";
        //    mysqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ToString());

        //    try
        //    {
        //        mysqlConnection.Open();
        //        try
        //        {
        //            //-- Command objektum
        //            mysqlCommand = mysqlConnection.CreateCommand();
        //            mysqlCommand.CommandText = "SELECT * FROM autok;";

        //            try
        //            {
        //                //-- DataReader objektum
        //                MySqlDataReader mySqlDataReader = mysqlCommand.ExecuteReader();
        //                while (mySqlDataReader.Read())
        //                {
        //                    Auto auto = new Auto(mySqlDataReader.GetInt32("id"), mySqlDataReader.GetString("rendszam"), mySqlDataReader.GetString("gyartmany"), mySqlDataReader.GetString("tipus"));
        //                    this.listBox_Autok.Items.Add(auto);
        //                }
        //            }
        //            catch (MySqlException ex)
        //            {

        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //        catch (MySqlException ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //        }

        //    }
        //    catch (MySqlException ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion //-- Módszer2 újra1

        #region //-- Módszer2 újra2
        private void AutokAdatainakBetolteseAdatbazisbol()
        {
            //-- Connection objektum
            try
            {
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.Database = "autok";
                mySqlConnectionStringBuilder.UserID = "root";
                mySqlConnectionStringBuilder.Server = "localhost";
                mySqlConnectionStringBuilder.Password = "";
                mySqlConnectionStringBuilder.SslMode = 0;
                mySqlConnectionStringBuilder.CharacterSet = "utf8";

                mysqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ToString());
                mysqlConnection.Open();

                //-- Command objektum:
                try
                {
                    mysqlCommand = new MySqlCommand("SELECT * FROM autok;", mysqlConnection);                    

                    //-- DataReader objektum:
                    try
                    {
                        MySqlDataReader mySqlDataReader = mysqlCommand.ExecuteReader();
                        while (mySqlDataReader.Read())
                        {
                            Auto auto = new Auto(mySqlDataReader.GetInt32("id"), mySqlDataReader.GetString("rendszam"), mySqlDataReader.GetString("gyartmany"), mySqlDataReader.GetString("tipus"));
                            this.listBox_Autok.Items.Add(auto);
                        }
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            mysqlConnection.Close();
        }
        #endregion //-- Módszer2 újra2

        private void button_Close_Click(object sender, EventArgs e)
        {
            
            string sqlInserIntoString = "INSERT INTO `autok`(`rendszam`, `gyartmany`, `tipus`) VALUES (@rendszam,@gyartmany,@tipus);";
            mysqlCommand.CommandText = sqlInserIntoString;
            mysqlConnection.Open();

            //int ujAutoInListbox = 0; //Ennek értékét mindig eggyel növeljük, ha új - még rögzítetlen elemet találunk a listboxban) Lásd a foreach ciklusban.
            foreach (Auto auto in listBox_Autok.Items)
            {
                if (auto.Id==0)
                {
                    mysqlCommand.Parameters.AddWithValue("@rendszam",(string) textBox_Rendszam.Text);
                    mysqlCommand.Parameters.AddWithValue("@gyartmany",(string) textBox_Gyartmany.Text);
                    mysqlCommand.Parameters.AddWithValue("@tipus",(string) textBox_Tipus.Text);
                    mysqlCommand.ExecuteNonQuery();
                }
            }

            //try
            //{
            //    //mysqlConnection.Open();
            //    mysqlCommand.ExecuteNonQuery();
            //}
            //catch (MySqlException ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            mysqlConnection.Close();
            //this.Close();
        }

        //private void button_Insert_MouseMove(object sender, MouseEventArgs e)
        //{
        //    ToolTip toolTip = new ToolTip();
        //    toolTip.ToolTipTitle = "Adatok rögzítése a listában.";
        //    toolTip.AutoPopDelay = 15000;
        //    toolTip.InitialDelay = 500;
        //    toolTip.ReshowDelay = 500;
        //    toolTip.IsBalloon = true;
        //    toolTip.ShowAlways = true;
        //    toolTip.SetToolTip(button_Insert,"Kattints a rögzítéshez!");
        //    //toolTip = null;
        //}

        private void button_Delete_Click(object sender, EventArgs e)
        {
            listBox_Autok.Items.RemoveAt(listBox_Autok.SelectedIndex);
        }

        private void button_Save_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 15000;
            toolTip.ToolTipTitle = "Mentés gomb";
            toolTip.SetToolTip(button_Save, "Adatok mentése adatbázisba, az ablak bezárása nélkül.");
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
        }

        private void button_Insert_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipTitle = "Adatok rögzítése a listában.";
            toolTip.AutoPopDelay = 15000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(button_Insert,"Kattints a gombra a listában való rögzítéshez!\n(Ekkor az adatbázisban még nem kerül mentésre.)");
            //toolTip = null;

        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(0, textBox_Rendszam.Text, textBox_Gyartmany.Text, textBox_Tipus.Text);
            listBox_Autok.Items.Add(auto);
        }
    }
}
