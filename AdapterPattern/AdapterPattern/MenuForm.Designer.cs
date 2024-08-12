namespace AdapterPattern
{
    partial class MenuForm
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
            button01 = new Button();
            button02 = new Button();
            button00 = new Button();
            SuspendLayout();
            // 
            // button01
            // 
            button01.Location = new Point(129, 47);
            button01.Name = "button01";
            button01.Size = new Size(231, 66);
            button01.TabIndex = 0;
            button01.Text = "01";
            button01.UseVisualStyleBackColor = true;
            button01.Click += button01_Click;
            // 
            // button02
            // 
            button02.Location = new Point(129, 143);
            button02.Name = "button02";
            button02.Size = new Size(231, 67);
            button02.TabIndex = 1;
            button02.Text = "02";
            button02.UseVisualStyleBackColor = true;
            button02.Click += button02_Click;
            // 
            // button00
            // 
            button00.Location = new Point(129, 243);
            button00.Name = "button00";
            button00.Size = new Size(231, 67);
            button00.TabIndex = 2;
            button00.Text = "00";
            button00.UseVisualStyleBackColor = true;
            button00.Click += button00_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(button00);
            Controls.Add(button02);
            Controls.Add(button01);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button01;
        private Button button02;
        private Button button00;
    }
}
