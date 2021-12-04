
namespace SchoolLibraryManager
{
    partial class AddBookForm
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
            this.cboBookCate = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookPubYear = new System.Windows.Forms.TextBox();
            this.txtBookPub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookWriter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookPage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboBookCate
            // 
            this.cboBookCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCate.FormattingEnabled = true;
            this.cboBookCate.Location = new System.Drawing.Point(81, 226);
            this.cboBookCate.Name = "cboBookCate";
            this.cboBookCate.Size = new System.Drawing.Size(247, 23);
            this.cboBookCate.TabIndex = 48;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(178, 273);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(72, 33);
            this.btnCancle.TabIndex = 45;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 33);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "분류번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "출판년도";
            // 
            // txtBookPubYear
            // 
            this.txtBookPubYear.Location = new System.Drawing.Point(81, 139);
            this.txtBookPubYear.Name = "txtBookPubYear";
            this.txtBookPubYear.Size = new System.Drawing.Size(247, 23);
            this.txtBookPubYear.TabIndex = 40;
            this.txtBookPubYear.TextChanged += new System.EventHandler(this.txtBookPubYear_TextChanged);
            // 
            // txtBookPub
            // 
            this.txtBookPub.Location = new System.Drawing.Point(81, 110);
            this.txtBookPub.Name = "txtBookPub";
            this.txtBookPub.Size = new System.Drawing.Size(247, 23);
            this.txtBookPub.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "출판사";
            // 
            // txtBookWriter
            // 
            this.txtBookWriter.Location = new System.Drawing.Point(81, 81);
            this.txtBookWriter.Name = "txtBookWriter";
            this.txtBookWriter.Size = new System.Drawing.Size(247, 23);
            this.txtBookWriter.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "저자";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(81, 52);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(247, 23);
            this.txtBookName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "도서명";
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(81, 23);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(247, 23);
            this.txtBookIsbn.TabIndex = 29;
            this.txtBookIsbn.TextChanged += new System.EventHandler(this.txtBookIsbn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "ISBN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "페이지수";
            // 
            // txtBookPage
            // 
            this.txtBookPage.Location = new System.Drawing.Point(81, 168);
            this.txtBookPage.Name = "txtBookPage";
            this.txtBookPage.Size = new System.Drawing.Size(247, 23);
            this.txtBookPage.TabIndex = 50;
            this.txtBookPage.TextChanged += new System.EventHandler(this.txtBookPage_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "보유권수";
            // 
            // txtBookCount
            // 
            this.txtBookCount.Location = new System.Drawing.Point(81, 197);
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Size = new System.Drawing.Size(247, 23);
            this.txtBookCount.TabIndex = 52;
            this.txtBookCount.TextChanged += new System.EventHandler(this.txtBookCount_TextChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 331);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBookCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBookPage);
            this.Controls.Add(this.cboBookCate);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBookPubYear);
            this.Controls.Add(this.txtBookPub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBookWriter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookIsbn);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboBookCate;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBokkPubYear;
        private System.Windows.Forms.TextBox txtBookPub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookWriter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBookCount;
        private System.Windows.Forms.TextBox txtBookPubYear;
    }
}