namespace HelloVisualWorld
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btngoodbye = new System.Windows.Forms.Button();
            this.btnreally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(224, 121);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(90, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Here";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(221, 64);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(93, 13);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello Visual World";
            this.lblHello.Visible = false;
            // 
            // btngoodbye
            // 
            this.btngoodbye.Location = new System.Drawing.Point(224, 186);
            this.btngoodbye.Name = "btngoodbye";
            this.btngoodbye.Size = new System.Drawing.Size(90, 23);
            this.btngoodbye.TabIndex = 2;
            this.btngoodbye.Text = "Click me last";
            this.btngoodbye.UseVisualStyleBackColor = true;
            this.btngoodbye.Click += new System.EventHandler(this.btngoodbye_Click);
            // 
            // btnreally
            // 
            this.btnreally.Location = new System.Drawing.Point(224, 242);
            this.btnreally.Name = "btnreally";
            this.btnreally.Size = new System.Drawing.Size(140, 23);
            this.btnreally.TabIndex = 3;
            this.btnreally.Text = "No, really click me last";
            this.btnreally.UseVisualStyleBackColor = true;
            this.btnreally.Click += new System.EventHandler(this.btnreally_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreally);
            this.Controls.Add(this.btngoodbye);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btngoodbye;
        private System.Windows.Forms.Button btnreally;
    }
}

