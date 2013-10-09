using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TimeSheet
{
	public partial class frmUser : Form
	{
		
		SqlConnection conn;
		SqlDataAdapter dAdapter;
		DataTable dTable;
		
		public frmUser()
		{
			InitializeComponent();
		}

		private void frmUser_Load(object sender, EventArgs e)
		{
			panel1.Top = 0;
			panel1.Left = 0;
			this.BackColor = Color.White;
			ViewData();
		}
		private void frmUser_Activated(object sender, EventArgs e)
		{
			MdiParent.Text = "HCL Applications : User Management";
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
				
				
				conn = new SqlConnection(connstring );
				conn.Open();
				
				string query = "select * from userMaster";
				dAdapter = new SqlDataAdapter(query,conn );
				
				SqlCommandBuilder cBuilder= new SqlCommandBuilder(dAdapter);
				
				dTable = new DataTable();
				dAdapter.Fill(dTable);
				
				
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
			cmdAdd.Text = "Add";
		}
		public bool validate()
		{
			bool bstatus = true;//default
			if(txtName.Text == "")
			{
				errorProvider1.SetError(txtName,"please Enter the User name");
				bstatus = false;
			}
			else
			{
				errorProvider1.Clear();
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
			string query = "insert into usermaster(username) values('"+ txtName.Text +"' )";
			executesql(query);
			
		}
		public void DeleteData()
		{   //concatenation of strings and textbox 3
			string query = "delete from usermaster where userid = "+ txtId.Text ;
			executesql(query);
			// delete the row if exists in usermapping table
			query = "delete from userMapping where userid = "+ txtId.Text ;
			executesql(query);
		}
		public void UpdateData()
		{
			string query = "update  usermaster set username ='"+txtName.Text+"' where userid = "+txtId.Text ;
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
				MessageBox.Show("please select a UserName to delete ");
				return;
			}
			DeleteData();
			MessageBox.Show("UserName was deleted");
			ViewData();
		}
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			txtName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
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
					MessageBox.Show("UserName was added");
					
				}
				else
				{
					UpdateData();
					MessageBox.Show("UserName was updated");
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