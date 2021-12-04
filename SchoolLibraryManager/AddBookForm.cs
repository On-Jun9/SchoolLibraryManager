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
    public partial class AddBookForm : Form
    {
        String _bookisbn, _bookname;
        String flag;
        string[] prevText = Enumerable.Repeat("", 10).ToArray();
        public AddBookForm()
        {
            InitializeComponent();
        }
        public AddBookForm(String bookisbn, String bookname)
        {
            _bookisbn = bookisbn;
            _bookname = bookname;

            flag = "modify";
            InitializeComponent();
        }
        private void AddBookForm_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Fillcombobox(myDB);

            this.Text = "추가";
            this.txtTitle.Text = "도서 추가";
            if (flag == "modify")//수정시
            {
                this.Text = "수정";
                this.txtTitle.Text = "도서 수정";
                DataSet myDS = myDB.ModifyBook(_bookisbn);
                DataTable myDT = myDS.Tables[0];
                this.txtBookIsbn.Text = _bookisbn;
                this.txtBookIsbn.ReadOnly = true;
                this.txtBookName.Text = _bookname;
                this.txtBookName.ReadOnly = true;
                foreach (DataRow row in myDT.Rows)
                {
                    this.txtBookWriter.Text = row["book_writer"] + "";
                    this.txtBookPub.Text = row["book_publisher"] + "";
                    this.txtBookPubYear.Text = row["book_pubyear"] + "";
                    this.txtBookPage.Text = row["book_page"] + "";
                    this.txtBookCount.Text = row["book_count"] + "";
                    if (cboBookCate.Items.Contains(myDB.CateCodeToName(row["category_no"] + "")))
                    {
                        cboBookCate.SelectedItem = myDB.CateCodeToName(row["category_no"] + "");
                    }

                }
            }
        }
        private void Fillcombobox(MyDB myDB)
        {
            DataSet majorDS = myDB.CategoryCodeList();
            DataTable majorDT = majorDS.Tables[0];
            foreach (DataRow row in majorDT.Rows)
            {
                this.cboBookCate.Items.Add(row["category_name"]);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            ArrayList formData = new ArrayList();
            formData.Add(this.txtBookIsbn.Text);//0
            formData.Add(this.txtBookName.Text);//1
            formData.Add(this.txtBookWriter.Text);//2
            formData.Add(this.txtBookPub.Text);//3
            formData.Add(this.txtBookPubYear.Text);//4
            formData.Add(this.txtBookPage.Text);//5
            formData.Add(this.txtBookCount.Text);//6
            formData.Add(this.cboBookCate.SelectedItem + "");//7

            if (this.txtBookIsbn.Text.Trim() == "" || this.txtBookName.Text.Trim() == "")
            {
                MessageBox.Show($"ISBN, 도서명 은 필수 값 입니다.", "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (this.txtBookIsbn.Text.Trim() == "")
                    this.txtBookIsbn.Focus();
                else if (this.txtBookName.Text.Trim() == "")
                    this.txtBookName.Focus();
            }
            else if (flag == "modify")//수정시
            {
                int modifyVal = myDB.ModifyBookService(formData);
                if (modifyVal == 0)
                {
                    MessageBox.Show($"수정 실패!", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"수정 완료!", "수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            else//추가시
            {
                int insertVal = myDB.InsertBookService(formData);
                if (insertVal == 0)
                {
                    MessageBox.Show($"추가 실패!", "추가 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"추가 완료!", "추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();

                }
            }

        }

        private void txtBookIsbn_TextChanged(object sender, EventArgs e)
        {
            
            Int64 value = 0;
            //입력받은 값이 double 형으로 변환활 수 있는 지 확인
            if (Int64.TryParse(this.txtBookIsbn.Text, out value) == false)
            {
                //변환할 수 없으면 이전 텍스트 값으로 재 설정
                this.txtBookIsbn.Text = prevText[0];
                //커서 위치를 텍스트의 제일 마지막으로 위치시킴
                this.txtBookIsbn.Select(this.txtBookIsbn.Text.Length, 0);
            }
            else
            {
                //변환할 수 있으면 현재 값을 이전 값으로 저장해 둠.
                prevText[0] = this.txtBookIsbn.Text;
            }
        }

        private void txtBookPubYear_TextChanged(object sender, EventArgs e)
        {
            Int64 value = 0;
            //입력받은 값이 double 형으로 변환활 수 있는 지 확인
            if (Int64.TryParse(this.txtBookPubYear.Text, out value) == false)
            {
                //변환할 수 없으면 이전 텍스트 값으로 재 설정
                this.txtBookPubYear.Text = prevText[1];
                //커서 위치를 텍스트의 제일 마지막으로 위치시킴
                this.txtBookPubYear.Select(this.txtBookPubYear.Text.Length, 0);
            }
            else
            {
                //변환할 수 있으면 현재 값을 이전 값으로 저장해 둠.
                prevText[1] = this.txtBookPubYear.Text;
            }
        }

        private void txtBookPage_TextChanged(object sender, EventArgs e)
        {
            Int64 value = 0;
            //입력받은 값이 double 형으로 변환활 수 있는 지 확인
            if (Int64.TryParse(this.txtBookPage.Text, out value) == false)
            {
                //변환할 수 없으면 이전 텍스트 값으로 재 설정
                this.txtBookPage.Text = prevText[2];
                //커서 위치를 텍스트의 제일 마지막으로 위치시킴
                this.txtBookPage.Select(this.txtBookPage.Text.Length, 0);
            }
            else
            {
                //변환할 수 있으면 현재 값을 이전 값으로 저장해 둠.
                prevText[2] = this.txtBookPage.Text;
            }
        }

        private void txtBookCount_TextChanged(object sender, EventArgs e)
        {
            Int64 value = 0;
            //입력받은 값이 double 형으로 변환활 수 있는 지 확인
            if (Int64.TryParse(this.txtBookCount.Text, out value) == false)
            {
                //변환할 수 없으면 이전 텍스트 값으로 재 설정
                this.txtBookCount.Text = prevText[3];
                //커서 위치를 텍스트의 제일 마지막으로 위치시킴
                this.txtBookCount.Select(this.txtBookCount.Text.Length, 0);
            }
            else
            {
                //변환할 수 있으면 현재 값을 이전 값으로 저장해 둠.
                prevText[3] = this.txtBookCount.Text;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
