namespace Calculator_Scintific
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.rbCelsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.txtValueToConvert = new System.Windows.Forms.TextBox();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btn1X = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnXY = new System.Windows.Forms.Button();
            this.btnLnX = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Temperature.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(912, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardToolStripMenuItem.Text = "Scintific";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(15, 46);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(346, 52);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temperature
            // 
            this.Temperature.Controls.Add(this.groupBox1);
            this.Temperature.Controls.Add(this.txtValueToConvert);
            this.Temperature.Controls.Add(this.txtConvert);
            this.Temperature.Controls.Add(this.btnReset);
            this.Temperature.Controls.Add(this.btnConvert);
            this.Temperature.Controls.Add(this.label3);
            this.Temperature.Controls.Add(this.label2);
            this.Temperature.Controls.Add(this.label1);
            this.Temperature.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Temperature.Location = new System.Drawing.Point(384, 46);
            this.Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.Temperature.Name = "Temperature";
            this.Temperature.Padding = new System.Windows.Forms.Padding(4);
            this.Temperature.Size = new System.Drawing.Size(511, 449);
            this.Temperature.TabIndex = 3;
            this.Temperature.TabStop = false;
            this.Temperature.Text = "Temperature";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKelvin);
            this.groupBox1.Controls.Add(this.rbFahrenheitToCelsius);
            this.groupBox1.Controls.Add(this.rbCelsiusToFahrenheit);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(474, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Temperature for Conversion";
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbKelvin.Location = new System.Drawing.Point(24, 113);
            this.rbKelvin.Margin = new System.Windows.Forms.Padding(4);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(75, 25);
            this.rbKelvin.TabIndex = 1;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            this.rbKelvin.CheckedChanged += new System.EventHandler(this.rbKevin_CheckedChanged);
            // 
            // rbFahrenheitToCelsius
            // 
            this.rbFahrenheitToCelsius.AutoSize = true;
            this.rbFahrenheitToCelsius.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFahrenheitToCelsius.Location = new System.Drawing.Point(24, 76);
            this.rbFahrenheitToCelsius.Margin = new System.Windows.Forms.Padding(4);
            this.rbFahrenheitToCelsius.Name = "rbFahrenheitToCelsius";
            this.rbFahrenheitToCelsius.Size = new System.Drawing.Size(184, 25);
            this.rbFahrenheitToCelsius.TabIndex = 2;
            this.rbFahrenheitToCelsius.TabStop = true;
            this.rbFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.rbFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.rbFahrenheitToCelsius.CheckedChanged += new System.EventHandler(this.rbFahrenheitToCelsius_CheckedChanged);
            // 
            // rbCelsiusToFahrenheit
            // 
            this.rbCelsiusToFahrenheit.AutoSize = true;
            this.rbCelsiusToFahrenheit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCelsiusToFahrenheit.Location = new System.Drawing.Point(24, 35);
            this.rbCelsiusToFahrenheit.Margin = new System.Windows.Forms.Padding(4);
            this.rbCelsiusToFahrenheit.Name = "rbCelsiusToFahrenheit";
            this.rbCelsiusToFahrenheit.Size = new System.Drawing.Size(184, 25);
            this.rbCelsiusToFahrenheit.TabIndex = 3;
            this.rbCelsiusToFahrenheit.TabStop = true;
            this.rbCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.rbCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.rbCelsiusToFahrenheit.CheckedChanged += new System.EventHandler(this.rbCelsiusToFahrenheit_CheckedChanged);
            // 
            // txtValueToConvert
            // 
            this.txtValueToConvert.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtValueToConvert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValueToConvert.Location = new System.Drawing.Point(302, 51);
            this.txtValueToConvert.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueToConvert.Multiline = true;
            this.txtValueToConvert.Name = "txtValueToConvert";
            this.txtValueToConvert.Size = new System.Drawing.Size(132, 30);
            this.txtValueToConvert.TabIndex = 3;
            // 
            // txtConvert
            // 
            this.txtConvert.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConvert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConvert.Location = new System.Drawing.Point(250, 322);
            this.txtConvert.Margin = new System.Windows.Forms.Padding(4);
            this.txtConvert.Multiline = true;
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(118, 30);
            this.txtConvert.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(365, 375);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 36);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(40, 375);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 36);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = " Convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Value to Convert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result of Converted Value";
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPi.Location = new System.Drawing.Point(223, 155);
            this.btnPi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(67, 46);
            this.btnPi.TabIndex = 1;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCosh.Location = new System.Drawing.Point(84, 105);
            this.btnCosh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(67, 46);
            this.btnCosh.TabIndex = 1;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(15, 400);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(67, 46);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCos.Location = new System.Drawing.Point(84, 155);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(67, 46);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(84, 253);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(67, 46);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBin.Location = new System.Drawing.Point(84, 204);
            this.btnBin.Margin = new System.Windows.Forms.Padding(4);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(67, 46);
            this.btnBin.TabIndex = 1;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX2.Location = new System.Drawing.Point(15, 350);
            this.btnX2.Margin = new System.Windows.Forms.Padding(4);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(67, 46);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x^2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btn1X
            // 
            this.btn1X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1X.Location = new System.Drawing.Point(15, 252);
            this.btn1X.Margin = new System.Windows.Forms.Padding(4);
            this.btn1X.Name = "btn1X";
            this.btn1X.Size = new System.Drawing.Size(67, 46);
            this.btn1X.TabIndex = 1;
            this.btn1X.Text = "1/x";
            this.btn1X.UseVisualStyleBackColor = true;
            this.btn1X.Click += new System.EventHandler(this.btn1X_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSinh.Location = new System.Drawing.Point(15, 105);
            this.btnSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(67, 46);
            this.btnSinh.TabIndex = 1;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTanh.Location = new System.Drawing.Point(154, 106);
            this.btnTanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(67, 46);
            this.btnTanh.TabIndex = 1;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExp.Location = new System.Drawing.Point(223, 252);
            this.btnExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(67, 46);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.numOperator);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDec.Location = new System.Drawing.Point(15, 203);
            this.btnDec.Margin = new System.Windows.Forms.Padding(4);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(67, 46);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHex.Location = new System.Drawing.Point(154, 204);
            this.btnHex.Margin = new System.Windows.Forms.Padding(4);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(67, 46);
            this.btnHex.TabIndex = 1;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOct.Location = new System.Drawing.Point(223, 204);
            this.btnOct.Margin = new System.Windows.Forms.Padding(4);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(67, 46);
            this.btnOct.TabIndex = 1;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSin.Location = new System.Drawing.Point(15, 155);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(67, 46);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTan.Location = new System.Drawing.Point(154, 155);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(67, 46);
            this.btnTan.TabIndex = 1;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(154, 253);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(67, 46);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.numOperator);
            // 
            // btnXY
            // 
            this.btnXY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXY.Location = new System.Drawing.Point(15, 302);
            this.btnXY.Margin = new System.Windows.Forms.Padding(4);
            this.btnXY.Name = "btnXY";
            this.btnXY.Size = new System.Drawing.Size(67, 46);
            this.btnXY.TabIndex = 1;
            this.btnXY.Text = "x^y";
            this.btnXY.UseVisualStyleBackColor = true;
            this.btnXY.Click += new System.EventHandler(this.numOperator);
            // 
            // btnLnX
            // 
            this.btnLnX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLnX.Location = new System.Drawing.Point(15, 449);
            this.btnLnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnLnX.Name = "btnLnX";
            this.btnLnX.Size = new System.Drawing.Size(67, 46);
            this.btnLnX.TabIndex = 1;
            this.btnLnX.Text = "Ln x";
            this.btnLnX.UseVisualStyleBackColor = true;
            this.btnLnX.Click += new System.EventHandler(this.btnLnX_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPre.Location = new System.Drawing.Point(294, 204);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(67, 46);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "%";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnBS
            // 
            this.btnBS.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBS.Location = new System.Drawing.Point(294, 106);
            this.btnBS.Margin = new System.Windows.Forms.Padding(4);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(67, 46);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(84, 350);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 46);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearEntry.Location = new System.Drawing.Point(294, 155);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(67, 46);
            this.btnClearEntry.TabIndex = 1;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click_1);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(154, 350);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 46);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(223, 106);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 46);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(223, 350);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 46);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPM.Location = new System.Drawing.Point(84, 449);
            this.btnPM.Margin = new System.Windows.Forms.Padding(4);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(67, 46);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(294, 352);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(67, 46);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.numOperator);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(84, 302);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 46);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(84, 400);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(154, 449);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 46);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(223, 301);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 46);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(223, 400);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 46);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(294, 449);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 46);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(154, 301);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 46);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(154, 400);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 46);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(223, 449);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(67, 46);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(294, 401);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.numOperator);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(294, 302);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(67, 46);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.numOperator);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(294, 252);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(67, 46);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.numOperator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 511);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnLnX);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnXY);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1X);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Temperature.ResumeLayout(false);
            this.Temperature.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem temperatureToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private TextBox txtDisplay;
        private GroupBox Temperature;
        private GroupBox groupBox1;
        private TextBox txtValueToConvert;
        private TextBox txtConvert;
        private Button btnReset;
        private Button btnConvert;
        private Label label2;
        private Label label1;
        private RadioButton rbKelvin;
        private RadioButton rbFahrenheitToCelsius;
        private RadioButton rbCelsiusToFahrenheit;
        private Label label3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPi;
        private Button btnCosh;
        private Button btnLog;
        private Button btnCos;
        private Button btnSqrt;
        private Button btnBin;
        private Button btnX2;
        private Button btn1X;
        private Button btnSinh;
        private Button btnTanh;
        private Button btnExp;
        private Button btnDec;
        private Button btnHex;
        private Button btnOct;
        private Button btnSin;
        private Button btnTan;
        private Button btnMod;
        private Button btnXY;
        private Button btnLnX;
        private Button btnPre;
        private Button btnBS;
        private Button btn4;
        private Button btnClearEntry;
        private Button btn5;
        private Button btnClear;
        private Button btn6;
        private Button btnPM;
        private Button btnSub;
        private Button btn7;
        private Button btn1;
        private Button btn0;
        private Button btn9;
        private Button btn3;
        private Button btnEqual;
        private Button btn8;
        private Button btn2;
        private Button btnDot;
        private Button btnAdd;
        private Button btnMult;
        private Button btnDiv;
        private ToolStripMenuItem standardToolStripMenuItem;
    }
}