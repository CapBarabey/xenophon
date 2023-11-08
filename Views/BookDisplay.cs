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
                           reader.GetValue(0),
                           reader.GetValue(1),
                           reader.GetValue(2),
                           reader.GetValue(3),
                           reader.GetValue(4),
                           reader.GetValue(5),
                           reader.GetValue(6),
                           reader.GetValue(7),
                           reader.GetValue(8),
                           reader.GetValue(9),
                           reader.GetValue(10),
                           reader.GetValue(11),
                           reader.GetValue(12),
                           reader.GetValue(13),
                           reader.GetValue(14));
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
