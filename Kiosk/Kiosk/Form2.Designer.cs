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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listName,
            this.listPrice,
            this.listCount});
            this.listView1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(441, 392);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ 1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(12, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "- 1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(130, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(323, 76);
            this.button4.TabIndex = 1;
            this.button4.Text = "카카오페이 결제";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(12, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 76);
            this.button3.TabIndex = 1;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(130, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(323, 76);
            this.button5.TabIndex = 1;
            this.button5.Text = "카드 결제";
            this.button5.UseVisualStyleBackColor = false;
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
            this.listCount.Width = 146;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(479, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 76);
            this.button6.TabIndex = 1;
            this.button6.Text = "이전";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(558, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 76);
            this.button7.TabIndex = 1;
            this.button7.Text = "다음";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(637, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 76);
            this.button8.TabIndex = 1;
            this.button8.Text = "종류 1";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(795, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 76);
            this.button9.TabIndex = 1;
            this.button9.Text = "종류 2";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(953, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(152, 76);
            this.button10.TabIndex = 1;
            this.button10.Text = "종류 3";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(479, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(152, 113);
            this.button11.TabIndex = 1;
            this.button11.Text = "메뉴 1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.Location = new System.Drawing.Point(637, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(152, 113);
            this.button12.TabIndex = 1;
            this.button12.Text = "메뉴 2";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(795, 94);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(152, 113);
            this.button13.TabIndex = 1;
            this.button13.Text = "메뉴 3";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(953, 94);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(152, 113);
            this.button14.TabIndex = 1;
            this.button14.Text = "메뉴 4";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.Location = new System.Drawing.Point(479, 213);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(152, 113);
            this.button15.TabIndex = 1;
            this.button15.Text = "메뉴 5";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button16.Location = new System.Drawing.Point(637, 213);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(152, 113);
            this.button16.TabIndex = 1;
            this.button16.Text = "메뉴 6";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(795, 213);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(152, 113);
            this.button17.TabIndex = 1;
            this.button17.Text = "메뉴 7";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.Location = new System.Drawing.Point(953, 213);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(152, 113);
            this.button18.TabIndex = 1;
            this.button18.Text = "메뉴 8";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button19.Location = new System.Drawing.Point(479, 332);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(152, 113);
            this.button19.TabIndex = 1;
            this.button19.Text = "메뉴 9";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button20.Location = new System.Drawing.Point(637, 332);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(152, 113);
            this.button20.TabIndex = 1;
            this.button20.Text = "메뉴 10";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button21.Location = new System.Drawing.Point(795, 332);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(152, 113);
            this.button21.TabIndex = 1;
            this.button21.Text = "메뉴 11";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button22.Location = new System.Drawing.Point(953, 332);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(152, 113);
            this.button22.TabIndex = 1;
            this.button22.Text = "메뉴 12";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button23.Location = new System.Drawing.Point(479, 451);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(152, 113);
            this.button23.TabIndex = 1;
            this.button23.Text = "메뉴 13";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button24.Location = new System.Drawing.Point(637, 451);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(152, 113);
            this.button24.TabIndex = 1;
            this.button24.Text = "메뉴 14";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button25.Location = new System.Drawing.Point(795, 451);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(152, 113);
            this.button25.TabIndex = 1;
            this.button25.Text = "메뉴 15";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button26.Location = new System.Drawing.Point(953, 451);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(152, 113);
            this.button26.TabIndex = 1;
            this.button26.Text = "메뉴 16";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 589);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form2";
            this.Text = "키오스크";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listPrice;
        private System.Windows.Forms.ColumnHeader listCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
    }
}