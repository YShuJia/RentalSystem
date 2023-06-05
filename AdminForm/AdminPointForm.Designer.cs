namespace RentalSystem.AdminForm
{
    partial class AdminPointForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.n_point = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.type = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "积分修改";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(289, 373);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(66, 32);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取 消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(481, 373);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(66, 32);
            this.submit.TabIndex = 8;
            this.submit.Text = "执 行";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // n_point
            // 
            this.n_point.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n_point.Location = new System.Drawing.Point(361, 334);
            this.n_point.Name = "n_point";
            this.n_point.Size = new System.Drawing.Size(114, 26);
            this.n_point.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "积  分:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "性  别:";
            // 
            // tel
            // 
            this.tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tel, 2);
            this.tel.ForeColor = System.Drawing.Color.Blue;
            this.tel.Location = new System.Drawing.Point(361, 249);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(61, 16);
            this.tel.TabIndex = 12;
            this.tel.Text = "label7";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号ID:";
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.id.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.id, 2);
            this.id.ForeColor = System.Drawing.Color.Blue;
            this.id.Location = new System.Drawing.Point(361, 114);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(61, 16);
            this.id.TabIndex = 14;
            this.id.Text = "label9";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.name, 2);
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.Location = new System.Drawing.Point(361, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 16);
            this.name.TabIndex = 13;
            this.name.Text = "label8";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "姓  名:";
            // 
            // sex
            // 
            this.sex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sex.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.sex, 2);
            this.sex.ForeColor = System.Drawing.Color.Blue;
            this.sex.Location = new System.Drawing.Point(361, 204);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(61, 16);
            this.sex.TabIndex = 16;
            this.sex.Text = "label8";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "电  话:";
            // 
            // point
            // 
            this.point.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.point.AutoSize = true;
            this.point.ForeColor = System.Drawing.Color.Blue;
            this.point.Location = new System.Drawing.Point(361, 294);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(61, 16);
            this.point.TabIndex = 18;
            this.point.Text = "label9";
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.submit, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.sex, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.name, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.n_point, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.type, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 473);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "扣除",
            "增加"});
            this.type.Location = new System.Drawing.Point(290, 335);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(65, 24);
            this.type.TabIndex = 19;
            this.type.Text = "扣除";
            // 
            // AdminPointForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AdminPointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPointForm";
            this.Load += new System.EventHandler(this.AdminComplaintForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox n_point;
        private System.Windows.Forms.ComboBox type;
    }
}