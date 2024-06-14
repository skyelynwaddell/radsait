namespace helloworld
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            txtboxWelcome = new TextBox();
            lblGreeting = new Label();
            lblName = new Label();
            btnGreetMe = new Button();
            lblDisplayName = new Label();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtboxWelcome
            // 
            txtboxWelcome.Location = new Point(178, 112);
            txtboxWelcome.Name = "txtboxWelcome";
            txtboxWelcome.Size = new Size(271, 29);
            txtboxWelcome.TabIndex = 0;
            txtboxWelcome.Text = "Enter your name...";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.BackColor = Color.FromArgb(192, 192, 255);
            lblGreeting.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(12, 9);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(285, 32);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Welcome to The Matrix";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(160, 22);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your name";
            // 
            // btnGreetMe
            // 
            btnGreetMe.BackColor = Color.MediumSlateBlue;
            btnGreetMe.Location = new Point(12, 158);
            btnGreetMe.Name = "btnGreetMe";
            btnGreetMe.Size = new Size(200, 47);
            btnGreetMe.TabIndex = 3;
            btnGreetMe.Text = "&Enter The Matrix";
            btnGreetMe.UseVisualStyleBackColor = false;
            btnGreetMe.Click += btnGreetMe_Click;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(12, 64);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(0, 22);
            lblDisplayName.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.RoyalBlue;
            btnReset.Location = new Point(218, 158);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(158, 47);
            btnReset.TabIndex = 5;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PaleVioletRed;
            btnExit.Location = new Point(382, 158);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 47);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmHello
            // 
            AcceptButton = btnGreetMe;
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnReset;
            ClientSize = new Size(543, 371);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lblDisplayName);
            Controls.Add(btnGreetMe);
            Controls.Add(lblName);
            Controls.Add(lblGreeting);
            Controls.Add(txtboxWelcome);
            DoubleBuffered = true;
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHello";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Matrix";
            TransparencyKey = Color.Gainsboro;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxWelcome;
        private Label lblGreeting;
        private Label lblName;
        private Button btnGreetMe;
        private Label lblDisplayName;
        private Button btnReset;
        private Button btnExit;
    }
}
