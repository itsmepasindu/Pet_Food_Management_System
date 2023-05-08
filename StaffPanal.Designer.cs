
namespace Pet_Food_Shop
{
    partial class StaffPanal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout_S = new System.Windows.Forms.Button();
            this.btnPayment_S = new System.Windows.Forms.Button();
            this.StaffPanalView_01 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnLogout_S);
            this.panel1.Controls.Add(this.btnPayment_S);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 450);
            this.panel1.TabIndex = 4;
            // 
            // btnLogout_S
            // 
            this.btnLogout_S.FlatAppearance.BorderSize = 0;
            this.btnLogout_S.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            this.btnLogout_S.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnLogout_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_S.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_S.ForeColor = System.Drawing.Color.White;
            this.btnLogout_S.Location = new System.Drawing.Point(22, 167);
            this.btnLogout_S.Name = "btnLogout_S";
            this.btnLogout_S.Size = new System.Drawing.Size(140, 45);
            this.btnLogout_S.TabIndex = 0;
            this.btnLogout_S.Text = "Logout";
            this.btnLogout_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout_S.UseVisualStyleBackColor = true;
            this.btnLogout_S.Click += new System.EventHandler(this.btnLogout_A_Click);
            // 
            // btnPayment_S
            // 
            this.btnPayment_S.FlatAppearance.BorderSize = 0;
            this.btnPayment_S.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            this.btnPayment_S.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnPayment_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment_S.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment_S.ForeColor = System.Drawing.Color.White;
            this.btnPayment_S.Location = new System.Drawing.Point(22, 116);
            this.btnPayment_S.Name = "btnPayment_S";
            this.btnPayment_S.Size = new System.Drawing.Size(140, 45);
            this.btnPayment_S.TabIndex = 0;
            this.btnPayment_S.Text = "Payments";
            this.btnPayment_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment_S.UseVisualStyleBackColor = true;
            this.btnPayment_S.Click += new System.EventHandler(this.btnPayment_S_Click);
            // 
            // StaffPanalView_01
            // 
            this.StaffPanalView_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPanalView_01.Location = new System.Drawing.Point(232, 0);
            this.StaffPanalView_01.Name = "StaffPanalView_01";
            this.StaffPanalView_01.Size = new System.Drawing.Size(568, 450);
            this.StaffPanalView_01.TabIndex = 5;
            // 
            // StaffPanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffPanalView_01);
            this.Controls.Add(this.panel1);
            this.Name = "StaffPanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPanal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout_S;
        private System.Windows.Forms.Button btnPayment_S;
        private System.Windows.Forms.Panel StaffPanalView_01;
    }
}