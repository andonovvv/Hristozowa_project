namespace Car_journey
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.rbtnKm = new System.Windows.Forms.RadioButton();
            this.rbtnMiles = new System.Windows.Forms.RadioButton();
            this.txtMpg = new System.Windows.Forms.TextBox();
            this.txtFuelPrice = new System.Windows.Forms.TextBox();
            this.txtMotorways = new System.Windows.Forms.TextBox();
            this.txtTowns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate_Click = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtLitres = new System.Windows.Forms.TextBox();
            this.txtJourneyCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journey calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Journey distance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(279, 120);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(67, 20);
            this.txtDistance.TabIndex = 2;
            // 
            // rbtnKm
            // 
            this.rbtnKm.AutoSize = true;
            this.rbtnKm.Location = new System.Drawing.Point(521, 119);
            this.rbtnKm.Name = "rbtnKm";
            this.rbtnKm.Size = new System.Drawing.Size(73, 17);
            this.rbtnKm.TabIndex = 3;
            this.rbtnKm.Text = "Kilometers";
            this.rbtnKm.UseMnemonic = false;
            this.rbtnKm.UseVisualStyleBackColor = true;
            // 
            // rbtnMiles
            // 
            this.rbtnMiles.AutoSize = true;
            this.rbtnMiles.Checked = true;
            this.rbtnMiles.Location = new System.Drawing.Point(443, 119);
            this.rbtnMiles.Name = "rbtnMiles";
            this.rbtnMiles.Size = new System.Drawing.Size(49, 17);
            this.rbtnMiles.TabIndex = 4;
            this.rbtnMiles.TabStop = true;
            this.rbtnMiles.Text = "Miles";
            this.rbtnMiles.UseVisualStyleBackColor = true;
            this.rbtnMiles.UseWaitCursor = true;
            // 
            // txtMpg
            // 
            this.txtMpg.Location = new System.Drawing.Point(279, 182);
            this.txtMpg.Name = "txtMpg";
            this.txtMpg.Size = new System.Drawing.Size(67, 20);
            this.txtMpg.TabIndex = 5;
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(279, 239);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.Size = new System.Drawing.Size(67, 20);
            this.txtFuelPrice.TabIndex = 6;
            // 
            // txtMotorways
            // 
            this.txtMotorways.Location = new System.Drawing.Point(279, 296);
            this.txtMotorways.Name = "txtMotorways";
            this.txtMotorways.Size = new System.Drawing.Size(67, 20);
            this.txtMotorways.TabIndex = 7;
            // 
            // txtTowns
            // 
            this.txtTowns.Location = new System.Drawing.Point(279, 361);
            this.txtTowns.Name = "txtTowns";
            this.txtTowns.Size = new System.Drawing.Size(67, 20);
            this.txtTowns.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "M/Km per gallon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fuel price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "% on journey on motorways";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of town centers  per route";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "$ per litre";
            // 
            // btnCalculate_Click
            // 
            this.btnCalculate_Click.Location = new System.Drawing.Point(245, 401);
            this.btnCalculate_Click.Name = "btnCalculate_Click";
            this.btnCalculate_Click.Size = new System.Drawing.Size(281, 27);
            this.btnCalculate_Click.TabIndex = 14;
            this.btnCalculate_Click.Text = "Calculate";
            this.btnCalculate_Click.UseVisualStyleBackColor = true;
            this.btnCalculate_Click.Click += new System.EventHandler(this.btnCalculate_Click_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estimated driving time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fuel requered";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 623);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fuel cost $";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(459, 487);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(33, 13);
            this.hours.TabIndex = 18;
            this.hours.Text = "hours";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(630, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "minutes";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(279, 484);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(67, 20);
            this.txtHours.TabIndex = 20;
            // 
            // txtLitres
            // 
            this.txtLitres.Location = new System.Drawing.Point(279, 554);
            this.txtLitres.Name = "txtLitres";
            this.txtLitres.Size = new System.Drawing.Size(67, 20);
            this.txtLitres.TabIndex = 21;
            // 
            // txtJourneyCost
            // 
            this.txtJourneyCost.Location = new System.Drawing.Point(279, 620);
            this.txtJourneyCost.Name = "txtJourneyCost";
            this.txtJourneyCost.Size = new System.Drawing.Size(67, 20);
            this.txtJourneyCost.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 593);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "litres";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(521, 484);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(69, 20);
            this.txtMinutes.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJourneyCost);
            this.Controls.Add(this.txtLitres);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate_Click);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTowns);
            this.Controls.Add(this.txtMotorways);
            this.Controls.Add(this.txtFuelPrice);
            this.Controls.Add(this.txtMpg);
            this.Controls.Add(this.rbtnMiles);
            this.Controls.Add(this.rbtnKm);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Journey Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.RadioButton rbtnKm;
        private System.Windows.Forms.RadioButton rbtnMiles;
        private System.Windows.Forms.TextBox txtMpg;
        private System.Windows.Forms.TextBox txtFuelPrice;
        private System.Windows.Forms.TextBox txtMotorways;
        private System.Windows.Forms.TextBox txtTowns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate_Click;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtLitres;
        private System.Windows.Forms.TextBox txtJourneyCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinutes;
    }
}

