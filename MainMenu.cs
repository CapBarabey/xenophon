using xenophon.Controllers;
using xenophon.Views;

namespace xenophon
{
    public partial class MainMenu : Form
    {

        DBConstructController DataBase = new DBConstructController();
        MainMenuDataDisplay DataDisplay = new MainMenuDataDisplay();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreateBook createBook = new CreateBook();

            createBook.ShowDialog();

            DataDisplay.Display(bookListGrid);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DataBase.DeleteBook(bookListGrid);

            DataDisplay.Display(bookListGrid);
        }

        private void bookListGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string bookId = DataBase.getBookId(bookListGrid);

            Book book = new Book(bookId);

            book.Show();

            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataBase.CreateDataBase();
            DataDisplay.Display(bookListGrid);
        }
    }
}