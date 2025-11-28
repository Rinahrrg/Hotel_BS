namespace Hotel_BS
{
    partial class CustomerLoginForm
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
            btnCancel = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            checkBox2 = new CheckBox();
            linkRegister = new LinkLabel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label8 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(342, 339);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(222, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label23);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 450);
            panel1.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(410, 27);
            txtPassword.TabIndex = 24;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(158, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(410, 27);
            txtUsername.TabIndex = 23;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(151, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(158, 182);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 18;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(151, 108);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 17;
            label4.Text = "Username:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(151, 256);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(129, 24);
            checkBox2.TabIndex = 29;
            checkBox2.Text = "Remember Me";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.LinkColor = Color.Black;
            linkRegister.Location = new Point(204, 391);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(283, 17);
            linkRegister.TabIndex = 30;
            linkRegister.TabStop = true;
            linkRegister.Text = "Don't have an account? Register here";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlText;
            label16.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(35, 404);
            label16.Name = "label16";
            label16.Size = new Size(24, 23);
            label16.TabIndex = 23;
            label16.Text = "R";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ControlText;
            label15.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(35, 370);
            label15.Name = "label15";
            label15.Size = new Size(23, 23);
            label15.TabIndex = 22;
            label15.Text = "E";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlText;
            label14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(35, 333);
            label14.Name = "label14";
            label14.Size = new Size(27, 23);
            label14.TabIndex = 21;
            label14.Text = "M";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlText;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(35, 298);
            label8.Name = "label8";
            label8.Size = new Size(26, 23);
            label8.TabIndex = 20;
            label8.Text = "O";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ControlText;
            label17.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(35, 258);
            label17.Name = "label17";
            label17.Size = new Size(23, 23);
            label17.TabIndex = 19;
            label17.Text = "T";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ControlText;
            label18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(35, 225);
            label18.Name = "label18";
            label18.Size = new Size(23, 23);
            label18.TabIndex = 18;
            label18.Text = "S";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.ControlText;
            label19.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(35, 189);
            label19.Name = "label19";
            label19.Size = new Size(25, 23);
            label19.TabIndex = 17;
            label19.Text = "U";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.ControlText;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(35, 153);
            label20.Name = "label20";
            label20.Size = new Size(25, 23);
            label20.TabIndex = 16;
            label20.Text = "C";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ControlText;
            label21.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(35, 94);
            label21.Name = "label21";
            label21.Size = new Size(29, 23);
            label21.TabIndex = 15;
            label21.Text = "W";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.ControlText;
            label22.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(35, 62);
            label22.Name = "label22";
            label22.Size = new Size(23, 23);
            label22.TabIndex = 14;
            label22.Text = "E";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = SystemColors.ControlText;
            label23.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.White;
            label23.Location = new Point(35, 27);
            label23.Name = "label23";
            label23.Size = new Size(25, 23);
            label23.TabIndex = 13;
            label23.Text = "N";
            // 
            // CustomerLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 450);
            Controls.Add(linkRegister);
            Controls.Add(checkBox2);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerLoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "CustomerLoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private CheckBox checkBox2;
        private LinkLabel linkRegister;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label8;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
    }
}