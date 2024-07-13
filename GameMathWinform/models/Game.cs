using System;
using System.Collections.Generic;

namespace GameMathWinform.models
{
    public class Game
    {
        private List<int> listLevelUp = new List<int> { 5, 10, 20, 30 };
        private int corects { get; set; }
        public int level { get; set; }

        public int Corects { 
            get { return this.corects; }
            set 
            { 
                if (listLevelUp.Contains(this.corects))
                    {
                        this.levelUp();
                    }
                this.corects = value;
            }
        }

        public int score { get; set; }
        public int time { get; set; }
        public bool isPlaying { get; set; }
        public bool isEnd { get; set; }
        public Question question { get; set; }

        public Game(int _time)
        {
            this.level = 1;
            this.Corects = 0;
            this.score = 0;
            this.isPlaying = false;
            this.isEnd = false;
            this.time = _time;
        }

        public Question generateQuestion()
        {
            this.question=new Question(level);
            return this.question;
        }

        public string levelUp()
        {
            this.level++;
            return $"Bạn đã lên level {this.level}.";
        }

        public string messLossing()
        {
            return $"Bạn đã hết lượt chơi, điểm của bạn là {this.score}.";
        }

        public string messCorrect()
        {
            return $"Chúc mừng bạn trả lời đúng {this.Corects} câu!";
        }

        public string messNotCorrect()
        {
            return $"Bạn trả lời sai rồi! bạn còn {this.time} lượt.";
        }

        public bool isLosing()
        {
            return this.time == 0;
        }
        
        public void Stop()
        {
            this.isEnd = true;
        }
        
        public void addScore(int scores)
        {
            this.score+=scores;
        }
        
        public void minusTime()
        {
            this.time--;
        }

        public void AddCorrect()
        {
            this.Corects++;
        }
    }
}
