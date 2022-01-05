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

        private void Form_Autok_Nyito_FormClosing(object sender, FormClosingEventArgs e)
        {
            mysqlConnection.Close();

        }


        #region //-- Módszer1 -- private void AutokAdatainakBetolteseAdatbazisbol()
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

        #region //-- Módszer2 -- private void AutokAdatainakBetolteseAdatbazisbol()
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

        #region //-- Módszer2 újra1 -- private void AutokAdatainakBetolteseAdatbazisbol()
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

        #region //-- Módszer2 újra2 private void AutokAdatainakBetolteseAdatbazisbol()
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
                        mySqlDataReader.Close();
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
            //-- A mysqlConnection objektum csak az űrlap bezáródásakor fog bezárulni, lásd:
            //-- private void Form_Autok_Nyito_FormClosing(object sender, FormClosingEventArgs e) metódus

        }
        #endregion //-- Módszer2 újra2

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //-- Csak akkor tudunk törrölni a listából, ha van kijelölt elem
            if (listBox_Autok.SelectedIndex > -1)
            {
                //-- Ha a kijelölt elem ID-je nem nulla, akkor az az elem már az adatbázisban van, tehát onnan kell törölni.
                //-- Ellenkező esetben az elem még nincs benne az adatbázisban, tehát csak a listából kell törölni.
                Auto auto = (Auto)listBox_Autok.SelectedItem;
                if (auto.Id != 0)
                {
                    mysqlCommand.CommandText= "DELETE FROM `autok` WHERE id = @id";
                    mysqlCommand.Parameters.AddWithValue("id",auto.Id);
                    mysqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Egy rekord törlésre került az adatbázisból is és a listáról is");
                    listBox_Autok.Items.RemoveAt(listBox_Autok.SelectedIndex);
                    AutokAdatainakBetolteseAdatbazisbol();
                }
                else
                {
                    listBox_Autok.Items.RemoveAt(listBox_Autok.SelectedIndex);
                    MessageBox.Show("Egy rekord törlésre került a listából, az adatbázis nem módosult.");
               }
            }
            return;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlCommand.CommandText = "INSERT INTO `autok`(`rendszam`, `gyartmany`, `tipus`) VALUES(@rendszam, @gyartmany, @tipus)";
                //mysqlConnection.Open();  -- Nem kell megnyitni a kapcsolatot, mert míg a form nyitva van, addig a kapcsolat is fennáll
                int rekordSzamlalo = 0;
                foreach (Auto auto in listBox_Autok.Items)
                {
                    if (auto.Id == 0)
                    {
                        mysqlCommand.Parameters.AddWithValue("@rendszam", Convert.ToString(auto.Rendszam));
                        mysqlCommand.Parameters.AddWithValue("@gyartmany", Convert.ToString(auto.Gyartmany));
                        mysqlCommand.Parameters.AddWithValue("@tipus", Convert.ToString(auto.Tipus));
                        rekordSzamlalo += mysqlCommand.ExecuteNonQuery();
                    }
                }
                if (rekordSzamlalo > 0)
                {
                    MessageBox.Show($"{rekordSzamlalo} rekordot adtunk hozzá az adatbázishoz.");
                }
                //-- Ezután a listbox taratalmát töröljük és újra betöltjük az datbázisból, de már az új rekodokkal együtt:
                listBox_Autok.Items.Clear();
                AutokAdatainakBetolteseAdatbazisbol();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            foreach (Control control in groupBox_Autok.Controls)
            {
                Console.WriteLine($"{control.GetType().ToString().ToLower()} {control.Name} {control.Text}");
                if (control.GetType() == typeof(TextBox)) //control.GetType().ToString().ToLower()== "system.windows.forms.textbox"
                {
                    MessageBox.Show("Minden mezőt ki kell tölteni!");
                    control.Focus();
                    return;
                }
            }
            Auto auto = new Auto(0, textBox_Rendszam.Text, textBox_Gyartmany.Text, textBox_Tipus.Text);
            listBox_Autok.Items.Add(auto);
            textBox_Rendszam.Text = "";
            textBox_Gyartmany.Text = "";
            textBox_Tipus.Text = "";
        }

        private void listBox_Autok_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex > -1)
            {
                button_Delete.Enabled = true;
                button_Delete.TabStop = true;
                button_Insert.Enabled = true;
                button_Insert.TabStop = true;
            }
            else
            {
                button_Delete.Enabled = false;
                button_Delete.TabStop = false;
                button_Insert.Enabled = false;
                button_Insert.TabStop = false;
            }
        }
    }
}
