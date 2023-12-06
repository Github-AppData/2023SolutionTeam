namespace Kiosk
{
    partial class Form4
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
            this.listView = new System.Windows.Forms.ListView();
            this.menuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRevise = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.crudtext = new System.Windows.Forms.TextBox();
            this.crudtext2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crudCombo = new System.Windows.Forms.ComboBox();
            this.selectkindof = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menuName,
            this.menuPrice});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 56);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(259, 393);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
            // 
            // menuName
            // 
            this.menuName.Text = "name";
            this.menuName.Width = 165;
            // 
            // menuPrice
            // 
            this.menuPrice.Text = "price";
            this.menuPrice.Width = 188;
            // 
            // btnRevise
            // 
            this.btnRevise.Location = new System.Drawing.Point(194, 159);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(75, 30);
            this.btnRevise.TabIndex = 2;
            this.btnRevise.Text = "수정";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(269, 44);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 44);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // crudtext
            // 
            this.crudtext.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.crudtext.Location = new System.Drawing.Point(13, 53);
            this.crudtext.Name = "crudtext";
            this.crudtext.Size = new System.Drawing.Size(154, 26);
            this.crudtext.TabIndex = 7;
            this.crudtext.TextChanged += new System.EventHandler(this.crudtext_TextChanged);
            // 
            // crudtext2
            // 
            this.crudtext2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.crudtext2.Location = new System.Drawing.Point(82, 93);
            this.crudtext2.Name = "crudtext2";
            this.crudtext2.Size = new System.Drawing.Size(154, 26);
            this.crudtext2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "가격 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crudCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.crudtext2);
            this.groupBox2.Controls.Add(this.crudtext);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnRevise);
            this.groupBox2.Location = new System.Drawing.Point(298, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 215);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRUD";
            // 
            // crudCombo
            // 
            this.crudCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "coffee",
            "noncoffee",
            "desert"});
            this.crudCombo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.crudCombo.FormattingEnabled = true;
            this.crudCombo.Items.AddRange(new object[] {
            "coffee",
            "noncoffee",
            "desert"});
            this.crudCombo.Location = new System.Drawing.Point(13, 23);
            this.crudCombo.Name = "crudCombo";
            this.crudCombo.Size = new System.Drawing.Size(96, 24);
            this.crudCombo.TabIndex = 15;
            // 
            // selectkindof
            // 
            this.selectkindof.AutoCompleteCustomSource.AddRange(new string[] {
            "coffee",
            "noncoffee",
            "desert"});
            this.selectkindof.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectkindof.FormattingEnabled = true;
            this.selectkindof.Items.AddRange(new object[] {
            "coffee",
            "noncoffee",
            "desert"});
            this.selectkindof.Location = new System.Drawing.Point(12, 12);
            this.selectkindof.Name = "selectkindof";
            this.selectkindof.Size = new System.Drawing.Size(96, 27);
            this.selectkindof.TabIndex = 15;
            this.selectkindof.UseWaitCursor = true;
            this.selectkindof.SelectedIndexChanged += new System.EventHandler(this.selectkindof_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.selectkindof);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox crudtext;
        private System.Windows.Forms.TextBox crudtext2;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox crudCombo;
        private System.Windows.Forms.ColumnHeader menuName;
        private System.Windows.Forms.ColumnHeader menuPrice;
        private System.Windows.Forms.ComboBox selectkindof;
    }
}