namespace WinFormsApp1
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
            txtDisplay = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Microsoft YaHei UI", 18F);
            txtDisplay.Location = new Point(11, 70);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(240, 38);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft YaHei UI", 14F);
            btn0.Location = new Point(105, 331);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft YaHei UI", 14F);
            btn1.Location = new Point(20, 266);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft YaHei UI", 14F);
            btn2.Location = new Point(105, 266);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft YaHei UI", 14F);
            btn3.Location = new Point(187, 266);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft YaHei UI", 14F);
            btn4.Location = new Point(20, 199);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft YaHei UI", 14F);
            btn5.Location = new Point(105, 199);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft YaHei UI", 14F);
            btn6.Location = new Point(187, 199);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft YaHei UI", 14F);
            btn7.Location = new Point(20, 130);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft YaHei UI", 14F);
            btn8.Location = new Point(105, 130);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft YaHei UI", 14F);
            btn9.Location = new Point(187, 130);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 14F);
            btnAdd.Location = new Point(257, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperator_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Microsoft YaHei UI", 14F);
            btnSubtract.Location = new Point(257, 199);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(50, 50);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnOperator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Microsoft YaHei UI", 14F);
            btnMultiply.Location = new Point(257, 130);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(50, 50);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Microsoft YaHei UI", 14F);
            btnDivide.Location = new Point(257, 65);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Microsoft YaHei UI", 14F);
            btnEquals.Location = new Point(187, 331);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(120, 50);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft YaHei UI", 14F);
            btnClear.Location = new Point(20, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 452);
            Controls.Add(txtDisplay);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "计算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnClear;
    }
}
