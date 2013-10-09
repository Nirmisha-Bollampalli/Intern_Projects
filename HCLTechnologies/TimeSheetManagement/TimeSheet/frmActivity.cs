using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace TimeSheet
{
	public partial class frmActivity : Form
	{
		SqlConnection conn;// Establish a new connection
		SqlDataAdapter dadapter;//Bring the data from the database using this connection
		DataTable dTable;//data bought is kept here
		
		public frmActivity()
		{
			InitializeComponent();
		}

		private void frmActivity_Load(object sender, EventArgs e)
		{
			panel1.Top = 0;
			panel1.Left = 0;
			this.BackColor = Color.White;
			ViewData();
		}
		private void frmActivity_Activated(object sender, EventArgs e)
		{
			MdiParent.Text = "HCL Applications : Activity Master";
		}
		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public void ViewData()
		{
			string connstring = "Data Source=116.75.133.129;initial catalog=TimeSheet;user id=sa;password=admin_007;";
			try
			{
				// first we give the connection (pass connection string to it )and then open the connection
				
				conn = new SqlConnection(connstring );
				conn.Open();
				
				string query = "select * from ActivityMaster";
				dadapter = new SqlDataAdapter(query,conn );
				
				SqlCommandBuilder cBuilder= new SqlCommandBuilder(dadapter);
				
				dTable = new DataTable();
				dadapter.Fill(dTable);
				
				// binds the data table and grid
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dTable;
				
				dataGridView1.DataSource = bSource;
				dataGridView1.Refresh();
				ClearControls();
			}
			catch {
				//handle all the errors
				throw;
			}
			finally
			{
				//close all the objects
			}
			
		}
		public void ClearControls()
		{
			txtId.Clear();
			txtName.Clear();
			txtDescription.Clear();
			cmdAdd.Text = "Add";
		}
		public bool validate()
		{
			bool bstatus = true;//default
			if(txtName.Text == "")
			{
				errorProvider1.SetError(txtName,"please Enter the Activity name");
				bstatus = false;
			}
			else
			{
				errorProvider1.Clear();
			}
			if(txtDescription.Text == "")
			{
				errorProvider2.SetError(txtDescription,"please enter the Activity Description");
				bstatus = false;
			}
			else
			{
				errorProvider2.Clear();
			}
			return bstatus;
			
		}
		public void executesql(string sqlquery)
		{
			SqlCommand objcmd;
			objcmd = new SqlCommand(sqlquery,conn );
			try
			{
				objcmd.ExecuteNonQuery();// executes query in database
			}
			catch
			{
				throw;
			}
			finally
			{
				objcmd.Dispose();
			}
			
		}
		public void InsertData()
		{
			string query = "insert into activitymaster(activityname,activitydescription) values('"+ txtName.Text +"','"+ txtDescription.Text +"' )";
			executesql(query);
			
		}
		public void DeleteData()
		{   //concatenation of strings and textbox 3
			string query = "delete from activitymaster where activityid = "+ txtId.Text ;
			executesql(query);
			
		}
		public void UpdateData()
		{
			string query = "update  activitymaster set activityname ='"+txtName.Text+"', activitydescription ='"+txtDescription.Text+"' where activityid = "+txtId.Text ;
			executesql(query);
			
		}
		
		void CmdClearClick(object sender, EventArgs e)
		{
			ClearControls();
		}
		
		void CmdDeleteClick(object sender, EventArgs e)
		{
			if(txtId.Text == "")
			{
				MessageBox.Show("please select an activity to delete ");
				return;
			}
			DeleteData();
			MessageBox.Show("activity was deleted");
			ViewData();
		}
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			txtName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
			txtDescription.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			txtId.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			cmdAdd.Text = "update";
			
		}
		void CmdAddClick(object sender, EventArgs e)
		{
			if( validate())
			{
				if(txtId.Text == "")
				{
					InsertData();
					MessageBox.Show("Activity was added");
					
				}
				else
				{
					UpdateData();
					MessageBox.Show("Activity was updated");
				}
				ViewData();
			}
		}
		
		
		void CmdRefreshClick(object sender, EventArgs e)
		{
			ViewData();
		}
	}
}