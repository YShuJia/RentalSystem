namespace RentalSystem.AdminForm
{
    partial class AdminMsgForm
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
            this.save = new System.Windows.Forms.Button();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warn_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.account_text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.save.Location = new System.Drawing.Point(601, 320);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(66, 32);
            this.save.TabIndex = 16;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // id_text
            // 
            this.id_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.id_text, 2);
            this.id_text.ForeColor = System.Drawing.Color.Blue;
            this.id_text.Location = new System.Drawing.Point(273, 98);
            this.id_text.Name = "id_text";
            this.id_text.ReadOnly = true;
            this.id_text.Size = new System.Drawing.Size(393, 26);
            this.id_text.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "电  话:";
            // 
            // tel_text
            // 
            this.tel_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tel_text, 2);
            this.tel_text.ForeColor = System.Drawing.Color.Blue;
            this.tel_text.Location = new System.Drawing.Point(273, 143);
            this.tel_text.MaxLength = 11;
            this.tel_text.Name = "tel_text";
            this.tel_text.ReadOnly = true;
            this.tel_text.Size = new System.Drawing.Size(393, 26);
            this.tel_text.TabIndex = 10;
            this.tel_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edit.Location = new System.Drawing.Point(201, 320);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(66, 32);
            this.edit.TabIndex = 15;
            this.edit.Text = "编辑";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "请输入密码验证身份:";
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Location = new System.Drawing.Point(473, 233);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(194, 26);
            this.pass.TabIndex = 20;
            this.pass.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(399, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "注：身份证、积分、账户、等信息不可修改...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证:";
            // 
            // warn_label
            // 
            this.warn_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.warn_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.warn_label, 3);
            this.warn_label.ForeColor = System.Drawing.Color.Red;
            this.warn_label.Location = new System.Drawing.Point(973, 14);
            this.warn_label.Name = "warn_label";
            this.warn_label.Size = new System.Drawing.Size(0, 16);
            this.warn_label.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "账  户:";
            // 
            // account_text
            // 
            this.account_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.account_text, 2);
            this.account_text.ForeColor = System.Drawing.Color.Blue;
            this.account_text.Location = new System.Drawing.Point(273, 188);
            this.account_text.Name = "account_text";
            this.account_text.ReadOnly = true;
            this.account_text.Size = new System.Drawing.Size(393, 26);
            this.account_text.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.warn_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.id_text, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tel_text, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.account_text, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pass, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.edit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.save, 3, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 515);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AdminMsgForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(981, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AdminMsgForm";
            this.Text = "AdminMsgForm";
            this.Load += new System.EventHandler(this.AdminMsgForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label warn_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox account_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button edit;
    }
}