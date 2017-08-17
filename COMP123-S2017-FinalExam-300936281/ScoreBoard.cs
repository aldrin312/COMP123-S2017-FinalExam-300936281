using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300936281
{
    class ScoreBoard
    {
        //private instances
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _timer;
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
        public int Timer
        {
            get
            {
                return this._timer;
            }
            set
            {
                this._timer = value;

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


    }
}
