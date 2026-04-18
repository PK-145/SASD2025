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
            splitContainer1 = new SplitContainer();
            txtValue = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn3 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnSign = new Button();
            btn2 = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnClear = new Button();
            btnDivide = new Button();
            btnMod = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtValue);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(304, 461);
            splitContainer1.SplitterDistance = 101;
            splitContainer1.TabIndex = 0;
            // 
            // txtValue
            // 
            txtValue.BackColor = SystemColors.Control;
            txtValue.BorderStyle = BorderStyle.None;
            txtValue.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(6, 3);
            txtValue.Name = "txtValue";
            txtValue.PlaceholderText = "145";
            txtValue.ReadOnly = true;
            txtValue.Size = new Size(292, 86);
            txtValue.TabIndex = 0;
            txtValue.TextAlign = HorizontalAlignment.Right;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00297F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9990082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9990082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9990139F));
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEqual, 3, 4);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 3);
            tableLayoutPanel1.Controls.Add(btnDecimal, 2, 4);
            tableLayoutPanel1.Controls.Add(btn0, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSign, 0, 4);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btnMinus, 3, 2);
            tableLayoutPanel1.Controls.Add(btnMulti, 3, 1);
            tableLayoutPanel1.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDivide, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMod, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBack, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(298, 350);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(151, 213);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 64);
            btn3.TabIndex = 28;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 213);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 64);
            btn1.TabIndex = 27;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(151, 143);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 64);
            btn6.TabIndex = 26;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(77, 143);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 64);
            btn5.TabIndex = 25;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(3, 143);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 64);
            btn4.TabIndex = 24;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(151, 73);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 64);
            btn9.TabIndex = 23;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(77, 73);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 64);
            btn8.TabIndex = 22;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(3, 73);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 64);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(225, 283);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(68, 64);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(225, 213);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(68, 64);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(151, 283);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(68, 64);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(77, 283);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 64);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSign.Location = new Point(3, 283);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(68, 64);
            btnSign.TabIndex = 16;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(77, 213);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 64);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(225, 143);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(68, 64);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(225, 73);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(68, 64);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(151, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 64);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(77, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 64);
            btnDivide.TabIndex = 2;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMod.Location = new Point(3, 3);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(68, 64);
            btnMod.TabIndex = 1;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(225, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 64);
            btnBack.TabIndex = 0;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 461);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Basic Calculator 145";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBack;
        private Button btnDecimal;
        private Button btn0;
        private Button btnSign;
        private Button btn2;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMod;
        private Button btnPlus;
        private Button btnEqual;
        private Button btn3;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private TextBox txtValue;
    }
}
