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
    
	
	
	public partial class frmUserMapping : Form
	{
		
		SqlConnection conn;
		SqlDataAdapter dAdapter;
		DataTable dTable;

		
		public frmUserMapping()
		{
			InitializeComponent();
		}

		private void frmUserMapping_Load(object sender, EventArgs e)
		{
			panel1.Top = 0;
			panel1.Left = 0;
			this.BackColor = Color.White;
			ViewData();
		}
		private void frmUserMapping_Activated(object sender, EventArgs e)
		{
			MdiParent.Text = "HCL Applications : User Role Mapping";
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
				string query = "select UM.*,U.UserName from usermapping UM INNER JOIN usermaster U ON UM.UserID = U.UserID";
				
				dAdapter = new SqlDataAdapter(query,conn );
				
				SqlCommandBuilder cBuilder= new SqlCommandBuilder(dAdapter);
				
				dTable = new DataTable();
				dAdapter.Fill(dTable);
				
				// binds the data table and grid
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dTable;
				
				dataGridView1.DataSource = bSource;
				dataGridView1.Refresh();
				PopulateUserNames();
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
		public void PopulateUserNames()
        {
			cmbUserId.Items.Clear(); 
            cmbUserName.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserMaster", conn);
            SqlDataReader DataReader = cmd.ExecuteReader();
		
            while (DataReader.Read())
            {
                cmbUserName.Items.Add(DataReader[1]); 
                cmbUserId.Items.Add(DataReader[0]);
            }
            DataReader.Close();
        }
		public bool UserExists()
        {
            
			SqlCommand cmd = new SqlCommand("SELECT * FROM UserMapping Where UserId =" + cmbUserId.Items[cmbUserName.SelectedIndex] , conn);
            SqlDataReader DataReader = cmd.ExecuteReader();
			bool bresult = false;// default value
            
			while (DataReader.Read())
            {
                bresult = true; 
            }
			DataReader.Close();
			return bresult;
			
			
        }
		void CmdRefreshClick(object sender, EventArgs e)
		{
			ViewData();
		}
		
		
		public void UpdateData()
		{
			
			string query = "update  usermapping set rolename ='"+ cmbRoleName.Text +"', userid ="+cmbUserId.Items[cmbUserName.SelectedIndex]+" where usermappingid = "+txtid.Text ;
			executesql(query);
		}
		
		public  void InsertData()
		{
			if (!UserExists())
				{
				
				string query = "insert into usermapping(userid,RoleName) values(" + cmbUserId.Items[cmbUserName.SelectedIndex] + ",' " + cmbRoleName.Text + " ')" ;
				executesql(query);
				MessageBox.Show("User Role Mapping was added");
			}
			else
				{
//				string query = "insert into usermapping(userid,RoleName) values(" + UserId[cmbUserName.SelectedIndex] + ",' " + cmbRoleName.Text + " ')" ;
//				executesql(query);
//				MessageBox.Show("User Role Mapping was added");
				MessageBox.Show("User Mapping already exists for this user");
			    }
			}      
		
		 void CmdAddClick(object sender, EventArgs e)
		{
			if( validate())
			{
				if(txtid.Text == "")
				{
					InsertData();
					
				}
				else
				{
					UpdateData();
					MessageBox.Show("User Role Mapping was updated");
				}
				ViewData();
			}
		}
		
		public bool validate()
		{
			bool bstatus = true;//default
			if(cmbUserName.Text == "")
			{
				errorProvider1.SetError(cmbUserName,"please Select User Name");
				bstatus = false;
			}
			else
			{
				errorProvider1.Clear();
			}
			if(cmbRoleName.Text == "")
			{
				errorProvider2.SetError(cmbRoleName,"please Select the User Role");
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
				objcmd.ExecuteNonQuery(); // executes query in database
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
		
		
		public  void CmdDeleteClick(object sender, EventArgs e)
		{
			if(txtid.Text == "")
			{
				MessageBox.Show("please select an User Role to delete ");
				return;
			}
			DeleteData();
			MessageBox.Show("User Role was deleted");
			ViewData();
		}
		
		public void DeleteData()
		{   //concatenation of strings and textbox 3
			string query = "delete from usermapping where usermappingid = "+ txtid.Text ;
			executesql(query);
			
		}
		
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			
			cmbRoleName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			txtid.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			cmbUserName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
			cmdAdd.Text = "update";
			
		}
		
		public void ClearControls()
		{
			txtid.Text ="";
			cmbRoleName.Text="";
			cmbUserName.Text="";
			cmdAdd.Text = "Add";
		}
		
		void CmdClearClick(object sender, EventArgs e)
		{
			ClearControls();
		}
        
        void Panel1Paint(object sender, PaintEventArgs e)
        {
        	
        }
	}
}





