namespace RentalSystem.UserForm
{
    partial class UserVIewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.warn_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "房  型:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "面积(m²):";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "租金(元):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "押金(元):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "地  址:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "简  介:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "时  间:";
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.type.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.type, 2);
            this.type.ForeColor = System.Drawing.Color.Blue;
            this.type.Location = new System.Drawing.Point(271, 94);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(61, 16);
            this.type.TabIndex = 8;
            this.type.Text = "label9";
            // 
            // rent
            // 
            this.rent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rent.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rent, 4);
            this.rent.ForeColor = System.Drawing.Color.Blue;
            this.rent.Location = new System.Drawing.Point(271, 184);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(70, 16);
            this.rent.TabIndex = 9;
            this.rent.Text = "label10";
            // 
            // area
            // 
            this.area.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.area.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.area, 4);
            this.area.ForeColor = System.Drawing.Color.Blue;
            this.area.Location = new System.Drawing.Point(271, 139);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(70, 16);
            this.area.TabIndex = 10;
            this.area.Text = "label11";
            // 
            // deposit
            // 
            this.deposit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deposit.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.deposit, 4);
            this.deposit.ForeColor = System.Drawing.Color.Blue;
            this.deposit.Location = new System.Drawing.Point(271, 229);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(70, 16);
            this.deposit.TabIndex = 11;
            this.deposit.Text = "label12";
            // 
            // addr
            // 
            this.addr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addr.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.addr, 4);
            this.addr.ForeColor = System.Drawing.Color.Blue;
            this.addr.Location = new System.Drawing.Point(271, 274);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(70, 16);
            this.addr.TabIndex = 12;
            this.addr.Text = "label13";
            // 
            // intro
            // 
            this.intro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.intro.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.intro, 4);
            this.intro.ForeColor = System.Drawing.Color.Blue;
            this.intro.Location = new System.Drawing.Point(271, 319);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(70, 16);
            this.intro.TabIndex = 13;
            this.intro.Text = "label14";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 2);
            this.label9.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(271, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "预约申请表";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(183, 398);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 32);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(511, 398);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 32);
            this.submit.TabIndex = 18;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // warn_label
            // 
            this.warn_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.warn_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.warn_label, 2);
            this.warn_label.ForeColor = System.Drawing.Color.Red;
            this.warn_label.Location = new System.Drawing.Point(511, 94);
            this.warn_label.Name = "warn_label";
            this.warn_label.Size = new System.Drawing.Size(0, 16);
            this.warn_label.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.type, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rent, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.area, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.deposit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.addr, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.intro, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.submit, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.warn_label, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.time, 3);
            this.time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.time.Location = new System.Drawing.Point(271, 359);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(326, 26);
            this.time.TabIndex = 20;
            // 
            // UserVIewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(779, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UserVIewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserVIewForm";
            this.Load += new System.EventHandler(this.UserShowHouse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label rent;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label deposit;
        private System.Windows.Forms.Label addr;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label warn_label;
        private System.Windows.Forms.DateTimePicker time;
    }
}