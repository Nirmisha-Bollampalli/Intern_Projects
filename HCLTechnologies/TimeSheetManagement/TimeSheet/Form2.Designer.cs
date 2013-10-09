namespace TimeSheet
{
    partial class frmLogin
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
        	this.cmdLogin = new System.Windows.Forms.Button();
        	this.txtUserName = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// cmdLogin
        	// 
        	this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cmdLogin.Location = new System.Drawing.Point(432, 196);
        	this.cmdLogin.Name = "cmdLogin";
        	this.cmdLogin.Size = new System.Drawing.Size(62, 23);
        	this.cmdLogin.TabIndex = 0;
        	this.cmdLogin.Text = "Login";
        	this.cmdLogin.UseVisualStyleBackColor = true;
        	this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
        	// 
        	// txtUserName
        	// 
        	this.txtUserName.Location = new System.Drawing.Point(395, 112);
        	this.txtUserName.Name = "txtUserName";
        	this.txtUserName.Size = new System.Drawing.Size(99, 20);
        	this.txtUserName.TabIndex = 1;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Location = new System.Drawing.Point(395, 160);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.Size = new System.Drawing.Size(99, 20);
        	this.txtPassword.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(392, 96);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(60, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "User Name";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(392, 145);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(53, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Password";
        	// 
        	// frmLogin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.FloralWhite;
        	this.ClientSize = new System.Drawing.Size(625, 375);
        	this.ControlBox = false;
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.txtUserName);
        	this.Controls.Add(this.cmdLogin);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "frmLogin";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        	this.Text = "Login";
        	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        	this.Load += new System.EventHandler(this.frmLogin_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}