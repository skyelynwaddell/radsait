namespace chickenegg
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            picAnswer = new PictureBox();
            groupBox1 = new GroupBox();
            radioEgg = new RadioButton();
            radioChicken = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picAnswer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picAnswer
            // 
            picAnswer.BackColor = SystemColors.ActiveCaption;
            picAnswer.BackgroundImageLayout = ImageLayout.Stretch;
            picAnswer.BorderStyle = BorderStyle.FixedSingle;
            picAnswer.Location = new Point(12, 12);
            picAnswer.Name = "picAnswer";
            picAnswer.Size = new Size(243, 197);
            picAnswer.SizeMode = PictureBoxSizeMode.Zoom;
            picAnswer.TabIndex = 0;
            picAnswer.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(radioEgg);
            groupBox1.Controls.Add(radioChicken);
            groupBox1.Location = new Point(21, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "What came first?";
            // 
            // radioEgg
            // 
            radioEgg.AutoSize = true;
            radioEgg.Location = new Point(59, 55);
            radioEgg.Name = "radioEgg";
            radioEgg.Size = new Size(64, 24);
            radioEgg.TabIndex = 1;
            radioEgg.TabStop = true;
            radioEgg.Text = "Egg";
            radioEgg.UseVisualStyleBackColor = true;
            radioEgg.CheckedChanged += radioEgg_CheckedChanged;
            // 
            // radioChicken
            // 
            radioChicken.AutoSize = true;
            radioChicken.Location = new Point(59, 25);
            radioChicken.Name = "radioChicken";
            radioChicken.Size = new Size(107, 24);
            radioChicken.TabIndex = 0;
            radioChicken.TabStop = true;
            radioChicken.Text = "Chicken";
            radioChicken.UseVisualStyleBackColor = true;
            radioChicken.CheckedChanged += radioChicken_CheckedChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(272, 375);
            Controls.Add(groupBox1);
            Controls.Add(picAnswer);
            DoubleBuffered = true;
            Font = new Font("Super Mario 256", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 4, 6, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChickenEgg";
            ((System.ComponentModel.ISupportInitialize)picAnswer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAnswer;
        private GroupBox groupBox1;
        private RadioButton radioEgg;
        private RadioButton radioChicken;
    }
}
