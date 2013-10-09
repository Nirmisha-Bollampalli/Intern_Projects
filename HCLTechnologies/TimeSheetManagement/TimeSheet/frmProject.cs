using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TimeSheet
{
	public partial class frmProject : Form
	{
		OleDbConnection conn;
		OleDbDataAdapter dAdapter;
		DataTable dTable;
		
		
		public frmProject()
		{
			InitializeComponent();
		}

		private void frmProject_Load(object sender, EventArgs e)
		{
			panel1.Top = 0;
			panel1.Left = 0;
			this.BackColor = Color.White;
			ViewData();
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmProject_Activated(object sender, EventArgs e)
		{
			MdiParent.Text = "HCL Applications : Project Master";
		}

		public void ViewData()
		{
			string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\MyProjects\\TimeSheet\\Timesheet.mdb";
			try
			{
				// first we give the connection (pass connection string to it )and then open the connection
				
				conn = new OleDbConnection(connstring );
				conn.Open();
				
				string query = "select * from projectMaster";
				dAdapter = new OleDbDataAdapter(query,conn );
				
				OleDbCommandBuilder cBuilder= new OleDbCommandBuilder(dAdapter);
				
				dTable = new DataTable();
				dAdapter.Fill(dTable);
				
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
				errorProvider1.SetError(txtName,"please Enter the Projet name");
				bstatus = false;
			}
			else
			{
				errorProvider1.Clear();
			}
			if(txtDescription.Text == "")
			{
				errorProvider2.SetError(txtDescription,"please enter the project Description");
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
			OleDbCommand objcmd;
			objcmd = new OleDbCommand(sqlquery,conn );
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
			string query = "insert into projectmaster(projectname,projectdescription) values('"+ txtName.Text +"','"+ txtDescription.Text +"' )";
			executesql(query);
			
		}
		public void DeleteData()
		{   //concatenation of strings and textbox 3
			string query = "delete from projectmaster where projectid = "+ txtId.Text ;
			executesql(query);
			
		}
		public void UpdateData()
		{
			string query = "update  projectmaster set projectname ='"+txtName.Text+"', projectdescription ='"+txtDescription.Text+"' where projectid = "+txtId.Text ;
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
				MessageBox.Show("please select a Project to delete ");
				return;
			}
			DeleteData();
			MessageBox.Show("Project was deleted");
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
					MessageBox.Show("Project was added");
					
				}
				else
				{
					UpdateData();
					MessageBox.Show("Project was updated");
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


