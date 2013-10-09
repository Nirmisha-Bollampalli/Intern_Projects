namespace TimeSheet
{
    partial class frmUser
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.cmdRefresh = new System.Windows.Forms.Button();
        	this.cmdAdd = new System.Windows.Forms.Button();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.cmdDelete = new System.Windows.Forms.Button();
        	this.cmdClear = new System.Windows.Forms.Button();
        	this.cmdClose = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtId = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(4, 5);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(134, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "List of Available Users";
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Location = new System.Drawing.Point(4, 21);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(425, 211);
        	this.dataGridView1.TabIndex = 1;
        	this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
        	// 
        	// cmdRefresh
        	// 
        	this.cmdRefresh.Location = new System.Drawing.Point(369, 238);
        	this.cmdRefresh.Name = "cmdRefresh";
        	this.cmdRefresh.Size = new System.Drawing.Size(60, 23);
        	this.cmdRefresh.TabIndex = 2;
        	this.cmdRefresh.Text = "Refresh";
        	this.cmdRefresh.UseVisualStyleBackColor = true;
        	this.cmdRefresh.Click += new System.EventHandler(this.CmdRefreshClick);
        	// 
        	// cmdAdd
        	// 
        	this.cmdAdd.Location = new System.Drawing.Point(474, 148);
        	this.cmdAdd.Name = "cmdAdd";
        	this.cmdAdd.Size = new System.Drawing.Size(60, 23);
        	this.cmdAdd.TabIndex = 3;
        	this.cmdAdd.Text = "Add";
        	this.cmdAdd.UseVisualStyleBackColor = true;
        	this.cmdAdd.Click += new System.EventHandler(this.CmdAddClick);
        	// 
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(473, 98);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(193, 20);
        	this.txtName.TabIndex = 7;
        	// 
        	// cmdDelete
        	// 
        	this.cmdDelete.Location = new System.Drawing.Point(540, 148);
        	this.cmdDelete.Name = "cmdDelete";
        	this.cmdDelete.Size = new System.Drawing.Size(60, 23);
        	this.cmdDelete.TabIndex = 8;
        	this.cmdDelete.Text = "Delete";
        	this.cmdDelete.UseVisualStyleBackColor = true;
        	this.cmdDelete.Click += new System.EventHandler(this.CmdDeleteClick);
        	// 
        	// cmdClear
        	// 
        	this.cmdClear.Location = new System.Drawing.Point(606, 148);
        	this.cmdClear.Name = "cmdClear";
        	this.cmdClear.Size = new System.Drawing.Size(60, 23);
        	this.cmdClear.TabIndex = 9;
        	this.cmdClear.Text = "Clear";
        	this.cmdClear.UseVisualStyleBackColor = true;
        	this.cmdClear.Click += new System.EventHandler(this.CmdClearClick);
        	// 
        	// cmdClose
        	// 
        	this.cmdClose.Location = new System.Drawing.Point(606, 177);
        	this.cmdClose.Name = "cmdClose";
        	this.cmdClose.Size = new System.Drawing.Size(60, 23);
        	this.cmdClose.TabIndex = 10;
        	this.cmdClose.Text = "Close";
        	this.cmdClose.UseVisualStyleBackColor = true;
        	this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(470, 35);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(43, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "User ID";
        	// 
        	// txtId
        	// 
        	this.txtId.Enabled = false;
        	this.txtId.Location = new System.Drawing.Point(474, 51);
        	this.txtId.Name = "txtId";
        	this.txtId.Size = new System.Drawing.Size(193, 20);
        	this.txtId.TabIndex = 5;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(469, 82);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(60, 13);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "User Name";
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.cmdClose);
        	this.panel1.Controls.Add(this.cmdClear);
        	this.panel1.Controls.Add(this.cmdDelete);
        	this.panel1.Controls.Add(this.txtName);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.txtId);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.cmdAdd);
        	this.panel1.Controls.Add(this.cmdRefresh);
        	this.panel1.Controls.Add(this.dataGridView1);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Location = new System.Drawing.Point(12, 12);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(684, 274);
        	this.panel1.TabIndex = 11;
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	// 
        	// errorProvider2
        	// 
        	this.errorProvider2.ContainerControl = this;
        	// 
        	// frmUser
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.FloralWhite;
        	this.ClientSize = new System.Drawing.Size(712, 325);
        	this.ControlBox = false;
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmUser";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        	this.Text = "frmUser";
        	this.Load += new System.EventHandler(this.frmUser_Load);
        	this.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
        	this.Activated += new System.EventHandler(this.frmUser_Activated);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}