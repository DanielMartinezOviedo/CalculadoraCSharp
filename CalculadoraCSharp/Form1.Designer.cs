namespace CalculadoraCSharp
{
    partial class Calculadora
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
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScreen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScreen.ForeColor = System.Drawing.Color.White;
            this.txtScreen.Location = new System.Drawing.Point(13, 12);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.Size = new System.Drawing.Size(299, 54);
            this.txtScreen.TabIndex = 0;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtScreen.TextChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.Location = new System.Drawing.Point(12, 271);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.Transparent;
            this.btn2.Location = new System.Drawing.Point(73, 271);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.Location = new System.Drawing.Point(134, 271);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.Transparent;
            this.btn6.Location = new System.Drawing.Point(134, 210);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.Transparent;
            this.btn5.Location = new System.Drawing.Point(73, 210);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.Transparent;
            this.btn4.Location = new System.Drawing.Point(12, 210);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.Transparent;
            this.btn9.Location = new System.Drawing.Point(134, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.Transparent;
            this.btn8.Location = new System.Drawing.Point(73, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.Transparent;
            this.btn7.Location = new System.Drawing.Point(12, 149);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.ForeColor = System.Drawing.Color.Transparent;
            this.btnDot.Location = new System.Drawing.Point(134, 332);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(55, 55);
            this.btnDot.TabIndex = 12;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.Transparent;
            this.btn0.Location = new System.Drawing.Point(73, 332);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSign.ForeColor = System.Drawing.Color.Transparent;
            this.btnSign.Location = new System.Drawing.Point(12, 332);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(55, 55);
            this.btnSign.TabIndex = 10;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPercent.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.ForeColor = System.Drawing.Color.Transparent;
            this.btnPercent.Location = new System.Drawing.Point(134, 88);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(55, 55);
            this.btnPercent.TabIndex = 15;
            this.btnPercent.Tag = "%";
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCE.ForeColor = System.Drawing.Color.Transparent;
            this.btnCE.Location = new System.Drawing.Point(73, 88);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(55, 55);
            this.btnCE.TabIndex = 14;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.Color.Transparent;
            this.btnC.Location = new System.Drawing.Point(12, 88);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(55, 55);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(195, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 55);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "←\t";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.ForeColor = System.Drawing.Color.Transparent;
            this.btnEqual.Location = new System.Drawing.Point(195, 332);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(116, 55);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSquareRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquareRoot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquareRoot.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquareRoot.ForeColor = System.Drawing.Color.Transparent;
            this.btnSquareRoot.Location = new System.Drawing.Point(195, 149);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(55, 55);
            this.btnSquareRoot.TabIndex = 18;
            this.btnSquareRoot.Tag = "√";
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnSlash
            // 
            this.btnSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlash.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSlash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlash.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSlash.ForeColor = System.Drawing.Color.Transparent;
            this.btnSlash.Location = new System.Drawing.Point(195, 210);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(55, 55);
            this.btnSlash.TabIndex = 17;
            this.btnSlash.Tag = "/";
            this.btnSlash.Text = "/";
            this.btnSlash.UseVisualStyleBackColor = false;
            this.btnSlash.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlus.Location = new System.Drawing.Point(195, 271);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(55, 55);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPower.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPower.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPower.ForeColor = System.Drawing.Color.Transparent;
            this.btnPower.Location = new System.Drawing.Point(256, 149);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(55, 55);
            this.btnPower.TabIndex = 23;
            this.btnPower.Tag = "²";
            this.btnPower.Text = "x²";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplication.ForeColor = System.Drawing.Color.Transparent;
            this.btnMultiplication.Location = new System.Drawing.Point(256, 210);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(55, 55);
            this.btnMultiplication.TabIndex = 22;
            this.btnMultiplication.Tag = "x";
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.ClickOperator);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinus.Location = new System.Drawing.Point(256, 271);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(55, 55);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Tag = "-";
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.ClickOperator);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(324, 395);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnSlash);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtScreen);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora DO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtScreen;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDot;
        private Button btn0;
        private Button btnSign;
        private Button btnPercent;
        private Button btnCE;
        private Button btnC;
        private Button btnDelete;
        private Button btnEqual;
        private Button btnSquareRoot;
        private Button btnSlash;
        private Button btnPlus;
        private Button btnPower;
        private Button btnMultiplication;
        private Button btnMinus;
    }
}