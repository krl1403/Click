using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicking_Game
{
    public partial class Form1 : Form, IEnableButtons
    {
        public int time_Count = 0;
        public static int score_Count;
        Color customBlue = Color.FromArgb(20, 33, 61);
        Color customOrange = Color.FromArgb(252, 163, 17);

        private Timer countdownTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            
            // Make background color of windows form to custome blue color
            //this.BackColor = customBlue;

            //// Make instructions color orange
            //lbl_instructions.ForeColor = customOrange;
            //label1.ForeColor = customOrange;

            // Set default values 
            lbl_time_count.Text = "Time: ";
            lbl_instructions.Text = "Select time. Click button to start! Good luck!";
        }

        private void InitializeCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // Timer interval in milliseconds (1 second)
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void StartCountdown()
        {
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            time_Count--;

            if (time_Count <= 0)
            {
                countdownTimer.Stop();
                lbl_time_count.Text = "Time's up!";
                MessageBox.Show($"Final Score: {score_Count}");
                EnableButtons(true);
            }
            else
            {
                lbl_time_count.Text = $"Time: {time_Count}s";
            }
        }

        private void Set_Time(int time)
        {
            time_Count = time;
            lbl_time_count.Text = $"Time: {time_Count}s";

            score_Count = ConvertStringToInt(lbl_score.Text);
            score_Count = 0;
            lbl_score.Text = ConvertToString(score_Count);
        }

        private void btn_fifteen_Click(object sender, EventArgs e)
        {
            Set_Time(15);
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            Set_Time(10);
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            Set_Time(5);
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            if (time_Count == 0)
            {
                MessageBox.Show("Ready to play? Choose time to begin!");
                EnableButtons(true);
            }
            else
            {
                score_Count = ConvertStringToInt(lbl_score.Text);
                score_Count++;
                lbl_score.Text = ConvertToString(score_Count);
                StartCountdown();
                EnableButtons(false);
            }
        }

        public void EnableButtons(bool value)
        {
            btn_five.Enabled = value;
            btn_fifteen.Enabled = value;
            btn_ten.Enabled = value;
        }

        private int ConvertStringToInt(string text)
        {
            return int.Parse(text);
        }

        private string ConvertToString(int count)
        {
            return count.ToString();
        }
    }
}
