namespace StatePattern
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
            labelDisplay = new Label();
            buttonMode = new Button();
            checkBoxEcoMode = new CheckBox();
            checkBoxOnOff = new CheckBox();
            SuspendLayout();
            // 
            // labelDisplay
            // 
            labelDisplay.BackColor = Color.White;
            labelDisplay.BorderStyle = BorderStyle.FixedSingle;
            labelDisplay.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelDisplay.Location = new Point(12, 23);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(370, 94);
            labelDisplay.TabIndex = 0;
            labelDisplay.Text = "label1";
            labelDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMode
            // 
            buttonMode.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonMode.Location = new Point(84, 302);
            buttonMode.Name = "buttonMode";
            buttonMode.Size = new Size(219, 83);
            buttonMode.TabIndex = 2;
            buttonMode.Text = "Mode";
            buttonMode.UseVisualStyleBackColor = true;
            buttonMode.Click += buttonMode_Click;
            // 
            // checkBoxEcoMode
            // 
            checkBoxEcoMode.Appearance = Appearance.Button;
            checkBoxEcoMode.BackColor = Color.LawnGreen;
            checkBoxEcoMode.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            checkBoxEcoMode.Location = new Point(134, 130);
            checkBoxEcoMode.Name = "checkBoxEcoMode";
            checkBoxEcoMode.Size = new Size(116, 53);
            checkBoxEcoMode.TabIndex = 5;
            checkBoxEcoMode.Text = "EcoMode";
            checkBoxEcoMode.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxEcoMode.UseVisualStyleBackColor = false;
            checkBoxEcoMode.CheckedChanged += checkBoxEcoMode_CheckedChanged;
            // 
            // checkBoxOnOff
            // 
            checkBoxOnOff.Appearance = Appearance.Button;
            checkBoxOnOff.BackColor = Color.Tomato;
            checkBoxOnOff.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            checkBoxOnOff.Location = new Point(12, 130);
            checkBoxOnOff.Name = "checkBoxOnOff";
            checkBoxOnOff.Size = new Size(116, 53);
            checkBoxOnOff.TabIndex = 6;
            checkBoxOnOff.Text = "ON/OFF";
            checkBoxOnOff.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxOnOff.UseVisualStyleBackColor = false;
            checkBoxOnOff.CheckedChanged += checkBoxOnOff_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(checkBoxOnOff);
            Controls.Add(checkBoxEcoMode);
            Controls.Add(buttonMode);
            Controls.Add(labelDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelDisplay;
        private Button buttonMode;
        private CheckBox checkBoxEcoMode;
        private CheckBox checkBoxOnOff;
    }
}
