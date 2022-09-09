namespace MindBoxTest
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
            this.CircleBtn = new System.Windows.Forms.RadioButton();
            this.TriangleBtn = new System.Windows.Forms.RadioButton();
            this.SquareBtn = new System.Windows.Forms.RadioButton();
            this.CountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CircleBtn
            // 
            this.CircleBtn.AutoSize = true;
            this.CircleBtn.Location = new System.Drawing.Point(12, 21);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(58, 20);
            this.CircleBtn.TabIndex = 0;
            this.CircleBtn.TabStop = true;
            this.CircleBtn.Text = "Круг";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.CheckedChanged += new System.EventHandler(this.CircleBtn_CheckedChanged);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.AutoSize = true;
            this.TriangleBtn.Location = new System.Drawing.Point(12, 47);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(113, 20);
            this.TriangleBtn.TabIndex = 1;
            this.TriangleBtn.TabStop = true;
            this.TriangleBtn.Text = "Треугольник";
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.CheckedChanged += new System.EventHandler(this.TriangleBtn_CheckedChanged);
            // 
            // SquareBtn
            // 
            this.SquareBtn.AutoSize = true;
            this.SquareBtn.Location = new System.Drawing.Point(12, 73);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(83, 20);
            this.SquareBtn.TabIndex = 2;
            this.SquareBtn.TabStop = true;
            this.SquareBtn.Text = "Квадрат";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.CheckedChanged += new System.EventHandler(this.SquareBtn_CheckedChanged);
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(357, 281);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(179, 23);
            this.CountBtn.TabIndex = 3;
            this.CountBtn.Text = "Вычислить площадь";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(251, 50);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(24, 16);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.CircleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CircleBtn;
        private System.Windows.Forms.RadioButton TriangleBtn;
        private System.Windows.Forms.RadioButton SquareBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

