
namespace Tipsy
{
    partial class TIPSY
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
            this.BILL_LABEL = new System.Windows.Forms.Label();
            this.TIP_LABEL = new System.Windows.Forms.Label();
            this.NBRPPL_label = new System.Windows.Forms.Label();
            this.TipPP_label = new System.Windows.Forms.Label();
            this.TotalPP_Lbl = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.txt_peeps = new System.Windows.Forms.TextBox();
            this.Tip_Addbtn = new System.Windows.Forms.Button();
            this.Tip_Minusbtn = new System.Windows.Forms.Button();
            this.ppl_Addbtn = new System.Windows.Forms.Button();
            this.ppl_minusbtn = new System.Windows.Forms.Button();
            this.Tpp_Lbl = new System.Windows.Forms.Label();
            this.amtpp_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BILL_LABEL
            // 
            this.BILL_LABEL.AutoSize = true;
            this.BILL_LABEL.Location = new System.Drawing.Point(28, 37);
            this.BILL_LABEL.Name = "BILL_LABEL";
            this.BILL_LABEL.Size = new System.Drawing.Size(36, 17);
            this.BILL_LABEL.TabIndex = 0;
            this.BILL_LABEL.Text = "BILL";
            // 
            // TIP_LABEL
            // 
            this.TIP_LABEL.AutoSize = true;
            this.TIP_LABEL.Location = new System.Drawing.Point(28, 123);
            this.TIP_LABEL.Name = "TIP_LABEL";
            this.TIP_LABEL.Size = new System.Drawing.Size(44, 17);
            this.TIP_LABEL.TabIndex = 0;
            this.TIP_LABEL.Text = "Tip %";
            // 
            // NBRPPL_label
            // 
            this.NBRPPL_label.AutoSize = true;
            this.NBRPPL_label.Location = new System.Drawing.Point(28, 221);
            this.NBRPPL_label.Name = "NBRPPL_label";
            this.NBRPPL_label.Size = new System.Drawing.Size(122, 17);
            this.NBRPPL_label.TabIndex = 0;
            this.NBRPPL_label.Text = "Number of person";
            // 
            // TipPP_label
            // 
            this.TipPP_label.AutoSize = true;
            this.TipPP_label.Location = new System.Drawing.Point(418, 99);
            this.TipPP_label.Name = "TipPP_label";
            this.TipPP_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TipPP_label.Size = new System.Drawing.Size(0, 17);
            this.TipPP_label.TabIndex = 1;
            // 
            // TotalPP_Lbl
            // 
            this.TotalPP_Lbl.AutoSize = true;
            this.TotalPP_Lbl.Location = new System.Drawing.Point(418, 207);
            this.TotalPP_Lbl.Name = "TotalPP_Lbl";
            this.TotalPP_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalPP_Lbl.Size = new System.Drawing.Size(0, 17);
            this.TotalPP_Lbl.TabIndex = 2;
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(33, 60);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(132, 22);
            this.txt_bill.TabIndex = 3;
            this.txt_bill.TextChanged += new System.EventHandler(this.Txt_Bill_TextChanged);
            // 
            // txt_tip
            // 
            this.txt_tip.Location = new System.Drawing.Point(54, 143);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(86, 22);
            this.txt_tip.TabIndex = 3;
            this.txt_tip.TextChanged += new System.EventHandler(this.Txt_Tip_TextChanged);
            // 
            // txt_peeps
            // 
            this.txt_peeps.Location = new System.Drawing.Point(54, 240);
            this.txt_peeps.Name = "txt_peeps";
            this.txt_peeps.Size = new System.Drawing.Size(86, 22);
            this.txt_peeps.TabIndex = 3;
            this.txt_peeps.TextChanged += new System.EventHandler(this.Txt_Peeps_TextChanged);
            // 
            // Tip_Addbtn
            // 
            this.Tip_Addbtn.Location = new System.Drawing.Point(141, 143);
            this.Tip_Addbtn.Name = "Tip_Addbtn";
            this.Tip_Addbtn.Size = new System.Drawing.Size(23, 24);
            this.Tip_Addbtn.TabIndex = 4;
            this.Tip_Addbtn.Text = "+";
            this.Tip_Addbtn.UseVisualStyleBackColor = true;
            this.Tip_Addbtn.Click += new System.EventHandler(this.Tip_Addbtn_Click);
            // 
            // Tip_Minusbtn
            // 
            this.Tip_Minusbtn.Location = new System.Drawing.Point(31, 143);
            this.Tip_Minusbtn.Name = "Tip_Minusbtn";
            this.Tip_Minusbtn.Size = new System.Drawing.Size(23, 24);
            this.Tip_Minusbtn.TabIndex = 4;
            this.Tip_Minusbtn.Text = "-";
            this.Tip_Minusbtn.UseVisualStyleBackColor = true;
            this.Tip_Minusbtn.Click += new System.EventHandler(this.Tip_Minusbtn_Click);
            // 
            // ppl_Addbtn
            // 
            this.ppl_Addbtn.Location = new System.Drawing.Point(141, 240);
            this.ppl_Addbtn.Name = "ppl_Addbtn";
            this.ppl_Addbtn.Size = new System.Drawing.Size(23, 24);
            this.ppl_Addbtn.TabIndex = 4;
            this.ppl_Addbtn.Text = "+";
            this.ppl_Addbtn.UseVisualStyleBackColor = true;
            this.ppl_Addbtn.Click += new System.EventHandler(this.Pers_Addbtn_Click);
            // 
            // ppl_minusbtn
            // 
            this.ppl_minusbtn.Location = new System.Drawing.Point(31, 240);
            this.ppl_minusbtn.Name = "ppl_minusbtn";
            this.ppl_minusbtn.Size = new System.Drawing.Size(23, 24);
            this.ppl_minusbtn.TabIndex = 4;
            this.ppl_minusbtn.Text = "-";
            this.ppl_minusbtn.UseVisualStyleBackColor = true;
            this.ppl_minusbtn.Click += new System.EventHandler(this.Pers_minusbtn_Click);
            // 
            // Tpp_Lbl
            // 
            this.Tpp_Lbl.AutoSize = true;
            this.Tpp_Lbl.ForeColor = System.Drawing.Color.Black;
            this.Tpp_Lbl.Location = new System.Drawing.Point(244, 82);
            this.Tpp_Lbl.Name = "Tpp_Lbl";
            this.Tpp_Lbl.Size = new System.Drawing.Size(77, 34);
            this.Tpp_Lbl.TabIndex = 5;
            this.Tpp_Lbl.Text = "Tip          \r\nper person\r\n";
            // 
            // amtpp_lbl
            // 
            this.amtpp_lbl.AutoSize = true;
            this.amtpp_lbl.Location = new System.Drawing.Point(244, 207);
            this.amtpp_lbl.Name = "amtpp_lbl";
            this.amtpp_lbl.Size = new System.Drawing.Size(77, 34);
            this.amtpp_lbl.TabIndex = 6;
            this.amtpp_lbl.Text = "Amount \r\nper person";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ppl_minusbtn);
            this.groupBox1.Controls.Add(this.Tip_Minusbtn);
            this.groupBox1.Controls.Add(this.ppl_Addbtn);
            this.groupBox1.Controls.Add(this.Tip_Addbtn);
            this.groupBox1.Controls.Add(this.txt_peeps);
            this.groupBox1.Controls.Add(this.txt_tip);
            this.groupBox1.Controls.Add(this.txt_bill);
            this.groupBox1.Controls.Add(this.NBRPPL_label);
            this.groupBox1.Controls.Add(this.TIP_LABEL);
            this.groupBox1.Controls.Add(this.BILL_LABEL);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // TIPSY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amtpp_lbl);
            this.Controls.Add(this.Tpp_Lbl);
            this.Controls.Add(this.TotalPP_Lbl);
            this.Controls.Add(this.TipPP_label);
            this.Name = "TIPSY";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TIPSY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BILL_LABEL;
        private System.Windows.Forms.Label TIP_LABEL;
        private System.Windows.Forms.Label NBRPPL_label;
        private System.Windows.Forms.Label TipPP_label;
        private System.Windows.Forms.Label TotalPP_Lbl;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.TextBox txt_peeps;
        private System.Windows.Forms.Button Tip_Addbtn;
        private System.Windows.Forms.Button Tip_Minusbtn;
        private System.Windows.Forms.Button ppl_Addbtn;
        private System.Windows.Forms.Button ppl_minusbtn;
        private System.Windows.Forms.Label Tpp_Lbl;
        private System.Windows.Forms.Label amtpp_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

