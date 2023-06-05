namespace RentalSystem.Common
{
    partial class Login
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
            this.registerButton = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.u = new System.Windows.Forms.RadioButton();
            this.o = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.sure = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.warn_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(328, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登录";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "账  号:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码:";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.AutoSize = true;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.registerButton.ForeColor = System.Drawing.Color.Red;
            this.registerButton.Location = new System.Drawing.Point(415, 309);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(116, 12);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "还没有账号？注册!";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.Location = new System.Drawing.Point(297, 269);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(232, 26);
            this.pass.TabIndex = 4;
            this.pass.TextChanged += new System.EventHandler(this.change);
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.Location = new System.Drawing.Point(297, 219);
            this.id.MaxLength = 18;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(232, 26);
            this.id.TabIndex = 5;
            this.id.TextChanged += new System.EventHandler(this.change);
            // 
            // u
            // 
            this.u.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.u.AutoSize = true;
            this.u.Checked = true;
            this.u.Cursor = System.Windows.Forms.Cursors.Hand;
            this.u.Location = new System.Drawing.Point(308, 165);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(59, 20);
            this.u.TabIndex = 6;
            this.u.TabStop = true;
            this.u.Text = "用户";
            this.u.UseVisualStyleBackColor = true;
            // 
            // o
            // 
            this.o.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.o.AutoSize = true;
            this.o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.o.Location = new System.Drawing.Point(381, 165);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(59, 20);
            this.o.TabIndex = 7;
            this.o.Text = "房主";
            this.o.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a.AutoSize = true;
            this.a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a.Location = new System.Drawing.Point(455, 165);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(76, 20);
            this.a.TabIndex = 8;
            this.a.Text = "管理员";
            this.a.UseVisualStyleBackColor = true;
            // 
            // sure
            // 
            this.sure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sure.Location = new System.Drawing.Point(233, 344);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(296, 31);
            this.sure.TabIndex = 9;
            this.sure.Text = "登  录";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "角  色:";
            // 
            // warn_label
            // 
            this.warn_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warn_label.AutoSize = true;
            this.warn_label.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.warn_label.ForeColor = System.Drawing.Color.Red;
            this.warn_label.Location = new System.Drawing.Point(557, 3);
            this.warn_label.Name = "warn_label";
            this.warn_label.Size = new System.Drawing.Size(0, 14);
            this.warn_label.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 498);
            this.Controls.Add(this.warn_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.a);
            this.Controls.Add(this.o);
            this.Controls.Add(this.u);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label registerButton;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.RadioButton u;
        private System.Windows.Forms.RadioButton o;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label warn_label;
    }
}