using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form3 : Form
    {
        // Mysql 관련 설정
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;" +
                                                    "Database=PointOfSalesDB;" +
                                                    "Uid=root;" +
                                                    "Pwd=1234;");

        string user_id;
        string user_pwd ;
        string user_pwdchk;
        string user_name;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_id = this.Box_id.Text;
            user_pwd = this.Box_pwd.Text;
            user_pwdchk = this.Box_pwdchk.Text;
            user_name = this.Box_name.Text;

            try
            {
                string insertQuery = "insert into user(user_id,user_password,user_name) values ('" + user_id + "', '" + user_pwd + "', '" + user_name + "')";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                if (user_pwd != user_pwdchk)
                {
                    MessageBox.Show("비밀번호와 비밀번호 확인의 값이 동일하지 않습니다.");
                }
                else
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.");
                        conn.Close();
                        Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
