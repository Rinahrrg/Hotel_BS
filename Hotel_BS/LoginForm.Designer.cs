namespace Hotel_BS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnLoginCustomer = new Button();
            btnRegisterCustomer = new Button();
            label3 = new Label();
            btnAdminLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLoginCustomer);
            panel1.Controls.Add(btnRegisterCustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 234);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 4;
            label2.Text = "Customer";
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(384, 111);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // btnLoginCustomer
            // 
            btnLoginCustomer.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginCustomer.Location = new Point(63, 312);
            btnLoginCustomer.Name = "btnLoginCustomer";
            btnLoginCustomer.Size = new Size(136, 34);
            btnLoginCustomer.TabIndex = 3;
            btnLoginCustomer.Text = "Login";
            btnLoginCustomer.UseVisualStyleBackColor = true;
            btnLoginCustomer.Click += btnLoginCustomer_Click;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterCustomer.Location = new Point(63, 370);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(136, 34);
            btnRegisterCustomer.TabIndex = 2;
            btnRegisterCustomer.Text = "Register";
            btnRegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 234);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 1;
            label3.Text = "Administrator";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = SystemColors.ControlText;
            btnAdminLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(372, 312);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(136, 34);
            btnAdminLogin.TabIndex = 2;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 450);
            Controls.Add(btnAdminLogin);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnLoginCustomer;
        private Button btnRegisterCustomer;
        private Label label3;
        private Button btnAdminLogin;
        private PictureBox pictureBox1;
    }
}
