namespace PhotoPriceCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrintCost = new System.Windows.Forms.Label();
            this.txtCSW = new System.Windows.Forms.TextBox();
            this.txtCSP = new System.Windows.Forms.TextBox();
            this.txtCSH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtASH = new System.Windows.Forms.TextBox();
            this.txtASW = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Photo Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Closest Size(mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Closest Size\'s Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actual Size(mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost of Print:";
            // 
            // lblPrintCost
            // 
            this.lblPrintCost.AutoSize = true;
            this.lblPrintCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintCost.Location = new System.Drawing.Point(149, 207);
            this.lblPrintCost.Name = "lblPrintCost";
            this.lblPrintCost.Size = new System.Drawing.Size(0, 24);
            this.lblPrintCost.TabIndex = 5;
            // 
            // txtCSW
            // 
            this.txtCSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSW.Location = new System.Drawing.Point(49, 98);
            this.txtCSW.Name = "txtCSW";
            this.txtCSW.Size = new System.Drawing.Size(54, 23);
            this.txtCSW.TabIndex = 6;
            this.txtCSW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSW_KeyPress);
            // 
            // txtCSP
            // 
            this.txtCSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSP.Location = new System.Drawing.Point(234, 98);
            this.txtCSP.Name = "txtCSP";
            this.txtCSP.Size = new System.Drawing.Size(100, 26);
            this.txtCSP.TabIndex = 7;
            this.txtCSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSP_KeyPress);
            // 
            // txtCSH
            // 
            this.txtCSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSH.Location = new System.Drawing.Point(131, 98);
            this.txtCSH.Name = "txtCSH";
            this.txtCSH.Size = new System.Drawing.Size(54, 23);
            this.txtCSH.TabIndex = 9;
            this.txtCSH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSH_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "H";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "W";
            // 
            // txtASH
            // 
            this.txtASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASH.Location = new System.Drawing.Point(131, 167);
            this.txtASH.Name = "txtASH";
            this.txtASH.Size = new System.Drawing.Size(54, 23);
            this.txtASH.TabIndex = 13;
            this.txtASH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtASH_KeyPress);
            // 
            // txtASW
            // 
            this.txtASW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASW.Location = new System.Drawing.Point(49, 167);
            this.txtASW.Name = "txtASW";
            this.txtASW.Size = new System.Drawing.Size(54, 23);
            this.txtASW.TabIndex = 12;
            this.txtASW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtASW_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(234, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 38);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 249);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtASH);
            this.Controls.Add(this.txtASW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCSH);
            this.Controls.Add(this.txtCSP);
            this.Controls.Add(this.txtCSW);
            this.Controls.Add(this.lblPrintCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Photo Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrintCost;
        private System.Windows.Forms.TextBox txtCSW;
        private System.Windows.Forms.TextBox txtCSP;
        private System.Windows.Forms.TextBox txtCSH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtASH;
        private System.Windows.Forms.TextBox txtASW;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

