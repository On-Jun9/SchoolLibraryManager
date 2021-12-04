
namespace SchoolLibraryManager
{
    partial class BorrowReturnForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOverCount = new System.Windows.Forms.Label();
            this.lblBorrowCount = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwBRStuList = new System.Windows.Forms.ListView();
            this.chbookno = new System.Windows.Forms.ColumnHeader();
            this.chBookIsbn = new System.Windows.Forms.ColumnHeader();
            this.chBookName = new System.Windows.Forms.ColumnHeader();
            this.chBookldate = new System.Windows.Forms.ColumnHeader();
            this.chBookrdate = new System.Windows.Forms.ColumnHeader();
            this.btnBookCancle = new System.Windows.Forms.Button();
            this.lvwBRBookList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.chBookWriter = new System.Windows.Forms.ColumnHeader();
            this.chBookPub = new System.Windows.Forms.ColumnHeader();
            this.chBookYear = new System.Windows.Forms.ColumnHeader();
            this.chBookPage = new System.Windows.Forms.ColumnHeader();
            this.chBookCount = new System.Windows.Forms.ColumnHeader();
            this.chBookCate = new System.Windows.Forms.ColumnHeader();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOverCount);
            this.groupBox1.Controls.Add(this.lblBorrowCount);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Location = new System.Drawing.Point(10, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(629, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생 정보";
            // 
            // lblOverCount
            // 
            this.lblOverCount.AutoSize = true;
            this.lblOverCount.Location = new System.Drawing.Point(379, 54);
            this.lblOverCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverCount.Name = "lblOverCount";
            this.lblOverCount.Size = new System.Drawing.Size(50, 14);
            this.lblOverCount.TabIndex = 11;
            this.lblOverCount.Text = "연체중 :";
            // 
            // lblBorrowCount
            // 
            this.lblBorrowCount.AutoSize = true;
            this.lblBorrowCount.Location = new System.Drawing.Point(379, 30);
            this.lblBorrowCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowCount.Name = "lblBorrowCount";
            this.lblBorrowCount.Size = new System.Drawing.Size(53, 14);
            this.lblBorrowCount.TabIndex = 10;
            this.lblBorrowCount.Text = "대여중 : ";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(18, 30);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 14);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Text = "학생 학번";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(18, 54);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(58, 14);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "학생 이름";
            // 
            // btnBookSave
            // 
            this.btnBookSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSave.Location = new System.Drawing.Point(533, 629);
            this.btnBookSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(106, 28);
            this.btnBookSave.TabIndex = 3;
            this.btnBookSave.Text = "저장";
            this.btnBookSave.UseVisualStyleBackColor = false;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "보유 도서";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "학생 대여중";
            // 
            // lvwBRStuList
            // 
            this.lvwBRStuList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvwBRStuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chbookno,
            this.chBookIsbn,
            this.chBookName,
            this.chBookldate,
            this.chBookrdate});
            this.lvwBRStuList.FullRowSelect = true;
            this.lvwBRStuList.GridLines = true;
            this.lvwBRStuList.HideSelection = false;
            this.lvwBRStuList.Location = new System.Drawing.Point(10, 415);
            this.lvwBRStuList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBRStuList.MultiSelect = false;
            this.lvwBRStuList.Name = "lvwBRStuList";
            this.lvwBRStuList.Size = new System.Drawing.Size(629, 206);
            this.lvwBRStuList.TabIndex = 9;
            this.lvwBRStuList.UseCompatibleStateImageBehavior = false;
            this.lvwBRStuList.View = System.Windows.Forms.View.Details;
            this.lvwBRStuList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwBRStuList_MouseDoubleClick);
            // 
            // chbookno
            // 
            this.chbookno.Text = "no";
            this.chbookno.Width = 40;
            // 
            // chBookIsbn
            // 
            this.chBookIsbn.Text = "ISBN";
            this.chBookIsbn.Width = 140;
            // 
            // chBookName
            // 
            this.chBookName.Text = "도서명";
            this.chBookName.Width = 180;
            // 
            // chBookldate
            // 
            this.chBookldate.Text = "대여일";
            this.chBookldate.Width = 90;
            // 
            // chBookrdate
            // 
            this.chBookrdate.Text = "반납기한";
            this.chBookrdate.Width = 90;
            // 
            // btnBookCancle
            // 
            this.btnBookCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookCancle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBookCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCancle.Location = new System.Drawing.Point(417, 629);
            this.btnBookCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookCancle.Name = "btnBookCancle";
            this.btnBookCancle.Size = new System.Drawing.Size(106, 28);
            this.btnBookCancle.TabIndex = 10;
            this.btnBookCancle.Text = "취소";
            this.btnBookCancle.UseVisualStyleBackColor = false;
            this.btnBookCancle.Click += new System.EventHandler(this.btnBookCancle_Click);
            // 
            // lvwBRBookList
            // 
            this.lvwBRBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvwBRBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.chBookWriter,
            this.chBookPub,
            this.chBookYear,
            this.chBookPage,
            this.chBookCount,
            this.chBookCate});
            this.lvwBRBookList.FullRowSelect = true;
            this.lvwBRBookList.GridLines = true;
            this.lvwBRBookList.HideSelection = false;
            this.lvwBRBookList.Location = new System.Drawing.Point(10, 181);
            this.lvwBRBookList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBRBookList.MultiSelect = false;
            this.lvwBRBookList.Name = "lvwBRBookList";
            this.lvwBRBookList.Size = new System.Drawing.Size(629, 206);
            this.lvwBRBookList.TabIndex = 11;
            this.lvwBRBookList.UseCompatibleStateImageBehavior = false;
            this.lvwBRBookList.View = System.Windows.Forms.View.Details;
            this.lvwBRBookList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwBRBookList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "도서명";
            this.columnHeader2.Width = 170;
            // 
            // chBookWriter
            // 
            this.chBookWriter.Text = "저자";
            this.chBookWriter.Width = 70;
            // 
            // chBookPub
            // 
            this.chBookPub.Text = "출판사";
            this.chBookPub.Width = 70;
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
            this.chBookCate.Width = 70;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(10, 629);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 28);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "초기화";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "↑ 더블클릭하여 이동 ↓";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 63);
            this.panel1.TabIndex = 56;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtTitle.Location = new System.Drawing.Point(202, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(255, 44);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "대여 반납 관리";
            // 
            // BorrowReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(652, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lvwBRBookList);
            this.Controls.Add(this.btnBookCancle);
            this.Controls.Add(this.lvwBRStuList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "대여 / 반납";
            this.Load += new System.EventHandler(this.BorrowReturnForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwBRStuList;
        private System.Windows.Forms.Label lblOverCount;
        private System.Windows.Forms.Label lblBorrowCount;
        private System.Windows.Forms.Button btnBookCancle;
        private System.Windows.Forms.ColumnHeader chBookIsbn;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chbookno;
        private System.Windows.Forms.ColumnHeader chBookldate;
        private System.Windows.Forms.ColumnHeader chBookrdate;
        private System.Windows.Forms.ListView lvwBRBookList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader chBookWriter;
        private System.Windows.Forms.ColumnHeader chBookPub;
        private System.Windows.Forms.ColumnHeader chBookYear;
        private System.Windows.Forms.ColumnHeader chBookPage;
        private System.Windows.Forms.ColumnHeader chBookCount;
        private System.Windows.Forms.ColumnHeader chBookCate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label testestest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTitle;
    }
}