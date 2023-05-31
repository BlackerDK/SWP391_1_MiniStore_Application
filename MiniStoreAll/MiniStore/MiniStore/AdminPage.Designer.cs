namespace MiniStore
{
    partial class AdminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tgDataAdmin = new System.Windows.Forms.TabControl();
            this.tbPageEmployee = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListEmployees = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalaryEmployees = new System.Windows.Forms.Button();
            this.btAddEmployees = new System.Windows.Forms.Button();
            this.btShowEmployees = new System.Windows.Forms.Button();
            this.tbPageProduct = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbType5 = new System.Windows.Forms.RadioButton();
            this.rdbType4 = new System.Windows.Forms.RadioButton();
            this.rdbType3 = new System.Windows.Forms.RadioButton();
            this.rdbType2 = new System.Windows.Forms.RadioButton();
            this.rdbType1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btAddProducts = new System.Windows.Forms.Button();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.tbPageRevune = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPageWorkSheet = new System.Windows.Forms.TabPage();
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
            this.tgDataAdmin.SuspendLayout();
            this.tbPageEmployee.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbPageProduct.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tgDataAdmin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1109, 480);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tgDataAdmin
            // 
            this.tgDataAdmin.Controls.Add(this.tbPageEmployee);
            this.tgDataAdmin.Controls.Add(this.tbPageProduct);
            this.tgDataAdmin.Controls.Add(this.tbPageRevune);
            this.tgDataAdmin.Controls.Add(this.tbPageWorkSheet);
            this.tgDataAdmin.Controls.Add(this.tbSalary);
            this.tgDataAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tgDataAdmin.Location = new System.Drawing.Point(3, 3);
            this.tgDataAdmin.Name = "tgDataAdmin";
            this.tgDataAdmin.SelectedIndex = 0;
            this.tgDataAdmin.Size = new System.Drawing.Size(1104, 474);
            this.tgDataAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tgDataAdmin.TabIndex = 2;
            // 
            // tbPageEmployee
            // 
            this.tbPageEmployee.AutoScroll = true;
            this.tbPageEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbPageEmployee.Controls.Add(this.panel2);
            this.tbPageEmployee.Controls.Add(this.panel1);
            this.tbPageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tbPageEmployee.Name = "tbPageEmployee";
            this.tbPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageEmployee.Size = new System.Drawing.Size(1096, 441);
            this.tbPageEmployee.TabIndex = 0;
            this.tbPageEmployee.Text = "Employees";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListEmployees);
            this.panel2.Location = new System.Drawing.Point(6, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 325);
            this.panel2.TabIndex = 4;
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvListEmployees.Name = "dgvListEmployees";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListEmployees.RowHeadersWidth = 51;
            this.dgvListEmployees.RowTemplate.Height = 24;
            this.dgvListEmployees.Size = new System.Drawing.Size(1078, 322);
            this.dgvListEmployees.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSalaryEmployees);
            this.panel1.Controls.Add(this.btAddEmployees);
            this.panel1.Controls.Add(this.btShowEmployees);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 98);
            this.panel1.TabIndex = 2;
            // 
            // btSalaryEmployees
            // 
            this.btSalaryEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSalaryEmployees.Location = new System.Drawing.Point(374, 21);
            this.btSalaryEmployees.Name = "btSalaryEmployees";
            this.btSalaryEmployees.Size = new System.Drawing.Size(136, 41);
            this.btSalaryEmployees.TabIndex = 2;
            this.btSalaryEmployees.Text = "Salary";
            this.btSalaryEmployees.UseVisualStyleBackColor = true;
            // 
            // btAddEmployees
            // 
            this.btAddEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddEmployees.Location = new System.Drawing.Point(187, 21);
            this.btAddEmployees.Name = "btAddEmployees";
            this.btAddEmployees.Size = new System.Drawing.Size(136, 41);
            this.btAddEmployees.TabIndex = 1;
            this.btAddEmployees.Text = "Add";
            this.btAddEmployees.UseVisualStyleBackColor = true;
            this.btAddEmployees.Click += new System.EventHandler(this.btAddEmployees_Click);
            // 
            // btShowEmployees
            // 
            this.btShowEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btShowEmployees.Location = new System.Drawing.Point(6, 21);
            this.btShowEmployees.Name = "btShowEmployees";
            this.btShowEmployees.Size = new System.Drawing.Size(136, 41);
            this.btShowEmployees.TabIndex = 0;
            this.btShowEmployees.Text = "Show";
            this.btShowEmployees.UseVisualStyleBackColor = true;
            this.btShowEmployees.Click += new System.EventHandler(this.btShowEmployees_Click);
            // 
            // tbPageProduct
            // 
            this.tbPageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbPageProduct.Controls.Add(this.panel5);
            this.tbPageProduct.Controls.Add(this.panel4);
            this.tbPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tbPageProduct.Name = "tbPageProduct";
            this.tbPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageProduct.Size = new System.Drawing.Size(1096, 441);
            this.tbPageProduct.TabIndex = 1;
            this.tbPageProduct.Text = "Products";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvListProducts);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(9, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1081, 325);
            this.panel5.TabIndex = 4;
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListProducts.Location = new System.Drawing.Point(165, 4);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.RowHeadersWidth = 51;
            this.dgvListProducts.RowTemplate.Height = 24;
            this.dgvListProducts.Size = new System.Drawing.Size(913, 318);
            this.dgvListProducts.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbType5);
            this.panel3.Controls.Add(this.rdbType4);
            this.panel3.Controls.Add(this.rdbType3);
            this.panel3.Controls.Add(this.rdbType2);
            this.panel3.Controls.Add(this.rdbType1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 325);
            this.panel3.TabIndex = 1;
            // 
            // rdbType5
            // 
            this.rdbType5.AutoSize = true;
            this.rdbType5.Location = new System.Drawing.Point(21, 232);
            this.rdbType5.Name = "rdbType5";
            this.rdbType5.Size = new System.Drawing.Size(105, 24);
            this.rdbType5.TabIndex = 4;
            this.rdbType5.TabStop = true;
            this.rdbType5.Text = "Number5";
            this.rdbType5.UseVisualStyleBackColor = true;
            // 
            // rdbType4
            // 
            this.rdbType4.AutoSize = true;
            this.rdbType4.Location = new System.Drawing.Point(21, 177);
            this.rdbType4.Name = "rdbType4";
            this.rdbType4.Size = new System.Drawing.Size(105, 24);
            this.rdbType4.TabIndex = 3;
            this.rdbType4.TabStop = true;
            this.rdbType4.Text = "Number4";
            this.rdbType4.UseVisualStyleBackColor = true;
            // 
            // rdbType3
            // 
            this.rdbType3.AutoSize = true;
            this.rdbType3.Location = new System.Drawing.Point(21, 122);
            this.rdbType3.Name = "rdbType3";
            this.rdbType3.Size = new System.Drawing.Size(105, 24);
            this.rdbType3.TabIndex = 2;
            this.rdbType3.TabStop = true;
            this.rdbType3.Text = "Number3";
            this.rdbType3.UseVisualStyleBackColor = true;
            // 
            // rdbType2
            // 
            this.rdbType2.AutoSize = true;
            this.rdbType2.Location = new System.Drawing.Point(21, 67);
            this.rdbType2.Name = "rdbType2";
            this.rdbType2.Size = new System.Drawing.Size(105, 24);
            this.rdbType2.TabIndex = 1;
            this.rdbType2.TabStop = true;
            this.rdbType2.Text = "Number2";
            this.rdbType2.UseVisualStyleBackColor = true;
            // 
            // rdbType1
            // 
            this.rdbType1.AutoSize = true;
            this.rdbType1.Location = new System.Drawing.Point(21, 12);
            this.rdbType1.Name = "rdbType1";
            this.rdbType1.Size = new System.Drawing.Size(105, 24);
            this.rdbType1.TabIndex = 0;
            this.rdbType1.TabStop = true;
            this.rdbType1.Text = "Number1";
            this.rdbType1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btAddProducts);
            this.panel4.Controls.Add(this.btShowProducts);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 98);
            this.panel4.TabIndex = 3;
            // 
            // btAddProducts
            // 
            this.btAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddProducts.Location = new System.Drawing.Point(187, 21);
            this.btAddProducts.Name = "btAddProducts";
            this.btAddProducts.Size = new System.Drawing.Size(136, 41);
            this.btAddProducts.TabIndex = 1;
            this.btAddProducts.Text = "Add";
            this.btAddProducts.UseVisualStyleBackColor = true;
            // 
            // btShowProducts
            // 
            this.btShowProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btShowProducts.Location = new System.Drawing.Point(6, 21);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(136, 41);
            this.btShowProducts.TabIndex = 0;
            this.btShowProducts.Text = "Show";
            this.btShowProducts.UseVisualStyleBackColor = true;
            // 
            // tbPageRevune
            // 
            this.tbPageRevune.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbPageRevune.Location = new System.Drawing.Point(4, 29);
            this.tbPageRevune.Name = "tbPageRevune";
            this.tbPageRevune.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageRevune.Size = new System.Drawing.Size(1096, 441);
            this.tbPageRevune.TabIndex = 2;
            this.tbPageRevune.Text = "Revune";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // tbPageWorkSheet
            // 
            this.tbPageWorkSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPageWorkSheet.Location = new System.Drawing.Point(4, 29);
            this.tbPageWorkSheet.Name = "tbPageWorkSheet";
            this.tbPageWorkSheet.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageWorkSheet.Size = new System.Drawing.Size(1096, 441);
            this.tbPageWorkSheet.TabIndex = 3;
            this.tbPageWorkSheet.Text = "WorkSheet";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(4, 29);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalary.Size = new System.Drawing.Size(1096, 441);
            this.tbSalary.TabIndex = 4;
            this.tbSalary.Text = "Salary";
            this.tbSalary.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 614);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tgDataAdmin.ResumeLayout(false);
            this.tbPageEmployee.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tbPageProduct.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabControl tgDataAdmin;
        private System.Windows.Forms.TabPage tbPageEmployee;
        private System.Windows.Forms.TabPage tbPageProduct;
        private System.Windows.Forms.TabPage tbPageRevune;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddEmployees;
        private System.Windows.Forms.Button btShowEmployees;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbType5;
        private System.Windows.Forms.RadioButton rdbType4;
        private System.Windows.Forms.RadioButton rdbType3;
        private System.Windows.Forms.RadioButton rdbType2;
        private System.Windows.Forms.RadioButton rdbType1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btAddProducts;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.Button btSalaryEmployees;
        private System.Windows.Forms.TabPage tbPageWorkSheet;
        private System.Windows.Forms.TabPage tbSalary;
    }
}