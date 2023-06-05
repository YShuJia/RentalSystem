namespace RentalSystem.UserForm
{
    partial class ComplaintsForm
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
            this.content = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.object_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(334, 384);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 32);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取 消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(545, 384);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 34);
            this.submit.TabIndex = 8;
            this.submit.Text = "执 行";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // content
            // 
            this.content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.content, 3);
            this.content.Location = new System.Drawing.Point(305, 294);
            this.content.MaxLength = 120;
            this.content.Multiline = true;
            this.content.Name = "content";
            this.tableLayoutPanel1.SetRowSpan(this.content, 2);
            this.content.Size = new System.Drawing.Size(354, 84);
            this.content.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "被投诉人ID:";
            // 
            // object_id
            // 
            this.object_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.object_id.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.object_id, 2);
            this.object_id.ForeColor = System.Drawing.Color.Blue;
            this.object_id.Location = new System.Drawing.Point(425, 125);
            this.object_id.Name = "object_id";
            this.object_id.Size = new System.Drawing.Size(61, 16);
            this.object_id.TabIndex = 13;
            this.object_id.Text = "label8";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Location = new System.Drawing.Point(305, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "投诉内容(限120字):";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "投诉申请表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.submit, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.object_id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.content, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.money, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 506);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "协 商: 退款:";
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
            this.point.Location = new System.Drawing.Point(425, 213);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(114, 24);
            this.point.TabIndex = 19;
            this.point.TextChanged += new System.EventHandler(this.point_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "积分扣除:";
            // 
            // money
            // 
            this.money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.money.Location = new System.Drawing.Point(425, 165);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(114, 26);
            this.money.TabIndex = 21;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(579, 193);
            this.label4.Name = "label4";
            this.tableLayoutPanel1.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(349, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "注意：\'积分扣除\'和\'退款\'只能选择其中一项";
            // 
            // ComplaintsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 505);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ComplaintsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserComplaintsForm";
            this.Load += new System.EventHandler(this.UserComplaintsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label object_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label4;
    }
}