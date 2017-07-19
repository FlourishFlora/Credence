using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Credence
{
    public partial class App : Application
	{
        public static List<Trivia> Database = new List<Trivia>();
        public static int Score = 0;
        public static int RoundNum = 0;
        public static bool AnsweredCorrectly = false;
        public static bool AIsCorrect = true;
        public static int DeltaScore;
        public static Random rand = new Random();

        // e.g., if you get 3 out of 4 answers right for something you answered 60%
        // scoresCorrect[1] would be 3, and scoresTotal[1] would be 4
        // tbh I should probably make a separate object for this than use parallel arrays but whatevs
        // 6 because you have six confidence levels: 50%, 60%, 70%, 80%, 90%, and 99%
        public static int[] CorrectAnswers = new int[6];
        public static int[] TotalAnswers = new int[6];

        public App()
		{
            InitializeComponent();

            Trivia.buildTrivia();
			MainPage = new Credence.TitlePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
