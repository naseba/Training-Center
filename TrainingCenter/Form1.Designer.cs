﻿namespace TrainingCenter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SigninPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.FNametext = new System.Windows.Forms.TextBox();
            this.LNametext = new System.Windows.Forms.TextBox();
            this.Phonetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaleradioButton1 = new System.Windows.Forms.RadioButton();
            this.FemaleradioButton2 = new System.Windows.Forms.RadioButton();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AgainPasswordtext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SigninPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SigninPanel
            // 
            this.SigninPanel.Controls.Add(this.label2);
            this.SigninPanel.Controls.Add(this.label1);
            this.SigninPanel.Controls.Add(this.textBox2);
            this.SigninPanel.Controls.Add(this.textBox1);
            this.SigninPanel.Controls.Add(this.button3);
            this.SigninPanel.Location = new System.Drawing.Point(116, 95);
            this.SigninPanel.Name = "SigninPanel";
            this.SigninPanel.Size = new System.Drawing.Size(299, 229);
            this.SigninPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.label12);
            this.RegisterPanel.Controls.Add(this.label11);
            this.RegisterPanel.Controls.Add(this.label10);
            this.RegisterPanel.Controls.Add(this.label9);
            this.RegisterPanel.Controls.Add(this.AgainPasswordtext);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.Emailtext);
            this.RegisterPanel.Controls.Add(this.FemaleradioButton2);
            this.RegisterPanel.Controls.Add(this.MaleradioButton1);
            this.RegisterPanel.Controls.Add(this.label8);
            this.RegisterPanel.Controls.Add(this.label7);
            this.RegisterPanel.Controls.Add(this.label6);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.Passwordtext);
            this.RegisterPanel.Controls.Add(this.Phonetext);
            this.RegisterPanel.Controls.Add(this.LNametext);
            this.RegisterPanel.Controls.Add(this.FNametext);
            this.RegisterPanel.Controls.Add(this.button4);
            this.RegisterPanel.Location = new System.Drawing.Point(66, 48);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(393, 397);
            this.RegisterPanel.TabIndex = 8;
            this.RegisterPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Register";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FNametext
            // 
            this.FNametext.Location = new System.Drawing.Point(139, 19);
            this.FNametext.Name = "FNametext";
            this.FNametext.Size = new System.Drawing.Size(194, 20);
            this.FNametext.TabIndex = 1;
            // 
            // LNametext
            // 
            this.LNametext.Location = new System.Drawing.Point(139, 68);
            this.LNametext.Name = "LNametext";
            this.LNametext.Size = new System.Drawing.Size(194, 20);
            this.LNametext.TabIndex = 2;
            // 
            // Phonetext
            // 
            this.Phonetext.Location = new System.Drawing.Point(139, 117);
            this.Phonetext.Name = "Phonetext";
            this.Phonetext.Size = new System.Drawing.Size(194, 20);
            this.Phonetext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gender";
            // 
            // MaleradioButton1
            // 
            this.MaleradioButton1.AutoSize = true;
            this.MaleradioButton1.Location = new System.Drawing.Point(139, 164);
            this.MaleradioButton1.Name = "MaleradioButton1";
            this.MaleradioButton1.Size = new System.Drawing.Size(48, 17);
            this.MaleradioButton1.TabIndex = 14;
            this.MaleradioButton1.TabStop = true;
            this.MaleradioButton1.Text = "Male";
            this.MaleradioButton1.UseVisualStyleBackColor = true;
            // 
            // FemaleradioButton2
            // 
            this.FemaleradioButton2.AutoSize = true;
            this.FemaleradioButton2.Location = new System.Drawing.Point(250, 164);
            this.FemaleradioButton2.Name = "FemaleradioButton2";
            this.FemaleradioButton2.Size = new System.Drawing.Size(59, 17);
            this.FemaleradioButton2.TabIndex = 15;
            this.FemaleradioButton2.TabStop = true;
            this.FemaleradioButton2.Text = "Female";
            this.FemaleradioButton2.UseVisualStyleBackColor = true;
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(139, 259);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(194, 20);
            this.Passwordtext.TabIndex = 5;
            this.Passwordtext.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // Emailtext
            // 
            this.Emailtext.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Emailtext.Location = new System.Drawing.Point(139, 209);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(194, 20);
            this.Emailtext.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirm Password";
            // 
            // AgainPasswordtext
            // 
            this.AgainPasswordtext.Location = new System.Drawing.Point(139, 307);
            this.AgainPasswordtext.Name = "AgainPasswordtext";
            this.AgainPasswordtext.Size = new System.Drawing.Size(194, 20);
            this.AgainPasswordtext.TabIndex = 18;
            this.AgainPasswordtext.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(145, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Please make sure your passwords match";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(157, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Please enter valid email address";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(100, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "The email address you have entered is already registered";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.SigninPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SigninPanel.ResumeLayout(false);
            this.SigninPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SigninPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phonetext;
        private System.Windows.Forms.TextBox LNametext;
        private System.Windows.Forms.TextBox FNametext;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton MaleradioButton1;
        private System.Windows.Forms.RadioButton FemaleradioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AgainPasswordtext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

