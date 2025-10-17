namespace TapCopter
{
    public partial class PlayArea : Form
    {
        public Point HeliInitLocation { get; set; }
        public bool Started { get; set; } = false;
        public int Distance { get; set; } = 0;
        public int BestScore { get; set; } = 0;

        public bool MoveUp = false;

        public bool MoveDown = false;

        public int Gravity = 5;
        public PlayArea()
        {
            InitializeComponent();
            HeliInitLocation = Helicopter.Location;
            lbl_distance.Visible = false;
            lbl_score.Visible = false;

        }
        private void TimerMovementUpdater_Tick(object sender, EventArgs e)
        {
            if (!Started) return;

            Point P = Helicopter.Location;

            if (MoveUp)
                P.Y -= Helicopter.speed;
            else
                P.Y += Gravity;

            if (P.Y < 0)
                P.Y = 0;
            if (P.Y > this.ClientSize.Height - Helicopter.Height)
                P.Y = this.ClientSize.Height - Helicopter.Height;

            Helicopter.Location = P;
        }

        public void StartGame()
        {
            lbl_distance.Visible = true;
            lbl_score.Visible = true;
            lbl_start.Visible = false;
            lbl_controls.Visible = false;
            TimerMovementUpdater.Start();
        }

        public void StopGame()
        {

        }

        private void PlayArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Started)
            {
                Started = true;
                StartGame();
            }
        }

        private void PlayArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (Started)
            {
                MoveUp = true;
            }
        }



        private void PlayArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Space)
                {
                    MoveUp = true;
                }
            }
        }

        private void PlayArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Space)
                {
                    MoveUp = false;
                }
            }
        }

        private void PlayArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (Started)
            {
                MoveUp = false;
            }
        }
    }
}
