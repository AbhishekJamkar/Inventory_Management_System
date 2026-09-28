using System.Drawing;
using System.Windows.Forms;

namespace InventoryClientApp
{
    partial class ManageOrders
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderdataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddCostomer = new System.Windows.Forms.Button();
            this.textBoxProductQty = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultTotalAmount = new System.Windows.Forms.Label();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.buttonViewOrders = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1566, 107);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1523, 9);
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
            this.label2.Location = new System.Drawing.Point(606, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Billing Process";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(490, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 816);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1566, 18);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(339, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customers List";
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(226, 172);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.RowTemplate.Height = 25;
            this.CustomersDataGridView.Size = new System.Drawing.Size(442, 205);
            this.CustomersDataGridView.TabIndex = 35;
            this.CustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellContentClick);
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Enabled = false;
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCustomerId.Location = new System.Drawing.Point(260, 480);
            this.textBoxCustomerId.Multiline = true;
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(305, 36);
            this.textBoxCustomerId.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 619);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(1168, 137);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(169, 24);
            this.comboBoxSearch.TabIndex = 41;
            this.comboBoxSearch.Text = "Select Category";
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(710, 167);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.RowTemplate.Height = 25;
            this.ProductsDataGridView.Size = new System.Drawing.Size(817, 283);
            this.ProductsDataGridView.TabIndex = 40;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1009, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Products List";
            // 
            // OrderdataGridView1
            // 
            this.OrderdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView1.Location = new System.Drawing.Point(710, 529);
            this.OrderdataGridView1.Name = "OrderdataGridView1";
            this.OrderdataGridView1.RowHeadersWidth = 51;
            this.OrderdataGridView1.RowTemplate.Height = 25;
            this.OrderdataGridView1.Size = new System.Drawing.Size(817, 164);
            this.OrderdataGridView1.TabIndex = 43;
            // 
            // buttonAddCostomer
            // 
            this.buttonAddCostomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddCostomer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonAddCostomer.Location = new System.Drawing.Point(1147, 471);
            this.buttonAddCostomer.Name = "buttonAddCostomer";
            this.buttonAddCostomer.Size = new System.Drawing.Size(144, 41);
            this.buttonAddCostomer.TabIndex = 45;
            this.buttonAddCostomer.Text = "Add To Order";
            this.buttonAddCostomer.UseVisualStyleBackColor = false;
            this.buttonAddCostomer.Click += new System.EventHandler(this.buttonAddCostomer_Click);
            // 
            // textBoxProductQty
            // 
            this.textBoxProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductQty.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxProductQty.Location = new System.Drawing.Point(854, 475);
            this.textBoxProductQty.Multiline = true;
            this.textBoxProductQty.Name = "textBoxProductQty";
            this.textBoxProductQty.Size = new System.Drawing.Size(285, 36);
            this.textBoxProductQty.TabIndex = 44;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Enabled = false;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCustomerName.Location = new System.Drawing.Point(260, 548);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(305, 36);
            this.textBoxCustomerName.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(875, 706);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "Total amount :";
            // 
            // resultTotalAmount
            // 
            this.resultTotalAmount.AutoSize = true;
            this.resultTotalAmount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.resultTotalAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultTotalAmount.Location = new System.Drawing.Point(1018, 706);
            this.resultTotalAmount.Name = "resultTotalAmount";
            this.resultTotalAmount.Size = new System.Drawing.Size(73, 29);
            this.resultTotalAmount.TabIndex = 48;
            this.resultTotalAmount.Text = "Result";
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInsertOrder.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonInsertOrder.Location = new System.Drawing.Point(260, 728);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(144, 41);
            this.buttonInsertOrder.TabIndex = 49;
            this.buttonInsertOrder.Text = "Insert Order";
            this.buttonInsertOrder.UseVisualStyleBackColor = false;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // buttonViewOrders
            // 
            this.buttonViewOrders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonViewOrders.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonViewOrders.Location = new System.Drawing.Point(421, 728);
            this.buttonViewOrders.Name = "buttonViewOrders";
            this.buttonViewOrders.Size = new System.Drawing.Size(144, 41);
            this.buttonViewOrders.TabIndex = 50;
            this.buttonViewOrders.Text = "View Orders";
            this.buttonViewOrders.UseVisualStyleBackColor = false;
            this.buttonViewOrders.Click += new System.EventHandler(this.buttonViewOrders_Click);
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
            this.panel6.Size = new System.Drawing.Size(205, 709);
            this.panel6.TabIndex = 51;
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
            this.button3.Location = new System.Drawing.Point(12, 617);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Cusomer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "CusomerID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(740, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Quantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "OrderID";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Enabled = false;
            this.textBoxOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderId.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxOrderId.Location = new System.Drawing.Point(260, 420);
            this.textBoxOrderId.Multiline = true;
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(266, 30);
            this.textBoxOrderId.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Order Date";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(260, 688);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 24);
            this.radioButton1.TabIndex = 57;
            this.radioButton1.Text = "CASH";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(448, 688);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(176, 24);
            this.radioButton2.TabIndex = 58;
            this.radioButton2.Text = "ONLINE PAYMENT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(256, 660);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Payment Mode";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(364, 688);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 24);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.Text = "CARD";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 834);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonViewOrders);
            this.Controls.Add(this.buttonInsertOrder);
            this.Controls.Add(this.resultTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.buttonAddCostomer);
            this.Controls.Add(this.textBoxProductQty);
            this.Controls.Add(this.OrderdataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.CustomersDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView CustomersDataGridView;
        private TextBox textBoxCustomerId;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxSearch;
        private DataGridView ProductsDataGridView;
        private Label label6;
        private DataGridView OrderdataGridView1;
        private Button buttonAddCostomer;
        private TextBox textBoxProductQty;
        private TextBox textBoxCustomerName;
        private Label label7;
        private Label resultTotalAmount;
        private Button buttonInsertOrder;
        private Button buttonViewOrders;
        private Panel panel6;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label10;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox textBoxOrderId;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label12;
        private RadioButton radioButton3;
    }
}