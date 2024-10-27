namespace DecoratorPattern
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
            buttonReadA = new Button();
            radioButtonNormal = new RadioButton();
            radioButtonUpperCase = new RadioButton();
            radioButtonLowerCase = new RadioButton();
            buttonReadB = new Button();
            SuspendLayout();
            // 
            // buttonReadA
            // 
            buttonReadA.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonReadA.Location = new Point(267, 215);
            buttonReadA.Name = "buttonReadA";
            buttonReadA.Size = new Size(232, 65);
            buttonReadA.TabIndex = 0;
            buttonReadA.Text = "Read File A";
            buttonReadA.UseVisualStyleBackColor = true;
            buttonReadA.Click += buttonReadA_Click;
            // 
            // radioButtonNormal
            // 
            radioButtonNormal.AutoSize = true;
            radioButtonNormal.Checked = true;
            radioButtonNormal.Font = new Font("Yu Gothic UI", 18F);
            radioButtonNormal.Location = new Point(267, 68);
            radioButtonNormal.Name = "radioButtonNormal";
            radioButtonNormal.Size = new Size(111, 36);
            radioButtonNormal.TabIndex = 1;
            radioButtonNormal.TabStop = true;
            radioButtonNormal.Text = "Normal";
            radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpperCase
            // 
            radioButtonUpperCase.AutoSize = true;
            radioButtonUpperCase.Font = new Font("Yu Gothic UI", 18F);
            radioButtonUpperCase.Location = new Point(267, 110);
            radioButtonUpperCase.Name = "radioButtonUpperCase";
            radioButtonUpperCase.Size = new Size(150, 36);
            radioButtonUpperCase.TabIndex = 2;
            radioButtonUpperCase.Text = "Upper case";
            radioButtonUpperCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerCase
            // 
            radioButtonLowerCase.AutoSize = true;
            radioButtonLowerCase.Font = new Font("Yu Gothic UI", 18F);
            radioButtonLowerCase.Location = new Point(267, 152);
            radioButtonLowerCase.Name = "radioButtonLowerCase";
            radioButtonLowerCase.Size = new Size(148, 36);
            radioButtonLowerCase.TabIndex = 3;
            radioButtonLowerCase.Text = "Lower case";
            radioButtonLowerCase.UseVisualStyleBackColor = true;
            // 
            // buttonReadB
            // 
            buttonReadB.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonReadB.Location = new Point(267, 303);
            buttonReadB.Name = "buttonReadB";
            buttonReadB.Size = new Size(232, 65);
            buttonReadB.TabIndex = 4;
            buttonReadB.Text = "Read File B";
            buttonReadB.UseVisualStyleBackColor = true;
            buttonReadB.Click += buttonReadB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReadB);
            Controls.Add(radioButtonLowerCase);
            Controls.Add(radioButtonUpperCase);
            Controls.Add(radioButtonNormal);
            Controls.Add(buttonReadA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReadA;
        private RadioButton radioButtonNormal;
        private RadioButton radioButtonUpperCase;
        private RadioButton radioButtonLowerCase;
        private Button buttonReadB;
    }
}
