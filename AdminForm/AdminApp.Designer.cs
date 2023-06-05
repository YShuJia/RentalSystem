namespace RentalSystem.AdminForm
{
    partial class AdminApp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.now = new System.Windows.Forms.LinkLabel();
            this.owner = new System.Windows.Forms.LinkLabel();
            this.user = new System.Windows.Forms.LinkLabel();
            this.tranfer_log = new System.Windows.Forms.LinkLabel();
            this.msg_link = new System.Windows.Forms.LinkLabel();
            this.pass_link = new System.Windows.Forms.LinkLabel();
            this.exit_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 180;
            this.splitContainer1.Panel2MinSize = 5;
            this.splitContainer1.Size = new System.Drawing.Size(846, 539);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.now, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.owner, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.user, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tranfer_log, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.msg_link, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pass_link, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.exit_link, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // now
            // 
            this.now.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.now.AutoSize = true;
            this.now.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.now.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.now.LinkColor = System.Drawing.Color.Black;
            this.now.Location = new System.Drawing.Point(1, 1);
            this.now.Margin = new System.Windows.Forms.Padding(0);
            this.now.Name = "now";
            this.now.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.now.Size = new System.Drawing.Size(172, 45);
            this.now.TabIndex = 2;
            this.now.TabStop = true;
            this.now.Text = "等待处理";
            this.now.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.now.UseCompatibleTextRendering = true;
            this.now.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.now_LinkClicked);
            // 
            // owner
            // 
            this.owner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.owner.AutoSize = true;
            this.owner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.owner.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.owner.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.owner.LinkColor = System.Drawing.Color.Black;
            this.owner.Location = new System.Drawing.Point(1, 47);
            this.owner.Margin = new System.Windows.Forms.Padding(0);
            this.owner.Name = "owner";
            this.owner.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.owner.Size = new System.Drawing.Size(172, 45);
            this.owner.TabIndex = 0;
            this.owner.TabStop = true;
            this.owner.Text = "房主管理";
            this.owner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.owner.UseCompatibleTextRendering = true;
            this.owner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.owner_LinkClicked);
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.user.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.user.LinkColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(1, 93);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.user.Size = new System.Drawing.Size(172, 45);
            this.user.TabIndex = 3;
            this.user.TabStop = true;
            this.user.Text = "用户管理";
            this.user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.user.UseCompatibleTextRendering = true;
            this.user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.user_LinkClicked);
            // 
            // tranfer_log
            // 
            this.tranfer_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tranfer_log.AutoSize = true;
            this.tranfer_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranfer_log.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.tranfer_log.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tranfer_log.LinkColor = System.Drawing.Color.Black;
            this.tranfer_log.Location = new System.Drawing.Point(1, 139);
            this.tranfer_log.Margin = new System.Windows.Forms.Padding(0);
            this.tranfer_log.Name = "tranfer_log";
            this.tranfer_log.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.tranfer_log.Size = new System.Drawing.Size(172, 45);
            this.tranfer_log.TabIndex = 5;
            this.tranfer_log.TabStop = true;
            this.tranfer_log.Text = "转账记录";
            this.tranfer_log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tranfer_log.UseCompatibleTextRendering = true;
            this.tranfer_log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tranfer_log_LinkClicked);
            // 
            // msg_link
            // 
            this.msg_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg_link.AutoSize = true;
            this.msg_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msg_link.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.msg_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.msg_link.LinkColor = System.Drawing.Color.Black;
            this.msg_link.Location = new System.Drawing.Point(1, 185);
            this.msg_link.Margin = new System.Windows.Forms.Padding(0);
            this.msg_link.Name = "msg_link";
            this.msg_link.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.msg_link.Size = new System.Drawing.Size(172, 45);
            this.msg_link.TabIndex = 7;
            this.msg_link.TabStop = true;
            this.msg_link.Text = "个人信息";
            this.msg_link.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.msg_link.UseCompatibleTextRendering = true;
            this.msg_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.msg_link_LinkClicked);
            // 
            // pass_link
            // 
            this.pass_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_link.AutoSize = true;
            this.pass_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pass_link.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.pass_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.pass_link.LinkColor = System.Drawing.Color.Black;
            this.pass_link.Location = new System.Drawing.Point(1, 231);
            this.pass_link.Margin = new System.Windows.Forms.Padding(0);
            this.pass_link.Name = "pass_link";
            this.pass_link.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.pass_link.Size = new System.Drawing.Size(172, 45);
            this.pass_link.TabIndex = 6;
            this.pass_link.TabStop = true;
            this.pass_link.Text = "修改密码";
            this.pass_link.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pass_link.UseCompatibleTextRendering = true;
            this.pass_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pass_link_LinkClicked);
            // 
            // exit_link
            // 
            this.exit_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_link.AutoSize = true;
            this.exit_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_link.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.exit_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.exit_link.LinkColor = System.Drawing.Color.Black;
            this.exit_link.Location = new System.Drawing.Point(1, 277);
            this.exit_link.Margin = new System.Windows.Forms.Padding(0);
            this.exit_link.Name = "exit_link";
            this.exit_link.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.exit_link.Size = new System.Drawing.Size(172, 45);
            this.exit_link.TabIndex = 8;
            this.exit_link.TabStop = true;
            this.exit_link.Text = "安全退出";
            this.exit_link.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_link.UseCompatibleTextRendering = true;
            this.exit_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exit_link_LinkClicked);
            // 
            // AdminApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(846, 539);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AdminApp";
            this.Text = "AdminApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel now;
        private System.Windows.Forms.LinkLabel owner;
        private System.Windows.Forms.LinkLabel user;
        private System.Windows.Forms.LinkLabel tranfer_log;
        private System.Windows.Forms.LinkLabel pass_link;
        private System.Windows.Forms.LinkLabel exit_link;
        private System.Windows.Forms.LinkLabel msg_link;

    }
}