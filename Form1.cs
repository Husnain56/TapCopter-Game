using System.ComponentModel;
using TapCopter.Models;
using TapCopter.Properties;
using static System.Formats.Asn1.AsnWriter;
using System.Media;


namespace TapCopter
{
    public partial class PlayArea : Form
    {
        public Point HeliInitLocation { get; set; }
        public bool Started { get; set; } = false;
        public int Distance { get; set; } = 0;
        public int BestScore { get; set; } = 0;

        public bool MoveUp;

        public int Gravity;

        public int time_btw_obstacles;

        public int HighScore;

        List<Obstacle> Buildings;

        SoundPlayer Helicopter_Sound;
        SoundPlayer Explosion_Sound;

        public PlayArea()
        {
            InitializeComponent();
            string highScorePath = "Best Score.txt";
            if (File.Exists(highScorePath))
            {
                string text = File.ReadAllText(highScorePath);
                int.TryParse(text, out HighScore);
            }
            else
            {
                File.WriteAllText(highScorePath, "0");
            }
            lbl_bestscore_count.Text = Convert.ToString(HighScore);

            HeliInitLocation = Helicopter.Location;
            lbl_distance.Visible = false;
            lbl_score.Visible = false;
            Buildings = new List<Obstacle>();
            Gravity = 5;
            time_btw_obstacles = 0;
            MoveUp = false;
            
            string soundPath1 = Path.Combine(Application.StartupPath, "Sounds", "HelicopterSound.wav");
            string soundPath2 = Path.Combine(Application.StartupPath, "Sounds", "ExplosionSound.wav");

            Helicopter_Sound = new SoundPlayer(soundPath1);
            Explosion_Sound = new SoundPlayer(soundPath2);

        }

        public void MoveHelicopter()
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

        public void CreateBuidings ()
        {
            if (time_btw_obstacles == 0)
            {
                Random Rand = new Random();
                int num = Rand.Next(50, 539 - 300);

                Obstacle Building = new Obstacle(new Point(840, num));
                Buildings.Add(Building);
                Controls.Add(Building);

                time_btw_obstacles = 60;
            }
            time_btw_obstacles--;

        }

        public void MoveBuildings()
        {
            if (Started == false)
            {
                return;
            }
            for (int i = Buildings.Count - 1; i >= 0; i--)
            {
                Buildings[i].MoveLeft();

                if (Buildings[i].Location.X < -60)
                {
                    this.Controls.Remove(Buildings[i]);
                    Buildings.RemoveAt(i);
                }
            }
        }


        public bool CheckCollision()
        {
            for(int i = 0; i < Buildings.Count(); i++)
            {
                if (Helicopter.Bounds.IntersectsWith(Buildings[i].Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        public void TimerMovementUpdater_Tick(object sender, EventArgs e)
        {
            if (Started)
            {
                CreateBuidings();
                MoveHelicopter();
                if (CheckCollision())
                {
                    var pos = Helicopter.Location;
                    pos.X -= 4;
                    pos.Y += 8;
                    Helicopter.Location = pos;
                    StopGame();
                    return;
                }
                
                MoveBuildings();
                Distance += 1;
                lbl_score.Text = Convert.ToString(Distance);
            }
        }

        public void StartGame()
        {   
            lbl_distance.Visible = true;
            lbl_score.Visible = true;
            lbl_start.Visible = false;
            lbl_controls.Visible = false;

            Helicopter_Sound.Play();
            TimerMovementUpdater.Start();
        }

        public void SaveHighScore()
        {
          
            lbl_score.Text = "0";
            if (Distance > HighScore)
            {
                HighScore = Distance;
                File.WriteAllText("Best Score.txt", HighScore.ToString());
                lbl_bestscore_count.Text = Convert.ToString(HighScore);
            }
            Distance = 0;
            
        }

        public async void StopGame()
        {
               
            TimerMovementUpdater.Stop();
            lbl_start.Text = "Game Over!";
            lbl_start.Visible = true;
            Helicopter_Sound.Stop();
            Explosion_Sound.Play();

            await Task.Delay(4000);
            Explosion_Sound.Stop();
            SaveHighScore();

            for (int i = Buildings.Count - 1; i >= 0; i--)
            {
                Controls.Remove(Buildings[i]);
            }
            Buildings.Clear();

            Started = false;
            Helicopter.Location = HeliInitLocation;
            lbl_start.Text = "CLICK TO START";
            lbl_controls.Visible = true;
        }

        public void PlayArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Started)
            {
                Started = true;
                StartGame();
            }
        }

        public void PlayArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (Started)
            {
                MoveUp = true;
            }
        }



        public void PlayArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Space)
                {
                    MoveUp = true;
                }
            }
        }

        public void PlayArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Space)
                {
                    MoveUp = false;
                }
            }
        }

        public void PlayArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (Started)
            {
                MoveUp = false;
            }
        }
    }
}
