using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SchoolLibraryManager
{
    class MyDB
    {
        private string con_str = "";

        public MyDB()
        {
            DBInfo dbinfo = new DBInfo();
            con_str = dbinfo.Con_str;//클래스로부터 DB정보 가져옴 (DB정보 숨김)
        }

        public void loginCheck(String userId, String userPassword)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT * FROM login WHERE userid = '{userId}' AND userpw = '{userPassword}'", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            //rdr.Read();
            String loginSuc = null;
            while (rdr.Read())
            {
               loginSuc = rdr["userid"] as String;
            }

            if( loginSuc == null)
            {
                LoginFlag.flagUserBool = false;
            }
            else
            {
                LoginFlag.flagUserBool = true;
                LoginFlag.flagUserId = loginSuc;
            }

            conn.Dispose();
            conn.Close();

            //return loginSuc;

        }

        public int StudentCount(int register)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();

            Int32 count = 0;

            if (register == 0)//모든 학생 수
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM student", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if(register == 1)//재학중
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM student Where regi_code = 1", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if (register == 2)//휴학중
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM student Where regi_code = 2", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if (register == 3)//졸업
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM student Where regi_code = 3", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if (register == 4)//제적
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM student Where regi_code = 4", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            conn.Dispose();
            conn.Close();

            return count;

        }
        public ArrayList StudentListItem()
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT * FROM student", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt32(0) +"",
                    rdr["stu_name"] as string,
                    rdr.GetDateTime(2).ToString("yyyy/MM/dd"),
                    rdr["stu_gender"] as string,
                    rdr["stu_phone"] as string,
                    rdr["stu_zip"] as string,
                    rdr["stu_email"] as string,
                    rdr.GetDateTime(7).ToString("yyyy/MM/dd"),
                    rdr["stu_lcnt"] as string,
                    rdr["stu_lsum"] as string,
                    rdr["stu_odcnt"] as string,
                    rdr["stu_odsum"] as string,
                    rdr["stu_pex"] as string,
                    rdr["major_code"] as string,
                    rdr["regi_code"] as string
                };

                lvt = new ListViewItem(strArray);
                
                lvtList.Add(lvt);
            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }
        public ArrayList SearchStudent(String par)
        {
            int intpar;
            String sql;
            if(int.TryParse(par, out intpar))
            {
                sql = $"SELECT * FROM student WHERE regexp_like(stu_id,'{intpar}')";
            }
            else
            {
                sql = $"SELECT * FROM student WHERE regexp_like(stu_name,'{par}')";
            }
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql,conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt32(0) +"",
                    rdr["stu_name"] as string,
                    rdr.GetDateTime(2).ToString("yyyy/MM/dd"),
                    rdr["stu_gender"] as string,
                    rdr["stu_phone"] as string,
                    rdr["stu_zip"] as string,
                    rdr["stu_email"] as string,
                    rdr.GetDateTime(7).ToString("yyyy/MM/dd"),
                    rdr["stu_lcnt"] as string,
                    rdr["stu_lsum"] as string,
                    rdr["stu_odcnt"] as string,
                    rdr["stu_odsum"] as string,
                    rdr["stu_pex"] as string,
                    rdr["major_code"] as string,
                    rdr["regi_code"] as string
                };

                lvt = new ListViewItem(strArray);

                lvtList.Add(lvt);

            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }

        public int BookCount(int register)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();

            Int32 count = 0;

            if (register == 0)//모든 책 수
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM book", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if (register == 1)//대여중
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM loan", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else if (register == 2)//연체중
            {
                OracleCommand cmd = new OracleCommand($"SELECT COUNT(*) count FROM overdue", conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            conn.Dispose();
            conn.Close();

            return count;

        }

        public ArrayList BookListItem()
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT * FROM book", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr["BOOK_NAME"] as string,
                    rdr["BOOK_WRITER"] as string,
                    rdr["BOOK_PUBLISHER"] as string,
                    rdr.GetInt32(4) +"",
                    rdr.GetInt32(5) +"",
                    rdr.GetInt32(6) +"",
                    rdr["CATEGORY_NO"] as string,
                };

                lvt = new ListViewItem(strArray);

                lvtList.Add(lvt);
            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }
        public ArrayList SearchBook(String par)
        {
            int intpar;
            String sql;
            if (int.TryParse(par, out intpar))
            {
                sql = $"SELECT * FROM book WHERE regexp_like(book_isbn,'{intpar}')";
            }
            else
            {
                sql = $"SELECT * FROM book WHERE regexp_like(book_name,'{par}')";
            }
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr["BOOK_NAME"] as string,
                    rdr["BOOK_WRITER"] as string,
                    rdr["BOOK_PUBLISHER"] as string,
                    rdr.GetInt32(4) +"",
                    rdr.GetInt32(5) +"",
                    rdr.GetInt32(6) +"",
                    rdr["CATEGORY_NO"] as string,
                };

                lvt = new ListViewItem(strArray);

                lvtList.Add(lvt);

            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }
        public DataSet ModifyStudent(String userId)
        {
            int intpar;
            int.TryParse(userId, out intpar);
            DataSet ds = new DataSet();

            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT * FROM student WHERE stu_id = {intpar}", conn);
            adapter.Fill(ds);

            conn.Dispose();
            conn.Close();

            return ds;
        }
        public DataSet MajorCodeList()
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT * FROM major", conn);
            adapter.Fill(ds);

            conn.Dispose();
            conn.Close();

            return ds;
        }
        public DataSet RegiCodeList()
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT * FROM register", conn);
            adapter.Fill(ds);

            conn.Dispose();
            conn.Close();

            return ds;
        }
        public int ModifyStuService(ArrayList arrayList)
        {
            int i=0;
            int intpar;
            String gender;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            int.TryParse(arrayList[0]+"", out intpar);

            if (arrayList[3]+"" == "남")
            {
                gender = "M";
            }else
            {
                gender = "F";
            }

            OracleCommand cmd = new OracleCommand($"UPDATE student SET stu_birth=TO_DATE('{arrayList[2]}'), stu_gender='{gender}', stu_phone='{arrayList[4]}', stu_zip='{arrayList[5]}', stu_email='{arrayList[6]}', stu_admitdate=TO_DATE('{arrayList[7]}'), major_code = (select Major_code From Major WHERE major_name = '{arrayList[8]}'), regi_code = (select regi_code From register WHERE regi_name = '{arrayList[9]}') WHERE stu_id = {intpar}", conn);
            i = cmd.ExecuteNonQuery();
            

            return i;
        }
        public String RegiCodeToName(String regicode)
        {
            if (regicode == "")
            {
                return "";
            }
            String regi_name="";
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open(); 
            OracleCommand cmd = new OracleCommand($"SELECT regi_name FROM register WHERE regi_code = {regicode}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                regi_name = rdr["regi_name"] as string;

            }
            conn.Dispose();
            conn.Close();

            return regi_name;

        }
        public String MajorCodeToName(String majorcode)
        {
            if (majorcode == "")
            {
                return "";
            }
            String major_name = "";
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT major_name FROM major WHERE major_code = {majorcode}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                major_name = rdr["major_name"] as string;

            }
            conn.Dispose();
            conn.Close();

            return major_name;

        }
        public int InsertStuService(ArrayList arrayList)
        {
            int i = 0;
            int intpar;
            String gender;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            int.TryParse(arrayList[0] + "", out intpar);

            if (arrayList[3] + "" == "남")
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            OracleCommand cmd = new OracleCommand($"INSERT INTO student(stu_id,stu_name,stu_birth,stu_gender,stu_phone,stu_zip,stu_email,stu_admitdate,major_code,regi_code) " +
                $"VALUES ({intpar},'{arrayList[1]}',TO_DATE('{arrayList[2]}'), '{gender}', '{arrayList[4]}', '{arrayList[5]}', '{arrayList[6]}', TO_DATE('{arrayList[7]}'), (select Major_code From Major WHERE major_name = '{arrayList[8]}'),(select regi_code From register WHERE regi_name = '{arrayList[9]}'))", conn);
            i = cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();

            return i;
        }
        public int deleteStuService(String userId,String userName)
        {
            int i=0;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            int.TryParse(userId + "", out int parId);

            OracleCommand cmd = new OracleCommand($"DELETE FROM student WHERE stu_id = {parId} AND stu_name = '{userName}'", conn);
            i = cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();

            return i;
        }

        public DataSet CategoryCodeList()
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT * FROM category", conn);
            adapter.Fill(ds);

            conn.Dispose();
            conn.Close();

            return ds;
        }
        public DataSet ModifyBook(String bookIsbn)
        {
            Int64 intpar;
            Int64.TryParse(bookIsbn, out intpar);
            DataSet ds = new DataSet();

            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT * FROM book WHERE book_isbn = {intpar}", conn);
            adapter.Fill(ds);

            conn.Dispose();
            conn.Close();

            return ds;
        }

        public String CateCodeToName(String catecode)
        {
            if (catecode == "")
            {
                return "";
            }
            String cate_name = "";
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT category_name FROM category WHERE category_no = '{catecode}'", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cate_name = rdr["category_name"] as string;

            }
            conn.Dispose();
            conn.Close();

            return cate_name;

        }
        public int ModifyBookService(ArrayList arrayList)
        {
            int i = 0;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(arrayList[0] + "", out Int64 intpar);
            Int64.TryParse(arrayList[4] + "", out Int64 pubpar);
            Int64.TryParse(arrayList[5] + "", out Int64 pagepar);
            Int64.TryParse(arrayList[6] + "", out Int64 countpar);

            OracleCommand cmd = new OracleCommand($"UPDATE book SET book_writer='{arrayList[2]}', book_publisher='{arrayList[3]}', book_pubyear={pubpar}, book_page={pagepar}, book_count={countpar},category_no = (select category_no From category WHERE category_name = '{arrayList[7]}') WHERE book_isbn = {intpar}", conn);
            i = cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();

            return i;
        }
        public int InsertBookService(ArrayList arrayList)
        {
            int i = 0;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(arrayList[0] + "", out Int64 intpar);
            Int64.TryParse(arrayList[4] + "", out Int64 pubpar);
            Int64.TryParse(arrayList[5] + "", out Int64 pagepar);
            Int64.TryParse(arrayList[6] + "", out Int64 countpar);


            OracleCommand cmd = new OracleCommand($"INSERT INTO book " +
                $"VALUES ({intpar},'{arrayList[1]}','{arrayList[2]}', '{arrayList[3]}', {pubpar}, {pagepar}, {countpar}, (select category_no From category WHERE category_name = '{arrayList[7]}'))", conn);
            i = cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();

            return i;
        }
        public int deleteBookService(String bookIsbn)
        {
            int i = 0;
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(bookIsbn + "", out Int64 parId);

            OracleCommand cmd = new OracleCommand($"DELETE FROM book WHERE book_isbn = {parId}", conn);
            i = cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();

            return i;
        }

        public DataSet loanCount(String stu_id)
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(con_str);
            Int64.TryParse(stu_id, out Int64 parId);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT COUNT(*) loancount FROM loan WHERE stu_id = {parId}", conn);
            adapter.Fill(ds);
            conn.Dispose();
            conn.Close();

            return ds;
        }
        public DataSet overCount(String stu_id)
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(con_str);
            Int64.TryParse(stu_id, out Int64 parId);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT COUNT(*) overcount FROM overdue WHERE stu_id = {parId}", conn);
            adapter.Fill(ds);
            conn.Dispose();
            conn.Close();

            return ds;
        }

        public ArrayList studentLibraryList(String stu_id)
        {
            OracleConnection conn = new OracleConnection(con_str);
            Int64.TryParse(stu_id, out Int64 parId);
            conn.Open();

            OracleCommand cmd = new OracleCommand($"SELECT l.loan_no no,l.book_isbn isbn,b.book_name name, l.loan_ldate ldate, l.loan_rdate rdate FROM loan l,book b WHERE l.book_isbn = b.book_isbn AND l.stu_id = {parId}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr.GetInt64(1) +"",
                    rdr["name"] as string,
                    rdr.GetDateTime(3).ToString("yyyy/MM/dd"),
                    rdr.GetDateTime(4).ToString("yyyy/MM/dd"),
                };

                lvt = new ListViewItem(strArray);

                lvtList.Add(lvt);
            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }
        public ArrayList BookListSubB()
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleCommand cmd = new OracleCommand($"SELECT * FROM book WHERE book_isbn NOT IN (SELECT book_isbn FROM loan)", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr["BOOK_NAME"] as string,
                    rdr["BOOK_WRITER"] as string,
                    rdr["BOOK_PUBLISHER"] as string,
                    rdr.GetInt32(4) +"",
                    rdr.GetInt32(5) +"",
                    rdr.GetInt32(6) +"",
                    rdr["CATEGORY_NO"] as string,
                };

                lvt = new ListViewItem(strArray);

                lvtList.Add(lvt);
            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }
        public ListViewItem SearchIsbnStu(String isbn)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(isbn, out Int64 parseisbn);
            OracleCommand cmd = new OracleCommand($"SELECT * FROM book WHERE book_isbn = {parseisbn}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr["BOOK_NAME"] as string,
                    rdr["BOOK_WRITER"] as string,
                    rdr["BOOK_PUBLISHER"] as string,
                    rdr.GetInt32(4) +"",
                    rdr.GetInt32(5) +"",
                    rdr.GetInt32(6) +"",
                    rdr["CATEGORY_NO"] as string,
                };
                lvt = new ListViewItem(strArray);
            }
            conn.Dispose();
            conn.Close();
            return lvt;
        }
        public ListViewItem SearchIsbnAll(String isbn)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(isbn, out Int64 parseisbn);
            OracleCommand cmd = new OracleCommand($"SELECT book_isbn isbn,book_name name FROM book WHERE book_isbn = {parseisbn}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    "+",
                    rdr.GetInt64(0) +"",
                    rdr["name"] as string,
                    "+",
                    "+",
                };

                lvt = new ListViewItem(strArray);
            }
            conn.Dispose();
            conn.Close();
            return lvt;
        }
        public ListViewItem cancleReturn(String isbn)
        {
            OracleConnection conn = new OracleConnection(con_str);
            Int64.TryParse(isbn, out Int64 parId);
            conn.Open();

            OracleCommand cmd = new OracleCommand($"SELECT l.loan_no no,l.book_isbn isbn,b.book_name name, l.loan_ldate ldate, l.loan_rdate rdate FROM loan l,book b WHERE l.book_isbn = b.book_isbn AND b.book_isbn = {parId}", conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            ListViewItem lvt = new ListViewItem();
            while (rdr.Read())
            {
                var strArray = new string[] {
                    rdr.GetInt64(0) +"",
                    rdr.GetInt64(1) +"",
                    rdr["name"] as string,
                    rdr.GetDateTime(3).ToString("yyyy/MM/dd"),
                    rdr.GetDateTime(4).ToString("yyyy/MM/dd"),
                };

                lvt = new ListViewItem(strArray);

            }
            conn.Dispose();
            conn.Close();
            return lvt;
        }

        public void libraryService(ArrayList borrowList, ArrayList returnList, String stu_id)
        {

            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(stu_id, out Int64 parseid);

            foreach (String m in borrowList)
            {
                Int64.TryParse(m, out Int64 parsem);
                OracleCommand cmd = new OracleCommand($"insert into loan values(Loan_no_seq.nextval,{parsem},sysdate,sysdate+7,{parseid})",conn);
                cmd.ExecuteNonQuery();
            }
            foreach (String m in returnList)
            {
                Int64.TryParse(m, out Int64 parsem);
                OracleCommand cmd = new OracleCommand($"DELETE FROM loan WHERE book_isbn = {parsem} AND stu_id = {parseid}", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Dispose();
            conn.Close();

        }
        public int checkBook(String book_isbn)
        {
            //MessageBox.Show($"{book_isbn}", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            int i=0;
            Int64.TryParse(book_isbn, out Int64 book__);
            Int64.TryParse(book_isbn.Trim(), out Int64 parseisbn);
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            OracleDataAdapter adapter = new OracleDataAdapter($"SELECT COUNT(*) FROM loan WHERE book_isbn = {book__}",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DataTable majorDT = ds.Tables[0];
            foreach (DataRow row in majorDT.Rows)
            {
                if (row["COUNT(*)"]+""!="0")
                {
                    i = 1;
                }
                
            }


            conn.Dispose();
            conn.Close();
            return i;
        }
        public ArrayList loanTOstu(String book_isbn)
        {
            OracleConnection conn = new OracleConnection(con_str);
            conn.Open();
            Int64.TryParse(book_isbn, out Int64 parseisbn);
            OracleCommand cmd = new OracleCommand($"SELECT stu_id,stu_name FROM student WHERE stu_id = (SELECT stu_id FROM loan WHERE book_isbn ={parseisbn})", conn);       
            OracleDataReader rdr = cmd.ExecuteReader();
            ArrayList lvtList = new ArrayList();
            while (rdr.Read())
            {
                lvtList.Add(rdr.GetInt64(0) +"");
                lvtList.Add(rdr["stu_name"] as string);
            }
            conn.Dispose();
            conn.Close();
            return lvtList;
        }

    }
}
