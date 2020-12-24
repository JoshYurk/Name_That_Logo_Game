
namespace Name_That_Logo_Game
{
    partial class ImageSearchWindow
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
            this.searchTermInput = new System.Windows.Forms.TextBox();
            this.searchTermLabel = new System.Windows.Forms.Label();
            this.safeSearchOff = new System.Windows.Forms.RadioButton();
            this.safeSearchModerate = new System.Windows.Forms.RadioButton();
            this.safeSearchStrict = new System.Windows.Forms.RadioButton();
            this.safeSearchLabel = new System.Windows.Forms.Label();
            this.imageCounter = new System.Windows.Forms.NumericUpDown();
            this.imagesToReturnLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTermInput
            // 
            this.searchTermInput.Location = new System.Drawing.Point(132, 12);
            this.searchTermInput.Name = "searchTermInput";
            this.searchTermInput.Size = new System.Drawing.Size(335, 22);
            this.searchTermInput.TabIndex = 0;
            // 
            // searchTermLabel
            // 
            this.searchTermLabel.AutoSize = true;
            this.searchTermLabel.Location = new System.Drawing.Point(36, 15);
            this.searchTermLabel.Name = "searchTermLabel";
            this.searchTermLabel.Size = new System.Drawing.Size(90, 17);
            this.searchTermLabel.TabIndex = 1;
            this.searchTermLabel.Text = "Search Term";
            // 
            // safeSearchOff
            // 
            this.safeSearchOff.AutoSize = true;
            this.safeSearchOff.Location = new System.Drawing.Point(132, 87);
            this.safeSearchOff.Name = "safeSearchOff";
            this.safeSearchOff.Size = new System.Drawing.Size(48, 21);
            this.safeSearchOff.TabIndex = 2;
            this.safeSearchOff.TabStop = true;
            this.safeSearchOff.Text = "Off";
            this.safeSearchOff.UseVisualStyleBackColor = true;
            this.safeSearchOff.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // safeSearchModerate
            // 
            this.safeSearchModerate.AutoSize = true;
            this.safeSearchModerate.Checked = true;
            this.safeSearchModerate.Location = new System.Drawing.Point(132, 114);
            this.safeSearchModerate.Name = "safeSearchModerate";
            this.safeSearchModerate.Size = new System.Drawing.Size(89, 21);
            this.safeSearchModerate.TabIndex = 3;
            this.safeSearchModerate.TabStop = true;
            this.safeSearchModerate.Text = "Moderate";
            this.safeSearchModerate.UseVisualStyleBackColor = true;
            this.safeSearchModerate.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // safeSearchStrict
            // 
            this.safeSearchStrict.AutoSize = true;
            this.safeSearchStrict.Location = new System.Drawing.Point(132, 141);
            this.safeSearchStrict.Name = "safeSearchStrict";
            this.safeSearchStrict.Size = new System.Drawing.Size(61, 21);
            this.safeSearchStrict.TabIndex = 4;
            this.safeSearchStrict.TabStop = true;
            this.safeSearchStrict.Text = "Strict";
            this.safeSearchStrict.UseVisualStyleBackColor = true;
            this.safeSearchStrict.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // safeSearchLabel
            // 
            this.safeSearchLabel.AutoSize = true;
            this.safeSearchLabel.Location = new System.Drawing.Point(36, 89);
            this.safeSearchLabel.Name = "safeSearchLabel";
            this.safeSearchLabel.Size = new System.Drawing.Size(86, 17);
            this.safeSearchLabel.TabIndex = 5;
            this.safeSearchLabel.Text = "Safe Search";
            // 
            // imageCounter
            // 
            this.imageCounter.Location = new System.Drawing.Point(132, 206);
            this.imageCounter.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.imageCounter.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.imageCounter.Name = "imageCounter";
            this.imageCounter.Size = new System.Drawing.Size(120, 22);
            this.imageCounter.TabIndex = 6;
            this.imageCounter.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // imagesToReturnLabel
            // 
            this.imagesToReturnLabel.AutoSize = true;
            this.imagesToReturnLabel.Location = new System.Drawing.Point(5, 208);
            this.imagesToReturnLabel.Name = "imagesToReturnLabel";
            this.imagesToReturnLabel.Size = new System.Drawing.Size(121, 17);
            this.imagesToReturnLabel.TabIndex = 7;
            this.imagesToReturnLabel.Text = "Images To Return";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(703, 403);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 35);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ImageSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.imagesToReturnLabel);
            this.Controls.Add(this.imageCounter);
            this.Controls.Add(this.safeSearchLabel);
            this.Controls.Add(this.safeSearchStrict);
            this.Controls.Add(this.safeSearchModerate);
            this.Controls.Add(this.safeSearchOff);
            this.Controls.Add(this.searchTermLabel);
            this.Controls.Add(this.searchTermInput);
            this.Name = "ImageSearchWindow";
            this.Text = "Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.imageCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTermInput;
        private System.Windows.Forms.Label searchTermLabel;
        private System.Windows.Forms.RadioButton safeSearchOff;
        private System.Windows.Forms.RadioButton safeSearchModerate;
        private System.Windows.Forms.RadioButton safeSearchStrict;
        private System.Windows.Forms.Label safeSearchLabel;
        private System.Windows.Forms.NumericUpDown imageCounter;
        private System.Windows.Forms.Label imagesToReturnLabel;
        private System.Windows.Forms.Button searchButton;
    }
}