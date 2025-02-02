namespace AbstractFactoryPattern.View
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
            labelShow = new Label();
            buttonGet = new Button();
            SuspendLayout();
            // 
            // labelShow
            // 
            labelShow.AutoSize = true;
            labelShow.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelShow.Location = new Point(40, 51);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(105, 45);
            labelShow.TabIndex = 0;
            labelShow.Text = "label1";
            // 
            // buttonGet
            // 
            buttonGet.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonGet.Location = new Point(410, 156);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(184, 72);
            buttonGet.TabIndex = 1;
            buttonGet.Text = "Get";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 261);
            Controls.Add(buttonGet);
            Controls.Add(labelShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShow;
        private Button buttonGet;
    }
}
