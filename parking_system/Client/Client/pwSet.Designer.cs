namespace Client
{
    partial class pwSet
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("等线", 8F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(132, 115);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(90, 15);
            this.textBox8.TabIndex = 51;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("等线", 8F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(132, 79);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 15);
            this.textBox7.TabIndex = 50;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("等线", 8F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(132, 45);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 15);
            this.textBox6.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("等线", 10.5F);
            this.label9.Location = new System.Drawing.Point(63, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 48;
            this.label9.Text = "验证码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("等线", 10.5F);
            this.label8.Location = new System.Drawing.Point(63, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "确认密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 10.5F);
            this.label7.Location = new System.Drawing.Point(63, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "输入密码：";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("等线", 8.5F);
            this.button3.Location = new System.Drawing.Point(39, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 53;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("等线", 8.5F);
            this.button2.Location = new System.Drawing.Point(203, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 20);
            this.button2.TabIndex = 52;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pwSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 227);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "pwSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pwSet";
            this.Load += new System.EventHandler(this.pwSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}