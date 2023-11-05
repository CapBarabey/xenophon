namespace xenophon
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Create_btn = new Button();
            Delete_btn = new Button();
            Export_btn = new Button();
            label1 = new Label();
            bookListGrid = new DataGridView();
            book_name = new DataGridViewTextBoxColumn();
            book_period = new DataGridViewTextBoxColumn();
            updated_at = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bookListGrid).BeginInit();
            SuspendLayout();
            // 
            // Create_btn
            // 
            Create_btn.Anchor = AnchorStyles.Bottom;
            Create_btn.Location = new Point(92, 271);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(120, 30);
            Create_btn.TabIndex = 4;
            Create_btn.Text = "Create";
            Create_btn.UseVisualStyleBackColor = true;
            Create_btn.Click += Create_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.Anchor = AnchorStyles.Bottom;
            Delete_btn.Location = new Point(236, 271);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(120, 30);
            Delete_btn.TabIndex = 5;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Export_btn
            // 
            Export_btn.Anchor = AnchorStyles.Bottom;
            Export_btn.Location = new Point(375, 271);
            Export_btn.Name = "Export_btn";
            Export_btn.Size = new Size(120, 30);
            Export_btn.TabIndex = 6;
            Export_btn.Text = "Export";
            Export_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(543, 318);
            label1.Name = "label1";
            label1.Size = new Size(47, 11);
            label1.TabIndex = 7;
            label1.Text = "V 0.0.1";
            // 
            // bookListGrid
            // 
            bookListGrid.AllowUserToAddRows = false;
            bookListGrid.AllowUserToDeleteRows = false;
            bookListGrid.AllowUserToOrderColumns = true;
            bookListGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            bookListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bookListGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookListGrid.BackgroundColor = Color.WhiteSmoke;
            bookListGrid.BorderStyle = BorderStyle.Fixed3D;
            bookListGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            bookListGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            bookListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookListGrid.Columns.AddRange(new DataGridViewColumn[] { book_name, book_period, updated_at, created_at, id });
            bookListGrid.GridColor = Color.White;
            bookListGrid.Location = new Point(12, 12);
            bookListGrid.MultiSelect = false;
            bookListGrid.Name = "bookListGrid";
            bookListGrid.ReadOnly = true;
            bookListGrid.RightToLeft = RightToLeft.No;
            bookListGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            bookListGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            bookListGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            bookListGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            bookListGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            bookListGrid.RowTemplate.Height = 25;
            bookListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookListGrid.Size = new Size(567, 231);
            bookListGrid.TabIndex = 3;
            bookListGrid.CellMouseDoubleClick += bookListGrid_CellMouseDoubleClick;
            // 
            // book_name
            // 
            book_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_name.HeaderText = "Book name";
            book_name.Name = "book_name";
            book_name.ReadOnly = true;
            // 
            // book_period
            // 
            book_period.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_period.HeaderText = "Book period";
            book_period.Name = "book_period";
            book_period.ReadOnly = true;
            // 
            // updated_at
            // 
            updated_at.HeaderText = "Updated at";
            updated_at.Name = "updated_at";
            updated_at.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.HeaderText = "Created at";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 331);
            Controls.Add(label1);
            Controls.Add(Export_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Create_btn);
            Controls.Add(bookListGrid);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)bookListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Create_btn;
        private Button Delete_btn;
        private Button Export_btn;
        private Label label1;
        private DataGridView bookListGrid;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_period;
        private DataGridViewTextBoxColumn updated_at;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn id;
    }
}