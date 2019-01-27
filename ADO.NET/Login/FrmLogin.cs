using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        private OleDbConnection LocalConn;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataReader myReader;
            string sql = null;

            try
            {
                LocalConn = Common_DB.DBConnection();
                LocalConn.Open();

                if(txtID.Text == "" || txtPWD.Text == "")
                {
                    MessageBox.Show("ID 또는 Password를 입력 하세요...");
                    return;
                }
                //sql = "select pwd from member ";
                //sql += " where id = " + "'" + txtID.Text + "'";

                sql = "select pwd from member ";
                sql += " where id = ? ";

                myReader = Common_DB.DataSelect(txtID.Text, sql, LocalConn);

                if (myReader.Read())
                {
                    if(txtPWD.Text != myReader["pwd"].ToString())
                    {
                        MessageBox.Show("Password가 맞지 않습니다...");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("등록되지 않은 ID 입니다.");
                    return;
                }

                // ID가 PWD가 맞는 경우
                Form f = new Form();
                f.Text = "로그인 OK";
                f.ShowDialog();
            }

            catch(Exception e1)
            {
                Log.WriteLine("FrmLogin", e1.ToString());
                MessageBox.Show(e1.ToString() + sql, "FrmLogin :: 로그인오류!");
            }
        }

        //패스워드를 입력하고 엔터키를 입력해도 로그인 되도록...
        private void txtPWD_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
