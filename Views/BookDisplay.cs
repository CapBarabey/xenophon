using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace xenophon.Views
{
    internal class BookDisplay
    {
        string source = "data source = xenData_base.db";

        SqliteConnection connection;
        SqliteCommand command;
        SqliteDataReader reader;

        public void Display(DataGridView pageGrid, string page, string bookId)
        {
            pageGrid.Rows.Clear();

            using (connection = new SqliteConnection(source))
            {
                connection.Open();

                string sqlRequest = "SELECT " +
                    "point, jan, feb, mar, apr, may, june, july, aug, sept, oct, nov, dec, total, average " +
                    $"FROM {page} WHERE book_id='{bookId}'";
                command = new SqliteCommand(sqlRequest, connection);

                reader  = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pageGrid.Rows.Insert(0,
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10),
                            reader.GetString(11),
                            reader.GetString(12),
                            reader.GetString(13),
                            reader.GetString(14));
                    }
                }
            }

            foreach (DataGridViewRow row in pageGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().StartsWith("Total") || row.Cells[0].Value.ToString().StartsWith("% from"))
                {
                    row.ReadOnly = true;
                }
            }

            pageGrid.ClearSelection();
        }
    }
} 
