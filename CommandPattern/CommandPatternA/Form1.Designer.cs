namespace CommandPatternA
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
            labelTarget = new Label();
            buttonRight = new Button();
            textBoxAmount = new TextBox();
            buttonUndo = new Button();
            buttonLeft = new Button();
            buttonColor = new Button();
            buttonRedo = new Button();
            textBoxTarget = new TextBox();
            radioButtonText = new RadioButton();
            radioButtonLabel = new RadioButton();
            SuspendLayout();
            // 
            // labelTarget
            // 
            labelTarget.BackColor = Color.Red;
            labelTarget.Location = new Point(354, 150);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(75, 23);
            labelTarget.TabIndex = 0;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(376, 301);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(75, 23);
            buttonRight.TabIndex = 1;
            buttonRight.Text = "Right";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(428, 256);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(75, 23);
            textBoxAmount.TabIndex = 2;
            textBoxAmount.Text = "10";
            // 
            // buttonUndo
            // 
            buttonUndo.Location = new Point(295, 349);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(75, 23);
            buttonUndo.TabIndex = 3;
            buttonUndo.Text = "Undo";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(295, 300);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(75, 23);
            buttonLeft.TabIndex = 4;
            buttonLeft.Text = "Left";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(457, 301);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(75, 23);
            buttonColor.TabIndex = 5;
            buttonColor.Text = "Color";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // buttonRedo
            // 
            buttonRedo.Location = new Point(376, 349);
            buttonRedo.Name = "buttonRedo";
            buttonRedo.Size = new Size(75, 23);
            buttonRedo.TabIndex = 6;
            buttonRedo.Text = "Redo";
            buttonRedo.UseVisualStyleBackColor = true;
            buttonRedo.Click += buttonRedo_Click;
            // 
            // textBoxTarget
            // 
            textBoxTarget.BackColor = Color.Yellow;
            textBoxTarget.Location = new Point(354, 111);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(75, 23);
            textBoxTarget.TabIndex = 7;
            textBoxTarget.Text = "ABCDE";
            textBoxTarget.TextAlign = HorizontalAlignment.Center;
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Checked = true;
            radioButtonText.Location = new Point(302, 260);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(46, 19);
            radioButtonText.TabIndex = 8;
            radioButtonText.TabStop = true;
            radioButtonText.Text = "Text";
            radioButtonText.UseVisualStyleBackColor = true;
            radioButtonText.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButtonLabel
            // 
            radioButtonLabel.AutoSize = true;
            radioButtonLabel.Location = new Point(354, 260);
            radioButtonLabel.Name = "radioButtonLabel";
            radioButtonLabel.Size = new Size(53, 19);
            radioButtonLabel.TabIndex = 9;
            radioButtonLabel.Text = "Label";
            radioButtonLabel.UseVisualStyleBackColor = true;
            radioButtonLabel.CheckedChanged += radioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonLabel);
            Controls.Add(radioButtonText);
            Controls.Add(textBoxTarget);
            Controls.Add(buttonRedo);
            Controls.Add(buttonColor);
            Controls.Add(buttonLeft);
            Controls.Add(buttonUndo);
            Controls.Add(textBoxAmount);
            Controls.Add(buttonRight);
            Controls.Add(labelTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTarget;
        private Button buttonRight;
        private TextBox textBoxAmount;
        private Button buttonUndo;
        private Button buttonLeft;
        private Button buttonColor;
        private Button buttonRedo;
        private TextBox textBoxTarget;
        private RadioButton radioButtonText;
        private RadioButton radioButtonLabel;
    }
}
