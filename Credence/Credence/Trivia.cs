using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Credence
{
    public class Trivia
    {
        public string Text { get; set; }
        public string CorrectAns { get; set; }
        public string IncorrectAns { get; set; }

        public Trivia()
        {
            Text = "";
            CorrectAns = "";
            IncorrectAns = "";
        }

        public Trivia(string text, string correctAns, string incorrectAns)
        {
            Text = text;
            CorrectAns = correctAns;
            IncorrectAns = incorrectAns;
        }

        public static void buildTrivia()
        {
            App.Database.Add(new Trivia(
                "In 2011, each of these people was ranked by Forbes as one of the ten richest billionaires in the world. Who was ranked higher?",
                    "Carlos Slim",
                    "Lawrence Ellison"
                    ));
            for (int j = 0; j < 200; j++)
            {
                JObject o = (JObject)JSONTrivia.m["results"][j];
                App.Database.Add(new Trivia()
                {
                    Text = (string)o["question"],
                    CorrectAns = (string)o["correct_answer"],
                    IncorrectAns = ((string)o["type"] == "multiple") ? (string)o["incorrect_answers"][App.rand.Next(0, 3)] : (string)o["incorrect_answers"][0],
                });
            }
        }
    }
}
