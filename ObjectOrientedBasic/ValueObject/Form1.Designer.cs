namespace ValueObject
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
            buttonGetAddr = new Button();
            textBoxAddress = new TextBox();
            numericUpDownDP = new NumericUpDown();
            radioButtonMm = new RadioButton();
            radioButtonUm = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDP).BeginInit();
            SuspendLayout();
            // 
            // buttonGetAddr
            // 
            buttonGetAddr.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonGetAddr.Location = new Point(117, 157);
            buttonGetAddr.Name = "buttonGetAddr";
            buttonGetAddr.Size = new Size(177, 46);
            buttonGetAddr.TabIndex = 0;
            buttonGetAddr.Text = "Get Address";
            buttonGetAddr.UseVisualStyleBackColor = true;
            buttonGetAddr.Click += buttonGetAddr_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBoxAddress.Location = new Point(53, 52);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(304, 39);
            textBoxAddress.TabIndex = 1;
            // 
            // numericUpDownDP
            // 
            numericUpDownDP.Location = new Point(307, 104);
            numericUpDownDP.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownDP.Name = "numericUpDownDP";
            numericUpDownDP.Size = new Size(50, 23);
            numericUpDownDP.TabIndex = 2;
            numericUpDownDP.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // radioButtonMm
            // 
            radioButtonMm.AutoSize = true;
            radioButtonMm.Checked = true;
            radioButtonMm.Location = new Point(201, 104);
            radioButtonMm.Name = "radioButtonMm";
            radioButtonMm.Size = new Size(45, 19);
            radioButtonMm.TabIndex = 3;
            radioButtonMm.TabStop = true;
            radioButtonMm.Text = "mm";
            radioButtonMm.UseVisualStyleBackColor = true;
            // 
            // radioButtonUm
            // 
            radioButtonUm.AutoSize = true;
            radioButtonUm.Location = new Point(252, 104);
            radioButtonUm.Name = "radioButtonUm";
            radioButtonUm.Size = new Size(42, 19);
            radioButtonUm.TabIndex = 4;
            radioButtonUm.Text = "um";
            radioButtonUm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 283);
            Controls.Add(radioButtonUm);
            Controls.Add(radioButtonMm);
            Controls.Add(numericUpDownDP);
            Controls.Add(textBoxAddress);
            Controls.Add(buttonGetAddr);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetAddr;
        private TextBox textBoxAddress;
        private NumericUpDown numericUpDownDP;
        private RadioButton radioButtonMm;
        private RadioButton radioButtonUm;
    }
}
