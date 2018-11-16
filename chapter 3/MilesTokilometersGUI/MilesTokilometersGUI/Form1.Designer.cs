namespace MilesTokilometersGUI
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
            this.txtNumMiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumMiles
            // 
            this.txtNumMiles.Location = new System.Drawing.Point(276, 12);
            this.txtNumMiles.Name = "txtNumMiles";
            this.txtNumMiles.Size = new System.Drawing.Size(100, 20);
            this.txtNumMiles.TabIndex = 0;
            this.txtNumMiles.TextChanged += new System.EventHandler(this.txtNumMiles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter number of miles";
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.Location = new System.Drawing.Point(276, 59);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(91, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Click to convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(273, 137);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(103, 38);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(768, 517);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumMiles);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label kilometers;
        private System.Windows.Forms.TextBox txtNumMiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblAnswer;
    }
}

