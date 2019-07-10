namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.firstValue = new System.Windows.Forms.TextBox();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.PowerTwoArguments = new System.Windows.Forms.Button();
            this.PowerOfDivision = new System.Windows.Forms.Button();
            this.logTwoArguments = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.MAX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Cursor = System.Windows.Forms.Cursors.Default;
            this.Plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Plus.Location = new System.Drawing.Point(229, 122);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(24, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(259, 122);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(25, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(290, 122);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(22, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(229, 151);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(24, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Label1_Click);
            // 
            // firstValue
            // 
            this.firstValue.Location = new System.Drawing.Point(37, 80);
            this.firstValue.Multiline = true;
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(129, 36);
            this.firstValue.TabIndex = 4;
            // 
            // secondValue
            // 
            this.secondValue.Location = new System.Drawing.Point(185, 80);
            this.secondValue.Multiline = true;
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(127, 36);
            this.secondValue.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(355, 80);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(83, 36);
            this.Result.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Первое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Второе значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            // 
            // SquareRoot
            // 
            this.SquareRoot.Location = new System.Drawing.Point(38, 131);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(27, 21);
            this.SquareRoot.TabIndex = 11;
            this.SquareRoot.Text = "√";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Power
            // 
            this.Power.BackgroundImage = global::calculator.Properties.Resources._57519890e6de315516bbf632;
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Power.ForeColor = System.Drawing.SystemColors.Control;
            this.Power.Location = new System.Drawing.Point(37, 158);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(137, 91);
            this.Power.TabIndex = 12;
            this.Power.Text = "x^2";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Label2_Click);
            // 
            // PowerTwoArguments
            // 
            this.PowerTwoArguments.Location = new System.Drawing.Point(259, 151);
            this.PowerTwoArguments.Name = "PowerTwoArguments";
            this.PowerTwoArguments.Size = new System.Drawing.Size(53, 23);
            this.PowerTwoArguments.TabIndex = 13;
            this.PowerTwoArguments.Text = "x^y";
            this.PowerTwoArguments.UseVisualStyleBackColor = true;
            this.PowerTwoArguments.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PowerOfDivision
            // 
            this.PowerOfDivision.Location = new System.Drawing.Point(229, 180);
            this.PowerOfDivision.Name = "PowerOfDivision";
            this.PowerOfDivision.Size = new System.Drawing.Size(53, 23);
            this.PowerOfDivision.TabIndex = 14;
            this.PowerOfDivision.Text = "x^(1/y)";
            this.PowerOfDivision.UseVisualStyleBackColor = true;
            this.PowerOfDivision.Click += new System.EventHandler(this.Label1_Click);
            // 
            // logTwoArguments
            // 
            this.logTwoArguments.Location = new System.Drawing.Point(229, 209);
            this.logTwoArguments.Name = "logTwoArguments";
            this.logTwoArguments.Size = new System.Drawing.Size(53, 23);
            this.logTwoArguments.TabIndex = 15;
            this.logTwoArguments.Text = "LOGx(y)";
            this.logTwoArguments.UseVisualStyleBackColor = true;
            this.logTwoArguments.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(288, 180);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(53, 23);
            this.MIN.TabIndex = 16;
            this.MIN.Text = "Min";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MAX
            // 
            this.MAX.Location = new System.Drawing.Point(288, 209);
            this.MAX.Name = "MAX";
            this.MAX.Size = new System.Drawing.Size(53, 23);
            this.MAX.TabIndex = 17;
            this.MAX.Text = "Max";
            this.MAX.UseVisualStyleBackColor = true;
            this.MAX.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 379);
            this.Controls.Add(this.MAX);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.logTwoArguments);
            this.Controls.Add(this.PowerOfDivision);
            this.Controls.Add(this.PowerTwoArguments);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button PowerTwoArguments;
        private System.Windows.Forms.Button PowerOfDivision;
        private System.Windows.Forms.Button logTwoArguments;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Button MAX;
    }
}

