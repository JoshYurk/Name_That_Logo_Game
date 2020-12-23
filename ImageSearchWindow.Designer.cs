
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.safeSearchOff = new System.Windows.Forms.RadioButton();
            this.safeSearchModerate = new System.Windows.Forms.RadioButton();
            this.safeSearchStrict = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Term";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Safe Search";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(132, 206);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Images To Return";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(703, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.safeSearchStrict);
            this.Controls.Add(this.safeSearchModerate);
            this.Controls.Add(this.safeSearchOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ImageSearchWindow";
            this.Text = "Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton safeSearchOff;
        private System.Windows.Forms.RadioButton safeSearchModerate;
        private System.Windows.Forms.RadioButton safeSearchStrict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}