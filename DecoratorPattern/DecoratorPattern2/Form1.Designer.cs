namespace DecoratorPattern2
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
            textBoxMeasureId = new TextBox();
            buttonMeasure = new Button();
            listBoxMessage = new ListBox();
            checkBoxXOR = new CheckBox();
            checkBoxCompress = new CheckBox();
            SuspendLayout();
            // 
            // textBoxMeasureId
            // 
            textBoxMeasureId.Font = new Font("Yu Gothic UI", 18F);
            textBoxMeasureId.Location = new Point(34, 34);
            textBoxMeasureId.Name = "textBoxMeasureId";
            textBoxMeasureId.Size = new Size(238, 39);
            textBoxMeasureId.TabIndex = 0;
            textBoxMeasureId.Text = "123";
            // 
            // buttonMeasure
            // 
            buttonMeasure.Font = new Font("Yu Gothic UI", 18F);
            buttonMeasure.Location = new Point(291, 34);
            buttonMeasure.Name = "buttonMeasure";
            buttonMeasure.Size = new Size(157, 39);
            buttonMeasure.TabIndex = 1;
            buttonMeasure.Text = "Measure";
            buttonMeasure.UseVisualStyleBackColor = true;
            buttonMeasure.Click += buttonMeasure_Click;
            // 
            // listBoxMessage
            // 
            listBoxMessage.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            listBoxMessage.FormattingEnabled = true;
            listBoxMessage.ItemHeight = 25;
            listBoxMessage.Location = new Point(34, 144);
            listBoxMessage.Name = "listBoxMessage";
            listBoxMessage.Size = new Size(731, 254);
            listBoxMessage.TabIndex = 2;
            // 
            // checkBoxXOR
            // 
            checkBoxXOR.AutoSize = true;
            checkBoxXOR.Font = new Font("Yu Gothic UI", 15.75F);
            checkBoxXOR.Location = new Point(471, 37);
            checkBoxXOR.Name = "checkBoxXOR";
            checkBoxXOR.Size = new Size(139, 34);
            checkBoxXOR.TabIndex = 3;
            checkBoxXOR.Text = "XOR Cipher";
            checkBoxXOR.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompress
            // 
            checkBoxCompress.AutoSize = true;
            checkBoxCompress.Font = new Font("Yu Gothic UI", 15.75F);
            checkBoxCompress.Location = new Point(626, 37);
            checkBoxCompress.Name = "checkBoxCompress";
            checkBoxCompress.Size = new Size(152, 34);
            checkBoxCompress.TabIndex = 4;
            checkBoxCompress.Text = "Compression";
            checkBoxCompress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxCompress);
            Controls.Add(checkBoxXOR);
            Controls.Add(listBoxMessage);
            Controls.Add(buttonMeasure);
            Controls.Add(textBoxMeasureId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMeasureId;
        private Button buttonMeasure;
        private ListBox listBoxMessage;
        private CheckBox checkBoxXOR;
        private CheckBox checkBoxCompress;
    }
}
