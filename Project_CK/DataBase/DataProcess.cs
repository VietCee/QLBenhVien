using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Project_CK.DataBase
{
    internal class DataProcess
    {
        string strConnect = "Data Source = QLBenhVien.db";
        SQLiteConnection sqlconnect = null;

        void OpenConnect()
        {
            sqlconnect = new SQLiteConnection(strConnect);
            if (sqlconnect.State != ConnectionState.Open)
                sqlconnect.Open();
        }

        void CloseConnect()
        {
            if (sqlconnect.State != ConnectionState.Closed)
                sqlconnect.Close();
            sqlconnect.Dispose();
        }

        /*PT doc 1 lenh select tra ve DataTable*/
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sqlSelect, sqlconnect);
            data.Fill(dt);
            CloseConnect();
            data.Dispose();
            return dt;
        }

        /*PT thuc thi cac lenh dang: insert, update, delete*/
        public void ChangeData(string sql)
        {
            OpenConnect();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = sql;
            command.Connection = sqlconnect;
            command.ExecuteNonQuery();
            CloseConnect();
            command.Dispose();
        }
    }
}
