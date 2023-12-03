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
        string user_pwd_chk;
        string user_name;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_id = this.Box_id.Text;
            user_pwd = this.Box_pwd.Text;
            user_pwd_chk = this.Box_pwdchk.Text;
            user_name = this.Box_name.Text;

            if(user_pwd == user_pwd_chk)
            {
                
            }
        }
    }
}
