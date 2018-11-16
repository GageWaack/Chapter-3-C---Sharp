namespace GUIcalculator
{
    partial class GUIcalculator
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
            this.btnsum = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(362, 123);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(75, 23);
            this.btnsum.TabIndex = 2;
            this.btnsum.Text = "add";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(281, 123);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 5;
            this.btnsub.Text = "subtract";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(200, 123);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "divide";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(119, 123);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 11;
            this.btnmulti.Text = "multiply";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(38, 123);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 14;
            this.btnmod.Text = "modulus";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt2.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt2.Location = new System.Drawing.Point(272, 50);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(59, 20);
            this.txt2.TabIndex = 18;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt1.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt1.Location = new System.Drawing.Point(109, 50);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(59, 20);
            this.txt1.TabIndex = 19;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblResult.Location = new System.Drawing.Point(173, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(126, 29);
            this.lblResult.TabIndex = 20;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kinda looks like face";
            // 
            // GUIcalculator
            // 
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(456, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsum);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GUIcalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lbResultAdd;
        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Label Lbresultdiv;
        private System.Windows.Forms.Label lblresultmult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

