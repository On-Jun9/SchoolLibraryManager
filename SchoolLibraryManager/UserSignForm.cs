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
    public partial class UserSignForm : Form
    {
        public UserSignForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            myDB.loginCheck(this.txtUserId.Text, this.txtUserPwd.Text);
            //String userName = myDB.loginCheck(this.txtUserId.Text,this.txtUserPwd.Text);

            if (LoginFlag.flagUserBool == false)
            {
                //로그인 에러
                MessageBox.Show($"아이디 또는 비밀번호를 확인해 주세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserId.Focus();
            }
            else
            {
                //로그인 성공
                MessageBox.Show($"{LoginFlag.flagUserId} 님 로그인 성공!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
          
        }

        private void UserSignForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
