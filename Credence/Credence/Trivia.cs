using System;
using System.Collections.Generic;
using System.Text;

namespace Credence
{
    public class Trivia
    {
        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public int Correct { get; set; }
        public string CorrectAns { get; set; }

        public Trivia(string text, string answer1, string answer2, int correct)
        {
            Text = text;
            Answer1 = answer1;
            Answer2 = answer2;
            Correct = correct;
            CorrectAns = (Correct == 1) ? Answer1 : Answer2;
        }
    }
}
