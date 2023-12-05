using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                                                    "Database=PointOfSalesDB;" +
                                                    "Uid=root;" +
                                                    "Pwd=1234;");

        int sum = 0;

        string quantityStringValue;
        ListViewItem clickedItem;
        // "수량" 컬럼의 인덱스를 지정 (예를 들어, 3번째 컬럼이라면 2를 사용)
        int quantityColumnIndex = 1;

        // 리스트뷰에서 "가격" 컬럼의 모든 값 가져오기
        List<int> prices = new List<int>();

        // "가격" 컬럼의 인덱스를 지정 (예를 들어, 2번째 컬럼이라면 1을 사용)
        int priceColumnIndex = 2;


        MySqlCommand cmd;
        string kindname = "coffee";
        
        // 폼이 표시되기 이 전에 발생한다.
        // - 데이터를 셋 하는 과정
        private void Form2_Load(object sender, EventArgs e)
        {
            sum = 0;
            string menuAllselectQuery = "select name from coffee order by idx;";
            conn.Open();

            try
            {
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

                table.Close();

                // kindOf_1btn, kindOf_2btn, kindOf_3btn Setting
                kindOf_1btn.Text = "coffee";
                kindOf_2btn.Text = "noncoffee";
                kindOf_3btn.Text = "desert";
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            

        }

        public Form2()
        {
            InitializeComponent();
        }
        
        private void btn_click(object sender, EventArgs e)
        {
            // 이벤트가 발생한 버튼을 확인합니다.
            Button clickedButton = sender as Button;
            string menuNameselectQuery = "select name, quantity, price from "+ kindname+" where name = @name;";

            try
            {
                conn.Open();
                // MySqlCommand에 매개변수 추가
                using (MySqlCommand cmd2 = new MySqlCommand(menuNameselectQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("@name", clickedButton.Text);

                    Console.WriteLine(clickedButton.Text);
                    
                    using(MySqlDataReader table = cmd2.ExecuteReader())
                    {
                        // 여러 값을 저장할 리스트
                        List<string[]> listViewItems = new List<string[]>();
                        listViewItems.Clear();
                        

                        while (table.Read())
                        {
                            string nameValue = "";
                            string quanValue = "";
                            string priceValue = "";
                            nameValue = table["name"].ToString();
                            // Console.WriteLine("nameValue : " + nameValue);
                            quanValue = table["quantity"].ToString();
                            priceValue = table["price"].ToString();
                            
                                try
                                {
                                    // 각각의 값을 배열에 저장
                                    var listViewArray = new string[] { nameValue, quanValue, priceValue };

                                    // ListViewItem 생성 및 각 컬럼 값 추가
                                    var listViewItem = new ListViewItem(listViewArray);

                                    // ListView에 아이템 추가
                                    OrderListView.Items.Add(listViewItem);

                                    
                                    foreach (ListViewItem item in OrderListView.Items)
                                    {
                                        // 컬럼 인덱스를 사용하여 값을 가져오기
                                        var price2Value = Convert.ToInt32(item.SubItems[priceColumnIndex].Text);
                                        sum += price2Value;

                                        // 리스트에 값 추가
                                        //prices.Add(price2Value);

                                        Console.WriteLine("sum : " + sum);

                                        txtbox.Text = Convert.ToString(sum);

                                    }
                                } 
                                catch (ArgumentOutOfRangeException ex)
                                {
                                    // 예외 처리 로직
                                    Console.WriteLine($"ListView에 아이템 추가 중 오류: {ex.Message}");
                                }
                              
                        }
                        table.Close();
                    }
                }
               
            }
            catch (MySqlException)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        private void kindof2_btn_click(object sender, EventArgs e)
        {
            kindname = "noncoffee";
            string menuAllnoncoffeeselectQuery = "select name from noncoffee order by idx;";
            Console.WriteLine(kindname);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllnoncoffeeselectQuery, conn);
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

                table.Close();

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }


        private void kindof3_btn_click(object sender, EventArgs e)
        {
            string menuAllDesertselectQuery = "select name from desert order by idx;";
            kindname = "desert";
            Console.WriteLine(kindname);

            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllDesertselectQuery, conn);
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

                table.Close();

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        private void kindof1_btn_click(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select name from coffee order by idx;";
            conn.Open();

            kindname = "coffee";
            Console.WriteLine(kindname);

            try
            {
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

                        // 다음 버튼을 위해 인덱스 증가
                        buttonIndex++;
                    }
                }
            }
            catch(MySqlException)
            {

            }finally
            {
                conn.Close();
            }
            
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            sum = 0;
            OrderListView.Items.Clear();
        }

        private void OrderListView_MouseDown(object sender, MouseEventArgs e)
        {
            // 마우스 오른쪽 버튼 클릭인지 확인
            if (e.Button == MouseButtons.Left)
            {
                // 마우스 클릭한 위치의 아이템과 서브아이템 인덱스 가져오기
                clickedItem = OrderListView.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    // 컬럼 인덱스를 사용하여 값을 가져오기
                    quantityStringValue = clickedItem.SubItems[quantityColumnIndex].Text;
                }
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            // 문자열을 int로 변환
            if (int.TryParse(quantityStringValue, out int currentQuantity))
            {
                // 현재 수량 값 증가
                currentQuantity++;

                // 증가된 값을 다시 리스트뷰에 할당
                clickedItem.SubItems[quantityColumnIndex].Text = currentQuantity.ToString();
            }
            else
            {
                // 변환 실패 시 처리 (예를 들어, 로그 출력 또는 다른 예외 처리)
                Console.WriteLine($"수량 값을 int로 변환할 수 없습니다: {quantityStringValue}");
            }
        }

        private void Minusbtn_Click(object sender, EventArgs e)
        {
            // 문자열을 int로 변환
            if (int.TryParse(quantityStringValue, out int currentQuantity))
            {
                // 현재 수량 값 감소
                currentQuantity--;

                // 증가된 값을 다시 리스트뷰에 할당
                clickedItem.SubItems[quantityColumnIndex].Text = currentQuantity.ToString();
            }
            else
            {
                // 변환 실패 시 처리 (예를 들어, 로그 출력 또는 다른 예외 처리)
                Console.WriteLine($"수량 값을 int로 변환할 수 없습니다: {quantityStringValue}");
            }
        }
    }
}
