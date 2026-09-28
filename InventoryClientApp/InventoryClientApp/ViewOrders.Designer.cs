using System.Drawing;
using System.Windows.Forms;

namespace InventoryClientApp
{
    partial class ViewOrders
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
            this.OrderdataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonViewOrders = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1237, 107);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1206, 0);
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
            this.label2.Location = new System.Drawing.Point(494, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(378, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // OrderdataGridView2
            // 
            this.OrderdataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderdataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView2.Location = new System.Drawing.Point(310, 155);
            this.OrderdataGridView2.Name = "OrderdataGridView2";
            this.OrderdataGridView2.RowHeadersWidth = 51;
            this.OrderdataGridView2.RowTemplate.Height = 25;
            this.OrderdataGridView2.Size = new System.Drawing.Size(856, 356);
            this.OrderdataGridView2.TabIndex = 44;
            this.OrderdataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderdataGridView2_CellContentClick);
            // 
            // buttonViewOrders
            // 
            this.buttonViewOrders.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonViewOrders.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.buttonViewOrders.Location = new System.Drawing.Point(310, 542);
            this.buttonViewOrders.Name = "buttonViewOrders";
            this.buttonViewOrders.Size = new System.Drawing.Size(216, 41);
            this.buttonViewOrders.TabIndex = 51;
            this.buttonViewOrders.Text = "Back To Manage Orders";
            this.buttonViewOrders.UseVisualStyleBackColor = false;
            this.buttonViewOrders.Click += new System.EventHandler(this.buttonViewOrders_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 18);
            this.panel2.TabIndex = 52;
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
            this.panel6.Size = new System.Drawing.Size(205, 544);
            this.panel6.TabIndex = 53;
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
            this.button3.Location = new System.Drawing.Point(12, 488);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button1.Location = new System.Drawing.Point(911, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 41);
            this.button1.TabIndex = 54;
            this.button1.Text = "View Order Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonViewOrders);
            this.Controls.Add(this.OrderdataGridView2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView OrderdataGridView2;
        private Button buttonViewOrders;
        private Panel panel2;
        private Panel panel6;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button1;
    }
}