
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
            this.components = new System.ComponentModel.Container();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBookForm = new System.Windows.Forms.TextBox();
            this.lvwBook = new System.Windows.Forms.ListView();
            this.chBookIsbn = new System.Windows.Forms.ColumnHeader();
            this.chBookName = new System.Windows.Forms.ColumnHeader();
            this.chBookWriter = new System.Windows.Forms.ColumnHeader();
            this.chBookPub = new System.Windows.Forms.ColumnHeader();
            this.chBookYear = new System.Windows.Forms.ColumnHeader();
            this.chBookPage = new System.Windows.Forms.ColumnHeader();
            this.chBookCount = new System.Windows.Forms.ColumnHeader();
            this.chBookCate = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOverdueBook = new System.Windows.Forms.Label();
            this.lblBorrowBook = new System.Windows.Forms.Label();
            this.lblAllBook = new System.Windows.Forms.Label();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.btnBookReload = new System.Windows.Forms.Button();
            this.cmsBookMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrModi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrDele = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cmsBookMenu.SuspendLayout();
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
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(114, 220);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(80, 30);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.Text = "검색";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "도서명/ISBN";
            // 
            // txtSearchBookForm
            // 
            this.txtSearchBookForm.Location = new System.Drawing.Point(27, 193);
            this.txtSearchBookForm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBookForm.Name = "txtSearchBookForm";
            this.txtSearchBookForm.Size = new System.Drawing.Size(166, 23);
            this.txtSearchBookForm.TabIndex = 8;
            this.txtSearchBookForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBookForm_KeyDown);
            // 
            // lvwBook
            // 
            this.lvwBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookIsbn,
            this.chBookName,
            this.chBookWriter,
            this.chBookPub,
            this.chBookYear,
            this.chBookPage,
            this.chBookCount,
            this.chBookCate});
            this.lvwBook.FullRowSelect = true;
            this.lvwBook.GridLines = true;
            this.lvwBook.HideSelection = false;
            this.lvwBook.Location = new System.Drawing.Point(230, 38);
            this.lvwBook.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBook.Name = "lvwBook";
            this.lvwBook.Size = new System.Drawing.Size(555, 380);
            this.lvwBook.TabIndex = 7;
            this.lvwBook.UseCompatibleStateImageBehavior = false;
            this.lvwBook.View = System.Windows.Forms.View.Details;
            this.lvwBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwBook_MouseClick);
            // 
            // chBookIsbn
            // 
            this.chBookIsbn.Text = "ISBN";
            this.chBookIsbn.Width = 100;
            // 
            // chBookName
            // 
            this.chBookName.Text = "도서명";
            this.chBookName.Width = 100;
            // 
            // chBookWriter
            // 
            this.chBookWriter.Text = "저자";
            this.chBookWriter.Width = 70;
            // 
            // chBookPub
            // 
            this.chBookPub.Text = "출판사";
            // 
            // chBookYear
            // 
            this.chBookYear.Text = "출판년도";
            // 
            // chBookPage
            // 
            this.chBookPage.Text = "페이지";
            this.chBookPage.Width = 50;
            // 
            // chBookCount
            // 
            this.chBookCount.Text = "보유";
            this.chBookCount.Width = 40;
            // 
            // chBookCate
            // 
            this.chBookCate.Text = "분류번호";
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
            this.lblBorrowBook.Text = "대여 중인 도서 수 : ";
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
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(230, 21);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(0, 15);
            this.lblSearchLabel.TabIndex = 15;
            // 
            // btnBookReload
            // 
            this.btnBookReload.Location = new System.Drawing.Point(617, 422);
            this.btnBookReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookReload.Name = "btnBookReload";
            this.btnBookReload.Size = new System.Drawing.Size(168, 25);
            this.btnBookReload.TabIndex = 16;
            this.btnBookReload.Text = "초기화";
            this.btnBookReload.UseVisualStyleBackColor = true;
            this.btnBookReload.Click += new System.EventHandler(this.btnBookReload_Click);
            // 
            // cmsBookMenu
            // 
            this.cmsBookMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrBookInfo,
            this.tsrBook,
            this.tsrModi,
            this.tsrDele});
            this.cmsBookMenu.Name = "cmsStudentMenu";
            this.cmsBookMenu.Size = new System.Drawing.Size(136, 92);
            // 
            // tsrBookInfo
            // 
            this.tsrBookInfo.Name = "tsrBookInfo";
            this.tsrBookInfo.Size = new System.Drawing.Size(135, 22);
            this.tsrBookInfo.Text = "대여 / 반납";
            this.tsrBookInfo.Click += new System.EventHandler(this.tsrBookInfo_Click);
            // 
            // tsrBook
            // 
            this.tsrBook.Name = "tsrBook";
            this.tsrBook.Size = new System.Drawing.Size(135, 22);
            this.tsrBook.Text = "도서메뉴";
            // 
            // tsrModi
            // 
            this.tsrModi.Name = "tsrModi";
            this.tsrModi.Size = new System.Drawing.Size(135, 22);
            this.tsrModi.Text = "수정";
            this.tsrModi.Click += new System.EventHandler(this.tsrModi_Click);
            // 
            // tsrDele
            // 
            this.tsrDele.Name = "tsrDele";
            this.tsrDele.Size = new System.Drawing.Size(135, 22);
            this.tsrDele.Text = "삭제";
            this.tsrDele.Click += new System.EventHandler(this.tsrDele_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 467);
            this.Controls.Add(this.btnBookReload);
            this.Controls.Add(this.lblSearchLabel);
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
            this.cmsBookMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.ColumnHeader chBookIsbn;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chBookWriter;
        private System.Windows.Forms.ColumnHeader chBookPub;
        private System.Windows.Forms.ColumnHeader chBookYear;
        private System.Windows.Forms.ColumnHeader chBookPage;
        private System.Windows.Forms.ColumnHeader chBookCount;
        private System.Windows.Forms.ColumnHeader chBookCate;
        private System.Windows.Forms.Button btnBookReload;
        private System.Windows.Forms.ContextMenuStrip cmsBookMenu;
        private System.Windows.Forms.ToolStripMenuItem tsrBook;
        private System.Windows.Forms.ToolStripMenuItem tsrModi;
        private System.Windows.Forms.ToolStripMenuItem tsrDele;
        private System.Windows.Forms.ToolStripMenuItem tsrBookInfo;
    }
}