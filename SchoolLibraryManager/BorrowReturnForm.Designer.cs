
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lvwBRBookList = new System.Windows.Forms.ListView();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwBRStuList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(384, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "연체중 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "대여중 :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(16, 32);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(59, 15);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Text = "학생 학번";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(16, 58);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(59, 15);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "학생 이름";
            // 
            // lvwBRBookList
            // 
            this.lvwBRBookList.HideSelection = false;
            this.lvwBRBookList.Location = new System.Drawing.Point(8, 206);
            this.lvwBRBookList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBRBookList.Name = "lvwBRBookList";
            this.lvwBRBookList.Size = new System.Drawing.Size(187, 215);
            this.lvwBRBookList.TabIndex = 1;
            this.lvwBRBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(276, 433);
            this.btnBookSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(116, 30);
            this.btnBookSave.TabIndex = 3;
            this.btnBookSave.Text = "저장";
            this.btnBookSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "전체 리스트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "학생 대여중";
            // 
            // lvwBRStuList
            // 
            this.lvwBRStuList.HideSelection = false;
            this.lvwBRStuList.Location = new System.Drawing.Point(205, 206);
            this.lvwBRStuList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBRStuList.Name = "lvwBRStuList";
            this.lvwBRStuList.Size = new System.Drawing.Size(187, 215);
            this.lvwBRStuList.TabIndex = 9;
            this.lvwBRStuList.UseCompatibleStateImageBehavior = false;
            // 
            // BorrowReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 487);
            this.Controls.Add(this.lvwBRStuList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.lvwBRBookList);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowReturnForm";
            this.Text = "BorrowReturnForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwBRBookList;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwBRStuList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}