
namespace SchoolLibraryManager
{
    partial class BookListForm
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBookForm = new System.Windows.Forms.TextBox();
            this.lvwBook = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOverdueBook = new System.Windows.Forms.Label();
            this.lblBorrowBook = new System.Windows.Forms.Label();
            this.lblAllBook = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchStuBookForm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(28, 393);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(168, 25);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "도서 추가";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(115, 301);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(80, 30);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.Text = "검색";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "도서명/ISBN";
            // 
            // txtSearchBookForm
            // 
            this.txtSearchBookForm.Location = new System.Drawing.Point(25, 274);
            this.txtSearchBookForm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBookForm.Name = "txtSearchBookForm";
            this.txtSearchBookForm.Size = new System.Drawing.Size(169, 23);
            this.txtSearchBookForm.TabIndex = 8;
            // 
            // lvwBook
            // 
            this.lvwBook.HideSelection = false;
            this.lvwBook.Location = new System.Drawing.Point(230, 38);
            this.lvwBook.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBook.Name = "lvwBook";
            this.lvwBook.Size = new System.Drawing.Size(555, 380);
            this.lvwBook.TabIndex = 7;
            this.lvwBook.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOverdueBook);
            this.groupBox1.Controls.Add(this.lblBorrowBook);
            this.groupBox1.Controls.Add(this.lblAllBook);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서현황";
            // 
            // lblOverdueBook
            // 
            this.lblOverdueBook.AutoSize = true;
            this.lblOverdueBook.Location = new System.Drawing.Point(12, 94);
            this.lblOverdueBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverdueBook.Name = "lblOverdueBook";
            this.lblOverdueBook.Size = new System.Drawing.Size(114, 15);
            this.lblOverdueBook.TabIndex = 8;
            this.lblOverdueBook.Text = "연체 중인 도서 수 : ";
            // 
            // lblBorrowBook
            // 
            this.lblBorrowBook.AutoSize = true;
            this.lblBorrowBook.Location = new System.Drawing.Point(12, 71);
            this.lblBorrowBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowBook.Name = "lblBorrowBook";
            this.lblBorrowBook.Size = new System.Drawing.Size(114, 15);
            this.lblBorrowBook.TabIndex = 7;
            this.lblBorrowBook.Text = "대출 중인 도서 수 : ";
            // 
            // lblAllBook
            // 
            this.lblAllBook.AutoSize = true;
            this.lblAllBook.Location = new System.Drawing.Point(12, 26);
            this.lblAllBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllBook.Name = "lblAllBook";
            this.lblAllBook.Size = new System.Drawing.Size(86, 15);
            this.lblAllBook.TabIndex = 5;
            this.lblAllBook.Text = "전체 도서 수 : ";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(116, 218);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(80, 30);
            this.btnSearchStudent.TabIndex = 14;
            this.btnSearchStudent.Text = "검색";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "학번/이름";
            // 
            // txtSearchStuBookForm
            // 
            this.txtSearchStuBookForm.Location = new System.Drawing.Point(27, 191);
            this.txtSearchStuBookForm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStuBookForm.Name = "txtSearchStuBookForm";
            this.txtSearchStuBookForm.Size = new System.Drawing.Size(169, 23);
            this.txtSearchStuBookForm.TabIndex = 12;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 446);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchStuBookForm);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchBookForm);
            this.Controls.Add(this.lvwBook);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBookForm;
        private System.Windows.Forms.ListView lvwBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOverdueBook;
        private System.Windows.Forms.Label lblBorrowBook;
        private System.Windows.Forms.Label lblAllBook;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchStuBookForm;
    }
}