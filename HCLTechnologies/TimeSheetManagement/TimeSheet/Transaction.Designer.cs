/*
 * Created by SharpDevelop.
 * User: nirmisha
 * Date: 6/18/2009
 * Time: 10:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TimeSheet
{
	partial class Transaction
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbprojectid = new System.Windows.Forms.ComboBox();
			this.Transactionid = new System.Windows.Forms.TextBox();
			this.cmbActivityId = new System.Windows.Forms.ComboBox();
			this.Tid = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comments = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Hours = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Minutes = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtxt = new System.Windows.Forms.TextBox();
			this.cmbProjectName = new System.Windows.Forms.ComboBox();
			this.cmbActivityName = new System.Windows.Forms.ComboBox();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdClear = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.ProjectName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.cmdRefresh = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.cmbprojectid);
			this.panel2.Controls.Add(this.Transactionid);
			this.panel2.Controls.Add(this.cmbActivityId);
			this.panel2.Controls.Add(this.Tid);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.comments);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.Hours);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.Minutes);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.dtxt);
			this.panel2.Controls.Add(this.cmbProjectName);
			this.panel2.Controls.Add(this.cmbActivityName);
			this.panel2.Controls.Add(this.cmdClose);
			this.panel2.Controls.Add(this.cmdClear);
			this.panel2.Controls.Add(this.cmdDelete);
			this.panel2.Controls.Add(this.ProjectName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cmdAdd);
			this.panel2.Controls.Add(this.cmdRefresh);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(759, 385);
			this.panel2.TabIndex = 17;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(641, 117);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 20);
			this.label8.TabIndex = 29;
			this.label8.Text = "ProjectId";
			this.label8.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(641, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 22);
			this.label3.TabIndex = 28;
			this.label3.Text = "ActivityId";
			this.label3.Visible = false;
			// 
			// cmbprojectid
			// 
			this.cmbprojectid.FormattingEnabled = true;
			this.cmbprojectid.Location = new System.Drawing.Point(707, 114);
			this.cmbprojectid.Name = "cmbprojectid";
			this.cmbprojectid.Size = new System.Drawing.Size(36, 21);
			this.cmbprojectid.TabIndex = 27;
			this.cmbprojectid.Visible = false;
			// 
			// Transactionid
			// 
			this.Transactionid.Location = new System.Drawing.Point(90, 6);
			this.Transactionid.Name = "Transactionid";
			this.Transactionid.Size = new System.Drawing.Size(184, 20);
			this.Transactionid.TabIndex = 26;
			// 
			// cmbActivityId
			// 
			this.cmbActivityId.FormattingEnabled = true;
			this.cmbActivityId.Location = new System.Drawing.Point(707, 74);
			this.cmbActivityId.Name = "cmbActivityId";
			this.cmbActivityId.Size = new System.Drawing.Size(36, 21);
			this.cmbActivityId.TabIndex = 24;
			this.cmbActivityId.Visible = false;
			// 
			// Tid
			// 
			this.Tid.Location = new System.Drawing.Point(6, 6);
			this.Tid.Name = "Tid";
			this.Tid.Size = new System.Drawing.Size(78, 25);
			this.Tid.TabIndex = 23;
			this.Tid.Text = "TransactionId";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(474, 259);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 15);
			this.label7.TabIndex = 22;
			this.label7.Text = "Comments";
			// 
			// comments
			// 
			this.comments.Location = new System.Drawing.Point(556, 254);
			this.comments.Name = "comments";
			this.comments.Size = new System.Drawing.Size(89, 20);
			this.comments.TabIndex = 21;
			this.comments.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(474, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 18);
			this.label6.TabIndex = 20;
			this.label6.Text = "Duration";
			// 
			// Hours
			// 
			this.Hours.FormattingEnabled = true;
			this.Hours.Items.AddRange(new object[] {
									"1",
									"4",
									"2",
									"8"});
			this.Hours.Location = new System.Drawing.Point(556, 227);
			this.Hours.Name = "Hours";
			this.Hours.Size = new System.Drawing.Size(39, 21);
			this.Hours.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(601, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 19);
			this.label5.TabIndex = 18;
			this.label5.Text = "min";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(556, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 19);
			this.label1.TabIndex = 17;
			this.label1.Text = "hrs";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(556, 34);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
			this.dateTimePicker1.TabIndex = 16;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// Minutes
			// 
			this.Minutes.FormattingEnabled = true;
			this.Minutes.Items.AddRange(new object[] {
									"20",
									"10 ",
									"30",
									"15"});
			this.Minutes.Location = new System.Drawing.Point(606, 227);
			this.Minutes.Name = "Minutes";
			this.Minutes.Size = new System.Drawing.Size(38, 21);
			this.Minutes.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(474, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Date";
			// 
			// dtxt
			// 
			this.dtxt.Location = new System.Drawing.Point(474, 35);
			this.dtxt.Name = "dtxt";
			this.dtxt.Size = new System.Drawing.Size(76, 20);
			this.dtxt.TabIndex = 13;
			this.dtxt.TextChanged += new System.EventHandler(this.TxtidTextChanged);
			// 
			// cmbProjectName
			// 
			this.cmbProjectName.FormattingEnabled = true;
			this.cmbProjectName.Items.AddRange(new object[] {
									"Administrator",
									"Office User",
									"Guest"});
			this.cmbProjectName.Location = new System.Drawing.Point(474, 114);
			this.cmbProjectName.Name = "cmbProjectName";
			this.cmbProjectName.Size = new System.Drawing.Size(141, 21);
			this.cmbProjectName.TabIndex = 12;
			// 
			// cmbActivityName
			// 
			this.cmbActivityName.FormattingEnabled = true;
			this.cmbActivityName.Items.AddRange(new object[] {
									"Nirmisha",
									"Madhu",
									"Paavani"});
			this.cmbActivityName.Location = new System.Drawing.Point(474, 74);
			this.cmbActivityName.Name = "cmbActivityName";
			this.cmbActivityName.Size = new System.Drawing.Size(141, 21);
			this.cmbActivityName.TabIndex = 11;
			this.cmbActivityName.SelectedIndexChanged += new System.EventHandler(this.CmbActivityNameSelectedIndexChanged);
			// 
			// cmdClose
			// 
			this.cmdClose.Location = new System.Drawing.Point(683, 173);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(60, 23);
			this.cmdClose.TabIndex = 10;
			this.cmdClose.Text = "Close";
			this.cmdClose.UseVisualStyleBackColor = true;
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(606, 173);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(60, 23);
			this.cmdClear.TabIndex = 9;
			this.cmdClear.Text = "Clear";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler(this.CmdClearClick);
			// 
			// cmdDelete
			// 
			this.cmdDelete.Location = new System.Drawing.Point(540, 173);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(60, 23);
			this.cmdDelete.TabIndex = 8;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.CmdDeleteClick);
			// 
			// ProjectName
			// 
			this.ProjectName.AutoSize = true;
			this.ProjectName.Location = new System.Drawing.Point(474, 98);
			this.ProjectName.Name = "ProjectName";
			this.ProjectName.Size = new System.Drawing.Size(71, 13);
			this.ProjectName.TabIndex = 6;
			this.ProjectName.Text = "Project Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(474, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Activity Name";
			// 
			// cmdAdd
			// 
			this.cmdAdd.Location = new System.Drawing.Point(474, 173);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(60, 23);
			this.cmdAdd.TabIndex = 3;
			this.cmdAdd.Text = "Add";
			this.cmdAdd.UseVisualStyleBackColor = true;
			this.cmdAdd.Click += new System.EventHandler(this.CmdAddClick);
			// 
			// cmdRefresh
			// 
			this.cmdRefresh.Location = new System.Drawing.Point(369, 251);
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
			this.dataGridView1.Location = new System.Drawing.Point(4, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(425, 211);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// Transaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 388);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Transaction";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Transaction";
			this.Load += new System.EventHandler(this.TransactionLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Transactionid;
		private System.Windows.Forms.ComboBox cmbprojectid;
		private System.Windows.Forms.Label Tid;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox cmbActivityId;
		private System.Windows.Forms.Label ProjectName;
		private System.Windows.Forms.TextBox comments;
		private System.Windows.Forms.ComboBox Hours;
		private System.Windows.Forms.ComboBox Minutes;
		private System.Windows.Forms.ComboBox cmbActivityName;
		private System.Windows.Forms.ComboBox cmbProjectName;
		private System.Windows.Forms.TextBox dtxt;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button cmdRefresh;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		
		
	}
}
