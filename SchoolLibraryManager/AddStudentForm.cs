﻿using System;
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
    public partial class AddStudentForm : Form
    {
        String _userId, _username;
        String flag;
        string[] prevText = Enumerable.Repeat("", 10).ToArray();
        public AddStudentForm()
        {
            InitializeComponent();
        }
        public AddStudentForm(String userid, String username)
        {
            _userId = userid;
            _username = username;
            flag = "modify";
            InitializeComponent();

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            
            Fillcombobox(myDB);

            this.Text = "추가";
            this.txtTitle.Text = "학생 추가";
            if (flag == "modify")//수정시
            {
                this.Text = "수정";
                this.txtTitle.Text = "학생 수정";
                DataSet myDS = myDB.ModifyStudent(_userId);
                DataTable myDT = myDS.Tables[0];
                this.txtStudentId.Text = _userId;
                this.txtStudentId.ReadOnly = true; 
                this.txtStudentName.Text = _username;
                this.txtStudentName.ReadOnly = true;
                foreach (DataRow row in myDT.Rows)
                {

                    this.dtpBirth.Value = (DateTime)row["stu_birth"];
                    if (row["stu_gender"] + "" == "M")
                    {
                        this.cboGender.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cboGender.SelectedIndex = 1;
                    }

                    this.txtPhone.Text = row["stu_phone"] + "";
                    this.txtZip.Text = row["stu_zip"] + "";
                    this.txtEmail.Text = row["stu_email"] + "";
                    this.dtpAdmit.Value = (DateTime)row["stu_admitdate"];

                    if (cboMajor.Items.Contains(myDB.MajorCodeToName(row["major_code"] + "")))
                    {
                        cboMajor.SelectedItem = myDB.MajorCodeToName(row["major_code"] + "");
                    }

                    if (cboRegi.Items.Contains(myDB.RegiCodeToName(row["regi_code"] + "")))
                    {
                        cboRegi.SelectedItem = myDB.RegiCodeToName(row["regi_code"] + "");
                    }

                }
            }

        }

        private void Fillcombobox(MyDB myDB)
        {
            DataSet majorDS = myDB.MajorCodeList();
            DataTable majorDT = majorDS.Tables[0];
            foreach (DataRow row in majorDT.Rows)
            {
                this.cboMajor.Items.Add(row["major_name"]);
            }

            DataSet regiDS = myDB.RegiCodeList();
            DataTable regiDT = regiDS.Tables[0];
            foreach (DataRow row in regiDT.Rows)
            {
                this.cboRegi.Items.Add(row["regi_name"]);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MyDB myDB = new MyDB();

                ArrayList formData = new ArrayList();
                formData.Add(this.txtStudentId.Text);//0
                formData.Add(this.txtStudentName.Text);//1
                formData.Add(this.dtpBirth.Value.ToString("yyyy-MM-dd"));//2
                formData.Add(this.cboGender.SelectedItem + "");//3
                formData.Add(this.txtPhone.Text);//4
                formData.Add(this.txtZip.Text);//5
                formData.Add(this.txtEmail.Text);//6
                formData.Add(this.dtpAdmit.Value.ToString("yyyy-MM-dd"));//7
                formData.Add(this.cboMajor.SelectedItem + "");//8
                formData.Add(this.cboRegi.SelectedItem + "");//9

                if (this.txtStudentId.Text.Trim() == "" || this.txtStudentName.Text.Trim() == "")
                {
                    MessageBox.Show($"학번, 이름 은 필수 값 입니다.", "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (this.txtStudentId.Text.Trim() == "")
                        this.txtStudentId.Focus();
                    else if (this.txtStudentName.Text.Trim() == "")
                        this.txtStudentName.Focus();
                }

                else if (flag == "modify")//수정시
                {
                    int modifyVal = myDB.ModifyStuService(formData);
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
                    int insertVal = myDB.InsertStuService(formData);
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
            catch
            {
                MessageBox.Show($"값을 확인해 주세요", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            Int64 value = 0;
            //입력받은 값이 double 형으로 변환활 수 있는 지 확인
            if (Int64.TryParse(this.txtStudentId.Text, out value) == false)
            {
                //변환할 수 없으면 이전 텍스트 값으로 재 설정
                this.txtStudentId.Text = prevText[0];
                //커서 위치를 텍스트의 제일 마지막으로 위치시킴
                this.txtStudentId.Select(this.txtStudentId.Text.Length, 0);
            }
            else
            {
                //변환할 수 있으면 현재 값을 이전 값으로 저장해 둠.
                prevText[0] = this.txtStudentId.Text;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
