namespace Name_That_Logo_Game
{
    partial class GamePlayer_Window
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
            this.playerLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerLogoPictureBox
            // 
            this.playerLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.playerLogoPictureBox.Name = "playerLogoPictureBox";
            this.playerLogoPictureBox.Size = new System.Drawing.Size(800, 450);
            this.playerLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerLogoPictureBox.TabIndex = 0;
            this.playerLogoPictureBox.TabStop = false;
            // 
            // GamePlayer_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.playerLogoPictureBox);
            this.Name = "GamePlayer_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player Window";
            ((System.ComponentModel.ISupportInitialize)(this.playerLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerLogoPictureBox;
    }
}