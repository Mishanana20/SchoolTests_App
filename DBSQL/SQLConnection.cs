using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WPFAppNote.model;
using System.Configuration;

namespace WPFAppNote.DBSQL
{
    class SQLConnection
    {
        public List<Item> ItemList = new List<Item>();


        //SQLConnection sqlConnectionObj 
        //{
        //    get 
        //    {
        //        return sqlConnectionObj;
        //    } 
        //    set 
        //    { 
        //        ItemList = new List<Item>(); 
        //    } 
        //}

        string database = ConfigurationManager.AppSettings.Get("database");
        string datatable = ConfigurationManager.AppSettings.Get("datatable");
        SqlConnection sqlConnection = new SqlConnection($"Data Source=" + ConfigurationManager.AppSettings.Get("server")
                                      + ";Initial Catalog=" + ConfigurationManager.AppSettings.Get("database")
                                      + ";Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public void GetAllItems()
        {

            ItemList.Clear();
            string sqlExpression = $"SELECT * FROM {datatable}";
            SqlCommand command = new SqlCommand(sqlExpression, sqlConnection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        int Id = 0;
                        string MenuTitle = "";
                        string NoteTitle = "";
                        string NoteText = "";
                        DateTime NoteCreateDateTime = DateTime.Now;
                        DateTime NoteEditDateTime = DateTime.Now;
                        string ColorText = "";
                        if (!reader.IsDBNull(0))
                        {
                            Id = (int)reader.GetValue(0);
                        }
                        if (!reader.IsDBNull(1))
                        {
                            MenuTitle = (string)reader.GetValue(1);
                        }
                        if (!reader.IsDBNull(2))
                        {
                            NoteTitle = (string)reader.GetValue(2);
                        }
                        if (!reader.IsDBNull(3))
                        {
                            NoteText = (string)reader.GetValue(3);
                        }
                        if (!reader.IsDBNull(4))
                        {
                            NoteCreateDateTime = (DateTime)reader.GetValue(4);
                        }
                        if (!reader.IsDBNull(5))
                        {
                            NoteEditDateTime = (DateTime)reader.GetValue(5);
                        }
                        if (!reader.IsDBNull(6))
                        {
                            ColorText = (string)reader.GetValue(6);
                        }
                        ItemList.Add(new Item
                        {
                            Id = Id,
                            MenuTitle = MenuTitle,
                            NoteTitle = NoteTitle,
                            NoteText = NoteText,
                            NoteCreateDateTime = NoteCreateDateTime,
                            NoteEditDateTime = NoteEditDateTime,
                            ColorText = ColorText
                        });
                    }
                }
            }
        }


        //ItemList.Add(new Item
        //                    { 
        //                        Id = (int) reader.GetValue(0),
        //                        MenuTitle = (string) reader.GetValue(1),
        //                        NoteTitle = (string) reader.GetValue(2),
        //                        NoteText = (string) reader.GetValue(3),
        //                        NoteCreateDateTime = (DateTime) reader.GetValue(4),
        //                        NoteEditDateTime = (DateTime) reader.GetValue(5),
        //                        ColorText = (string) reader.GetValue(6)
        //                    });

        public void SaveChange(Item item)
        {
        }
    }
}
