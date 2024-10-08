﻿using Microsoft.Data.Sqlite;
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
                            $"jan INTEGER, " +
                            $"feb INTEGER, " +
                            $"mar INTEGER, " +
                            $"apr INTEGER, " +
                            $"may INTEGER, " +
                            $"june INTEGER, " +
                            $"july INTEGER, " +
                            $"aug INTEGER, " +
                            $"sept INTEGER, " +
                            $"oct INTEGER, " +
                            $"nov INTEGER, " +
                            $"dec INTEGER, " +
                            $"total INTEGER," +
                            $"average INTEGER," +
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
