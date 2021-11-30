
namespace SchoolLibraryManager
{
    partial class MainForm
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
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.btnBookForm = new System.Windows.Forms.Button();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.Location = new System.Drawing.Point(210, 152);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(206, 175);
            this.btnStudentForm.TabIndex = 0;
            this.btnStudentForm.Text = "학생 관리";
            this.btnStudentForm.UseVisualStyleBackColor = true;
            // 
            // btnBookForm
            // 
            this.btnBookForm.Location = new System.Drawing.Point(450, 152);
            this.btnBookForm.Name = "btnBookForm";
            this.btnBookForm.Size = new System.Drawing.Size(206, 175);
            this.btnBookForm.TabIndex = 1;
            this.btnBookForm.Text = "도서 관리";
            this.btnBookForm.UseVisualStyleBackColor = true;
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Location = new System.Drawing.Point(711, 500);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(112, 34);
            this.btnLoginForm.TabIndex = 2;
            this.btnLoginForm.Text = "로그인/로그아웃";
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Location = new System.Drawing.Point(533, 505);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(73, 25);
            this.lblLoginUser.TabIndex = 3;
            this.lblLoginUser.Text = "Login : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 546);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.btnBookForm);
            this.Controls.Add(this.btnStudentForm);
            this.Name = "MainForm";
            this.Text = "학생 도서관 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.Button btnBookForm;
        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Label lblLoginUser;
    }
}

