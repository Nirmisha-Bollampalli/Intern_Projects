namespace TimeSheet
{
    partial class Form1
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.button5 = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.label6 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(2, -1);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(807, 99);
        	this.pictureBox1.TabIndex = 1;
        	this.pictureBox1.TabStop = false;
        	// 
        	// button2
        	// 
        	this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
        	this.button2.Location = new System.Drawing.Point(365, 10);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(62, 65);
        	this.button2.TabIndex = 7;
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.label2.Location = new System.Drawing.Point(379, 78);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(39, 13);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Users";
        	this.label2.Visible = false;
        	// 
        	// button3
        	// 
        	this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
        	this.button3.Location = new System.Drawing.Point(444, 10);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(62, 65);
        	this.button3.TabIndex = 9;
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
        	// 
        	// button4
        	// 
        	this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
        	this.button4.Location = new System.Drawing.Point(528, 10);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(62, 65);
        	this.button4.TabIndex = 10;
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
        	this.button4.Click += new System.EventHandler(this.button4_Click);
        	this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
        	// 
        	// button5
        	// 
        	this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
        	this.button5.Location = new System.Drawing.Point(616, 10);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(62, 65);
        	this.button5.TabIndex = 11;
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
        	this.button5.Click += new System.EventHandler(this.button5_Click);
        	this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.label1.Location = new System.Drawing.Point(427, 78);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(85, 13);
        	this.label1.TabIndex = 12;
        	this.label1.Text = "User Mapping";
        	this.label1.Visible = false;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.label3.Location = new System.Drawing.Point(518, 79);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(91, 13);
        	this.label3.TabIndex = 13;
        	this.label3.Text = "Activity Master";
        	this.label3.Visible = false;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.label4.Location = new System.Drawing.Point(606, 79);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(89, 13);
        	this.label4.TabIndex = 14;
        	this.label4.Text = "Project Master";
        	this.label4.Visible = false;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackColor = System.Drawing.Color.White;
        	this.pictureBox2.Location = new System.Drawing.Point(2, 383);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(822, 32);
        	this.pictureBox2.TabIndex = 16;
        	this.pictureBox2.TabStop = false;
        	this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
        	// 
        	// label5
        	// 
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.label5.Location = new System.Drawing.Point(528, 383);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(256, 30);
        	this.label5.TabIndex = 17;
        	this.label5.Text = "Time";
        	this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.label5.Click += new System.EventHandler(this.Label5Click);
        	// 
        	// timer1
        	// 
        	this.timer1.Enabled = true;
        	this.timer1.Interval = 3000;
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
        	this.pictureBox3.Location = new System.Drawing.Point(4, 100);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(787, 280);
        	this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox3.TabIndex = 18;
        	this.pictureBox3.TabStop = false;
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
        	this.button1.Location = new System.Drawing.Point(701, 10);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(63, 65);
        	this.button1.TabIndex = 20;
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.MouseLeave += new System.EventHandler(this.Button1_Mouseleave);
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	this.button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
        	// 
        	// label6
        	// 
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
        	this.label6.Location = new System.Drawing.Point(697, 77);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(87, 18);
        	this.label6.TabIndex = 21;
        	this.label6.Text = "Transaction";
        	this.label6.MouseLeave += new System.EventHandler(this.Button1_Mouseleave);
        	this.label6.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(789, 411);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.pictureBox2);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.pictureBox3);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.IsMdiContainer = true;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "Form1";
        	this.Text = "HCL Applications : Time Sheet";
        	this.Load += new System.EventHandler(this.Form1_Load);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        
        
        
    }
}

