namespace TimeSheet
{
    partial class frmUserMapping
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
        	this.components = new System.ComponentModel.Container();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.cmbUserId = new System.Windows.Forms.ComboBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.txtid = new System.Windows.Forms.TextBox();
        	this.cmbRoleName = new System.Windows.Forms.ComboBox();
        	this.cmbUserName = new System.Windows.Forms.ComboBox();
        	this.cmdClose = new System.Windows.Forms.Button();
        	this.cmdClear = new System.Windows.Forms.Button();
        	this.cmdDelete = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.cmdAdd = new System.Windows.Forms.Button();
        	this.cmdRefresh = new System.Windows.Forms.Button();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.label1 = new System.Windows.Forms.Label();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.panel1.SuspendLayout();
        	this.panel2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.panel2);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Location = new System.Drawing.Point(0, 36);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(712, 273);
        	this.panel1.TabIndex = 12;
        	this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
        	// 
        	// panel2
        	// 
        	this.panel2.Controls.Add(this.cmbUserId);
        	this.panel2.Controls.Add(this.cmdRefresh);
        	this.panel2.Controls.Add(this.label4);
        	this.panel2.Controls.Add(this.txtid);
        	this.panel2.Controls.Add(this.cmbRoleName);
        	this.panel2.Controls.Add(this.cmbUserName);
        	this.panel2.Controls.Add(this.cmdClose);
        	this.panel2.Controls.Add(this.cmdClear);
        	this.panel2.Controls.Add(this.cmdDelete);
        	this.panel2.Controls.Add(this.label3);
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Controls.Add(this.cmdAdd);
        	this.panel2.Controls.Add(this.dataGridView1);
        	this.panel2.Location = new System.Drawing.Point(0, 21);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(712, 303);
        	this.panel2.TabIndex = 16;
        	// 
        	// cmbUserId
        	// 
        	this.cmbUserId.FormattingEnabled = true;
        	this.cmbUserId.Items.AddRange(new object[] {
        	        	        	"Nirmisha",
        	        	        	"Madhu",
        	        	        	"Paavani"});
        	this.cmbUserId.Location = new System.Drawing.Point(474, 228);
        	this.cmbUserId.Name = "cmbUserId";
        	this.cmbUserId.Size = new System.Drawing.Size(194, 21);
        	this.cmbUserId.TabIndex = 15;
        	this.cmbUserId.Visible = false;
        	// 
        	// label4
        	// 
        	this.label4.Enabled = false;
        	this.label4.Location = new System.Drawing.Point(474, 14);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(89, 18);
        	this.label4.TabIndex = 14;
        	this.label4.Text = "usermappingid";
        	// 
        	// txtid
        	// 
        	this.txtid.Location = new System.Drawing.Point(474, 35);
        	this.txtid.Name = "txtid";
        	this.txtid.Size = new System.Drawing.Size(191, 20);
        	this.txtid.TabIndex = 13;
        	// 
        	// cmbRoleName
        	// 
        	this.cmbRoleName.FormattingEnabled = true;
        	this.cmbRoleName.Items.AddRange(new object[] {
        	        	        	"Administrator",
        	        	        	"Office User",
        	        	        	"Guest"});
        	this.cmbRoleName.Location = new System.Drawing.Point(474, 114);
        	this.cmbRoleName.Name = "cmbRoleName";
        	this.cmbRoleName.Size = new System.Drawing.Size(194, 21);
        	this.cmbRoleName.TabIndex = 12;
        	// 
        	// cmbUserName
        	// 
        	this.cmbUserName.FormattingEnabled = true;
        	this.cmbUserName.Items.AddRange(new object[] {
        	        	        	"Nirmisha",
        	        	        	"Madhu",
        	        	        	"Paavani"});
        	this.cmbUserName.Location = new System.Drawing.Point(474, 74);
        	this.cmbUserName.Name = "cmbUserName";
        	this.cmbUserName.Size = new System.Drawing.Size(194, 21);
        	this.cmbUserName.TabIndex = 11;
        	this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.CmbUserNameSelectedIndexChanged);
        	// 
        	// cmdClose
        	// 
        	this.cmdClose.Location = new System.Drawing.Point(606, 170);
        	this.cmdClose.Name = "cmdClose";
        	this.cmdClose.Size = new System.Drawing.Size(60, 23);
        	this.cmdClose.TabIndex = 10;
        	this.cmdClose.Text = "Close";
        	this.cmdClose.UseVisualStyleBackColor = true;
        	this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
        	// 
        	// cmdClear
        	// 
        	this.cmdClear.Location = new System.Drawing.Point(606, 141);
        	this.cmdClear.Name = "cmdClear";
        	this.cmdClear.Size = new System.Drawing.Size(60, 23);
        	this.cmdClear.TabIndex = 9;
        	this.cmdClear.Text = "Clear";
        	this.cmdClear.UseVisualStyleBackColor = true;
        	this.cmdClear.Click += new System.EventHandler(this.CmdClearClick);
        	// 
        	// cmdDelete
        	// 
        	this.cmdDelete.Location = new System.Drawing.Point(540, 141);
        	this.cmdDelete.Name = "cmdDelete";
        	this.cmdDelete.Size = new System.Drawing.Size(60, 23);
        	this.cmdDelete.TabIndex = 8;
        	this.cmdDelete.Text = "Delete";
        	this.cmdDelete.UseVisualStyleBackColor = true;
        	this.cmdDelete.Click += new System.EventHandler(this.CmdDeleteClick);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(474, 98);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(60, 13);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Role Name";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(474, 58);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(60, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "User Name";
        	// 
        	// cmdAdd
        	// 
        	this.cmdAdd.Location = new System.Drawing.Point(474, 141);
        	this.cmdAdd.Name = "cmdAdd";
        	this.cmdAdd.Size = new System.Drawing.Size(60, 23);
        	this.cmdAdd.TabIndex = 3;
        	this.cmdAdd.Text = "Add";
        	this.cmdAdd.UseVisualStyleBackColor = true;
        	this.cmdAdd.Click += new System.EventHandler(this.CmdAddClick);
        	// 
        	// cmdRefresh
        	// 
        	this.cmdRefresh.Location = new System.Drawing.Point(368, 229);
        	this.cmdRefresh.Name = "cmdRefresh";
        	this.cmdRefresh.Size = new System.Drawing.Size(60, 23);
        	this.cmdRefresh.TabIndex = 2;
        	this.cmdRefresh.Text = "Refresh";
        	this.cmdRefresh.UseVisualStyleBackColor = true;
        	this.cmdRefresh.Click += new System.EventHandler(this.CmdRefreshClick);
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Location = new System.Drawing.Point(3, 3);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(425, 211);
        	this.dataGridView1.TabIndex = 1;
        	this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(4, 5);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(118, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "User_Role Mapping";
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	// 
        	// errorProvider2
        	// 
        	this.errorProvider2.ContainerControl = this;
        	// 
        	// frmUserMapping
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.FloralWhite;
        	this.ClientSize = new System.Drawing.Size(724, 348);
        	this.ControlBox = false;
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "frmUserMapping";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        	this.Load += new System.EventHandler(this.frmUserMapping_Load);
        	this.Activated += new System.EventHandler(this.frmUserMapping_Activated);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbUserId;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoleName;
        private System.Windows.Forms.ComboBox cmbUserName;


        
        void CmbUserNameSelectedIndexChanged(object sender, System.EventArgs e)
        {
        	
        }
        
       
    }
}