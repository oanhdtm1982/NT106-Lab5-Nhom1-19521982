namespace Lab5_Nhom1_19521982
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYc3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYc4 = new System.Windows.Forms.Button();
            this.btnYc5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(231, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab5 - Sending - Receiving Email in C#\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(622, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(256, 89);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Thành viên nhóm 1: \r\n19521982 - Đỗ Thị Minh Oanh\r\n20521986 - Lê Thị Anh Thư\r\n2052" +
    "1759 - Hà Minh Phúc\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Yêu cầu 3 - Gửi email (SMTP)";
            // 
            // btnYc3
            // 
            this.btnYc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYc3.Location = new System.Drawing.Point(141, 147);
            this.btnYc3.Name = "btnYc3";
            this.btnYc3.Size = new System.Drawing.Size(157, 52);
            this.btnYc3.TabIndex = 26;
            this.btnYc3.Text = "Yêu Cầu 3";
            this.btnYc3.UseVisualStyleBackColor = true;
            this.btnYc3.Click += new System.EventHandler(this.btnYc3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Yêu cầu 4 - Nhận email (IMAP)";
            // 
            // btnYc4
            // 
            this.btnYc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYc4.Location = new System.Drawing.Point(141, 303);
            this.btnYc4.Name = "btnYc4";
            this.btnYc4.Size = new System.Drawing.Size(157, 52);
            this.btnYc4.TabIndex = 28;
            this.btnYc4.Text = "Yêu Cầu 4";
            this.btnYc4.UseVisualStyleBackColor = true;
            this.btnYc4.Click += new System.EventHandler(this.btnYc4_Click);
            // 
            // btnYc5
            // 
            this.btnYc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYc5.Location = new System.Drawing.Point(141, 457);
            this.btnYc5.Name = "btnYc5";
            this.btnYc5.Size = new System.Drawing.Size(157, 52);
            this.btnYc5.TabIndex = 30;
            this.btnYc5.Text = "Yêu Cầu 5";
            this.btnYc5.UseVisualStyleBackColor = true;
            this.btnYc5.Click += new System.EventHandler(this.btnYc5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Yêu cầu 5 - Email Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 560);
            this.Controls.Add(this.btnYc5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYc4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYc3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYc3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYc4;
        private System.Windows.Forms.Button btnYc5;
        private System.Windows.Forms.Label label4;
    }
}

