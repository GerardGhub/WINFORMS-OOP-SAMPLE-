namespace WPF_OOP.ApplicationForm.User
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnInActive = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalRecords = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RadioActive = new System.Windows.Forms.RadioButton();
            this.RadioInActive = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userfile_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(31, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1350, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userfile_id,
            this.user_rights_id,
            this.username,
            this.password,
            this.employee_name,
            this.employee_lastname,
            this.is_active});
            this.DgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsers.Location = new System.Drawing.Point(3, 18);
            this.DgvUsers.MultiSelect = false;
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersWidth = 51;
            this.DgvUsers.RowTemplate.Height = 24;
            this.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsers.Size = new System.Drawing.Size(1344, 305);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.CurrentCellChanged += new System.EventHandler(this.DgvUsers_CurrentCellChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(34, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 50);
            this.panel1.TabIndex = 5;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnEdit,
            this.BtnInActive,
            this.matBtnSave,
            this.matBtnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(570, 50);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(87, 47);
            this.BtnNew.Text = "&New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(83, 47);
            this.BtnEdit.Text = "&Edit";
            // 
            // BtnInActive
            // 
            this.BtnInActive.Image = ((System.Drawing.Image)(resources.GetObject("BtnInActive.Image")));
            this.BtnInActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInActive.Name = "BtnInActive";
            this.BtnInActive.Size = new System.Drawing.Size(114, 47);
            this.BtnInActive.Text = "&InActive";
            this.BtnInActive.Click += new System.EventHandler(this.BtnInActive_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(89, 47);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(104, 47);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1202, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Items: ";
            // 
            // LblTotalRecords
            // 
            this.LblTotalRecords.AutoSize = true;
            this.LblTotalRecords.Location = new System.Drawing.Point(1299, 508);
            this.LblTotalRecords.Name = "LblTotalRecords";
            this.LblTotalRecords.Size = new System.Drawing.Size(79, 16);
            this.LblTotalRecords.TabIndex = 7;
            this.LblTotalRecords.Text = "Total Items: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(699, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RadioActive
            // 
            this.RadioActive.AutoSize = true;
            this.RadioActive.Location = new System.Drawing.Point(8, 23);
            this.RadioActive.Name = "RadioActive";
            this.RadioActive.Size = new System.Drawing.Size(65, 20);
            this.RadioActive.TabIndex = 8;
            this.RadioActive.TabStop = true;
            this.RadioActive.Text = "Active";
            this.RadioActive.UseVisualStyleBackColor = true;
            this.RadioActive.CheckedChanged += new System.EventHandler(this.RadioActive_CheckedChanged);
            // 
            // RadioInActive
            // 
            this.RadioInActive.AutoSize = true;
            this.RadioInActive.Location = new System.Drawing.Point(126, 23);
            this.RadioInActive.Name = "RadioInActive";
            this.RadioInActive.Size = new System.Drawing.Size(75, 20);
            this.RadioInActive.TabIndex = 9;
            this.RadioInActive.TabStop = true;
            this.RadioInActive.Text = "InActive";
            this.RadioInActive.UseVisualStyleBackColor = true;
            this.RadioInActive.CheckedChanged += new System.EventHandler(this.RadioInActive_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioInActive);
            this.panel2.Controls.Add(this.RadioActive);
            this.panel2.Location = new System.Drawing.Point(542, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 56);
            this.panel2.TabIndex = 10;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(106, 46);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(320, 22);
            this.TxtSearch.TabIndex = 11;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search :";
            // 
            // userfile_id
            // 
            this.userfile_id.DataPropertyName = "userfile_id";
            this.userfile_id.HeaderText = "ID";
            this.userfile_id.MinimumWidth = 6;
            this.userfile_id.Name = "userfile_id";
            this.userfile_id.ReadOnly = true;
            // 
            // user_rights_id
            // 
            this.user_rights_id.DataPropertyName = "user_rights_id";
            this.user_rights_id.HeaderText = "RIGHTS ID";
            this.user_rights_id.MinimumWidth = 6;
            this.user_rights_id.Name = "user_rights_id";
            this.user_rights_id.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "USERNAME";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "PASSWORD";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // employee_name
            // 
            this.employee_name.DataPropertyName = "employee_name";
            this.employee_name.HeaderText = "NAME";
            this.employee_name.MinimumWidth = 6;
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            // 
            // employee_lastname
            // 
            this.employee_lastname.DataPropertyName = "employee_lastname";
            this.employee_lastname.HeaderText = "LASTNAME";
            this.employee_lastname.MinimumWidth = 6;
            this.employee_lastname.Name = "employee_lastname";
            this.employee_lastname.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.HeaderText = "STATUS";
            this.is_active.MinimumWidth = 6;
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1393, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblTotalRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.ToolStripButton BtnInActive;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalRecords;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RadioActive;
        private System.Windows.Forms.RadioButton RadioInActive;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userfile_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
    }
}