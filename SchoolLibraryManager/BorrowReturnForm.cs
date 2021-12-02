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
    public partial class BorrowReturnForm : Form
    {
        String _userId,_username;
        public BorrowReturnForm()
        {
            InitializeComponent();
        }

        public BorrowReturnForm(String userid,String username)
        {
            _userId = userid;
            _username = username;
            InitializeComponent();
        }

        private void btnBookCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrowReturnForm_Load(object sender, EventArgs e)
        {
            this.lblStudentID.Text = _userId;
            this.lblStudentName.Text = _username;
        }
    }
}
