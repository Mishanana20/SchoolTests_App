using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Login_App.model;
    
namespace Login_App.DataBase
{
    public class Connection
    {
        public static List<Question> TestConnectionToDatabase()
        {
            List<Question> questions = new List<Question>();

            string connectionString = "Data Source=Datafolder/usersdata.db;Cache=Shared;Mode=ReadWriteCreate;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            //connection.Open();
            //connection.Close();

            using (connection = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM  Questions ";
                // Создаем объект DataAdapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                // перебор всех таблиц
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        Question question = new Question(Convert.ToInt32(cells.GetValue(0)), Convert.ToInt32(cells.GetValue(1)), Convert.ToString(cells.GetValue(2)));
                        questions.Add(question);
                    }
                }
            }


            using (connection = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM  ResponseToQuestion";
                // Создаем объект DataAdapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                // перебор всех таблиц
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        string answerText = Convert.ToString(cells.GetValue(2));
                        bool isTrue = Convert.ToInt32(cells.GetValue(3)) == 1 ? true : false;
                        Answer answer = new Answer(answerText, isTrue);
                        //questions.Add(answer);
                        questions.First(p => p.Id == Convert.ToInt32(cells.GetValue(1))).AnswerList.Add(answer);
                    }
                }
            }
            return questions;
        }
    }
}
