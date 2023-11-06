using Microsoft.Data.Sqlite;
using System.Net;
using System.Windows.Forms;

namespace xenophon.Controllers
{
    internal class DBConstructController
    {
        string path = "xenData_base.db";
        string source = "data source = xenData_base.db";

        SqliteConnection connection;
        SqliteCommand command;

        public void CreateDataBase()
        {
            string[] _tables =
            {
                "total",
                "incomes",
                "savings",
                "household_expenses",
                "vital_activity",
                "children",
                "transport",
                "health"
            };

            if (!File.Exists(path))
            {
                try
                {
                    using (connection = new SqliteConnection(source))
                    {
                        connection.Open();

                        string _book = "CREATE TABLE books(" +
                        "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                        "name TEXT NOT NULL, " +
                        "book_period TEXT NOT NULL, " +
                        "updated TEXT NOT NULL, " +
                        "created TEXT NOT NULL); PRAGMA foreign_keys=on;";

                        command = new SqliteCommand(_book, connection);
                        command.ExecuteNonQuery();
                    }

                    using (connection = new SqliteConnection(source))
                    {
                        connection.Open();

                        for (int i = 0; i < _tables.Count(); i ++)
                        {
                            string _tablesTemplate = $"CREATE TABLE {_tables[i]}(" +
                            $"id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                            $"book_id INTEGER NOT NULL, " +
                            $"point TEXT NOT NULL, " +
                            $"jan REAL DEFAULT '', " +
                            $"feb REAL DEFAULT '', " +
                            $"mar REAL DEFAULT '', " +
                            $"apr REAL DEFAULT '', " +
                            $"may REAL DEFAULT '', " +
                            $"june REAL DEFAULT '', " +
                            $"july REAL DEFAULT '', " +
                            $"aug REAL DEFAULT '', " +
                            $"sept REAL DEFAULT '', " +
                            $"oct REAL DEFAULT '', " +
                            $"nov REAL DEFAULT '', " +
                            $"dec REAL DEFAULT '', " +
                            $"total REAL DEFAULT ''," +
                            $"average REAL DEFAULT ''," +
                            $"FOREIGN KEY (book_id) REFERENCES Books(id) " +
                            $"ON DELETE CASCADE)";

                            command = new SqliteCommand(_tablesTemplate, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Book creation error", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public void DeleteBook(DataGridView bookList)
        {
            string bookID = getBookId(bookList);

           // foreach (DataGridViewRow id in bookList.SelectedRows)
           // {
          //      bookID = id.Cells[4].Value.ToString();
           // }

            using (connection = new SqliteConnection(source))
            {
                connection.Open();

                string _delete = $"PRAGMA foreign_keys = ON;" +
                    $"DELETE FROM Books WHERE id='{bookID}'";

                command = new SqliteCommand(_delete, connection);
                command.ExecuteNonQuery();
            }
        }

        public string getBookId(DataGridView bookList)
        {
            string bookId = "";

            foreach (DataGridViewRow id in bookList.SelectedRows)
            {
                bookId = id.Cells[4].Value.ToString();
            }

            return bookId;
        }
    }
}
