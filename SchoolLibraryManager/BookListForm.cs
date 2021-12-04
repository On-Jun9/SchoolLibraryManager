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
    public partial class BookListForm : Form
    {
        string selectIsbn, selectName;
        public BookListForm()
        {
            InitializeComponent();
        }
        private void BookListForm_Load(object sender, EventArgs e)
        {
            this.lblSearchLabel.Text = "전체 도서";
            MyDB myDB = new MyDB();
            int bookall = myDB.BookCount(0);
            this.lblAllBook.Text = "전체 도서 수 : " + bookall;
            int bookborrow = myDB.BookCount(1);
            this.lblBorrowBook.Text = "대여 중인 도서 수 : " + bookborrow;
            int bookover = myDB.BookCount(2);
            this.lblOverdueBook.Text = "연체 중인 도서 수 : " + bookover;

            this.lvwBook.Items.Clear();
            ArrayList rowList = myDB.BookListItem();
            foreach (ListViewItem m in rowList)
            {
                this.lvwBook.Items.Add(m);
            }

        }
        private void btnBookReload_Click(object sender, EventArgs e)
        {
            BookListForm_Load(null, EventArgs.Empty);
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            this.lvwBook.Items.Clear();
            ArrayList searchList = myDB.SearchBook(this.txtSearchBookForm.Text.Trim());
            this.lblSearchLabel.Text = $"'{this.txtSearchBookForm.Text.Trim()}' 검색 결과";
            this.txtSearchBookForm.Text = "";
            foreach (ListViewItem m in searchList)
            {
                this.lvwBook.Items.Add(m);
            }
        }

        private void txtSearchBookForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchBook_Click(this, new EventArgs());
            }
        }

        private void tsrModi_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(selectIsbn, selectName);
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                BookListForm_Load(null, EventArgs.Empty);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                BookListForm_Load(null, EventArgs.Empty);
            }
        }

        private void tsrBookInfo_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            int SelectRow = this.lvwBook.SelectedItems[0].Index;
            selectIsbn = this.lvwBook.Items[SelectRow].SubItems[0].Text;
            if (myDB.checkBook(selectIsbn) == 1)
            {
                ArrayList al = myDB.loanTOstu(selectIsbn);
                String _userId = al[0] + "";
                String _username = al[1] + "";
                BorrowReturnForm borrowReturnForm = new BorrowReturnForm(_userId, _username);
                if (borrowReturnForm.ShowDialog() == DialogResult.OK)
                {
                    BookListForm_Load(null, EventArgs.Empty);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"대여중이 아닌 도서입니다\n학생리스트로 이동하시겠습니까?", "대여", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult= DialogResult.OK;
                    this.Close();
                }
            }
            
        }

        private void tsrDele_Click(object sender, EventArgs e)
        {
            if (this.lvwBook.SelectedItems.Count == 1)
            {
                MyDB myDB = new MyDB();
                DialogResult deleteResult = MessageBox.Show($"선택한 도서가 삭제됩니다", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteResult == DialogResult.OK)
                {
                    int deleteSuccess = myDB.deleteBookService(selectIsbn);
                    MessageBox.Show("삭제 되었습니다.", "삭제완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookListForm_Load(null, EventArgs.Empty);
                }

                else if (deleteResult == DialogResult.Cancel)
                {
                }
            }
        }

        private void lvwBook_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.lvwBook.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                var focusedItem = this.lvwBook.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {

                    if (this.lvwBook.SelectedItems.Count > 1)
                    {
                        //cmsBookMenu.Show(Cursor.Position);
                    }
                    else if (this.lvwBook.SelectedItems.Count != 0)
                    {
                        cmsBookMenu.Show(Cursor.Position);
                        int SelectRow = this.lvwBook.SelectedItems[0].Index;

                        selectIsbn = this.lvwBook.Items[SelectRow].SubItems[0].Text;
                        selectName = this.lvwBook.Items[SelectRow].SubItems[1].Text;

                    }
                    else
                    {

                    }

                }
            }
            
        }
    }
}
