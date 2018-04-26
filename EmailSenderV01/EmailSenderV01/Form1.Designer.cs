namespace EmailSenderV01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.RichTextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsendtolist = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbrowsefile = new System.Windows.Forms.Button();
            this.btnloadtext = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnloadlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Login :";
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(318, 102);
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(352, 377);
            this.txtbody.TabIndex = 1;
            this.txtbody.Text = "";
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(83, 102);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(212, 21);
            this.txtlogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email Sender - Mighty Inc.";
            // 
            // txtport
            // 
            this.txtport.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.Location = new System.Drawing.Point(83, 263);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(212, 21);
            this.txtport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port :";
            // 
            // txtsmtp
            // 
            this.txtsmtp.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsmtp.Location = new System.Drawing.Point(83, 237);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(212, 21);
            this.txtsmtp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP :";
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.Location = new System.Drawing.Point(83, 210);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(212, 21);
            this.txtsubject.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subject :";
            // 
            // txtto
            // 
            this.txtto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.Location = new System.Drawing.Point(83, 184);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(212, 21);
            this.txtto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Send To:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(83, 128);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(212, 21);
            this.txtpassword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email Body :";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(83, 437);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(92, 42);
            this.btnsend.TabIndex = 15;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Location = new System.Drawing.Point(83, 157);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(212, 21);
            this.txtfrom.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Send From:";
            // 
            // btnsendtolist
            // 
            this.btnsendtolist.Location = new System.Drawing.Point(203, 437);
            this.btnsendtolist.Name = "btnsendtolist";
            this.btnsendtolist.Size = new System.Drawing.Size(92, 42);
            this.btnsendtolist.TabIndex = 18;
            this.btnsendtolist.Text = "Send to List";
            this.btnsendtolist.UseVisualStyleBackColor = true;
            this.btnsendtolist.Click += new System.EventHandler(this.btnsendtolist_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtfilepath
            // 
            this.txtfilepath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilepath.Location = new System.Drawing.Point(83, 292);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(212, 21);
            this.txtfilepath.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Attach Path:";
            // 
            // btnbrowsefile
            // 
            this.btnbrowsefile.Location = new System.Drawing.Point(82, 320);
            this.btnbrowsefile.Name = "btnbrowsefile";
            this.btnbrowsefile.Size = new System.Drawing.Size(212, 25);
            this.btnbrowsefile.TabIndex = 21;
            this.btnbrowsefile.Text = "Browse for File";
            this.btnbrowsefile.UseVisualStyleBackColor = true;
            this.btnbrowsefile.Click += new System.EventHandler(this.btnbrowsefile_Click);
            // 
            // btnloadtext
            // 
            this.btnloadtext.Location = new System.Drawing.Point(83, 351);
            this.btnloadtext.Name = "btnloadtext";
            this.btnloadtext.Size = new System.Drawing.Size(212, 25);
            this.btnloadtext.TabIndex = 22;
            this.btnloadtext.Text = "Load Text";
            this.btnloadtext.UseVisualStyleBackColor = true;
            this.btnloadtext.Click += new System.EventHandler(this.btnloadtext_Click);
            // 
            // btnreplace
            // 
            this.btnreplace.BackColor = System.Drawing.Color.Tomato;
            this.btnreplace.Location = new System.Drawing.Point(83, 406);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(212, 25);
            this.btnreplace.TabIndex = 23;
            this.btnreplace.Text = "Test Replace";
            this.btnreplace.UseVisualStyleBackColor = false;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // txtreplace
            // 
            this.txtreplace.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreplace.Location = new System.Drawing.Point(82, 382);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(212, 21);
            this.txtreplace.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Test Text";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(804, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 381);
            this.listBox1.TabIndex = 26;
            // 
            // btnloadlist
            // 
            this.btnloadlist.Location = new System.Drawing.Point(685, 102);
            this.btnloadlist.Name = "btnloadlist";
            this.btnloadlist.Size = new System.Drawing.Size(113, 40);
            this.btnloadlist.TabIndex = 27;
            this.btnloadlist.Text = "Load Mailing List";
            this.btnloadlist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 514);
            this.Controls.Add(this.btnloadlist);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnloadtext);
            this.Controls.Add(this.btnbrowsefile);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsendtolist);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsmtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtbody;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsendtolist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnbrowsefile;
        private System.Windows.Forms.Button btnloadtext;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnloadlist;
    }
}

