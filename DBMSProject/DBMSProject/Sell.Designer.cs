﻿namespace DBMSProject
{
    partial class Sell
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
            this.vehicleCB = new System.Windows.Forms.ComboBox();
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.Vehicle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repairCostLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.sellDGV = new System.Windows.Forms.DataGridView();
            this.sellBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.commissionLB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.commissionPercLB = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sellidTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleCB
            // 
            this.vehicleCB.BackColor = System.Drawing.Color.Black;
            this.vehicleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCB.ForeColor = System.Drawing.Color.Yellow;
            this.vehicleCB.FormattingEnabled = true;
            this.vehicleCB.Location = new System.Drawing.Point(101, 12);
            this.vehicleCB.Name = "vehicleCB";
            this.vehicleCB.Size = new System.Drawing.Size(122, 26);
            this.vehicleCB.TabIndex = 15;
            this.vehicleCB.SelectedIndexChanged += new System.EventHandler(this.vehicleCB_Change);
            // 
            // customerCB
            // 
            this.customerCB.BackColor = System.Drawing.Color.Black;
            this.customerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCB.ForeColor = System.Drawing.Color.Yellow;
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(340, 12);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(122, 26);
            this.customerCB.TabIndex = 16;
            // 
            // Vehicle
            // 
            this.Vehicle.AutoSize = true;
            this.Vehicle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.Vehicle.Location = new System.Drawing.Point(14, 18);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(56, 20);
            this.Vehicle.TabIndex = 17;
            this.Vehicle.Text = "Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(248, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(334, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cost";
            // 
            // costLB
            // 
            this.costLB.AutoSize = true;
            this.costLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.costLB.Location = new System.Drawing.Point(445, 73);
            this.costLB.Name = "costLB";
            this.costLB.Size = new System.Drawing.Size(17, 20);
            this.costLB.TabIndex = 20;
            this.costLB.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(334, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Repair Cost";
            // 
            // repairCostLB
            // 
            this.repairCostLB.AutoSize = true;
            this.repairCostLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCostLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.repairCostLB.Location = new System.Drawing.Point(445, 114);
            this.repairCostLB.Name = "repairCostLB";
            this.repairCostLB.Size = new System.Drawing.Size(17, 20);
            this.repairCostLB.TabIndex = 22;
            this.repairCostLB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(336, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total";
            // 
            // totalLB
            // 
            this.totalLB.AutoSize = true;
            this.totalLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.totalLB.Location = new System.Drawing.Point(445, 148);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(17, 20);
            this.totalLB.TabIndex = 24;
            this.totalLB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label8.Location = new System.Drawing.Point(567, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sell Price";
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.Color.Black;
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.ForeColor = System.Drawing.Color.Yellow;
            this.priceTB.Location = new System.Drawing.Point(658, 18);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(122, 22);
            this.priceTB.TabIndex = 31;
            this.priceTB.Text = "Enter Sell Price";
            this.priceTB.TextChanged += new System.EventHandler(this.price_Changed);
            // 
            // sellDGV
            // 
            this.sellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDGV.Location = new System.Drawing.Point(13, 264);
            this.sellDGV.Name = "sellDGV";
            this.sellDGV.Size = new System.Drawing.Size(787, 187);
            this.sellDGV.TabIndex = 33;
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.Black;
            this.sellBtn.Location = new System.Drawing.Point(684, 230);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(96, 28);
            this.sellBtn.TabIndex = 34;
            this.sellBtn.Text = "Sell Car";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(18, 221);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(115, 28);
            this.delBtn.TabIndex = 36;
            this.delBtn.Text = "Remove Sell";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // commissionLB
            // 
            this.commissionLB.AutoSize = true;
            this.commissionLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commissionLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.commissionLB.Location = new System.Drawing.Point(721, 114);
            this.commissionLB.Name = "commissionLB";
            this.commissionLB.Size = new System.Drawing.Size(17, 20);
            this.commissionLB.TabIndex = 40;
            this.commissionLB.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label10.Location = new System.Drawing.Point(567, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Your Commission";
            // 
            // commissionPercLB
            // 
            this.commissionPercLB.AutoSize = true;
            this.commissionPercLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commissionPercLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.commissionPercLB.Location = new System.Drawing.Point(721, 73);
            this.commissionPercLB.Name = "commissionPercLB";
            this.commissionPercLB.Size = new System.Drawing.Size(17, 20);
            this.commissionPercLB.TabIndex = 38;
            this.commissionPercLB.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label12.Location = new System.Drawing.Point(523, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Commission Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(744, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            this.label5.Location = new System.Drawing.Point(10, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sell ID";
            // 
            // sellidTB
            // 
            this.sellidTB.BackColor = System.Drawing.Color.Black;
            this.sellidTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellidTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellidTB.ForeColor = System.Drawing.Color.Yellow;
            this.sellidTB.Location = new System.Drawing.Point(101, 179);
            this.sellidTB.Name = "sellidTB";
            this.sellidTB.Size = new System.Drawing.Size(122, 22);
            this.sellidTB.TabIndex = 42;
            this.sellidTB.Text = "Enter Sell ID";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sellidTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commissionLB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.commissionPercLB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.sellDGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.totalLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repairCostLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.customerCB);
            this.Controls.Add(this.vehicleCB);
            this.Name = "Sell";
            this.Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)(this.sellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vehicleCB;
        private System.Windows.Forms.ComboBox customerCB;
        private System.Windows.Forms.Label Vehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label repairCostLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.DataGridView sellDGV;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label commissionLB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label commissionPercLB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sellidTB;
    }
}