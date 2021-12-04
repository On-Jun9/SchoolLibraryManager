
namespace SchoolLibraryManager
{
    partial class StudentListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblexpelledStudent = new System.Windows.Forms.Label();
            this.lblGraduatedStudent = new System.Windows.Forms.Label();
            this.lblLeaveStudent = new System.Windows.Forms.Label();
            this.lblAttendingStudent = new System.Windows.Forms.Label();
            this.lblAllStudent = new System.Windows.Forms.Label();
            this.lvwStudentList = new System.Windows.Forms.ListView();
            this.chStuId = new System.Windows.Forms.ColumnHeader();
            this.chStuName = new System.Windows.Forms.ColumnHeader();
            this.chStuBirth = new System.Windows.Forms.ColumnHeader();
            this.chStuGender = new System.Windows.Forms.ColumnHeader();
            this.chStuPhone = new System.Windows.Forms.ColumnHeader();
            this.chStuZip = new System.Windows.Forms.ColumnHeader();
            this.chStuEmail = new System.Windows.Forms.ColumnHeader();
            this.chStuAdmitdate = new System.Windows.Forms.ColumnHeader();
            this.cmsStudentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrModi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrDele = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchStuStuForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnStuReload = new System.Windows.Forms.Button();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.cmsStudentMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblexpelledStudent);
            this.groupBox1.Controls.Add(this.lblGraduatedStudent);
            this.groupBox1.Controls.Add(this.lblLeaveStudent);
            this.groupBox1.Controls.Add(this.lblAttendingStudent);
            this.groupBox1.Controls.Add(this.lblAllStudent);
            this.groupBox1.Location = new System.Drawing.Point(20, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(192, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생현황";
            // 
            // lblexpelledStudent
            // 
            this.lblexpelledStudent.AutoSize = true;
            this.lblexpelledStudent.Location = new System.Drawing.Point(14, 110);
            this.lblexpelledStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexpelledStudent.Name = "lblexpelledStudent";
            this.lblexpelledStudent.Size = new System.Drawing.Size(83, 14);
            this.lblexpelledStudent.TabIndex = 9;
            this.lblexpelledStudent.Text = "재적 학생 수 : ";
            // 
            // lblGraduatedStudent
            // 
            this.lblGraduatedStudent.AutoSize = true;
            this.lblGraduatedStudent.Location = new System.Drawing.Point(14, 89);
            this.lblGraduatedStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraduatedStudent.Name = "lblGraduatedStudent";
            this.lblGraduatedStudent.Size = new System.Drawing.Size(83, 14);
            this.lblGraduatedStudent.TabIndex = 8;
            this.lblGraduatedStudent.Text = "졸업 학생 수 : ";
            // 
            // lblLeaveStudent
            // 
            this.lblLeaveStudent.AutoSize = true;
            this.lblLeaveStudent.Location = new System.Drawing.Point(14, 67);
            this.lblLeaveStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveStudent.Name = "lblLeaveStudent";
            this.lblLeaveStudent.Size = new System.Drawing.Size(83, 14);
            this.lblLeaveStudent.TabIndex = 7;
            this.lblLeaveStudent.Text = "휴학 학생 수 : ";
            // 
            // lblAttendingStudent
            // 
            this.lblAttendingStudent.AutoSize = true;
            this.lblAttendingStudent.Location = new System.Drawing.Point(14, 46);
            this.lblAttendingStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttendingStudent.Name = "lblAttendingStudent";
            this.lblAttendingStudent.Size = new System.Drawing.Size(83, 14);
            this.lblAttendingStudent.TabIndex = 6;
            this.lblAttendingStudent.Text = "재학 학생 수 : ";
            // 
            // lblAllStudent
            // 
            this.lblAllStudent.AutoSize = true;
            this.lblAllStudent.Location = new System.Drawing.Point(14, 24);
            this.lblAllStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllStudent.Name = "lblAllStudent";
            this.lblAllStudent.Size = new System.Drawing.Size(83, 14);
            this.lblAllStudent.TabIndex = 5;
            this.lblAllStudent.Text = "전체 학생 수 : ";
            // 
            // lvwStudentList
            // 
            this.lvwStudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvwStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStuId,
            this.chStuName,
            this.chStuBirth,
            this.chStuGender,
            this.chStuPhone,
            this.chStuZip,
            this.chStuEmail,
            this.chStuAdmitdate});
            this.lvwStudentList.FullRowSelect = true;
            this.lvwStudentList.GridLines = true;
            this.lvwStudentList.HideSelection = false;
            this.lvwStudentList.Location = new System.Drawing.Point(231, 89);
            this.lvwStudentList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwStudentList.MultiSelect = false;
            this.lvwStudentList.Name = "lvwStudentList";
            this.lvwStudentList.Size = new System.Drawing.Size(634, 355);
            this.lvwStudentList.TabIndex = 1;
            this.lvwStudentList.UseCompatibleStateImageBehavior = false;
            this.lvwStudentList.View = System.Windows.Forms.View.Details;
            this.lvwStudentList.SelectedIndexChanged += new System.EventHandler(this.lvwStudentList_SelectedIndexChanged);
            this.lvwStudentList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwStudentList_MouseClick);
            // 
            // chStuId
            // 
            this.chStuId.Text = "학번";
            this.chStuId.Width = 90;
            // 
            // chStuName
            // 
            this.chStuName.Text = "이름";
            // 
            // chStuBirth
            // 
            this.chStuBirth.Text = "생년월일";
            this.chStuBirth.Width = 90;
            // 
            // chStuGender
            // 
            this.chStuGender.Text = "성별";
            this.chStuGender.Width = 30;
            // 
            // chStuPhone
            // 
            this.chStuPhone.Text = "전화번호";
            this.chStuPhone.Width = 100;
            // 
            // chStuZip
            // 
            this.chStuZip.Text = "주소";
            this.chStuZip.Width = 130;
            // 
            // chStuEmail
            // 
            this.chStuEmail.Text = "이메일";
            this.chStuEmail.Width = 130;
            // 
            // chStuAdmitdate
            // 
            this.chStuAdmitdate.Text = "입학일";
            this.chStuAdmitdate.Width = 100;
            // 
            // cmsStudentMenu
            // 
            this.cmsStudentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrBook,
            this.tsrModi,
            this.tsrDele});
            this.cmsStudentMenu.Name = "cmsStudentMenu";
            this.cmsStudentMenu.Size = new System.Drawing.Size(128, 70);
            // 
            // tsrBook
            // 
            this.tsrBook.Name = "tsrBook";
            this.tsrBook.Size = new System.Drawing.Size(127, 22);
            this.tsrBook.Text = "대여/반납";
            this.tsrBook.Click += new System.EventHandler(this.tsrBook_Click);
            // 
            // tsrModi
            // 
            this.tsrModi.Name = "tsrModi";
            this.tsrModi.Size = new System.Drawing.Size(127, 22);
            this.tsrModi.Text = "수정";
            this.tsrModi.Click += new System.EventHandler(this.tsrModi_Click);
            // 
            // tsrDele
            // 
            this.tsrDele.Name = "tsrDele";
            this.tsrDele.Size = new System.Drawing.Size(127, 22);
            this.tsrDele.Text = "삭제";
            this.tsrDele.Click += new System.EventHandler(this.tsrDele_Click);
            // 
            // txtSearchStuStuForm
            // 
            this.txtSearchStuStuForm.Location = new System.Drawing.Point(20, 257);
            this.txtSearchStuStuForm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStuStuForm.Name = "txtSearchStuStuForm";
            this.txtSearchStuStuForm.Size = new System.Drawing.Size(193, 22);
            this.txtSearchStuStuForm.TabIndex = 2;
            this.txtSearchStuStuForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchStuStuForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "학번/이름";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnSearchStudent.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnSearchStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Location = new System.Drawing.Point(123, 286);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(90, 30);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "검색";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnAddStudent.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(20, 404);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(193, 40);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "학생 추가";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStuReload
            // 
            this.btnStuReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnStuReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnStuReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnStuReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuReload.Location = new System.Drawing.Point(20, 286);
            this.btnStuReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuReload.Name = "btnStuReload";
            this.btnStuReload.Size = new System.Drawing.Size(90, 30);
            this.btnStuReload.TabIndex = 6;
            this.btnStuReload.Text = "초기화";
            this.btnStuReload.UseVisualStyleBackColor = false;
            this.btnStuReload.Click += new System.EventHandler(this.btnStuReload_Click);
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(231, 73);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(0, 14);
            this.lblSearchLabel.TabIndex = 8;
            this.lblSearchLabel.Click += new System.EventHandler(this.lblSearchLabel_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtTitle.Location = new System.Drawing.Point(359, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(173, 44);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "학생 관리";
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 63);
            this.panel1.TabIndex = 58;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(886, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.btnStuReload);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchStuStuForm);
            this.Controls.Add(this.lvwStudentList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "학생관리";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsStudentMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGraduatedStudent;
        private System.Windows.Forms.Label lblLeaveStudent;
        private System.Windows.Forms.Label lblAttendingStudent;
        private System.Windows.Forms.Label lblAllStudent;
        private System.Windows.Forms.TextBox txtSearchStuStuForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ColumnHeader chStuId;
        private System.Windows.Forms.ColumnHeader chStuName;
        private System.Windows.Forms.ColumnHeader chStuBirth;
        private System.Windows.Forms.ColumnHeader chStuGender;
        private System.Windows.Forms.ColumnHeader chStuPhone;
        private System.Windows.Forms.ColumnHeader chStuZip;
        private System.Windows.Forms.ColumnHeader chStuEmail;
        private System.Windows.Forms.ColumnHeader chStuAdmitdate;
        public System.Windows.Forms.ListView lvwStudentList;
        private System.Windows.Forms.Button btnStuReload;
        private System.Windows.Forms.ContextMenuStrip cmsStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem 도서메뉴;
        private System.Windows.Forms.ToolStripMenuItem 수정;
        private System.Windows.Forms.ToolStripMenuItem 삭제;
        private System.Windows.Forms.ToolStripMenuItem tsrBook;
        private System.Windows.Forms.ToolStripMenuItem tsrModi;
        private System.Windows.Forms.ToolStripMenuItem tsrDele;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.Label lblexpelledStudent;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panel1;
    }
}