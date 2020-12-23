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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectImagesButton = new System.Windows.Forms.Button();
            this.previousImageButton = new System.Windows.Forms.Button();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.sendImageToPlayerWindow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializePlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizePlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizePlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPlayerScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlayerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retieveSearchedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureSlider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Image Browser";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imagePictureSlider);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 526);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // imagePictureSlider
            // 
            this.imagePictureSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureSlider.Location = new System.Drawing.Point(0, 0);
            this.imagePictureSlider.Margin = new System.Windows.Forms.Padding(4);
            this.imagePictureSlider.Name = "imagePictureSlider";
            this.imagePictureSlider.Size = new System.Drawing.Size(1067, 467);
            this.imagePictureSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureSlider.TabIndex = 0;
            this.imagePictureSlider.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.selectImagesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previousImageButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextImageButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sendImageToPlayerWindow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureCountLabel, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectImagesButton
            // 
            this.selectImagesButton.AutoSize = true;
            this.selectImagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectImagesButton.Location = new System.Drawing.Point(4, 4);
            this.selectImagesButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectImagesButton.Name = "selectImagesButton";
            this.selectImagesButton.Size = new System.Drawing.Size(205, 46);
            this.selectImagesButton.TabIndex = 0;
            this.selectImagesButton.Text = "Select Images";
            this.selectImagesButton.UseVisualStyleBackColor = true;
            this.selectImagesButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // previousImageButton
            // 
            this.previousImageButton.AutoSize = true;
            this.previousImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousImageButton.Enabled = false;
            this.previousImageButton.Location = new System.Drawing.Point(217, 4);
            this.previousImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(205, 46);
            this.previousImageButton.TabIndex = 3;
            this.previousImageButton.Text = "Previous Image";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.PreviousImageButton_Click);
            // 
            // nextImageButton
            // 
            this.nextImageButton.AutoSize = true;
            this.nextImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextImageButton.Enabled = false;
            this.nextImageButton.Location = new System.Drawing.Point(643, 4);
            this.nextImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(205, 46);
            this.nextImageButton.TabIndex = 1;
            this.nextImageButton.Text = "Next Image";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // sendImageToPlayerWindow
            // 
            this.sendImageToPlayerWindow.AutoSize = true;
            this.sendImageToPlayerWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendImageToPlayerWindow.Enabled = false;
            this.sendImageToPlayerWindow.Location = new System.Drawing.Point(430, 4);
            this.sendImageToPlayerWindow.Margin = new System.Windows.Forms.Padding(4);
            this.sendImageToPlayerWindow.Name = "sendImageToPlayerWindow";
            this.sendImageToPlayerWindow.Size = new System.Drawing.Size(205, 46);
            this.sendImageToPlayerWindow.TabIndex = 2;
            this.sendImageToPlayerWindow.Text = "Send Image To Player";
            this.sendImageToPlayerWindow.UseVisualStyleBackColor = true;
            this.sendImageToPlayerWindow.Click += new System.EventHandler(this.SendImageToPlayerWindowButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.searchForImagesToolStripMenuItem,
            this.retieveSearchedImagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializePlayerScreenToolStripMenuItem,
            this.maximizePlayerScreenToolStripMenuItem,
            this.minimizePlayerScreenToolStripMenuItem,
            this.resetPlayerScreenToolStripMenuItem,
            this.clearPlayerImageToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.controlsToolStripMenuItem.Text = "Player Screen Controls";
            // 
            // initializePlayerScreenToolStripMenuItem
            // 
            this.initializePlayerScreenToolStripMenuItem.Name = "initializePlayerScreenToolStripMenuItem";
            this.initializePlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.initializePlayerScreenToolStripMenuItem.Text = "Initialize Player Screen";
            this.initializePlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.InitializePlayerScreenToolStripMenuItem_Click);
            // 
            // maximizePlayerScreenToolStripMenuItem
            // 
            this.maximizePlayerScreenToolStripMenuItem.Enabled = false;
            this.maximizePlayerScreenToolStripMenuItem.Name = "maximizePlayerScreenToolStripMenuItem";
            this.maximizePlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.maximizePlayerScreenToolStripMenuItem.Text = "Maximize Player Screen";
            this.maximizePlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.MaximizePlayerScreenToolStripMenuItem_Click);
            // 
            // minimizePlayerScreenToolStripMenuItem
            // 
            this.minimizePlayerScreenToolStripMenuItem.Enabled = false;
            this.minimizePlayerScreenToolStripMenuItem.Name = "minimizePlayerScreenToolStripMenuItem";
            this.minimizePlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.minimizePlayerScreenToolStripMenuItem.Text = "Minimize Player Screen";
            this.minimizePlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.MinimizePlayerScreenToolStripMenuItem_Click);
            // 
            // resetPlayerScreenToolStripMenuItem
            // 
            this.resetPlayerScreenToolStripMenuItem.Enabled = false;
            this.resetPlayerScreenToolStripMenuItem.Name = "resetPlayerScreenToolStripMenuItem";
            this.resetPlayerScreenToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.resetPlayerScreenToolStripMenuItem.Text = "Reset Player Screen";
            this.resetPlayerScreenToolStripMenuItem.Click += new System.EventHandler(this.ResetPlayerScreenToolStripMenuItem_Click);
            // 
            // clearPlayerImageToolStripMenuItem
            // 
            this.clearPlayerImageToolStripMenuItem.Enabled = false;
            this.clearPlayerImageToolStripMenuItem.Name = "clearPlayerImageToolStripMenuItem";
            this.clearPlayerImageToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.clearPlayerImageToolStripMenuItem.Text = "Clear Player Image";
            this.clearPlayerImageToolStripMenuItem.Click += new System.EventHandler(this.ClearPlayerImageToolStripMenuItem_Click);
            // 
            // searchForImagesToolStripMenuItem
            // 
            this.searchForImagesToolStripMenuItem.Name = "searchForImagesToolStripMenuItem";
            this.searchForImagesToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.searchForImagesToolStripMenuItem.Text = "Search For Images";
            this.searchForImagesToolStripMenuItem.Click += new System.EventHandler(this.searchForImagesToolStripMenuItem_Click);
            // 
            // retieveSearchedImagesToolStripMenuItem
            // 
            this.retieveSearchedImagesToolStripMenuItem.Enabled = false;
            this.retieveSearchedImagesToolStripMenuItem.Name = "retieveSearchedImagesToolStripMenuItem";
            this.retieveSearchedImagesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.retieveSearchedImagesToolStripMenuItem.Text = "Retieve Searched Images";
            this.retieveSearchedImagesToolStripMenuItem.Click += new System.EventHandler(this.retieveSearchedImagesToolStripMenuItem_Click);
            // 
            // pictureCountLabel
            // 
            this.pictureCountLabel.AutoSize = true;
            this.pictureCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureCountLabel.Location = new System.Drawing.Point(855, 0);
            this.pictureCountLabel.Name = "pictureCountLabel";
            this.pictureCountLabel.Size = new System.Drawing.Size(209, 54);
            this.pictureCountLabel.TabIndex = 4;
            this.pictureCountLabel.Text = "Picture 0/0";
            this.pictureCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameMaster_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameMaster_Window";
            this.Text = "GameMaster Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameMaster_Window_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureSlider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizePlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizePlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPlayerScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlayerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializePlayerScreenToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem searchForImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retieveSearchedImagesToolStripMenuItem;
        private System.Windows.Forms.Label pictureCountLabel;
    }
}

