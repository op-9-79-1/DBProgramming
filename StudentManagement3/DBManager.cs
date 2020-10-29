using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement3
{
    public partial class DBManager : StudentManagement3.MainForm
    {
        private string connection_string = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정

        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        private DBManager()
        {
            
        }

        public void Insert_A_Update(string query)
        {

            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();

                MySqlCommand cmdinsert = new MySqlCommand(query, conn);
                cmdinsert.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
