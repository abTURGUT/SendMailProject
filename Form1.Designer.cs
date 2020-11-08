namespace SendMail
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mailFromTXT = new System.Windows.Forms.TextBox();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bodyTXT = new System.Windows.Forms.TextBox();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.selectFileBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.clearFileBTN = new System.Windows.Forms.Button();
            this.sendBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mailToTXT = new System.Windows.Forms.TextBox();
            this.notselectedLBL = new System.Windows.Forms.Label();
            this.selectedLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mailFromTXT
            // 
            this.mailFromTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailFromTXT.Location = new System.Drawing.Point(32, 146);
            this.mailFromTXT.Name = "mailFromTXT";
            this.mailFromTXT.Size = new System.Drawing.Size(253, 27);
            this.mailFromTXT.TabIndex = 0;
            this.mailFromTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTXT.Location = new System.Drawing.Point(32, 215);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(253, 27);
            this.passwordTXT.TabIndex = 1;
            this.passwordTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTXT.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEND MAIL MESSAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAIL (FROM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(27, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 3);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(27, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 3);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ACCOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(331, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "MESSAGE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(330, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 3);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(331, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 3);
            this.panel4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(427, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "BODY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(412, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "SUBJECT";
            // 
            // bodyTXT
            // 
            this.bodyTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bodyTXT.Location = new System.Drawing.Point(336, 215);
            this.bodyTXT.Name = "bodyTXT";
            this.bodyTXT.Size = new System.Drawing.Size(253, 27);
            this.bodyTXT.TabIndex = 4;
            this.bodyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subjectTXT
            // 
            this.subjectTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subjectTXT.Location = new System.Drawing.Point(336, 146);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(253, 27);
            this.subjectTXT.TabIndex = 3;
            this.subjectTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectFileBTN
            // 
            this.selectFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileBTN.Location = new System.Drawing.Point(467, 293);
            this.selectFileBTN.Name = "selectFileBTN";
            this.selectFileBTN.Size = new System.Drawing.Size(94, 26);
            this.selectFileBTN.TabIndex = 6;
            this.selectFileBTN.Text = "SELECT FILE";
            this.selectFileBTN.UseVisualStyleBackColor = true;
            this.selectFileBTN.Click += new System.EventHandler(this.selectFileBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(433, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "FILE";
            // 
            // clearFileBTN
            // 
            this.clearFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFileBTN.Location = new System.Drawing.Point(367, 292);
            this.clearFileBTN.Name = "clearFileBTN";
            this.clearFileBTN.Size = new System.Drawing.Size(94, 27);
            this.clearFileBTN.TabIndex = 5;
            this.clearFileBTN.Text = "CLEAR FILE";
            this.clearFileBTN.UseVisualStyleBackColor = true;
            this.clearFileBTN.Click += new System.EventHandler(this.clearFileBTN_Click);
            // 
            // sendBTN
            // 
            this.sendBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendBTN.ForeColor = System.Drawing.Color.Fuchsia;
            this.sendBTN.Location = new System.Drawing.Point(218, 394);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(182, 67);
            this.sendBTN.TabIndex = 7;
            this.sendBTN.Text = "SEND";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(110, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "MAIL (TO)";
            // 
            // mailToTXT
            // 
            this.mailToTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailToTXT.Location = new System.Drawing.Point(37, 292);
            this.mailToTXT.Name = "mailToTXT";
            this.mailToTXT.Size = new System.Drawing.Size(253, 27);
            this.mailToTXT.TabIndex = 2;
            this.mailToTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notselectedLBL
            // 
            this.notselectedLBL.AutoSize = true;
            this.notselectedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notselectedLBL.ForeColor = System.Drawing.Color.Red;
            this.notselectedLBL.Location = new System.Drawing.Point(422, 322);
            this.notselectedLBL.Name = "notselectedLBL";
            this.notselectedLBL.Size = new System.Drawing.Size(85, 17);
            this.notselectedLBL.TabIndex = 22;
            this.notselectedLBL.Text = "not selected";
            // 
            // selectedLBL
            // 
            this.selectedLBL.AutoSize = true;
            this.selectedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedLBL.ForeColor = System.Drawing.Color.Lime;
            this.selectedLBL.Location = new System.Drawing.Point(434, 322);
            this.selectedLBL.Name = "selectedLBL";
            this.selectedLBL.Size = new System.Drawing.Size(61, 17);
            this.selectedLBL.TabIndex = 23;
            this.selectedLBL.Text = "selected";
            this.selectedLBL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 506);
            this.Controls.Add(this.selectedLBL);
            this.Controls.Add(this.notselectedLBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mailToTXT);
            this.Controls.Add(this.sendBTN);
            this.Controls.Add(this.clearFileBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectFileBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bodyTXT);
            this.Controls.Add(this.subjectTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.mailFromTXT);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailFromTXT;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bodyTXT;
        private System.Windows.Forms.TextBox subjectTXT;
        private System.Windows.Forms.Button selectFileBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearFileBTN;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mailToTXT;
        private System.Windows.Forms.Label notselectedLBL;
        private System.Windows.Forms.Label selectedLBL;
    }
}

