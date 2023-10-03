namespace Lab1_extra_n01587121
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
            btnCalculate = new Button();
            btnExit = new Button();
            txtLength = new TextBox();
            lbLength = new Label();
            lbWidth = new Label();
            txtWidth = new TextBox();
            lbArea = new Label();
            txtArea = new TextBox();
            lbPerim = new Label();
            txtPerimeter = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(191, 593);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(554, 593);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(369, 153);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(335, 39);
            txtLength.TabIndex = 2;
            // 
            // lbLength
            // 
            lbLength.AutoSize = true;
            lbLength.Location = new Point(191, 153);
            lbLength.Name = "lbLength";
            lbLength.Size = new Size(88, 32);
            lbLength.TabIndex = 3;
            lbLength.Text = "Length";
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.Location = new Point(191, 239);
            lbWidth.Name = "lbWidth";
            lbWidth.Size = new Size(78, 32);
            lbWidth.TabIndex = 5;
            lbWidth.Text = "Width";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(369, 239);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(335, 39);
            txtWidth.TabIndex = 4;
            // 
            // lbArea
            // 
            lbArea.AutoSize = true;
            lbArea.Location = new Point(191, 330);
            lbArea.Name = "lbArea";
            lbArea.Size = new Size(62, 32);
            lbArea.TabIndex = 7;
            lbArea.Text = "Area";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(369, 330);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(335, 39);
            txtArea.TabIndex = 6;
            // 
            // lbPerim
            // 
            lbPerim.AutoSize = true;
            lbPerim.Location = new Point(191, 414);
            lbPerim.Name = "lbPerim";
            lbPerim.Size = new Size(116, 32);
            lbPerim.TabIndex = 9;
            lbPerim.Text = "Perimeter";
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(369, 414);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(335, 39);
            txtPerimeter.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 733);
            Controls.Add(lbPerim);
            Controls.Add(txtPerimeter);
            Controls.Add(lbArea);
            Controls.Add(txtArea);
            Controls.Add(lbWidth);
            Controls.Add(txtWidth);
            Controls.Add(lbLength);
            Controls.Add(txtLength);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtLength;
        private Label lbLength;
        private Label lbWidth;
        private TextBox txtWidth;
        private Label lbArea;
        private TextBox txtArea;
        private Label lbPerim;
        private TextBox txtPerimeter;
    }
}