
namespace Pet_Food_Shop
{
    partial class report
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
            System.Windows.Forms.Button btnMonthlyReport_A;
            this.label1 = new System.Windows.Forms.Label();
            this.btnDailyReport_A = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            btnMonthlyReport_A = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMonthlyReport_A
            // 
            btnMonthlyReport_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            btnMonthlyReport_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            btnMonthlyReport_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            btnMonthlyReport_A.ForeColor = System.Drawing.Color.White;
            btnMonthlyReport_A.Location = new System.Drawing.Point(104, 200);
            btnMonthlyReport_A.Name = "btnMonthlyReport_A";
            btnMonthlyReport_A.Size = new System.Drawing.Size(200, 60);
            btnMonthlyReport_A.TabIndex = 1;
            btnMonthlyReport_A.Text = "All Sales";
            btnMonthlyReport_A.UseVisualStyleBackColor = false;
            btnMonthlyReport_A.Click += new System.EventHandler(this.btnMonthlyReport_A_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDailyReport_A
            // 
            this.btnDailyReport_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnDailyReport_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            this.btnDailyReport_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnDailyReport_A.ForeColor = System.Drawing.Color.White;
            this.btnDailyReport_A.Location = new System.Drawing.Point(104, 120);
            this.btnDailyReport_A.Name = "btnDailyReport_A";
            this.btnDailyReport_A.Size = new System.Drawing.Size(200, 60);
            this.btnDailyReport_A.TabIndex = 1;
            this.btnDailyReport_A.Text = "Last 30 Days";
            this.btnDailyReport_A.UseVisualStyleBackColor = false;
            this.btnDailyReport_A.Click += new System.EventHandler(this.btnDailyReport_A_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(30, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 30);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(802, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 515);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(30, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 30);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 545);
            this.panel1.TabIndex = 13;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(btnMonthlyReport_A);
            this.Controls.Add(this.btnDailyReport_A);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "report";
            this.Text = "report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDailyReport_A;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}