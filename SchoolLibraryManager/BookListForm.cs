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

        private void lvwBook_MouseClick(object sender, MouseEventArgs e)
        {
            var focusedItem = this.lvwBook.FocusedItem;
            if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
            {

                if (this.lvwBook.SelectedItems.Count > 1)
                {
                    cmsBookMenu2.Show(Cursor.Position);
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
