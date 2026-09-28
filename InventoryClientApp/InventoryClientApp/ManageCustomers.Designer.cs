using System.Drawing;
using System.Windows.Forms;

namespace InventoryClientApp
{
    partial class ManageCustomers
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddCostomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderLableCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LableAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 107);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1325, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(588, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // textBoxCustomerPhoneNumber
            // 
            this.textBoxCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerPhoneNumber.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCustomerPhoneNumber.Location = new System.Drawing.Point(270, 332);
            this.textBoxCustomerPhoneNumber.MaxLength = 10;
            this.textBoxCustomerPhoneNumber.Multiline = true;
            this.textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            this.textBoxCustomerPhoneNumber.Size = new System.Drawing.Size(285, 36);
            this.textBoxCustomerPhoneNumber.TabIndex = 7;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCustomerName.Location = new System.Drawing.Point(270, 262);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(285, 36);
            this.textBoxCustomerName.TabIndex = 6;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCustomerID.Location = new System.Drawing.Point(270, 187);
            this.textBoxCustomerID.Multiline = true;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(285, 36);
            this.textBoxCustomerID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(844, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customers List";
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(622, 175);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.RowTemplate.Height = 25;
            this.CustomersDataGridView.Size = new System.Drawing.Size(677, 279);
            this.CustomersDataGridView.TabIndex = 13;
            this.CustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellContentClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonClear.Location = new System.Drawing.Point(267, 449);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(286, 41);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(467, 395);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEdit.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(367, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 41);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddCostomer
            // 
            this.buttonAddCostomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddCostomer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonAddCostomer.Location = new System.Drawing.Point(267, 395);
            this.buttonAddCostomer.Name = "buttonAddCostomer";
            this.buttonAddCostomer.Size = new System.Drawing.Size(86, 41);
            this.buttonAddCostomer.TabIndex = 14;
            this.buttonAddCostomer.Text = "Add";
            this.buttonAddCostomer.UseVisualStyleBackColor = false;
            this.buttonAddCostomer.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 747);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 18);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.OrderLableCount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(626, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 107);
            this.panel3.TabIndex = 20;
            // 
            // OrderLableCount
            // 
            this.OrderLableCount.AutoSize = true;
            this.OrderLableCount.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.OrderLableCount.Location = new System.Drawing.Point(87, 51);
            this.OrderLableCount.Name = "OrderLableCount";
            this.OrderLableCount.Size = new System.Drawing.Size(26, 31);
            this.OrderLableCount.TabIndex = 3;
            this.OrderLableCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Oders Count";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.LableAmount);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(845, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 107);
            this.panel4.TabIndex = 21;
            // 
            // LableAmount
            // 
            this.LableAmount.AutoSize = true;
            this.LableAmount.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.LableAmount.Location = new System.Drawing.Point(97, 50);
            this.LableAmount.Name = "LableAmount";
            this.LableAmount.Size = new System.Drawing.Size(26, 31);
            this.LableAmount.TabIndex = 4;
            this.LableAmount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(46, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Orders Amount";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.labelDate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(1061, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 107);
            this.panel5.TabIndex = 21;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(21, 50);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 31);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(80, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Order Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 640);
            this.panel6.TabIndex = 39;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 54);
            this.button4.TabIndex = 28;
            this.button4.Text = "Orders";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 47);
            this.button3.TabIndex = 27;
            this.button3.Text = "LogOut";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 54);
            this.button5.TabIndex = 26;
            this.button5.Text = "Billing";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 54);
            this.button6.TabIndex = 25;
            this.button6.Text = "Customer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "CusomerID";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 765);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddCostomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomersDataGridView);
            this.Controls.Add(this.textBoxCustomerPhoneNumber);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCustomerPhoneNumber;
        private TextBox textBoxCustomerName;
        private TextBox textBoxCustomerID;
        private Label label4;
        private DataGridView CustomersDataGridView;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAddCostomer;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label OrderLableCount;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Label LableAmount;
        private Label labelDate;
        private Panel panel6;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}