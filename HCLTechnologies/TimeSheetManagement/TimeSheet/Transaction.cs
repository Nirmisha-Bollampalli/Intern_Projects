
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.ComponentModel;
using System.Text;
using System.Data.SqlClient;

namespace TimeSheet
{
	
	public partial class Transaction : Form
	{
		SqlConnection conn;
		SqlDataAdapter dadapter;
		DataTable dtable ;
		
		
		public Transaction()
		{
			
			InitializeComponent();
			
			
		}
		
		public void ViewData()
		{
			string connstring = "Data Source=116.75.133.129;initial catalog=TimeSheet;user id=sa;password=admin_007;";		
			try
			{
			conn = new SqlConnection(connstring);
			conn.Open();
			
			string query = " select * from Transactiontable ";
			dadapter = new SqlDataAdapter(query,conn);
			
			SqlCommandBuilder  cbuilder   = new SqlCommandBuilder(dadapter);
			
			dtable = new DataTable();
			dadapter.Fill(dtable);
			
			BindingSource bsource = new BindingSource();
			bsource.DataSource = dtable;
			
			dataGridView1.DataSource = bsource;
			dataGridView1.Refresh();
			
			clearcontrols()	;
			PopulateActivityNames();
			PopulateProjectNames();
			
			}
			catch{
				throw;
			} 
		    finally
		    {
		    	
		    }
		
		}
		
		
		public void clearcontrols()
		{
			Transactionid.Clear();
			dtxt.Text ="";
	     	cmbActivityName.Text ="";
            cmbProjectName.Text  ="";
			Hours.Text ="";
		    Minutes.Text ="";
		    comments.Text ="";
		    cmbActivityId.Text = "";
		    cmbprojectid.Text = "";
		    cmdAdd.Text = "Add";
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		void TransactionLoad(object sender, EventArgs e)
		{
			panel2.Top = 0;
			panel2.Left = 0;
			this.BackColor = Color.White;
			ViewData();
		}
		
		void TxtidTextChanged(object sender, EventArgs e)
		{
			//dtxt.Text = DateTime.Now.ToString("MM:dd:yyyy  hh:mm:ss");
		}
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void CmdClearClick(object sender, EventArgs e)
		{
			clearcontrols();
		}
		
		void CmdRefreshClick(object sender, EventArgs e)
		{
			ViewData();
		}
		
		void CmdAddClick(object sender, EventArgs e)
		{
		if( validate())
			{
				if(Transactionid.Text == "")
				{
                    
					InsertData();
					
				}
				else
				{
					UpdateData1();
					//updatedata2();
					MessageBox.Show("Updated");
				}
				ViewData();
			}
		
			
		}
	   
		
		public bool validate()
		{
			bool bstatus = true;//default
			if(cmbActivityName.Text == "")
			{
				errorProvider1.SetError(cmbActivityName,"please Select Activity Name");
				bstatus = false;
			}
			else
			{
				errorProvider1.Clear();
			}
			if(cmbProjectName.Text == "")
			{
				errorProvider2.SetError(cmbProjectName,"please Select the Project Name");
				bstatus = false;
			}
			else
			{
				errorProvider2.Clear();
			}
			
			
			return bstatus;
			
		}
		public void InsertData()
		{
			string query ="insert into transactiontable (activityid,activityname,projectid,projectname,[date],DurationInHours,DurationInMinutes,comments) values(" + cmbActivityId.Items[cmbActivityName.SelectedIndex] + ",'" + cmbActivityName.Text+ "'," + cmbprojectid.Items[cmbProjectName.SelectedIndex] + ",'" + cmbProjectName.Text + "','" + dtxt.Text + "','" + Hours.Text + "','" + Minutes.Text + " ','" + comments.Text + "')";
		    executesql(query);
			MessageBox.Show("Added");
		}
		public void DeleteData()
		{   //concatenation of strings and textbox 3
			string query = "delete from Transactiontable where transactionid = "+ Transactionid.Text ;
			executesql(query);
			
		}
		public  void CmdDeleteClick(object sender, EventArgs e)
		{
			if(Transactionid.Text == "")
			{
				MessageBox.Show("please select a Process to delete ");
				return;
			}
			DeleteData();
			MessageBox.Show(" Deleted");
			ViewData();
		}
		
		
		public void UpdateData1()
		{
			string query = "update  transactiontable set activityid ='"+ cmbActivityId.Items[cmbActivityName.SelectedIndex] +"',activityname = '"+ cmbActivityName.Text +"' ,projectname = '"+ cmbProjectName.Text +"',[date]='"+dtxt.Text+"',DurationInHours='"+Hours.Text+"',DurationInMinutes = ' " + Minutes.Text + " ',Comments = '"+comments.Text+"',projectid ="+cmbprojectid.Items[cmbProjectName.SelectedIndex]+" where TransactionId = "+Transactionid.Text ;
			executesql(query);
			
		}
//		public void updatedata2()
//		{
//			string query = "update  TransactionTable set projectid ='"+cmbprojectid.Text+"'" ;
//			executesql(query);
//		}
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
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			Transactionid.Text =dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			dtxt.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
			comments.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
			cmdAdd.Text = "update";
			cmbProjectName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
		    cmbActivityName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
		    Hours.Text =dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
		    Minutes.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
		  
		}
		
		void CmbActivityNameSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	
		public void PopulateActivityNames()
		{
			cmbActivityName.Items .Clear();
			cmbActivityId.Items.Clear();
			SqlCommand cmd = new SqlCommand("select * from ActivityMaster  " , conn);
            //similar to data adapter(but row by row)
            SqlDataReader DataReader = cmd.ExecuteReader();
		
            while (DataReader.Read())// reads row
            {
                cmbActivityName.Items.Add(DataReader[1]); // add the username to the combo box
                cmbActivityId.Items.Add(DataReader[0]);//store the userid in this array
            }
            
            
            DataReader.Close();
		}
	
        public void PopulateProjectNames()
		{
			cmbprojectid.Items .Clear();
			cmbProjectName.Items.Clear();
			SqlCommand cmd = new SqlCommand(" select Projectid,ProjectName from ProjectMaster  " , conn);
            //similar to data adapter(but row by row)
            SqlDataReader DataReader = cmd.ExecuteReader();
		
            while (DataReader.Read())// reads row
            {
                cmbProjectName.Items.Add(DataReader[1]); // add the username to the combo box
                cmbprojectid.Items.Add(DataReader[0]);//store the userid in this array
            }
            DataReader.Close();
		}
	
	
		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			dtxt.Text = dateTimePicker1.Value.ToString();
		}
	}
	}
	
	
