
namespace Pet_Food_Shop
{
    partial class CategoryFrm
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
            this.btnAdd_new_category_A = new System.Windows.Forms.Button();
            this.btnViewCategory_A = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd_new_category_A
            // 
            this.btnAdd_new_category_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnAdd_new_category_A.FlatAppearance.BorderSize = 0;
            this.btnAdd_new_category_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            this.btnAdd_new_category_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAdd_new_category_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnAdd_new_category_A.ForeColor = System.Drawing.Color.White;
            this.btnAdd_new_category_A.Location = new System.Drawing.Point(104, 120);
            this.btnAdd_new_category_A.Name = "btnAdd_new_category_A";
            this.btnAdd_new_category_A.Size = new System.Drawing.Size(200, 60);
            this.btnAdd_new_category_A.TabIndex = 0;
            this.btnAdd_new_category_A.Text = "Add New Category";
            this.btnAdd_new_category_A.UseVisualStyleBackColor = false;
            this.btnAdd_new_category_A.Click += new System.EventHandler(this.btnAdd_new_category_A_Click);
            // 
            // btnViewCategory_A
            // 
            this.btnViewCategory_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnViewCategory_A.FlatAppearance.BorderSize = 0;
            this.btnViewCategory_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray;
            this.btnViewCategory_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnViewCategory_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnViewCategory_A.ForeColor = System.Drawing.Color.White;
            this.btnViewCategory_A.Location = new System.Drawing.Point(104, 200);
            this.btnViewCategory_A.Name = "btnViewCategory_A";
            this.btnViewCategory_A.Size = new System.Drawing.Size(200, 60);
            this.btnViewCategory_A.TabIndex = 1;
            this.btnViewCategory_A.Text = "View Category";
            this.btnViewCategory_A.UseVisualStyleBackColor = false;
            this.btnViewCategory_A.Click += new System.EventHandler(this.btnViewCategory_A_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(30, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 30);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(879, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 542);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(30, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 30);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 572);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewCategory_A);
            this.Controls.Add(this.btnAdd_new_category_A);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Category";
            this.Text = "Category";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_new_category_A;
        private System.Windows.Forms.Button btnViewCategory_A;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}