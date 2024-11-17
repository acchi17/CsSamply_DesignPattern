namespace CompositePattern
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonRelease = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.LabelEdit = true;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(484, 489);
            treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "plain1.png");
            imageList1.Images.SetKeyName(1, "plain2.png");
            imageList1.Images.SetKeyName(2, "green.png");
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(502, 42);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(163, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(502, 71);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(163, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRelease
            // 
            buttonRelease.Location = new Point(502, 100);
            buttonRelease.Name = "buttonRelease";
            buttonRelease.Size = new Size(163, 23);
            buttonRelease.TabIndex = 3;
            buttonRelease.Text = "Release";
            buttonRelease.UseVisualStyleBackColor = true;
            buttonRelease.Click += buttonRelease_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 489);
            Controls.Add(buttonRelease);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ImageList imageList1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonRelease;
    }
}
