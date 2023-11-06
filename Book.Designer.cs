namespace xenophon
{
    partial class Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pageGridView = new DataGridView();
            point = new DataGridViewTextBoxColumn();
            jan = new DataGridViewTextBoxColumn();
            feb = new DataGridViewTextBoxColumn();
            mar = new DataGridViewTextBoxColumn();
            apr = new DataGridViewTextBoxColumn();
            may = new DataGridViewTextBoxColumn();
            june = new DataGridViewTextBoxColumn();
            july = new DataGridViewTextBoxColumn();
            aug = new DataGridViewTextBoxColumn();
            sept = new DataGridViewTextBoxColumn();
            oct = new DataGridViewTextBoxColumn();
            nov = new DataGridViewTextBoxColumn();
            dec = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            pageControl = new TabControl();
            total_page = new TabPage();
            incomes_page = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pageGridView).BeginInit();
            pageControl.SuspendLayout();
            total_page.SuspendLayout();
            SuspendLayout();
            // 
            // pageGridView
            // 
            pageGridView.AllowUserToAddRows = false;
            pageGridView.AllowUserToDeleteRows = false;
            pageGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            pageGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pageGridView.Columns.AddRange(new DataGridViewColumn[] { point, jan, feb, mar, apr, may, june, july, aug, sept, oct, nov, dec, total, average });
            pageGridView.Location = new Point(0, 0);
            pageGridView.Name = "pageGridView";
            pageGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.NullValue = "NULL";
            pageGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            pageGridView.RowTemplate.Height = 25;
            pageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pageGridView.Size = new Size(787, 330);
            pageGridView.TabIndex = 0;
            // 
            // point
            // 
            point.HeaderText = "Point";
            point.Name = "point";
            point.Width = 60;
            // 
            // jan
            // 
            jan.HeaderText = "Jan";
            jan.Name = "jan";
            jan.Width = 49;
            // 
            // feb
            // 
            feb.HeaderText = "Feb";
            feb.Name = "feb";
            feb.Width = 51;
            // 
            // mar
            // 
            mar.HeaderText = "Mar";
            mar.Name = "mar";
            mar.Width = 53;
            // 
            // apr
            // 
            apr.HeaderText = "Apr";
            apr.Name = "apr";
            apr.Width = 51;
            // 
            // may
            // 
            may.HeaderText = "May";
            may.Name = "may";
            may.Width = 55;
            // 
            // june
            // 
            june.HeaderText = "June";
            june.Name = "june";
            june.Width = 56;
            // 
            // july
            // 
            july.HeaderText = "July";
            july.Name = "july";
            july.Width = 52;
            // 
            // aug
            // 
            aug.HeaderText = "Aug";
            aug.Name = "aug";
            aug.Width = 54;
            // 
            // sept
            // 
            sept.HeaderText = "Sept";
            sept.Name = "sept";
            sept.Width = 55;
            // 
            // oct
            // 
            oct.HeaderText = "Oct";
            oct.Name = "oct";
            oct.Width = 51;
            // 
            // nov
            // 
            nov.HeaderText = "Nov";
            nov.Name = "nov";
            nov.Width = 54;
            // 
            // dec
            // 
            dec.HeaderText = "Dec";
            dec.Name = "dec";
            dec.Width = 52;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            total.Width = 57;
            // 
            // average
            // 
            average.HeaderText = "Average";
            average.Name = "average";
            average.Width = 75;
            // 
            // pageControl
            // 
            pageControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageControl.Controls.Add(total_page);
            pageControl.Controls.Add(incomes_page);
            pageControl.Location = new Point(0, 33);
            pageControl.Name = "pageControl";
            pageControl.SelectedIndex = 0;
            pageControl.Size = new Size(799, 362);
            pageControl.TabIndex = 1;
            pageControl.SelectedIndexChanged += pageControl_SelectedIndexChanged;
            // 
            // total_page
            // 
            total_page.BorderStyle = BorderStyle.Fixed3D;
            total_page.Controls.Add(pageGridView);
            total_page.Location = new Point(4, 24);
            total_page.Name = "total_page";
            total_page.Padding = new Padding(3);
            total_page.Size = new Size(791, 334);
            total_page.TabIndex = 0;
            total_page.Text = "Total";
            total_page.UseVisualStyleBackColor = true;
            // 
            // incomes_page
            // 
            incomes_page.BorderStyle = BorderStyle.Fixed3D;
            incomes_page.Location = new Point(4, 24);
            incomes_page.Name = "incomes_page";
            incomes_page.Padding = new Padding(3);
            incomes_page.Size = new Size(791, 334);
            incomes_page.TabIndex = 1;
            incomes_page.Text = "Incomes";
            incomes_page.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pageControl);
            Name = "Book";
            Text = "Book";
            FormClosed += Book_FormClosed;
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pageGridView).EndInit();
            pageControl.ResumeLayout(false);
            total_page.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pageGridView;
        private TabControl pageControl;
        private TabPage total_page;
        private TabPage incomes_page;
        private DataGridViewTextBoxColumn point;
        private DataGridViewTextBoxColumn jan;
        private DataGridViewTextBoxColumn feb;
        private DataGridViewTextBoxColumn mar;
        private DataGridViewTextBoxColumn apr;
        private DataGridViewTextBoxColumn may;
        private DataGridViewTextBoxColumn june;
        private DataGridViewTextBoxColumn july;
        private DataGridViewTextBoxColumn aug;
        private DataGridViewTextBoxColumn sept;
        private DataGridViewTextBoxColumn oct;
        private DataGridViewTextBoxColumn nov;
        private DataGridViewTextBoxColumn dec;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn average;
    }
}