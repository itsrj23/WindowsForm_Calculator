namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_add = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_minus = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_multiply = new Button();
            btn_clearall = new Button();
            btn_divide = new Button();
            btn_modulo = new Button();
            btn_clear = new Button();
            btn_0 = new Button();
            btn_decimal = new Button();
            btn_equals = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ActiveCaptionText;
            txtOutput.BorderStyle = BorderStyle.None;
            txtOutput.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = SystemColors.Window;
            txtOutput.Location = new Point(60, 59);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(344, 58);
            txtOutput.TabIndex = 0;
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(50, 379);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(76, 53);
            btn_1.TabIndex = 2;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(143, 379);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(76, 53);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(235, 379);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(76, 53);
            btn_3.TabIndex = 4;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_add
            // 
            btn_add.ForeColor = Color.Orange;
            btn_add.Location = new Point(328, 379);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(76, 53);
            btn_add.TabIndex = 5;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(51, 299);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(76, 53);
            btn_4.TabIndex = 6;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(143, 299);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(76, 53);
            btn_5.TabIndex = 7;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(235, 299);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(76, 53);
            btn_6.TabIndex = 8;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += button8_Click;
            // 
            // btn_minus
            // 
            btn_minus.ForeColor = Color.Orange;
            btn_minus.Location = new Point(328, 299);
            btn_minus.Name = "btn_minus";
            btn_minus.RightToLeft = RightToLeft.No;
            btn_minus.Size = new Size(76, 53);
            btn_minus.TabIndex = 9;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(50, 227);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(76, 53);
            btn_7.TabIndex = 10;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(144, 227);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(76, 53);
            btn_8.TabIndex = 11;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(236, 227);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(76, 53);
            btn_9.TabIndex = 12;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.ForeColor = Color.Orange;
            btn_multiply.Location = new Point(328, 227);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(76, 53);
            btn_multiply.TabIndex = 13;
            btn_multiply.Text = "x";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_clearall
            // 
            btn_clearall.ForeColor = Color.Orange;
            btn_clearall.Location = new Point(51, 157);
            btn_clearall.Name = "btn_clearall";
            btn_clearall.Size = new Size(76, 53);
            btn_clearall.TabIndex = 14;
            btn_clearall.Text = "AC";
            btn_clearall.UseVisualStyleBackColor = true;
            btn_clearall.Click += btn_clearall_Click;
            // 
            // btn_divide
            // 
            btn_divide.ForeColor = Color.Orange;
            btn_divide.Location = new Point(328, 157);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(76, 53);
            btn_divide.TabIndex = 15;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_modulo
            // 
            btn_modulo.ForeColor = Color.Orange;
            btn_modulo.Location = new Point(236, 157);
            btn_modulo.Name = "btn_modulo";
            btn_modulo.Size = new Size(76, 53);
            btn_modulo.TabIndex = 16;
            btn_modulo.Text = "%";
            btn_modulo.UseVisualStyleBackColor = true;
            btn_modulo.Click += btn_modulo_Click;
            // 
            // btn_clear
            // 
            btn_clear.ForeColor = Color.Orange;
            btn_clear.Location = new Point(144, 157);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(76, 53);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(50, 452);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(76, 53);
            btn_0.TabIndex = 1;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_decimal
            // 
            btn_decimal.Location = new Point(144, 452);
            btn_decimal.Name = "btn_decimal";
            btn_decimal.Size = new Size(76, 53);
            btn_decimal.TabIndex = 18;
            btn_decimal.Text = ".";
            btn_decimal.UseVisualStyleBackColor = true;
            btn_decimal.Click += btn_decimal_Click;
            // 
            // btn_equals
            // 
            btn_equals.BackColor = Color.Orange;
            btn_equals.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_equals.ForeColor = SystemColors.ButtonHighlight;
            btn_equals.Location = new Point(236, 452);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(168, 53);
            btn_equals.TabIndex = 19;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = false;
            btn_equals.Click += btn_equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(441, 532);
            Controls.Add(btn_equals);
            Controls.Add(btn_decimal);
            Controls.Add(btn_clear);
            Controls.Add(btn_modulo);
            Controls.Add(btn_divide);
            Controls.Add(btn_clearall);
            Controls.Add(btn_multiply);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_minus);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_add);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_0);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_add;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_minus;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_multiply;
        private Button btn_clearall;
        private Button btn_divide;
        private Button btn_modulo;
        private Button btn_clear;
        private Button btn_0;
        private Button btn_decimal;
        private Button btn_equals;
    }
}
