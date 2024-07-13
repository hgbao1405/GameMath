using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMathWinform.models
{
    public class Question
    {
        public int a {  get; set; }
        public int b { get; set; }
        public int math { get; set; }
        public int res { get; set; }

        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        public int CalculateMaxValue(int level)
        {
            return (int)Math.Pow(10, level) - 1;
        }
        
        public Question(int level)
        {
            int Max=this.CalculateMaxValue(level);
            Random rand = new Random();
            this.math = rand.Next(0, 4);

            switch (this.math)
            {
                case 0:
                    this.a = rand.Next(0, Max);
                    this.b = rand.Next(0, Max);
                    this.res = this.a + this.b;
                    break;
                case 1:
                    this.a = rand.Next(0, Max);
                    this.b = rand.Next(0, Max);
                    if (this.b > this.a)
                    {
                        this.res = this.b - this.a;
                    }
                    else
                    {
                        this.res = this.a - this.b;
                    }
                    break;
                case 2:
                    this.a = rand.Next(0, Max);
                    do
                    {
                        this.b = rand.Next(0, Max);
                    }
                    while (this.b  == 0 );
                    this.res = this.a * this.b;
                    break;
                case 3:
                    this.b = rand.Next(1, Max / 2);
                    this.a = this.b * rand.Next(1, Max);
                    this.res = this.a / this.b;
                    break;
            }
        }
        
        public string ShowCauhoi()
        {
            string question = "";
            switch (this.math)
            {
                case 0:
                    question=$"{this.a} + {this.b}=?";
                    break;
                case 1:
                    if (this.b > this.a)
                    {
                        question = $"{this.b}-{this.a}=?";
                    }
                    else
                    {
                        question=$"{this.a}-{this.b}=?";
                    }
                    break;
                case 2:
                    question = $"{this.a}x{this.b}=?";
                    break;
                case 3:
                    question = $"{this.a} / {this.b}=?";
                    break;
            }
            return question;
        }

        public bool IsCorrect(int ketqua)
        {
            return (ketqua == res);
        }
    }
}
