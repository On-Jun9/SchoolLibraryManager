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
    public partial class BorrowReturnForm : Form
    {
        String _userId,_username;
        ArrayList returnList, borrowList;
        public BorrowReturnForm()
        {
            InitializeComponent();
        }

        public BorrowReturnForm(String userid,String username)
        {
            returnList = new ArrayList();
            borrowList = new ArrayList();
            _userId = userid;
            _username = username;
            InitializeComponent();
        }

        private void btnBookCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BorrowReturnForm_Load(null, EventArgs.Empty);
            
        }

        private void lvwBRBookList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.lvwBRBookList.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                var focusedItem = this.lvwBRBookList.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    if (this.lvwBRBookList.SelectedItems.Count == 1)
                    {
                        MyDB myDB = new MyDB();
                        int SelectRow = this.lvwBRBookList.SelectedItems[0].Index;
                        var selectIsbn = this.lvwBRBookList.Items[SelectRow].SubItems[0].Text;
                        //var selectISBN = this.lvwBRBookList.Items[SelectRow].SubItems[1].Text;
                        this.lvwBRBookList.Items[SelectRow].Remove();
                        if (!borrowList.Contains(selectIsbn))
                        {
                            borrowList.Add(selectIsbn);
                        }
                        if (returnList.Contains(selectIsbn))
                        {
                            returnList.Remove(selectIsbn);
                            borrowList.Remove(selectIsbn);
                            lvwBRStuList.Items.Add(myDB.cancleReturn(selectIsbn));
                        }
                        else
                        {
                            lvwBRStuList.Items.Add(myDB.SearchIsbnAll(selectIsbn));
                        }
                    }

                }
            }
        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            myDB.libraryService(borrowList, returnList, _userId);
            DialogResult = DialogResult.OK;
            MessageBox.Show($"저장 완료 되었습니다.", "도서관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lvwBRStuList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.lvwBRStuList.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                var focusedItem = this.lvwBRStuList.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    if (this.lvwBRStuList.SelectedItems.Count ==1)
                    {
                        MyDB myDB = new MyDB();
                        int SelectRow = this.lvwBRStuList.SelectedItems[0].Index; 
                        var selectId = this.lvwBRStuList.Items[SelectRow].SubItems[0].Text;
                        var selectISBN = this.lvwBRStuList.Items[SelectRow].SubItems[1].Text;
                        this.lvwBRStuList.Items[SelectRow].Remove();
                        if (!returnList.Contains(selectISBN))
                        {
                            returnList.Add(selectISBN);
                        }
                        if (borrowList.Contains(selectISBN))
                        {
                            borrowList.Remove(selectISBN);
                            returnList.Remove(selectISBN);
                        }
                        lvwBRBookList.Items.Add(myDB.SearchIsbnStu(selectISBN));

                    }

                }
            }
        }

        private void BorrowReturnForm_Load(object sender, EventArgs e)
        {
            returnList = new ArrayList();
            borrowList = new ArrayList();
            MyDB myDB = new MyDB();
            this.lblStudentID.Text = _userId;
            this.lblStudentName.Text = _username;
            DataSet myDS = myDB.loanCount(_userId);
            DataTable myDT = myDS.Tables[0];
            foreach (DataRow row in myDT.Rows)
            {
                this.lblBorrowCount.Text = "대여중 : " + row["loancount"];
            }
            myDS = myDB.overCount(_userId);
            myDT = myDS.Tables[0];
            foreach (DataRow row in myDT.Rows)
            {
                this.lblOverCount.Text = "연체중 : " + row["overcount"];
            }
            this.lvwBRBookList.Items.Clear();
            this.lvwBRStuList.Items.Clear();

            ArrayList rowList = myDB.BookListSubB();
            foreach (ListViewItem m in rowList)
            {
                this.lvwBRBookList.Items.Add(m);
            }

            rowList = myDB.studentLibraryList(_userId);
            foreach (ListViewItem m in rowList)
            {
                this.lvwBRStuList.Items.Add(m);
            }
        }
    }
}
