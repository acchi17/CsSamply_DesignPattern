namespace ObserverPattern
{
    partial class SubForm
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
            labelWarning = new Label();
            SuspendLayout();
            // 
            // labelWarning
            // 
            labelWarning.Font = new Font("Yu Gothic UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelWarning.Location = new Point(43, 47);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(400, 93);
            labelWarning.TabIndex = 0;
            labelWarning.Text = "--";
            labelWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(labelWarning);
            Name = "SubForm";
            Text = "Sub";
            ResumeLayout(false);
        }

        #endregion

        private Label labelWarning;
    }
}
