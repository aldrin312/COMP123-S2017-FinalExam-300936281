using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300936281
{
    public class ScoreBoard
    {
        //private instances
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timerTextbox;

        //publuc properties

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;

            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                ScoreTextBox.Text = this._score.ToString();

            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;

            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimerTextbox.Text = this._time.ToString();

            }
        }
        public TextBox TimerTextbox
        {
            get
            {
                return this._timerTextbox;
            }
            set
            {
                this._timerTextbox = value;

            }
        }
        //methods
        public ScoreBoard(TextBox scoreTextBox,TextBox timerTextBox, TextBox finalScoreTextBox)
        {
            ScoreTextBox = scoreTextBox;
            TimerTextbox = timerTextBox;
            FinalScoreTextBox = finalScoreTextBox;
        }

        public void UpdateTimer()
        {
            Time = int.Parse(TimerTextbox.Text) - 1; 
        }

    }
}
