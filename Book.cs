using xenophon.Controllers;
using xenophon.Views;

namespace xenophon
{
    public partial class Book : Form
    {
        string BOOKID = "";
        string PAGE_NAME = "";

        BookDisplay PageDisplay = new BookDisplay();
        BookController Total = new BookController();

        public Book(string bookID)
        {
            BOOKID = bookID;
            InitializeComponent();
        }

        private void Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            PAGE_NAME = pageControl.SelectedTab.Name;
            PageDisplay.Display(pageGridView, PAGE_NAME, BOOKID);
        }

        private void pageControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAGE_NAME = pageControl.SelectedTab.Name;
            pageControl.SelectedTab.Controls.Add(pageGridView);
            PageDisplay.Display(pageGridView, PAGE_NAME, BOOKID);
        }

        private void pageGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PAGE_NAME = pageControl.SelectedTab.Name;
            Total.Total(pageGridView);
            PageDisplay.Display(pageGridView, PAGE_NAME, BOOKID);
        }



    }
}
