namespace Win10_Style_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblShowOps = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPowerHalf = new System.Windows.Forms.Button();
            this.btnHistoryClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShowOps
            // 
            this.lblShowOps.AutoSize = true;
            this.lblShowOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOps.Location = new System.Drawing.Point(215, 99);
            this.lblShowOps.Name = "lblShowOps";
            this.lblShowOps.Size = new System.Drawing.Size(0, 25);
            this.lblShowOps.TabIndex = 28;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(15, 156);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(384, 73);
            this.txtDisplay.TabIndex = 29;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(341, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 57);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDisplayHistory
            // 
            this.rtbDisplayHistory.BackColor = System.Drawing.Color.White;
            this.rtbDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplayHistory.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbDisplayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplayHistory.Location = new System.Drawing.Point(68, 39);
            this.rtbDisplayHistory.Name = "rtbDisplayHistory";
            this.rtbDisplayHistory.ReadOnly = true;
            this.rtbDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDisplayHistory.Size = new System.Drawing.Size(237, 387);
            this.rtbDisplayHistory.TabIndex = 31;
            this.rtbDisplayHistory.Text = "";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.Location = new System.Drawing.Point(326, 510);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(35, 40);
            this.btnClearHistory.TabIndex = 34;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistoryClear);
            this.panel1.Controls.Add(this.btnClearHistory);
            this.panel1.Controls.Add(this.rtbDisplayHistory);
            this.panel1.Location = new System.Drawing.Point(4, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 442);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSquare);
            this.panel2.Controls.Add(this.btnSqrt);
            this.panel2.Controls.Add(this.btnPercent);
            this.panel2.Controls.Add(this.btnEquals);
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Controls.Add(this.btnMinus);
            this.panel2.Controls.Add(this.btnMul);
            this.panel2.Controls.Add(this.btnDiv);
            this.panel2.Controls.Add(this.btnDot);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btnBackspace);
            this.panel2.Controls.Add(this.btnZero);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnPlusMinus);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btnCE);
            this.panel2.Controls.Add(this.btnPowerHalf);
            this.panel2.Location = new System.Drawing.Point(23, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 460);
            this.panel2.TabIndex = 34;
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(196, 4);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(90, 68);
            this.btnSquare.TabIndex = 46;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            this.btnSquare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(98, 4);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(90, 68);
            this.btnSqrt.TabIndex = 45;
            this.btnSqrt.Text = "✓";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            this.btnSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(0, 4);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(90, 68);
            this.btnPercent.TabIndex = 44;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            this.btnPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEquals.Enabled = false;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(294, 374);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(90, 68);
            this.btnEquals.TabIndex = 25;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            this.btnEquals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(294, 300);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(90, 68);
            this.btnPlus.TabIndex = 43;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operators_Click);
            this.btnPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(294, 226);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(90, 68);
            this.btnMinus.TabIndex = 42;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operators_Click);
            this.btnMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMul.FlatAppearance.BorderSize = 0;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(294, 152);
            this.btnMul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(90, 68);
            this.btnMul.TabIndex = 41;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.operators_Click);
            this.btnMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(294, 78);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(90, 68);
            this.btnDiv.TabIndex = 40;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operators_Click);
            this.btnDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(196, 374);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 68);
            this.btnDot.TabIndex = 39;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numbers_Only);
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(196, 300);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 68);
            this.btn3.TabIndex = 38;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numbers_Only);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(196, 226);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 68);
            this.btn6.TabIndex = 37;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numbers_Only);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(196, 152);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 68);
            this.btn9.TabIndex = 36;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numbers_Only);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(196, 78);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(90, 68);
            this.btnBackspace.TabIndex = 35;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            this.btnBackspace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(98, 374);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(90, 68);
            this.btnZero.TabIndex = 34;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.numbers_Only);
            this.btnZero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(98, 300);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 68);
            this.btn2.TabIndex = 33;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numbers_Only);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(98, 226);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 68);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numbers_Only);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(98, 152);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 68);
            this.btn8.TabIndex = 31;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numbers_Only);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(98, 78);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 68);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            this.btnClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseDown);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(0, 374);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(90, 68);
            this.btnPlusMinus.TabIndex = 29;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            this.btnPlusMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(0, 300);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 68);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numbers_Only);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 226);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 68);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numbers_Only);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(0, 152);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 68);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numbers_Only);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(0, 78);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(90, 68);
            this.btnCE.TabIndex = 24;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            this.btnCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnPowerHalf
            // 
            this.btnPowerHalf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPowerHalf.FlatAppearance.BorderSize = 0;
            this.btnPowerHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerHalf.Location = new System.Drawing.Point(294, 4);
            this.btnPowerHalf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPowerHalf.Name = "btnPowerHalf";
            this.btnPowerHalf.Size = new System.Drawing.Size(90, 68);
            this.btnPowerHalf.TabIndex = 47;
            this.btnPowerHalf.Text = "x½";
            this.btnPowerHalf.UseVisualStyleBackColor = false;
            this.btnPowerHalf.Click += new System.EventHandler(this.btnPowerHalf_Click);
            this.btnPowerHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnHistoryClear
            // 
            this.btnHistoryClear.FlatAppearance.BorderSize = 0;
            this.btnHistoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryClear.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryClear.Image")));
            this.btnHistoryClear.Location = new System.Drawing.Point(337, 373);
            this.btnHistoryClear.Name = "btnHistoryClear";
            this.btnHistoryClear.Size = new System.Drawing.Size(49, 53);
            this.btnHistoryClear.TabIndex = 35;
            this.btnHistoryClear.UseVisualStyleBackColor = true;
            this.btnHistoryClear.Visible = false;
            this.btnHistoryClear.Click += new System.EventHandler(this.btnHistoryClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblShowOps);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 700);
            this.MinimumSize = new System.Drawing.Size(420, 700);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.btnClearHistory_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShowOps;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbDisplayHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPowerHalf;
        private System.Windows.Forms.Button btnHistoryClear;
    }
}

