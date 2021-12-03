using System;
using System.Collections;
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
    public partial class StudentListForm : Form
    {
        string selectId, selectName;
        public StudentListForm()
        {
            InitializeComponent();
        }

        public ListView listView { get; set; }
        
        public StudentListForm(ListView listView)
        {
            this.listView = listView;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentListForm_Load(null, EventArgs.Empty);
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            this.lblSearchLabel.Text = "전체 학생";

            MyDB myDB = new MyDB();
            int studentall = myDB.StudentCount(0);
            this.lblAllStudent.Text = "전체 학생 수 : " + studentall;
            int sudentAttending = myDB.StudentCount(1);
            this.lblAttendingStudent.Text = "재학 학생 수 : " + sudentAttending;
            int sudentLeave = myDB.StudentCount(2);
            this.lblLeaveStudent.Text = "휴학 학생 수 : " + sudentLeave;
            int sudentGraduated = myDB.StudentCount(3);
            this.lblGraduatedStudent.Text = "졸업 학생 수 : " + sudentGraduated;

            this.lvwStudentList.Items.Clear();
            ArrayList rowList = myDB.StudentListItem();
            foreach(ListViewItem m in rowList)
            {
                this.lvwStudentList.Items.Add(m);
            }

            //this.lvwStudentList.Items.Add(myDB.StudentListItem());


        }

        private void btnStuReload_Click(object sender, EventArgs e)
        {
            StudentListForm_Load(null, EventArgs.Empty);
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            this.lvwStudentList.Items.Clear();
            ArrayList searchList = myDB.SearchStudent(this.txtSearchStuStuForm.Text.Trim());
            this.lblSearchLabel.Text = $"'{this.txtSearchStuStuForm.Text.Trim()}' 검색 결과";
            this.txtSearchStuStuForm.Text = "";
            foreach (ListViewItem m in searchList)
            {
                this.lvwStudentList.Items.Add(m);
            }
        }

        private void lvwStudentList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.lvwStudentList.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                var focusedItem = this.lvwStudentList.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    

                    if (this.lvwStudentList.SelectedItems.Count > 1)
                    {
                        cmsStudentMenu2.Show(Cursor.Position);
                    }
                    else if(this.lvwStudentList.SelectedItems.Count != 0)
                    {
                        cmsStudentMenu.Show(Cursor.Position);
                        int SelectRow = this.lvwStudentList.SelectedItems[0].Index;

                        selectId = this.lvwStudentList.Items[SelectRow].SubItems[0].Text;
                        selectName = this.lvwStudentList.Items[SelectRow].SubItems[1].Text;

                        
                        
                    }
                    else
                    {

                    }

                }

                
            }
        }
        private void tsrBook_Click(object sender, EventArgs e)
        {
            BorrowReturnForm borrowReturnForm = new BorrowReturnForm(selectId, selectName);
            //this.Close();
            borrowReturnForm.ShowDialog();
        }

        private void txtSearchStuStuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearchStudent_Click(this, new EventArgs());
            }
        }
    }
}
