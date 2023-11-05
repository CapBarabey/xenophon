namespace xenophon
{
    partial class CreateBook
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
            Create_btn = new Button();
            Cancel_btn = new Button();
            label1 = new Label();
            name_field = new TextBox();
            SuspendLayout();
            // 
            // Create_btn
            // 
            Create_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Create_btn.Location = new Point(13, 72);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(120, 30);
            Create_btn.TabIndex = 3;
            Create_btn.Text = "Create";
            Create_btn.UseVisualStyleBackColor = true;
            Create_btn.Click += Create_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel_btn.Location = new Point(168, 72);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(120, 30);
            Cancel_btn.TabIndex = 1;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 2;
            label1.Text = "Book Name:";
            // 
            // name_field
            // 
            name_field.Location = new Point(106, 26);
            name_field.Name = "name_field";
            name_field.Size = new Size(182, 23);
            name_field.TabIndex = 0;
            name_field.WordWrap = false;
            // 
            // CreateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 119);
            Controls.Add(name_field);
            Controls.Add(label1);
            Controls.Add(Cancel_btn);
            Controls.Add(Create_btn);
            Name = "CreateBook";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Create_btn;
        private Button Cancel_btn;
        private Label label1;
        private TextBox name_field;
    }
}