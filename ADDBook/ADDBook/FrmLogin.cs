﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ADDBook
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private OleDbConnection LocalConn;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbDataReader myReader;
            string sql = null;
            try
            {
                LocalConn = Common_DB.DBConnection();
                LocalConn.Open();

                if(txtID.Text =="" || txtPWD.Text == "")
                {
                    MessageBox.Show("ID 또는 Password를 입력하세요.");
                    return;
                }

                sql = "select pwd from member";
                sql += " where id = " + "'" + txtID.Text + "'";

                myReader = Common_DB.DataSelect(sql, LocalConn);

                if (myReader.Read())
                {
                    if(txtPWD.Text != myReader["pwd"].ToString())
                    {
                        MessageBox.Show("Password가 맞지 않습니다.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("등록되지 않은 ID 입니다.");
                    return;
                }

                FrmMDIMain m = new FrmMDIMain();
                m.Show();
                this.Hide();
                Log.WriteLine("FrmLogin", "[로그인 : " + txtID.Text + " ]");
            }
            catch (Exception e1)
            {
                Log.WriteLine("FrmLogin", e1.ToString());
                Log.WriteLine("FrmLogin", sql);
                MessageBox.Show("FrmLogin", "로그인 오류!" + sql);
            }
        }

        private void txtPWD_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
