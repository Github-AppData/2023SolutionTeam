using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kiosk
{
    public partial class Form2 : Form
    {
        // Mysql 관련 설정
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;" +
                                                    "Database=PointOfSalesDB" +
                                                    "Uid=YUHAN" +
                                                    "Pwd=1234");

        // 폼이 표시되기 이 전에 발생한다.
        // - 데이터를 셋 하는 과정
        private void Form2_Load(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select name from coffee order by idx;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            int buttonIndex = 1;

            // 데이터가 없을 때까지 Read 된다.
            while (table.Read())
            {
                // 기존에 만들어진 버튼을 찾음
                Button btn = this.Controls.Find("btn" + buttonIndex.ToString(), true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    // 버튼 텍스트 설정
                    btn.Text = table["name"].ToString();

                    // 버튼 이벤트 핸들러 등록
                    btn.Click += new EventHandler(btn_click);

                    // 다음 버튼을 위해 인덱스 증가
                    buttonIndex++;
                }
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_click(object sender, EventArgs e)
        {

        }
    }
}
