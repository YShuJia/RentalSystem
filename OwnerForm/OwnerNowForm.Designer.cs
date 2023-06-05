namespace RentalSystem.OwnerForm
{
    partial class OwnerNowForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.rent = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.warn_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.page_label = new System.Windows.Forms.Label();
            this.pre = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(904, 453);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.type, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.area, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rent, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.submit, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.warn_label, 6, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 36);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "",
            "两室一厅一卫",
            "三室一厅一卫",
            "三室一厅两卫",
            "三室两厅一卫",
            "三室两厅两卫",
            "四室一厅两卫",
            "四室两厅两卫",
            "五室一厅两卫",
            "五室两厅两卫",
            "六室一厅两卫",
            "六室两厅两卫"});
            this.type.Location = new System.Drawing.Point(0, 8);
            this.type.Margin = new System.Windows.Forms.Padding(0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(145, 24);
            this.type.TabIndex = 0;
            this.type.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "面积:";
            // 
            // area
            // 
            this.area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.area.Location = new System.Drawing.Point(208, 5);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(114, 26);
            this.area.TabIndex = 2;
            this.area.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // rent
            // 
            this.rent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rent.Location = new System.Drawing.Point(388, 5);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(114, 26);
            this.rent.TabIndex = 3;
            this.rent.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(332, 10);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(50, 16);
            this.lable.TabIndex = 4;
            this.lable.Text = "租金:";
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Location = new System.Drawing.Point(508, 3);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(74, 30);
            this.submit.TabIndex = 6;
            this.submit.Text = "筛选";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.TextChanged += new System.EventHandler(this.type_TextChanged);
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // warn_label
            // 
            this.warn_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.warn_label.AutoSize = true;
            this.warn_label.ForeColor = System.Drawing.Color.Red;
            this.warn_label.Location = new System.Drawing.Point(902, 10);
            this.warn_label.Name = "warn_label";
            this.warn_label.Size = new System.Drawing.Size(0, 16);
            this.warn_label.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.page_label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.next, 2, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 495);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(904, 37);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // page_label
            // 
            this.page_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(394, 10);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(114, 16);
            this.page_label.TabIndex = 0;
            this.page_label.Text = "1";
            this.page_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pre
            // 
            this.pre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pre.Location = new System.Drawing.Point(313, 3);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(75, 31);
            this.pre.TabIndex = 1;
            this.pre.Text = "上一页";
            this.pre.UseVisualStyleBackColor = true;
            this.pre.TextChanged += new System.EventHandler(this.type_TextChanged);
            this.pre.Click += new System.EventHandler(this.pre_Click);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.next.Location = new System.Drawing.Point(514, 3);
            this.next.Name = "next";
            this.next.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.next.Size = new System.Drawing.Size(75, 31);
            this.next.TabIndex = 2;
            this.next.Text = "下一页";
            this.next.UseVisualStyleBackColor = true;
            this.next.TextChanged += new System.EventHandler(this.type_TextChanged);
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // OwnerNowForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(905, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OwnerNowForm";
            this.Text = "OwnerNowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox rent;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label warn_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button next;
    }
}