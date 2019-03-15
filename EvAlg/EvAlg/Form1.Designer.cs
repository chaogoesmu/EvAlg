namespace EvAlg
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
            this.b_test = new System.Windows.Forms.Button();
            this.TB1_str_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_test
            // 
            this.b_test.Location = new System.Drawing.Point(678, 41);
            this.b_test.Name = "b_test";
            this.b_test.Size = new System.Drawing.Size(85, 41);
            this.b_test.TabIndex = 0;
            this.b_test.Text = "test";
            this.b_test.UseVisualStyleBackColor = true;
            this.b_test.Click += new System.EventHandler(this.b_test_Click);
            // 
            // TB1_str_in
            // 
            this.TB1_str_in.Location = new System.Drawing.Point(413, 42);
            this.TB1_str_in.Name = "TB1_str_in";
            this.TB1_str_in.Size = new System.Drawing.Size(180, 20);
            this.TB1_str_in.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB1_str_in);
            this.Controls.Add(this.b_test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_test;
        private System.Windows.Forms.TextBox TB1_str_in;
    }
}

