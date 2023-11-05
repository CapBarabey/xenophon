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

                        string _bookInsert = $"INSERT INTO Books(" +
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
                $"INSERT INTO Total(" +
                    $"book_id, _total)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'incomes'), " +
                    $"({BOOKID}, 'expenses'), " +
                    $"({BOOKID}, 'budget_surplus'), " +
                    $"({BOOKID}, 'savings_adjustment'), " +
                    $"({BOOKID}, 'balance_ofexpenses'), " +
                    $"({BOOKID}, 'savings_balance')"
                    ,
                $"INSERT INTO Incomes(" +
                    $"book_id, incomes)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'salary'), " +
                    $"({BOOKID}, 'hobby'), " +
                    $"({BOOKID}, 'dividends'), " +
                    $"({BOOKID}, 'present'), " +
                    $"({BOOKID}, 'returns_refunds'), " +
                    $"({BOOKID}, 'cashback'), " +
                    $"({BOOKID}, 'other'), " +
                    $"({BOOKID}, 'transfer_from_savings'), " +
                    $"({BOOKID}, 'total_income')"
                    ,
                $"INSERT INTO Savings(" +
                    $"book_id, savings)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'to_savings_accounts'), " +
                    $"({BOOKID}, 'for_unforeseen_expenses'), " +
                    $"({BOOKID}, 'on_retire'), " +
                    $"({BOOKID}, 'for_investment'), " +
                    $"({BOOKID}, 'for_childrens_education'), " +
                    $"({BOOKID}, 'other'), " +
                    $"({BOOKID}, 'total_savings'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
                    ,
                $"INSERT INTO Household_Expenses(" +
                    $"book_id, household_expenses)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'rent'), " +
                    $"({BOOKID}, 'communal_payments'), " +
                    $"({BOOKID}, 'internet'), " +
                    $"({BOOKID}, 'Maintenance'), " +
                    $"({BOOKID}, 'phone'), " +
                    $"({BOOKID}, 'other'), " +
                    $"({BOOKID}, 'total_household_expenses'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
                    ,
                $"INSERT INTO Vital_Activity(" +
                    $"book_id, vital_activity)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'products'), " +
                    $"({BOOKID}, 'personal_shopping'), " +
                    $"({BOOKID}, 'cloth'), " +
                    $"({BOOKID}, 'cafes_restaurants'), " +
                    $"({BOOKID}, 'dry_cleaning'), " +
                    $"({BOOKID}, 'hairdressers_salons')," +
                    $"({BOOKID}, 'other'), " +
                    $"({BOOKID}, 'total_vital_activity'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
                    ,
                $"INSERT INTO Сhildren(" +
                    $"book_id, children)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'medical_service'), " +
                    $"({BOOKID}, 'cloth'), " +
                    $"({BOOKID}, 'study_supplies'), " +
                    $"({BOOKID}, 'lunches'), " +
                    $"({BOOKID}, 'nanny')," +
                    $"({BOOKID}, 'toys'), " +
                    $"({BOOKID}, 'nutrition')," +
                    $"({BOOKID}, 'total_сhildren'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
                    ,
                $"INSERT INTO Transport(" +
                    $"book_id, transport)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'car_service'), " +
                    $"({BOOKID}, 'fuel'), " +
                    $"({BOOKID}, 'public_transport_taxi'), " +
                    $"({BOOKID}, 'repair'), " +
                    $"({BOOKID}, 'total_transport'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
                    ,
                $"INSERT INTO Health(" +
                    $"book_id, health)" +
                    $"VALUES(" +
                    $"{BOOKID}, 'doctors_dentists'), " +
                    $"({BOOKID}, 'medicines'), " +
                    $"({BOOKID}, 'ambulance'), " +
                    $"({BOOKID}, 'procedures'), " +
                    $"({BOOKID}, 'total_health'), " +
                    $"({BOOKID}, '%_from_all_expenses')"
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
            string _bookID = $"SELECT id FROM Books WHERE name='{name}'";
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
