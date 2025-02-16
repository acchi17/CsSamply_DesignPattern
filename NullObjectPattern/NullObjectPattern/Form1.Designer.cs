namespace NullObjectPattern
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
            textBoxProductId = new TextBox();
            buttonSearchId = new Button();
            labelProductName = new Label();
            labelProductNameTag = new Label();
            labelOpeTimeTag = new Label();
            labelOpeTime = new Label();
            SuspendLayout();
            // 
            // textBoxProductId
            // 
            textBoxProductId.Font = new Font("Yu Gothic UI", 12F);
            textBoxProductId.Location = new Point(38, 34);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(138, 29);
            textBoxProductId.TabIndex = 0;
            // 
            // buttonSearchId
            // 
            buttonSearchId.Font = new Font("Yu Gothic UI", 12F);
            buttonSearchId.Location = new Point(195, 31);
            buttonSearchId.Name = "buttonSearchId";
            buttonSearchId.Size = new Size(109, 32);
            buttonSearchId.TabIndex = 1;
            buttonSearchId.Text = "Search";
            buttonSearchId.UseVisualStyleBackColor = true;
            buttonSearchId.Click += buttonSearchId_Click;
            // 
            // labelProductName
            // 
            labelProductName.Font = new Font("Yu Gothic UI", 12F);
            labelProductName.Location = new Point(184, 110);
            labelProductName.Margin = new Padding(0);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(373, 26);
            labelProductName.TabIndex = 2;
            // 
            // labelProductNameTag
            // 
            labelProductNameTag.AutoSize = true;
            labelProductNameTag.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelProductNameTag.Location = new Point(47, 110);
            labelProductNameTag.Name = "labelProductNameTag";
            labelProductNameTag.Size = new Size(113, 21);
            labelProductNameTag.TabIndex = 3;
            labelProductNameTag.Text = "Product Name:";
            // 
            // labelOpeTimeTag
            // 
            labelOpeTimeTag.AutoSize = true;
            labelOpeTimeTag.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelOpeTimeTag.Location = new Point(47, 159);
            labelOpeTimeTag.Name = "labelOpeTimeTag";
            labelOpeTimeTag.Size = new Size(121, 21);
            labelOpeTimeTag.TabIndex = 4;
            labelOpeTimeTag.Text = "Operating Time:";
            // 
            // labelOpeTime
            // 
            labelOpeTime.Font = new Font("Yu Gothic UI", 12F);
            labelOpeTime.Location = new Point(184, 159);
            labelOpeTime.Margin = new Padding(0);
            labelOpeTime.Name = "labelOpeTime";
            labelOpeTime.Size = new Size(373, 26);
            labelOpeTime.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 310);
            Controls.Add(labelOpeTime);
            Controls.Add(labelOpeTimeTag);
            Controls.Add(labelProductNameTag);
            Controls.Add(labelProductName);
            Controls.Add(buttonSearchId);
            Controls.Add(textBoxProductId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductId;
        private Button buttonSearchId;
        private Label labelProductName;
        private Label labelProductNameTag;
        private Label labelOpeTimeTag;
        private Label labelOpeTime;
    }
}
