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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form2 인스턴스 생성
            Form2 form2 = new Form2();

            // Form2를 모달로 띄우기 (다른 폼과 상호작용이 불가능한 모달 형태)
            form2.ShowDialog();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
