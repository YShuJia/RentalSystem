namespace RentalSystem.Common
{
    partial class Register
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
            this.warn_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.o_check = new System.Windows.Forms.RadioButton();
            this.u_check = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sure_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warn_label
            // 
            this.warn_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warn_label.AutoSize = true;
            this.warn_label.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.warn_label.ForeColor = System.Drawing.Color.Red;
            this.warn_label.Location = new System.Drawing.Point(500, 3);
            this.warn_label.Name = "warn_label";
            this.warn_label.Size = new System.Drawing.Size(0, 14);
            this.warn_label.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "角  色:";
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.Location = new System.Drawing.Point(205, 373);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(298, 31);
            this.submit.TabIndex = 21;
            this.submit.Text = "注  册";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // o_check
            // 
            this.o_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.o_check.AutoSize = true;
            this.o_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.o_check.Location = new System.Drawing.Point(402, 117);
            this.o_check.Name = "o_check";
            this.o_check.Size = new System.Drawing.Size(59, 20);
            this.o_check.TabIndex = 19;
            this.o_check.Text = "房主";
            this.o_check.UseVisualStyleBackColor = true;
            // 
            // u_check
            // 
            this.u_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.u_check.AutoSize = true;
            this.u_check.Checked = true;
            this.u_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.u_check.Location = new System.Drawing.Point(298, 119);
            this.u_check.Name = "u_check";
            this.u_check.Size = new System.Drawing.Size(59, 20);
            this.u_check.TabIndex = 18;
            this.u_check.TabStop = true;
            this.u_check.Text = "用户";
            this.u_check.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.Location = new System.Drawing.Point(269, 152);
            this.id.MaxLength = 18;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(234, 26);
            this.id.TabIndex = 17;
            this.id.TextChanged += new System.EventHandler(this.change);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.Location = new System.Drawing.Point(269, 264);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(234, 26);
            this.pass.TabIndex = 16;
            this.pass.TextChanged += new System.EventHandler(this.change);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSize = true;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(400, 344);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 12);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "已有账号？登录!";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "密  码:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "身份证:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(301, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "欢迎注册";
            // 
            // sure_pass
            // 
            this.sure_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sure_pass.Location = new System.Drawing.Point(269, 303);
            this.sure_pass.Name = "sure_pass";
            this.sure_pass.PasswordChar = '*';
            this.sure_pass.Size = new System.Drawing.Size(234, 26);
            this.sure_pass.TabIndex = 25;
            this.sure_pass.TextChanged += new System.EventHandler(this.change);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "确  认:";
            // 
            // tel
            // 
            this.tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tel.Location = new System.Drawing.Point(269, 226);
            this.tel.MaxLength = 11;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(234, 26);
            this.tel.TabIndex = 27;
            this.tel.TextChanged += new System.EventHandler(this.change);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "电  话:";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(269, 189);
            this.name.MaxLength = 18;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 26);
            this.name.TabIndex = 29;
            this.name.TextChanged += new System.EventHandler(this.change);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "姓  名:";
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sure_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warn_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.o_check);
            this.Controls.Add(this.u_check);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warn_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sure_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton o_check;
        private System.Windows.Forms.RadioButton u_check;
    }
}