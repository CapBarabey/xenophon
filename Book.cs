using xenophon.Views;

namespace xenophon
{
    public partial class Book : Form
    {
        string BOOKID = "";

        BookDisplay PageDisplay = new BookDisplay();

        public Book(string bookID)
        {
            this.BOOKID = bookID;
            InitializeComponent();
        }

        private void Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            string pageName = pageControl.SelectedTab.Name;
            PageDisplay.Display(pageGridView, pageName, BOOKID);
        }

        private void pageControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pageName = pageControl.SelectedTab.Name;
            pageControl.SelectedTab.Controls.Add(pageGridView);
            PageDisplay.Display(pageGridView, pageName, BOOKID);
        }
    }
}
