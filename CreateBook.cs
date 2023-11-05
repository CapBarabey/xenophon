using xenophon.Controllers;

namespace xenophon
{
    public partial class CreateBook : Form
    {
        CreateBookController Book = new CreateBookController();
        public CreateBook()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            Book.CreateBook(name_field.Text, this);
        }
    }
}
