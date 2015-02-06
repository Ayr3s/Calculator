namespace Calculator
{
    partial class Form2
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
            this.boxtext = new System.Windows.Forms.TextBox();
            this.Zahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxtext
            // 
            this.boxtext.Location = new System.Drawing.Point(147, 13);
            this.boxtext.Name = "boxtext";
            this.boxtext.Size = new System.Drawing.Size(100, 20);
            this.boxtext.TabIndex = 0;
            // 
            // Zahl
            // 
            this.Zahl.Location = new System.Drawing.Point(147, 60);
            this.Zahl.Name = "Zahl";
            this.Zahl.Size = new System.Drawing.Size(100, 20);
            this.Zahl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grad der Wurzel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zahl zum Wurzelziehen:";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(147, 106);
            this.ok.MaximumSize = new System.Drawing.Size(100, 23);
            this.ok.MinimumSize = new System.Drawing.Size(100, 23);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "Ok!";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 141);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zahl);
            this.Controls.Add(this.boxtext);
            this.MaximumSize = new System.Drawing.Size(287, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(287, 180);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok;
        public System.Windows.Forms.TextBox boxtext;
        public System.Windows.Forms.TextBox Zahl;
    }
}