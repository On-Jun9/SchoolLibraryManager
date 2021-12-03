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
            AddStudentForm addStudentForm = new AddStudentForm();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                StudentListForm_Load(null, EventArgs.Empty);
            }
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            this.lblSearchLabel.Text = "전체 학생";

            MyDB myDB = new MyDB();
            int studentall = myDB.StudentCount(0);
            this.lblAllStudent.Text = "전체 학생 수 : " + studentall;
            int studentAttending = myDB.StudentCount(1);
            this.lblAttendingStudent.Text = "재학 학생 수 : " + studentAttending;
            int studentLeave = myDB.StudentCount(2);
            this.lblLeaveStudent.Text = "휴학 학생 수 : " + studentLeave;
            int studentGraduated = myDB.StudentCount(3);
            this.lblGraduatedStudent.Text = "졸업 학생 수 : " + studentGraduated;
            int studentExpelled = myDB.StudentCount(4);
            this.lblexpelledStudent.Text = "제적 학생 수 : " + studentExpelled;

            this.lvwStudentList.Items.Clear();
            ArrayList rowList = myDB.StudentListItem();
            foreach (ListViewItem m in rowList)
            {
                this.lvwStudentList.Items.Add(m);
            }
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
                    cmsStudentMenu.Items.Clear();

                    if (this.lvwStudentList.SelectedItems.Count > 1)
                    {
                        cmsStudentMenu.Items.Add(tsrDele);
                        cmsStudentMenu.Show(Cursor.Position);
                    }
                    else if(this.lvwStudentList.SelectedItems.Count != 0)
                    {
                        cmsStudentMenu.Items.Add(tsrBook);
                        cmsStudentMenu.Items.Add(tsrModi);
                        cmsStudentMenu.Items.Add(tsrDele);

                        cmsStudentMenu.Show(Cursor.Position);
                        int SelectRow = this.lvwStudentList.SelectedItems[0].Index;

                        selectId = this.lvwStudentList.Items[SelectRow].SubItems[0].Text;
                        selectName = this.lvwStudentList.Items[SelectRow].SubItems[1].Text;
                    }

                }  
            }
        }
        private void tsrBook_Click(object sender, EventArgs e)
        {
            BorrowReturnForm borrowReturnForm = new BorrowReturnForm(selectId, selectName);
            borrowReturnForm.ShowDialog();
        }

        private void tsrModi_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(selectId,selectName);
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                StudentListForm_Load(null, EventArgs.Empty);
            }
        }

        private void tsrDele_Click(object sender, EventArgs e)
        {
            if (this.lvwStudentList.SelectedItems.Count == 1)
            {
                MyDB myDB = new MyDB();
                myDB.deleteStuService(selectId, selectName);
                DialogResult deleteResult = MessageBox.Show($"선택한 학생이 삭제됩니다", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteResult == DialogResult.OK)
                {
                    int deleteSuccess = myDB.deleteStuService(selectId, selectName);
                    if (deleteSuccess == 0)
                    {
                        MessageBox.Show("삭제 되었습니다.", "삭제완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentListForm_Load(null, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show($"{deleteSuccess}삭제 실패 하였습니다.", "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (deleteResult == DialogResult.Cancel)
                {
                }
            }

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
