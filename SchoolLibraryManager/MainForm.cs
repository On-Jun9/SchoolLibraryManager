using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            if(LoginFlag.flagUserBool == false)
            {
                UserSignForm userSignForm = new UserSignForm();
 
                if (userSignForm.ShowDialog() == DialogResult.OK)
                {
                    MainForm_Load(null, EventArgs.Empty);
                }
            }
            else
            {
                LoginFlag.flagUserBool = false;
                LoginFlag.flagUserId = null;
                MainForm_Load(null, EventArgs.Empty);
                MessageBox.Show("로그아웃 되었습니다.", "로그아웃 완료", MessageBoxButtons.OK);
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginFlag.flagUserBool == false)
            {
                this.btnLoginForm.Text = "로그인";
                this.lblLoginUser.Text = "";
            }
            else
            {
                this.lblLoginUser.Text = $"{LoginFlag.flagUserId}님 로그인 중";
                this.btnLoginForm.Text = "로그아웃";
            }

        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            if (LoginFlag.flagUserBool == false)
            {
                MessageBox.Show("로그인이 필요합니다", "권한 필요", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (LoginFlag.flagUserBool == true)
            {
                StudentListForm studentListForm = new StudentListForm();
                studentListForm.ShowDialog();
            }
            
        }

        private void btnBookForm_Click(object sender, EventArgs e)
        {

            if (LoginFlag.flagUserBool == false)
            {
                MessageBox.Show("로그인이 필요합니다", "권한 필요", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (LoginFlag.flagUserBool == true)
            {
                BookListForm bookListForm = new BookListForm();
                if (bookListForm.ShowDialog() == DialogResult.OK)
                {
                    StudentListForm studentListForm = new StudentListForm();
                    studentListForm.ShowDialog();
                }
            }
            
        }
    }
}
