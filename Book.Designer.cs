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
            pageControl = new TabControl();
            total = new TabPage();
            incomes = new TabPage();
            savings = new TabPage();
            household_expenses = new TabPage();
            children = new TabPage();
            health = new TabPage();
            vital_activity = new TabPage();
            transport = new TabPage();
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
            page_total = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pageGridView).BeginInit();
            pageControl.SuspendLayout();
            total.SuspendLayout();
            SuspendLayout();
            // 
            // pageGridView
            // 
            pageGridView.AllowUserToAddRows = false;
            pageGridView.AllowUserToDeleteRows = false;
            pageGridView.AllowUserToResizeRows = false;
            pageGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pageGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pageGridView.BackgroundColor = Color.WhiteSmoke;
            pageGridView.BorderStyle = BorderStyle.Fixed3D;
            pageGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pageGridView.Columns.AddRange(new DataGridViewColumn[] { point, jan, feb, mar, apr, may, june, july, aug, sept, oct, nov, dec, page_total, average });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            pageGridView.DefaultCellStyle = dataGridViewCellStyle1;
            pageGridView.Location = new Point(0, 0);
            pageGridView.Name = "pageGridView";
            pageGridView.RowHeadersVisible = false;
            pageGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            pageGridView.RowTemplate.Height = 25;
            pageGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            pageGridView.ShowCellToolTips = false;
            pageGridView.Size = new Size(931, 332);
            pageGridView.TabIndex = 0;
            pageGridView.TabStop = false;
            pageGridView.CellEndEdit += pageGridView_CellEndEdit;
            // 
            // pageControl
            // 
            pageControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageControl.Controls.Add(total);
            pageControl.Controls.Add(incomes);
            pageControl.Controls.Add(savings);
            pageControl.Controls.Add(household_expenses);
            pageControl.Controls.Add(children);
            pageControl.Controls.Add(health);
            pageControl.Controls.Add(vital_activity);
            pageControl.Controls.Add(transport);
            pageControl.Location = new Point(0, 33);
            pageControl.Name = "pageControl";
            pageControl.SelectedIndex = 0;
            pageControl.Size = new Size(941, 362);
            pageControl.TabIndex = 1;
            pageControl.SelectedIndexChanged += pageControl_SelectedIndexChanged;
            // 
            // total
            // 
            total.BackColor = Color.Transparent;
            total.BorderStyle = BorderStyle.FixedSingle;
            total.Controls.Add(pageGridView);
            total.Location = new Point(4, 24);
            total.Name = "total";
            total.Padding = new Padding(3);
            total.Size = new Size(933, 334);
            total.TabIndex = 0;
            total.Text = "Total";
            total.UseVisualStyleBackColor = true;
            // 
            // incomes
            // 
            incomes.BorderStyle = BorderStyle.FixedSingle;
            incomes.Location = new Point(4, 24);
            incomes.Name = "incomes";
            incomes.Padding = new Padding(3);
            incomes.Size = new Size(933, 334);
            incomes.TabIndex = 1;
            incomes.Text = "Incomes";
            incomes.UseVisualStyleBackColor = true;
            // 
            // savings
            // 
            savings.Location = new Point(4, 24);
            savings.Name = "savings";
            savings.Padding = new Padding(3);
            savings.Size = new Size(933, 334);
            savings.TabIndex = 2;
            savings.Text = "Savings";
            savings.UseVisualStyleBackColor = true;
            // 
            // household_expenses
            // 
            household_expenses.Location = new Point(4, 24);
            household_expenses.Name = "household_expenses";
            household_expenses.Padding = new Padding(3);
            household_expenses.Size = new Size(933, 334);
            household_expenses.TabIndex = 3;
            household_expenses.Text = "Household Expenses";
            household_expenses.UseVisualStyleBackColor = true;
            // 
            // children
            // 
            children.Location = new Point(4, 24);
            children.Name = "children";
            children.Padding = new Padding(3);
            children.Size = new Size(933, 334);
            children.TabIndex = 4;
            children.Text = "Children";
            children.UseVisualStyleBackColor = true;
            // 
            // health
            // 
            health.Location = new Point(4, 24);
            health.Name = "health";
            health.Padding = new Padding(3);
            health.Size = new Size(933, 334);
            health.TabIndex = 5;
            health.Text = "Health";
            health.UseVisualStyleBackColor = true;
            // 
            // vital_activity
            // 
            vital_activity.Location = new Point(4, 24);
            vital_activity.Name = "vital_activity";
            vital_activity.Size = new Size(933, 334);
            vital_activity.TabIndex = 6;
            vital_activity.Text = "Vital Activity";
            vital_activity.UseVisualStyleBackColor = true;
            // 
            // transport
            // 
            transport.Location = new Point(4, 24);
            transport.Name = "transport";
            transport.Size = new Size(933, 334);
            transport.TabIndex = 7;
            transport.Text = "Transport";
            transport.UseVisualStyleBackColor = true;
            // 
            // point
            // 
            point.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            point.HeaderText = "Point";
            point.Name = "point";
            point.ReadOnly = true;
            point.Width = 60;
            // 
            // jan
            // 
            jan.HeaderText = "Jan";
            jan.Name = "jan";
            // 
            // feb
            // 
            feb.HeaderText = "Feb";
            feb.Name = "feb";
            // 
            // mar
            // 
            mar.HeaderText = "Mar";
            mar.Name = "mar";
            // 
            // apr
            // 
            apr.HeaderText = "Apr";
            apr.Name = "apr";
            // 
            // may
            // 
            may.HeaderText = "May";
            may.Name = "may";
            // 
            // june
            // 
            june.HeaderText = "June";
            june.Name = "june";
            // 
            // july
            // 
            july.HeaderText = "July";
            july.Name = "july";
            // 
            // aug
            // 
            aug.HeaderText = "Aug";
            aug.Name = "aug";
            // 
            // sept
            // 
            sept.HeaderText = "Sept";
            sept.Name = "sept";
            // 
            // oct
            // 
            oct.HeaderText = "Oct";
            oct.Name = "oct";
            // 
            // nov
            // 
            nov.HeaderText = "Nov";
            nov.Name = "nov";
            // 
            // dec
            // 
            dec.HeaderText = "Dec";
            dec.Name = "dec";
            // 
            // page_total
            // 
            page_total.HeaderText = "Total";
            page_total.Name = "page_total";
            page_total.ReadOnly = true;
            // 
            // average
            // 
            average.HeaderText = "Average";
            average.Name = "average";
            average.ReadOnly = true;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            Controls.Add(pageControl);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            FormClosed += Book_FormClosed;
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pageGridView).EndInit();
            pageControl.ResumeLayout(false);
            total.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pageGridView;
        private TabControl pageControl;
        private TabPage incomes;
        private TabPage total;
        private TabPage savings;
        private TabPage household_expenses;
        private TabPage children;
        private TabPage health;
        private TabPage vital_activity;
        private TabPage transport;
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
        private DataGridViewTextBoxColumn page_total;
        private DataGridViewTextBoxColumn average;
    }
}