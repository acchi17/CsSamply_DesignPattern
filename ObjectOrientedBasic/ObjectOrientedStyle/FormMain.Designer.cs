namespace ObjectOrientedStyle
{
    partial class FormMain
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
            radioButtonLuigi = new RadioButton();
            radioButtonMario = new RadioButton();
            buttonCall = new Button();
            buttonRight = new Button();
            panelField = new Panel();
            SuspendLayout();
            // 
            // radioButtonLuigi
            // 
            radioButtonLuigi.AutoSize = true;
            radioButtonLuigi.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            radioButtonLuigi.Location = new Point(88, 360);
            radioButtonLuigi.Name = "radioButtonLuigi";
            radioButtonLuigi.Size = new Size(62, 25);
            radioButtonLuigi.TabIndex = 9;
            radioButtonLuigi.TabStop = true;
            radioButtonLuigi.Text = "Luigi";
            radioButtonLuigi.UseVisualStyleBackColor = true;
            radioButtonLuigi.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButtonMario
            // 
            radioButtonMario.AutoSize = true;
            radioButtonMario.Checked = true;
            radioButtonMario.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            radioButtonMario.Location = new Point(13, 360);
            radioButtonMario.Name = "radioButtonMario";
            radioButtonMario.Size = new Size(69, 25);
            radioButtonMario.TabIndex = 8;
            radioButtonMario.TabStop = true;
            radioButtonMario.Text = "Mario";
            radioButtonMario.UseVisualStyleBackColor = true;
            radioButtonMario.CheckedChanged += radioButton_CheckedChanged;
            // 
            // buttonCall
            // 
            buttonCall.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonCall.Location = new Point(398, 349);
            buttonCall.Name = "buttonCall";
            buttonCall.Size = new Size(186, 51);
            buttonCall.TabIndex = 7;
            buttonCall.Text = "Call";
            buttonCall.UseVisualStyleBackColor = true;
            buttonCall.Click += buttonCall_Click;
            // 
            // buttonRight
            // 
            buttonRight.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonRight.Location = new Point(190, 349);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(186, 51);
            buttonRight.TabIndex = 6;
            buttonRight.Text = "→";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // panelField
            // 
            panelField.BackColor = Color.White;
            panelField.BorderStyle = BorderStyle.FixedSingle;
            panelField.Location = new Point(12, 19);
            panelField.Name = "panelField";
            panelField.Size = new Size(760, 316);
            panelField.TabIndex = 5;
            panelField.Paint += panelField_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(radioButtonLuigi);
            Controls.Add(radioButtonMario);
            Controls.Add(buttonCall);
            Controls.Add(buttonRight);
            Controls.Add(panelField);
            Name = "FormMain";
            Text = "Mario and Luigi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonLuigi;
        private RadioButton radioButtonMario;
        private Button buttonCall;
        private Button buttonRight;
        private Panel panelField;
    }
}
