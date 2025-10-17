namespace TapCopter
{
    partial class PlayArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayArea));
            TimerMovementUpdater = new System.Windows.Forms.Timer(components);
            Helicopter = new Models.Helicopter();
            lbl_start = new Label();
            lbl_controls = new Label();
            lbl_distance = new Label();
            lbl_bestscore = new Label();
            lbl_score = new Label();
            lbl_bestscore_count = new Label();
            ((System.ComponentModel.ISupportInitialize)Helicopter).BeginInit();
            SuspendLayout();
            // 
            // TimerMovementUpdater
            // 
            TimerMovementUpdater.Interval = 10;
            TimerMovementUpdater.Tick += TimerMovementUpdater_Tick;
            // 
            // Helicopter
            // 
            Helicopter.BackColor = Color.Transparent;
            Helicopter.Image = (Image)resources.GetObject("Helicopter.Image");
            Helicopter.InitialImage = null;
            Helicopter.Location = new Point(138, 159);
            Helicopter.Name = "Helicopter";
            Helicopter.Size = new Size(76, 61);
            Helicopter.speed = 10;
            Helicopter.TabIndex = 0;
            Helicopter.TabStop = false;
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.BackColor = SystemColors.ActiveCaptionText;
            lbl_start.Font = new Font("Segoe Script", 40F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_start.ForeColor = Color.SkyBlue;
            lbl_start.Location = new Point(252, 149);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(525, 86);
            lbl_start.TabIndex = 1;
            lbl_start.Text = "CLICK TO START";
            lbl_start.MouseClick += PlayArea_MouseClick;
            // 
            // lbl_controls
            // 
            lbl_controls.AutoSize = true;
            lbl_controls.BackColor = SystemColors.ActiveCaptionText;
            lbl_controls.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_controls.ForeColor = Color.SkyBlue;
            lbl_controls.Location = new Point(111, 320);
            lbl_controls.Name = "lbl_controls";
            lbl_controls.Size = new Size(656, 32);
            lbl_controls.TabIndex = 2;
            lbl_controls.Text = "CLICK AND HOLD TO GO UP AND RELEASE TO GO DOWN";
            lbl_controls.MouseClick += PlayArea_MouseClick;
            // 
            // lbl_distance
            // 
            lbl_distance.AutoSize = true;
            lbl_distance.BackColor = SystemColors.ActiveCaptionText;
            lbl_distance.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_distance.ForeColor = Color.SkyBlue;
            lbl_distance.Location = new Point(24, 448);
            lbl_distance.Name = "lbl_distance";
            lbl_distance.Size = new Size(108, 32);
            lbl_distance.TabIndex = 3;
            lbl_distance.Text = "Distance:";
            // 
            // lbl_bestscore
            // 
            lbl_bestscore.AutoSize = true;
            lbl_bestscore.BackColor = SystemColors.ActiveCaptionText;
            lbl_bestscore.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_bestscore.ForeColor = Color.SkyBlue;
            lbl_bestscore.Location = new Point(774, 448);
            lbl_bestscore.Name = "lbl_bestscore";
            lbl_bestscore.Size = new Size(63, 32);
            lbl_bestscore.TabIndex = 4;
            lbl_bestscore.Text = "Best:";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.BackColor = SystemColors.ActiveCaptionText;
            lbl_score.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_score.ForeColor = Color.SkyBlue;
            lbl_score.Location = new Point(138, 448);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(29, 32);
            lbl_score.TabIndex = 5;
            lbl_score.Text = "0";
            // 
            // lbl_bestscore_count
            // 
            lbl_bestscore_count.AutoSize = true;
            lbl_bestscore_count.BackColor = SystemColors.ActiveCaptionText;
            lbl_bestscore_count.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            lbl_bestscore_count.ForeColor = Color.SkyBlue;
            lbl_bestscore_count.Location = new Point(843, 448);
            lbl_bestscore_count.Name = "lbl_bestscore_count";
            lbl_bestscore_count.Size = new Size(29, 32);
            lbl_bestscore_count.TabIndex = 6;
            lbl_bestscore_count.Text = "0";
            // 
            // PlayArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(900, 500);
            Controls.Add(lbl_bestscore_count);
            Controls.Add(lbl_score);
            Controls.Add(lbl_bestscore);
            Controls.Add(lbl_distance);
            Controls.Add(lbl_controls);
            Controls.Add(lbl_start);
            Controls.Add(Helicopter);
            Name = "PlayArea";
            Text = "TapCopter";
            KeyDown += PlayArea_KeyDown;
            KeyUp += PlayArea_KeyUp;
            MouseClick += PlayArea_MouseClick;
            MouseDown += PlayArea_MouseDown;
            MouseUp += PlayArea_MouseUp;
            ((System.ComponentModel.ISupportInitialize)Helicopter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer TimerMovementUpdater;
        private Models.Helicopter Helicopter;
        private Label lbl_start;
        private Label lbl_controls;
        private Label lbl_distance;
        private Label lbl_bestscore;
        private Label lbl_score;
        private Label lbl_bestscore_count;
    }
}
