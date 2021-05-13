namespace BMI_Project
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculatedBMILabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 36);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(142, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(45, 53);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(135, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Enter your height in inches:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(61, 100);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(119, 13);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Enter your weight in lbs:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(12, 147);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(64, 13);
            this.bmiLabel.TabIndex = 4;
            this.bmiLabel.Text = "Your BMI is:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // calculatedBMILabel
            // 
            this.calculatedBMILabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedBMILabel.Location = new System.Drawing.Point(82, 139);
            this.calculatedBMILabel.Name = "calculatedBMILabel";
            this.calculatedBMILabel.Size = new System.Drawing.Size(265, 53);
            this.calculatedBMILabel.TabIndex = 6;
            this.calculatedBMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(186, 50);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 7;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(186, 97);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 292);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.calculatedBMILabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label calculatedBMILabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
    }
}

