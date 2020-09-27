namespace Name_That_Logo_Game
{
    partial class GameMaster_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imagePictureSlider = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.previousImageButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.sendImageToPlayerWindow = new System.Windows.Forms.Button();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectImagesButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizePlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlayerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizePlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Image Browser";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imagePictureSlider);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // imagePictureSlider
            // 
            this.imagePictureSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureSlider.Location = new System.Drawing.Point(0, 0);
            this.imagePictureSlider.Name = "imagePictureSlider";
            this.imagePictureSlider.Size = new System.Drawing.Size(800, 380);
            this.imagePictureSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureSlider.TabIndex = 0;
            this.imagePictureSlider.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer2.Location = new System.Drawing.Point(290, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.previousImageButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(510, 42);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 5;
            // 
            // previousImageButton
            // 
            this.previousImageButton.AutoSize = true;
            this.previousImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousImageButton.Location = new System.Drawing.Point(0, 0);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(170, 42);
            this.previousImageButton.TabIndex = 3;
            this.previousImageButton.Text = "Previous Image";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.previousImageButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.sendImageToPlayerWindow);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.nextImageButton);
            this.splitContainer3.Size = new System.Drawing.Size(336, 42);
            this.splitContainer3.SplitterDistance = 170;
            this.splitContainer3.TabIndex = 0;
            // 
            // sendImageToPlayerWindow
            // 
            this.sendImageToPlayerWindow.AutoSize = true;
            this.sendImageToPlayerWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendImageToPlayerWindow.Location = new System.Drawing.Point(0, 0);
            this.sendImageToPlayerWindow.Name = "sendImageToPlayerWindow";
            this.sendImageToPlayerWindow.Size = new System.Drawing.Size(170, 42);
            this.sendImageToPlayerWindow.TabIndex = 2;
            this.sendImageToPlayerWindow.Text = "Send Image To Player";
            this.sendImageToPlayerWindow.UseVisualStyleBackColor = true;
            this.sendImageToPlayerWindow.Click += new System.EventHandler(this.sendImageToPlayerWindowButton_Click);
            // 
            // nextImageButton
            // 
            this.nextImageButton.AutoSize = true;
            this.nextImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextImageButton.Location = new System.Drawing.Point(0, 0);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(162, 42);
            this.nextImageButton.TabIndex = 1;
            this.nextImageButton.Text = "Next Image";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectImagesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 4;
            // 
            // selectImagesButton
            // 
            this.selectImagesButton.AutoSize = true;
            this.selectImagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectImagesButton.Location = new System.Drawing.Point(0, 0);
            this.selectImagesButton.Name = "selectImagesButton";
            this.selectImagesButton.Size = new System.Drawing.Size(200, 42);
            this.selectImagesButton.TabIndex = 0;
            this.selectImagesButton.Text = "Select Images";
            this.selectImagesButton.UseVisualStyleBackColor = true;
            this.selectImagesButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizePlayerScreenToolStripMenuItem,
            this.minimizePlayerScreenToolStripMenuItem,
            this.resetPlayerScreenToolStripMenuItem,
            this.clearPlayerImageToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.controlsToolStripMenuItem.Text = "Player Screen Controls";
            // 
            // maximizePlayerScreenToolStripMenuItem
            // 
            this.maximizePlayerScreenToolStripMenuItem.Name = "maximizePlayerScreenToolStripMenuItem";
            this.maximizePlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.maximizePlayerScreenToolStripMenuItem.Text = "Maximize Player Screen";
            this.maximizePlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.maximizePlayerScreenToolStripMenuItem_Click);
            // 
            // clearPlayerImageToolStripMenuItem
            // 
            this.clearPlayerImageToolStripMenuItem.Name = "clearPlayerImageToolStripMenuItem";
            this.clearPlayerImageToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clearPlayerImageToolStripMenuItem.Text = "Clear Player Image";
            this.clearPlayerImageToolStripMenuItem.Click += new System.EventHandler(this.clearPlayerImageToolStripMenuItem_Click);
            // 
            // minimizePlayerScreenToolStripMenuItem
            // 
            this.minimizePlayerScreenToolStripMenuItem.Name = "minimizePlayerScreenToolStripMenuItem";
            this.minimizePlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.minimizePlayerScreenToolStripMenuItem.Text = "Minimize Player Screen";
            this.minimizePlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.minimizePlayerScreenToolStripMenuItem_Click);
            // 
            // resetPlayerScreenToolStripMenuItem
            // 
            this.resetPlayerScreenToolStripMenuItem.Name = "resetPlayerScreenToolStripMenuItem";
            this.resetPlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.resetPlayerScreenToolStripMenuItem.Text = "Reset Player Screen";
            this.resetPlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.resetPlayerScreenToolStripMenuItem_Click);
            // 
            // GameMaster_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameMaster_Window";
            this.Text = "GameMaster Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameMaster_Window_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureSlider)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button previousImageButton;
        private System.Windows.Forms.Button sendImageToPlayerWindow;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.Button selectImagesButton;
        private System.Windows.Forms.PictureBox imagePictureSlider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizePlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizePlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlayerImageToolStripMenuItem;
    }
}

