namespace Calculator
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
            this.seven = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearE = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.Con = new System.Windows.Forms.Label();
            this.equasion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(16, 87);
            this.seven.Margin = new System.Windows.Forms.Padding(4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(53, 49);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(16, 257);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(115, 49);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(16, 201);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 49);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(77, 87);
            this.eight.Margin = new System.Windows.Forms.Padding(4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(53, 49);
            this.eight.TabIndex = 3;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(77, 144);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(53, 49);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(77, 201);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 49);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(16, 144);
            this.four.Margin = new System.Windows.Forms.Padding(4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(53, 49);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(200, 87);
            this.div.Margin = new System.Windows.Forms.Padding(4);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(53, 49);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(139, 257);
            this.dot.Margin = new System.Windows.Forms.Padding(4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(53, 49);
            this.dot.TabIndex = 9;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(139, 201);
            this.three.Margin = new System.Windows.Forms.Padding(4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(53, 49);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(139, 144);
            this.six.Margin = new System.Windows.Forms.Padding(4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(53, 49);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(139, 87);
            this.nine.Margin = new System.Windows.Forms.Padding(4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(53, 49);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(200, 144);
            this.mul.Margin = new System.Windows.Forms.Padding(4);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(53, 49);
            this.mul.TabIndex = 13;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.operator_click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(200, 201);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(53, 49);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operator_click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(200, 257);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(53, 49);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operator_click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(262, 257);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 49);
            this.button16.TabIndex = 16;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(323, 201);
            this.enter.Margin = new System.Windows.Forms.Padding(4);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(53, 106);
            this.enter.TabIndex = 17;
            this.enter.Text = "=";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(261, 200);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(53, 49);
            this.button18.TabIndex = 18;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(323, 144);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(53, 49);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearE
            // 
            this.ClearE.Location = new System.Drawing.Point(323, 87);
            this.ClearE.Margin = new System.Windows.Forms.Padding(4);
            this.ClearE.Name = "ClearE";
            this.ClearE.Size = new System.Drawing.Size(53, 49);
            this.ClearE.TabIndex = 21;
            this.ClearE.Text = "CE";
            this.ClearE.UseVisualStyleBackColor = true;
            this.ClearE.Click += new System.EventHandler(this.ClearE_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(261, 144);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(53, 49);
            this.button22.TabIndex = 22;
            this.button22.Text = "1";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(261, 87);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(53, 49);
            this.button23.TabIndex = 23;
            this.button23.Text = "1";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(17, 40);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(359, 26);
            this.result.TabIndex = 24;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Con
            // 
            this.Con.AutoSize = true;
            this.Con.Location = new System.Drawing.Point(16, 15);
            this.Con.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(0, 17);
            this.Con.TabIndex = 25;
            // 
            // equasion
            // 
            this.equasion.AutoSize = true;
            this.equasion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.equasion.Location = new System.Drawing.Point(184, 13);
            this.equasion.Name = "equasion";
            this.equasion.Size = new System.Drawing.Size(0, 17);
            this.equasion.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 326);
            this.Controls.Add(this.equasion);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.ClearE);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.div);
            this.Controls.Add(this.four);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.seven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(409, 365);
            this.MinimumSize = new System.Drawing.Size(409, 365);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearE;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label Con;
        private System.Windows.Forms.Label equasion;
    }
}

