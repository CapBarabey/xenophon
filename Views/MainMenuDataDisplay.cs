using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace xenophon.Views
{
    internal class MainMenuDataDisplay
    {
        string source = "data source = xenData_base.db";

        SqliteConnection connection;
        SqliteCommand command;
        SqliteDataReader reader;

        public void Display(DataGridView bookList)
        {
            bookList.Rows.Clear();

            using (connection = new SqliteConnection(source))
            {
                connection.Open();

                string sqlRequest = "SELECT  name, book_period, updated, created, id FROM Books";
                command = new SqliteCommand(sqlRequest, connection);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bookList.Rows.Insert(0,
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4));
                    }
                }
            }

            bookList.ClearSelection();
        }
    }
}
