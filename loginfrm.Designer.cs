
namespace Pet_Food_Shop
{
    partial class loginfrm
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
            this.userButtonsPanal_01 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose_01 = new System.Windows.Forms.Button();
            this.btnStaff_01 = new System.Windows.Forms.Button();
            this.btnCashier_01 = new System.Windows.Forms.Button();
            this.btnAdmin_01 = new System.Windows.Forms.Button();
            this.loginViewPanal_01 = new System.Windows.Forms.Panel();
            this.userButtonsPanal_01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userButtonsPanal_01
            // 
            this.userButtonsPanal_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.userButtonsPanal_01.Controls.Add(this.pictureBox1);
            this.userButtonsPanal_01.Controls.Add(this.btnClose_01);
            this.userButtonsPanal_01.Controls.Add(this.btnStaff_01);
            this.userButtonsPanal_01.Controls.Add(this.btnCashier_01);
            this.userButtonsPanal_01.Controls.Add(this.btnAdmin_01);
            this.userButtonsPanal_01.Dock = System.Windows.Forms.DockStyle.Left;
            this.userButtonsPanal_01.ForeColor = System.Drawing.Color.White;
            this.userButtonsPanal_01.Location = new System.Drawing.Point(0, 0);
            this.userButtonsPanal_01.Name = "userButtonsPanal_01";
            this.userButtonsPanal_01.Size = new System.Drawing.Size(241, 450);
            this.userButtonsPanal_01.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pet_Food_Shop.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 158);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose_01
            // 
            this.btnClose_01.FlatAppearance.BorderSize = 0;
            this.btnClose_01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose_01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_01.Location = new System.Drawing.Point(12, 413);
            this.btnClose_01.Name = "btnClose_01";
            this.btnClose_01.Size = new System.Drawing.Size(86, 25);
            this.btnClose_01.TabIndex = 1;
            this.btnClose_01.Text = "Exit";
            this.btnClose_01.UseVisualStyleBackColor = true;
            this.btnClose_01.Click += new System.EventHandler(this.btnClose_01_Click);
            // 
            // btnStaff_01
            // 
            this.btnStaff_01.FlatAppearance.BorderSize = 0;
            this.btnStaff_01.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStaff_01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnStaff_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff_01.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff_01.ForeColor = System.Drawing.Color.White;
            this.btnStaff_01.Location = new System.Drawing.Point(38, 278);
            this.btnStaff_01.Name = "btnStaff_01";
            this.btnStaff_01.Size = new System.Drawing.Size(142, 45);
            this.btnStaff_01.TabIndex = 0;
            this.btnStaff_01.Text = "STAFF";
            this.btnStaff_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff_01.UseVisualStyleBackColor = true;
            this.btnStaff_01.Click += new System.EventHandler(this.btnStaff_01_Click);
            // 
            // btnCashier_01
            // 
            this.btnCashier_01.FlatAppearance.BorderSize = 0;
            this.btnCashier_01.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCashier_01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnCashier_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier_01.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier_01.ForeColor = System.Drawing.Color.White;
            this.btnCashier_01.Location = new System.Drawing.Point(38, 227);
            this.btnCashier_01.Name = "btnCashier_01";
            this.btnCashier_01.Size = new System.Drawing.Size(142, 45);
            this.btnCashier_01.TabIndex = 0;
            this.btnCashier_01.Text = "CASHIER";
            this.btnCashier_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier_01.UseVisualStyleBackColor = true;
            this.btnCashier_01.Click += new System.EventHandler(this.btnCashier_01_Click);
            // 
            // btnAdmin_01
            // 
            this.btnAdmin_01.FlatAppearance.BorderSize = 0;
            this.btnAdmin_01.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdmin_01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAdmin_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin_01.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin_01.ForeColor = System.Drawing.Color.White;
            this.btnAdmin_01.Location = new System.Drawing.Point(38, 176);
            this.btnAdmin_01.Name = "btnAdmin_01";
            this.btnAdmin_01.Size = new System.Drawing.Size(142, 45);
            this.btnAdmin_01.TabIndex = 0;
            this.btnAdmin_01.Text = "ADMIN";
            this.btnAdmin_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin_01.UseVisualStyleBackColor = true;
            this.btnAdmin_01.Click += new System.EventHandler(this.btnAdmin_01_Click);
            // 
            // loginViewPanal_01
            // 
            this.loginViewPanal_01.BackgroundImage = global::Pet_Food_Shop.Properties.Resources.Header_mobile;
            this.loginViewPanal_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginViewPanal_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginViewPanal_01.Location = new System.Drawing.Point(241, 0);
            this.loginViewPanal_01.Name = "loginViewPanal_01";
            this.loginViewPanal_01.Size = new System.Drawing.Size(623, 450);
            this.loginViewPanal_01.TabIndex = 1;
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.loginViewPanal_01);
            this.Controls.Add(this.userButtonsPanal_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(864, 450);
            this.MinimumSize = new System.Drawing.Size(864, 450);
            this.Name = "loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginfrm";
            this.userButtonsPanal_01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userButtonsPanal_01;
        private System.Windows.Forms.Panel loginViewPanal_01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose_01;
        private System.Windows.Forms.Button btnStaff_01;
        private System.Windows.Forms.Button btnCashier_01;
        private System.Windows.Forms.Button btnAdmin_01;
    }
}