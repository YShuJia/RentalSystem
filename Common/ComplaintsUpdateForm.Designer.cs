namespace RentalSystem.Common
{
    partial class ComplaintsUpdateForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.agree = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.ComboBox();
            this.money = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.Location = new System.Drawing.Point(305, 377);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 40);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取 消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Location = new System.Drawing.Point(559, 229);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 39);
            this.submit.TabIndex = 8;
            this.submit.Text = "修 改";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "投诉处理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.content, 3);
            this.content.ForeColor = System.Drawing.Color.Blue;
            this.content.Location = new System.Drawing.Point(305, 136);
            this.content.Name = "content";
            this.tableLayoutPanel1.SetRowSpan(this.content, 2);
            this.content.Size = new System.Drawing.Size(0, 16);
            this.content.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(305, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "投诉内容:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.content, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.agree, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.submit, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.admin, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.money, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 506);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // agree
            // 
            this.agree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.agree.Location = new System.Drawing.Point(432, 377);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(100, 40);
            this.agree.TabIndex = 18;
            this.agree.Text = "同 意";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.Click += new System.EventHandler(this.agree_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.tableLayoutPanel1.SetRowSpan(this.label2, 3);
            this.label2.Size = new System.Drawing.Size(296, 136);
            this.label2.TabIndex = 19;
            this.label2.Text = "注意：如果对协商结果不满意可修改后再提交，进行多次协商。或者请管理员介入（管理员一旦介入，房主和用户不在有权利修改该投诉）。";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.admin.Location = new System.Drawing.Point(559, 377);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(100, 40);
            this.admin.TabIndex = 20;
            this.admin.Text = "管理员";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "协 商: 退款:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "积分扣除:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(579, 308);
            this.label6.Name = "label6";
            this.tableLayoutPanel1.SetRowSpan(this.label6, 2);
            this.label6.Size = new System.Drawing.Size(349, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "注意：\'积分扣除\'和\'退款\'只能选择其中一项";
            // 
            // point
            // 
            this.point.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.point.FormattingEnabled = true;
            this.point.Items.AddRange(new object[] {
            "0",
            "10",
            "30",
            "50",
            "80",
            "120"});
            this.point.Location = new System.Drawing.Point(425, 328);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(114, 24);
            this.point.TabIndex = 24;
            this.point.TextChanged += new System.EventHandler(this.point_TextChanged);
            // 
            // money
            // 
            this.money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.money.Location = new System.Drawing.Point(425, 280);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(114, 26);
            this.money.TabIndex = 26;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // ComplaintsUpdateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 505);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ComplaintsUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComplaintsUpdateForm";
            this.Load += new System.EventHandler(this.UserComplaintsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label6;
    }
}