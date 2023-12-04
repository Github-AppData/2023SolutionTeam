using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kiosk.DES;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        // Mysql 관련 설정
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;" +
                                                    "Database=PointOfSalesDB;" +
                                                    "Uid=root;" +
                                                    "Pwd=1234;");

        DES des = new DES("qwerasdf");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form2 인스턴스 생성
            //Form2 form2 = new Form2();

            // Form2를 모달로 띄우기 (다른 폼과 상호작용이 불가능한 모달 형태)
           // form2.ShowDialog();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.id_Box.Text;
            string pwd = this.pwd_Box.Text;

            // 로그인 상태 변수 선언, 비로그인 상태는 0
            int login_status = 0;

            if (id == "" || pwd == "")
            {
                MessageBox.Show("아이디 또는 비밀번호가 입력되지 않았습니다.");
            }
            else
            {
                pwd = des.result(DesType.Encrypt, pwd);
                string searchQuery = "select * from user where user_id = '" +  id + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(searchQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    if (id == table["user_id"].ToString() && pwd == table["user_password"].ToString())
                    {
                        login_status = 1;
                    }
                }
                conn.Close();

                if(login_status == 1)
                {
                    MessageBox.Show("로그인에 성공하였습니다.");
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                    Close();
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다.");
                }
            }
        }
    }
}
