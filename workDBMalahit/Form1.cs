using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace workDBMalahit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            //button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameDB = "malahit.db";
            //SQLiteConnection.CreateFile(nameDB);
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + nameDB + "; Version=3;");
            try
            {
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*string sql_command = "INSERT INTO Sales(ServiceId,Amount,Date) "
                                                     + "VALUES(12,650.00,strftime('%s', '2014-02-01')); "
                                + "INSERT INTO Sales(ServiceId,Amount,Date) "
                                                     + "VALUES(4,235.00,strftime('%s', '2014-01-31')); ";/*
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('FFF',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('MAG',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('ARG',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('Silen',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('FARGUS',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('AYS',1,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('ZIS',5,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('KAS',1,3); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('TRAS',3,1); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "     
                                                     + "VALUES('MARS',1,3); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('Michlene',3,3); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('RAB',1,5); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('KISLOTA',2,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('ZHIZHA',3,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('KAKTUS',3,4); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('LIME',5,1); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('FRUKT',2,5); "
                                +"INSERT INTO FIRM(FIRM_NAME,FIRM_POST_ID,FIRM_JUR_CITY_ID) "
                                                     + "VALUES('CHEBurashka',1,5); "
                               + "INSERT INTO CITY(CITY_NAME) "
                                                     + "VALUES('CHelyabinsk'); "
                               + "INSERT INTO CITY(CITY_NAME) "
                                                     + "VALUES('SAnt-Petersburg'); "
                               +"INSERT INTO CITY(CITY_NAME) "
                                                     + "VALUES('Moskva'); "
                               +"INSERT INTO CITY(CITY_NAME) "
                                                     + "VALUES('Kirov'); "
                               +"INSERT INTO CITY(CITY_NAME) "
                                                     + "VALUES('Kaliningrad'); ";*/
            /*"CREATE TABLE Sales(ServiceId PRIMARY KEY,"
                 + "Amount REAL,"
                 + "Date INTEGER);";/*
                 + "FOREIGN KEY (FIRM_POST_ID) REFERENCES CITY(ID),"
                 + "FOREIGN KEY (FIRM_POST_ID) REFERENCES CITY(ID)); "
                             + "CREATE TABLE CITY(ID INTEGER NOT NULL PRIMARY KEY,"
                                                         +"CITY_NAME TEXT);";*//*"DROP TABLE IF EXISTS Sales;";*/
                                                                               /*SQLiteCommand cmd = conn.CreateCommand();
                                                                               cmd.CommandText = sql_command;
                                                                               try
                                                                               {
                                                                                   cmd.ExecuteNonQuery();
                                                                               }
                                                                               catch (SQLiteException ex)
                                                                               {
                                                                                   Console.WriteLine(ex.Message);
                                                                               }
                                                                               conn.Close();*/
            string tx = textBox1.Text;
            char[] arr = tx.ToCharArray();
            for (int i=0;i< tx.Length;i++)
            {
                int count = 0;
                foreach (Match m in Regex.Matches(tx, arr[i].ToString()))
                {
                    count++;
                }
                if (count ==1)
                {
                    textBox2.Text = arr[i].ToString();
                    break;
                }
            }
            Equals(9,9);
            

        }

        private char PrintEqChar(string tx)
        {
            char[] arr = tx.ToCharArray();
            for (int i = 0; i < tx.Length; i++)
            {
                int count = 0;
                foreach (Match m in Regex.Matches(tx, arr[i].ToString()))
                {
                    count++;
                }
                if (count == 1)
                {
                    return arr[i];
                }
                
            }
            return '0';
        }

        private void Equals(int a1,int b1)
        {
            int a = a1;
            int b = b1;
            List<int> c2 = new List<int>(2);
            c2.Add(((a + b) + Math.Abs(a - b)) / 2);
            bool m= c2.Contains(a);
            bool m2= c2.Contains(b);
            bool m3 = m.Equals(m2);
            textBox1.Text =m3.ToString();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameDB = "malahit.db";
            //SQLiteConnection.CreateFile(nameDB);
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + nameDB + "; Version=3;");
            try
            {
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            string sql_command = string.Empty;
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && radioButton1.Checked!=true)
            {
                sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                                  + "WHERE FIRM_NAME = '" + textBox1.Text.ToString() + "' AND CITY.ID = FIRM.FIRM_POST_ID"
                                                                  + " AND CITY_NAME= '" + textBox2.Text.ToString() + "';";
            }
            else
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && radioButton1.Checked == true)
            {
                sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                                  + "WHERE FIRM_NAME = '" + textBox1.Text.ToString() + "' AND CITY.ID = FIRM.FIRM_JUR_CITY_ID"
                                                                  + " AND CITY_NAME= '" + textBox2.Text.ToString() + "';";
            }
            else
            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                sql_command = "select strftime([Date],0) as [Date],ServiceId,Amount from Sales WHERE DATE < '2014-02-28' AND DATE > '2014-01-31'";/*"SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM F "
                                                   + "LEFT OUTER JOIN CITY C ON F.FIRM_POST_ID = C.ID";*/
            }
            else
                if(textBox2.Text==String.Empty && textBox1.Text!="")
                 sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                  +"WHERE FIRM_NAME = '"+textBox1.Text.ToString()+"' AND CITY.ID = FIRM.FIRM_POST_ID;";
                else
                    if(radioButton1.Checked!= true && radioButton2.Checked!=true)
                     sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                  + "WHERE CITY_NAME = '" + textBox2.Text.ToString() + "' AND CITY.ID = FIRM.FIRM_POST_ID;";
                    else
                        if (radioButton1.Checked == true)
                            sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                            + "WHERE CITY_NAME = '" + textBox2.Text.ToString() + "' AND CITY.ID = FIRM_JUR_CITY_ID;";
                        else
                            if(radioButton2.Checked == true)
                                    sql_command = "SELECT FIRM_NAME, FIRM_POST_ID, FIRM_JUR_CITY_ID, CITY_NAME  FROM FIRM, CITY "
                                                                    + "WHERE CITY_NAME = '" + textBox2.Text.ToString() + "' AND CITY.ID = FIRM.FIRM_POST_ID;";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql_command;
            DataTable tble_to_grid = new DataTable();
            tble_to_grid.Columns.Add(" / ");
            int IJ = 0;
            tble_to_grid.Columns.Add("Date");
            tble_to_grid.Columns.Add("ServiceId");
            tble_to_grid.Columns.Add("Amount");
            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                string line = String.Empty;
                string line_name = String.Empty;
                string line_city = String.Empty;
                while (r.Read())
                {
                    ++IJ;
                    line = r["Date"].ToString();
                                         if (radioButton1.Checked == true)
                        line_name = r["ServiceId"].ToString();
                    else
                        line_name = r["ServiceId"].ToString();
                    if (radioButton1.Checked == true)
                        line_city = r["Amount"].ToString();
                    else
                        line_city = r["Amount"].ToString();
                    tble_to_grid.Rows.Add(IJ,line, line_name, line_city);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            dataGridView1.DataSource = tble_to_grid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty || textBox2.Text != String.Empty)
                button2.Text = "Filtre";
            else
                button2.Text = "ShowAll";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty || textBox2.Text != String.Empty)
                button2.Text = "Filtre";
            else
                button2.Text = "ShowAll";
        }
    }
}
