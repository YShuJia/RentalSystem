namespace RentalSystem.AdminForm
{
    partial class AdminComplaintForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plaintiff_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.object_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.money, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.result, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.plaintiff_id, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.object_id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.content, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 506);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "赔款金额:";
            // 
            // money
            // 
            this.money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.money, 2);
            this.money.Location = new System.Drawing.Point(425, 345);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(203, 26);
            this.money.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "积分扣除:";
            // 
            // point
            // 
            this.point.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.point, 2);
            this.point.Location = new System.Drawing.Point(425, 300);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(203, 26);
            this.point.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "协商结果:";
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.result.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.result, 3);
            this.result.ForeColor = System.Drawing.Color.Blue;
            this.result.Location = new System.Drawing.Point(425, 215);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(61, 16);
            this.result.TabIndex = 12;
            this.result.Text = "label7";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "投诉人ID:";
            // 
            // plaintiff_id
            // 
            this.plaintiff_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.plaintiff_id.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.plaintiff_id, 2);
            this.plaintiff_id.ForeColor = System.Drawing.Color.Blue;
            this.plaintiff_id.Location = new System.Drawing.Point(425, 80);
            this.plaintiff_id.Name = "plaintiff_id";
            this.plaintiff_id.Size = new System.Drawing.Size(61, 16);
            this.plaintiff_id.TabIndex = 14;
            this.plaintiff_id.Text = "label9";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "被告人ID:";
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "投诉时间:";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.time.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.time, 2);
            this.time.ForeColor = System.Drawing.Color.Blue;
            this.time.Location = new System.Drawing.Point(425, 170);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(61, 16);
            this.time.TabIndex = 16;
            this.time.Text = "label8";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "投诉内容:";
            // 
            // content
            // 
            this.content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.content.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.content, 3);
            this.content.ForeColor = System.Drawing.Color.Blue;
            this.content.Location = new System.Drawing.Point(425, 260);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(61, 16);
            this.content.TabIndex = 18;
            this.content.Text = "label9";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "投诉处理表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.tableLayoutPanel1.SetRowSpan(this.label9, 3);
            this.label9.Size = new System.Drawing.Size(296, 64);
            this.label9.TabIndex = 19;
            this.label9.Text = "注意：积分扣除和赔款只能选择其中一项....\r\n\r\n都填写时默认积分扣除....";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminComplaintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 505);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AdminComplaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminComplaintForm";
            this.Load += new System.EventHandler(this.AdminComplaintForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label plaintiff_id;
        private System.Windows.Forms.Label object_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Label label9;
    }
}