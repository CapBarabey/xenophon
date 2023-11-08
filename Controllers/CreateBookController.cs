using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace xenophon.Controllers
{
    internal class CreateBookController
    {
        string source = "Data Source = xenData_base.db";

        SqliteConnection connection;
        SqliteCommand command;
        SqliteDataReader reader;

        public void CreateBook(string name_field, CreateBook form)
        {
            string NAME = name_field;
            DateTime DATE = DateTime.Now;
            DateTime PERIOD_DATE = DATE.AddYears(1);
            string PERIOD = $"{DATE.ToString("Y")} - {PERIOD_DATE.ToString("Y")}";

            //Таблица создается заранее т.к. для последующих таблиц необходим BOOKID, который получают из Books. 
            if (!string.IsNullOrEmpty(NAME))
            {
                try
                {
                    using (connection = new SqliteConnection(source))
                    {
                        connection.Open();

                        string _bookInsert = $"INSERT INTO books(" +
                            $"name, book_period, updated, created)" +
                            $"VALUES(" +
                            $"'{NAME}', '{PERIOD}', '{DATE}', '{DATE}')";

                        command = new SqliteCommand(_bookInsert, connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Insert in table Books error", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Book name required!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Получение BOOKID.
            int BOOKID = getBookId(NAME);

            //TO DO: переименовать позиции в столбце с их названием
            string[] _inserts =
            {
                $"INSERT INTO total(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'Savings balance'), " +
                    $"({BOOKID}, 'Balance of expenses'), " +
                    $"({BOOKID}, 'Savings Adjustment'), " +
                    $"({BOOKID}, 'Budget surplus'), " +
                    $"({BOOKID}, 'Expenses'), " +
                    $"({BOOKID}, 'Incomes')" 
                    ,
                $"INSERT INTO incomes(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'Total income'), " +
                    $"({BOOKID}, 'Transfer from savings'), " +
                    $"({BOOKID}, 'Cashback'), " +
                    $"({BOOKID}, 'Returns refunds'), " +
                    $"({BOOKID}, 'Present'), " +
                    $"({BOOKID}, 'Dividends'), " +
                    $"({BOOKID}, 'Hobby'), " +
                    $"({BOOKID}, 'salary')"
                    ,
                $"INSERT INTO savings(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total savings'), " +
                    $"({BOOKID}, 'Other'), " +
                    $"({BOOKID}, 'For childrens education'), " +
                    $"({BOOKID}, 'For investment'), " +
                    $"({BOOKID}, 'On retire'), " +
                    $"({BOOKID}, 'For unforeseen expenses'), " +
                    $"({BOOKID}, 'To savings accounts')"
                    ,
                $"INSERT INTO household_expenses(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total household expenses'), " +
                    $"({BOOKID}, 'Other'), " +
                    $"({BOOKID}, 'Phone'), " +
                    $"({BOOKID}, 'Maintenance'), " +
                    $"({BOOKID}, 'Internet'), " +
                    $"({BOOKID}, 'Communal payments'), " +
                    $"({BOOKID}, 'Rent')"
                    ,
                $"INSERT INTO vital_activity(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total vital activity'), " +
                    $"({BOOKID}, 'Other'), " +
                    $"({BOOKID}, 'Hairdressers salons')," +
                    $"({BOOKID}, 'Dry cleaning'), " +
                    $"({BOOKID}, 'Cafes restaurants'), " +
                    $"({BOOKID}, 'Cloth'), " +
                    $"({BOOKID}, 'Personal shopping'), " +
                    $"({BOOKID}, 'Products')"
                    ,
                $"INSERT INTO children(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total сhildren'), " +
                    $"({BOOKID}, 'Nutrition')," +
                    $"({BOOKID}, 'Toys'), " +
                    $"({BOOKID}, 'Nanny')," +
                    $"({BOOKID}, 'Lunches'), " +
                    $"({BOOKID}, 'Study supplies'), " +
                    $"({BOOKID}, 'Cloth'), " +
                    $"({BOOKID}, 'Medical service')"
                    ,
                $"INSERT INTO transport(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total transport'), " +
                    $"({BOOKID}, 'Repair'), " +
                    $"({BOOKID}, 'Public transport taxi'), " +
                    $"({BOOKID}, 'Fuel'), " +
                    $"({BOOKID}, 'Car service')" 
                    ,
                $"INSERT INTO health(" +
                    $"book_id, point)" +
                    $"VALUES(" +
                    $"{BOOKID}, '% from all expenses'), " +
                    $"({BOOKID}, 'Total health'), " +
                    $"({BOOKID}, 'Procedures'), " +
                    $"({BOOKID}, 'Ambulance'), " +
                    $"({BOOKID}, 'Medicines'), " +
                    $"({BOOKID}, 'Doctors dentists')"
            };

            try
            {
                using (connection = new SqliteConnection(source))
                {
                    connection.Open();

                    for (int i = 0; i < _inserts.Count(); i++)
                    {
                        command = new SqliteCommand(_inserts[i], connection);
                        command.ExecuteNonQuery();
                    }
                }

                form.Close();
                MessageBox.Show("Book created");
            }
            catch (Exception)
            {
                MessageBox.Show("Inser error", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int getBookId(string name)
        {
            string _bookID = $"SELECT id FROM books WHERE name='{name}'";
            int id = 0;

            connection = new SqliteConnection(source);
            connection.Open();

            command = new SqliteCommand(_bookID, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var objId = reader.GetValue(0);
                    id = Convert.ToInt32(objId);
                }
            }

            return id;
        }
    }
}
