namespace Kiosk
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderListView = new System.Windows.Forms.ListView();
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlusBtn = new System.Windows.Forms.Button();
            this.Minusbtn = new System.Windows.Forms.Button();
            this.kakaPaybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.CardPaybtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.fowardbtn = new System.Windows.Forms.Button();
            this.kindOf_1btn = new System.Windows.Forms.Button();
            this.kindOf_2btn = new System.Windows.Forms.Button();
            this.kindOf_3btn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderListView
            // 
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listName,
            this.listPrice,
            this.listCount});
            this.OrderListView.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderListView.GridLines = true;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(12, 185);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(441, 392);
            this.OrderListView.TabIndex = 0;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.View = System.Windows.Forms.View.Details;
            this.OrderListView.SelectedIndexChanged += new System.EventHandler(this.OrderListView_SelectedIndexChanged);
            // 
            // listName
            // 
            this.listName.Text = "상품 이름";
            this.listName.Width = 180;
            // 
            // listPrice
            // 
            this.listPrice.Text = "가격";
            this.listPrice.Width = 111;
            // 
            // listCount
            // 
            this.listCount.Text = "수량";
            this.listCount.Width = 164;
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusBtn.ForeColor = System.Drawing.Color.White;
            this.PlusBtn.Location = new System.Drawing.Point(12, 12);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(99, 35);
            this.PlusBtn.TabIndex = 1;
            this.PlusBtn.Text = "+ 1";
            this.PlusBtn.UseVisualStyleBackColor = false;
            // 
            // Minusbtn
            // 
            this.Minusbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.Minusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minusbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minusbtn.ForeColor = System.Drawing.Color.White;
            this.Minusbtn.Location = new System.Drawing.Point(12, 53);
            this.Minusbtn.Name = "Minusbtn";
            this.Minusbtn.Size = new System.Drawing.Size(99, 35);
            this.Minusbtn.TabIndex = 1;
            this.Minusbtn.Text = "- 1";
            this.Minusbtn.UseVisualStyleBackColor = false;
            // 
            // kakaPaybtn
            // 
            this.kakaPaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.kakaPaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kakaPaybtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kakaPaybtn.ForeColor = System.Drawing.Color.White;
            this.kakaPaybtn.Location = new System.Drawing.Point(130, 12);
            this.kakaPaybtn.Name = "kakaPaybtn";
            this.kakaPaybtn.Size = new System.Drawing.Size(323, 76);
            this.kakaPaybtn.TabIndex = 1;
            this.kakaPaybtn.Text = "카카오페이 결제";
            this.kakaPaybtn.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(11, 101);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(99, 76);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "삭제";
            this.Deletebtn.UseVisualStyleBackColor = false;
            // 
            // CardPaybtn
            // 
            this.CardPaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.CardPaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardPaybtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardPaybtn.ForeColor = System.Drawing.Color.White;
            this.CardPaybtn.Location = new System.Drawing.Point(129, 101);
            this.CardPaybtn.Name = "CardPaybtn";
            this.CardPaybtn.Size = new System.Drawing.Size(323, 76);
            this.CardPaybtn.TabIndex = 1;
            this.CardPaybtn.Text = "카드 결제";
            this.CardPaybtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backbtn.Location = new System.Drawing.Point(479, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(71, 76);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "이전";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // fowardbtn
            // 
            this.fowardbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.fowardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fowardbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fowardbtn.Location = new System.Drawing.Point(83, 7);
            this.fowardbtn.Name = "fowardbtn";
            this.fowardbtn.Size = new System.Drawing.Size(71, 76);
            this.fowardbtn.TabIndex = 1;
            this.fowardbtn.Text = "다음";
            this.fowardbtn.UseVisualStyleBackColor = false;
            // 
            // kindOf_1btn
            // 
            this.kindOf_1btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kindOf_1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kindOf_1btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kindOf_1btn.Location = new System.Drawing.Point(169, 8);
            this.kindOf_1btn.Name = "kindOf_1btn";
            this.kindOf_1btn.Size = new System.Drawing.Size(145, 76);
            this.kindOf_1btn.TabIndex = 1;
            this.kindOf_1btn.Text = "종류 1";
            this.kindOf_1btn.UseVisualStyleBackColor = false;
            this.kindOf_1btn.Click += new System.EventHandler(this.kindof1_btn_click);
            // 
            // kindOf_2btn
            // 
            this.kindOf_2btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kindOf_2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kindOf_2btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kindOf_2btn.Location = new System.Drawing.Point(329, 8);
            this.kindOf_2btn.Name = "kindOf_2btn";
            this.kindOf_2btn.Size = new System.Drawing.Size(145, 76);
            this.kindOf_2btn.TabIndex = 1;
            this.kindOf_2btn.Text = "종류 2";
            this.kindOf_2btn.UseVisualStyleBackColor = false;
            this.kindOf_2btn.Click += new System.EventHandler(this.kindof2_btn_click);
            // 
            // kindOf_3btn
            // 
            this.kindOf_3btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kindOf_3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kindOf_3btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kindOf_3btn.Location = new System.Drawing.Point(489, 8);
            this.kindOf_3btn.Name = "kindOf_3btn";
            this.kindOf_3btn.Size = new System.Drawing.Size(145, 76);
            this.kindOf_3btn.TabIndex = 1;
            this.kindOf_3btn.Text = "종류 3";
            this.kindOf_3btn.UseVisualStyleBackColor = false;
            this.kindOf_3btn.Click += new System.EventHandler(this.kindof3_btn_click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Azure;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(9, 96);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(145, 105);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "메뉴 1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Azure;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(169, 96);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(145, 105);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "메뉴 2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Azure;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(329, 96);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(145, 105);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "메뉴 3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Azure;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(489, 96);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(145, 105);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "메뉴 4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Azure;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(9, 216);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(145, 105);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "메뉴 5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Azure;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(169, 216);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(145, 105);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "메뉴 6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Azure;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(329, 216);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(145, 105);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "메뉴 7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Azure;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(489, 216);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(145, 105);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "메뉴 8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Azure;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(9, 336);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(145, 105);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "메뉴 9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Azure;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn10.Location = new System.Drawing.Point(169, 336);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(145, 105);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "메뉴 10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn_click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.Azure;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn11.Location = new System.Drawing.Point(329, 336);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(145, 105);
            this.btn11.TabIndex = 1;
            this.btn11.Text = "메뉴 11";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn_click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.Azure;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn12.Location = new System.Drawing.Point(489, 336);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(145, 105);
            this.btn12.TabIndex = 1;
            this.btn12.Text = "메뉴 12";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn_click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.Azure;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn13.Location = new System.Drawing.Point(9, 456);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(145, 105);
            this.btn13.TabIndex = 1;
            this.btn13.Text = "메뉴 13";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btn_click);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.Azure;
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn14.Location = new System.Drawing.Point(169, 456);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(145, 105);
            this.btn14.TabIndex = 1;
            this.btn14.Text = "메뉴 14";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btn_click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.Azure;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn15.Location = new System.Drawing.Point(329, 456);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(145, 105);
            this.btn15.TabIndex = 1;
            this.btn15.Text = "메뉴 15";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn_click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.Azure;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn16.Location = new System.Drawing.Point(489, 456);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(145, 105);
            this.btn16.TabIndex = 1;
            this.btn16.Text = "메뉴 16";
            this.btn16.UseVisualStyleBackColor = false;
            this.btn16.Click += new System.EventHandler(this.btn_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.kindOf_3btn);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.kindOf_2btn);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.kindOf_1btn);
            this.panel2.Controls.Add(this.btn12);
            this.panel2.Controls.Add(this.fowardbtn);
            this.panel2.Controls.Add(this.btn16);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn13);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn10);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn14);
            this.panel2.Controls.Add(this.btn11);
            this.panel2.Controls.Add(this.btn15);
            this.panel2.Location = new System.Drawing.Point(469, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 573);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(120, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 157);
            this.panel3.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.CardPaybtn);
            this.Controls.Add(this.kakaPaybtn);
            this.Controls.Add(this.Minusbtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "키오스크";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listPrice;
        private System.Windows.Forms.ColumnHeader listCount;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button Minusbtn;
        private System.Windows.Forms.Button kakaPaybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button CardPaybtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button fowardbtn;
        private System.Windows.Forms.Button kindOf_1btn;
        private System.Windows.Forms.Button kindOf_2btn;
        private System.Windows.Forms.Button kindOf_3btn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}