using Microsoft.Data.Sqlite;
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
                "Total", "_total",
                "Incomes", "incomes",
                "Savings", "savings",
                "Household_Expenses", "household_expenses",
                "Vital_Activity", "vital_activity",
                "Сhildren", "children",
                "Transport", "transport",
                "Health", "health",
            };

            if (!File.Exists(path))
            {
                try
                {
                    using (connection = new SqliteConnection(source))
                    {
                        connection.Open();

                        string _book = "CREATE TABLE Books(" +
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

                        for (int i = 0; i < _tables.Count(); i += 2)
                        {
                            string _tablesTemplate = $"CREATE TABLE {_tables[i]}(" +
                            $"id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                            $"book_id INTEGER, " +
                            $"{_tables[i + 1]} TEXT, " +
                            $"jan REAL, " +
                            $"feb REAL, " +
                            $"mar REAL, " +
                            $"apr REAL, " +
                            $"may REAL, " +
                            $"june REAL, " +
                            $"july REAL, " +
                            $"aug REAL, " +
                            $"sept REAL, " +
                            $"oct REAL, " +
                            $"nov REAL, " +
                            $"dec REAL, " +
                            $"total REAL," +
                            $"average REAL," +
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
            string bookID = "";

            foreach (DataGridViewRow id in bookList.SelectedRows)
            {
                bookID = id.Cells[4].Value.ToString();
            }

            using (connection = new SqliteConnection(source))
            {
                connection.Open();

                string _delete = $"PRAGMA foreign_keys = ON;" +
                    $"DELETE FROM Books WHERE id='{bookID}'";

                command = new SqliteCommand(_delete, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
