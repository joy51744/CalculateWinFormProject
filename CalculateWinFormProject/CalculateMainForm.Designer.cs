namespace CalculateWinFormProject
{
    partial class CalculateMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonLoanCalculate = new System.Windows.Forms.Button();
            this.buttonPostageCalculate = new System.Windows.Forms.Button();
            this.buttonDiscountCalculator = new System.Windows.Forms.Button();
            this.buttonArithmeticCalculator = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonSimple = new System.Windows.Forms.Button();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.buttonInterestCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgeCalculate = new System.Windows.Forms.Button();
            this.buttonCountDay = new System.Windows.Forms.Button();
            this.buttonCountdownDay = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonLoanCalculate
            // 
            this.buttonLoanCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLoanCalculate.Location = new System.Drawing.Point(437, 377);
            this.buttonLoanCalculate.Name = "buttonLoanCalculate";
            this.buttonLoanCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonLoanCalculate.TabIndex = 85;
            this.buttonLoanCalculate.Text = "貸款計算器";
            this.buttonLoanCalculate.UseVisualStyleBackColor = true;
            this.buttonLoanCalculate.Click += new System.EventHandler(this.buttonLoanCalculate_Click);
            // 
            // buttonPostageCalculate
            // 
            this.buttonPostageCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPostageCalculate.Location = new System.Drawing.Point(437, 86);
            this.buttonPostageCalculate.Name = "buttonPostageCalculate";
            this.buttonPostageCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonPostageCalculate.TabIndex = 84;
            this.buttonPostageCalculate.Text = "郵資計算";
            this.buttonPostageCalculate.UseVisualStyleBackColor = true;
            this.buttonPostageCalculate.Click += new System.EventHandler(this.buttonPostageCalculate_Click);
            // 
            // buttonDiscountCalculator
            // 
            this.buttonDiscountCalculator.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDiscountCalculator.Location = new System.Drawing.Point(231, 377);
            this.buttonDiscountCalculator.Name = "buttonDiscountCalculator";
            this.buttonDiscountCalculator.Size = new System.Drawing.Size(130, 45);
            this.buttonDiscountCalculator.TabIndex = 83;
            this.buttonDiscountCalculator.Text = "折扣計算";
            this.buttonDiscountCalculator.UseVisualStyleBackColor = true;
            this.buttonDiscountCalculator.Click += new System.EventHandler(this.buttonDiscountCalculator_Click);
            // 
            // buttonArithmeticCalculator
            // 
            this.buttonArithmeticCalculator.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonArithmeticCalculator.Location = new System.Drawing.Point(231, 231);
            this.buttonArithmeticCalculator.Name = "buttonArithmeticCalculator";
            this.buttonArithmeticCalculator.Size = new System.Drawing.Size(130, 45);
            this.buttonArithmeticCalculator.TabIndex = 82;
            this.buttonArithmeticCalculator.Text = "四則運算器";
            this.buttonArithmeticCalculator.UseVisualStyleBackColor = true;
            this.buttonArithmeticCalculator.Click += new System.EventHandler(this.buttonArithmeticCalculator_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCalculator.Location = new System.Drawing.Point(231, 86);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(130, 45);
            this.buttonCalculator.TabIndex = 81;
            this.buttonCalculator.Text = "普通計算器";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonSimple
            // 
            this.buttonSimple.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSimple.Location = new System.Drawing.Point(25, 377);
            this.buttonSimple.Name = "buttonSimple";
            this.buttonSimple.Size = new System.Drawing.Size(130, 45);
            this.buttonSimple.TabIndex = 80;
            this.buttonSimple.Text = "基本計算器";
            this.buttonSimple.UseVisualStyleBackColor = true;
            this.buttonSimple.Click += new System.EventHandler(this.buttonSimple_Click);
            // 
            // buttonBMI
            // 
            this.buttonBMI.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBMI.Location = new System.Drawing.Point(25, 231);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(130, 45);
            this.buttonBMI.TabIndex = 79;
            this.buttonBMI.Text = "BMI計算";
            this.buttonBMI.UseVisualStyleBackColor = true;
            this.buttonBMI.Click += new System.EventHandler(this.buttonBMI_Click);
            // 
            // buttonInterestCalculate
            // 
            this.buttonInterestCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonInterestCalculate.Location = new System.Drawing.Point(437, 231);
            this.buttonInterestCalculate.Name = "buttonInterestCalculate";
            this.buttonInterestCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonInterestCalculate.TabIndex = 78;
            this.buttonInterestCalculate.Text = "利息計算器";
            this.buttonInterestCalculate.UseVisualStyleBackColor = true;
            this.buttonInterestCalculate.Click += new System.EventHandler(this.buttonInterestCalculate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(25, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 77;
            this.button1.Text = "點擊次數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCilck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 76;
            this.label1.Text = "C# Calculate Project";
            // 
            // buttonAgeCalculate
            // 
            this.buttonAgeCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAgeCalculate.Location = new System.Drawing.Point(643, 86);
            this.buttonAgeCalculate.Name = "buttonAgeCalculate";
            this.buttonAgeCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonAgeCalculate.TabIndex = 86;
            this.buttonAgeCalculate.Text = "年齡計算器";
            this.buttonAgeCalculate.UseVisualStyleBackColor = true;
            this.buttonAgeCalculate.Click += new System.EventHandler(this.buttonAgeCalculate_Click);
            // 
            // buttonCountDay
            // 
            this.buttonCountDay.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCountDay.Location = new System.Drawing.Point(643, 233);
            this.buttonCountDay.Name = "buttonCountDay";
            this.buttonCountDay.Size = new System.Drawing.Size(130, 45);
            this.buttonCountDay.TabIndex = 87;
            this.buttonCountDay.Text = "天數計算器";
            this.buttonCountDay.UseVisualStyleBackColor = true;
            this.buttonCountDay.Click += new System.EventHandler(this.buttonCountDay_Click);
            // 
            // buttonCountdownDay
            // 
            this.buttonCountdownDay.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCountdownDay.Location = new System.Drawing.Point(643, 377);
            this.buttonCountdownDay.Name = "buttonCountdownDay";
            this.buttonCountdownDay.Size = new System.Drawing.Size(130, 45);
            this.buttonCountdownDay.TabIndex = 88;
            this.buttonCountdownDay.Text = "倒數日";
            this.buttonCountdownDay.UseVisualStyleBackColor = true;
            this.buttonCountdownDay.Click += new System.EventHandler(this.buttonCountdownDay_Click);
            // 
            // CalculateMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCountdownDay);
            this.Controls.Add(this.buttonCountDay);
            this.Controls.Add(this.buttonAgeCalculate);
            this.Controls.Add(this.buttonLoanCalculate);
            this.Controls.Add(this.buttonPostageCalculate);
            this.Controls.Add(this.buttonDiscountCalculator);
            this.Controls.Add(this.buttonArithmeticCalculator);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.buttonSimple);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.buttonInterestCalculate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CalculateMainForm";
            this.Text = "馬顥心 | C#計算專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonLoanCalculate;
        private System.Windows.Forms.Button buttonPostageCalculate;
        private System.Windows.Forms.Button buttonDiscountCalculator;
        private System.Windows.Forms.Button buttonArithmeticCalculator;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonSimple;
        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.Button buttonInterestCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgeCalculate;
        private System.Windows.Forms.Button buttonCountDay;
        private System.Windows.Forms.Button buttonCountdownDay;
    }
}

