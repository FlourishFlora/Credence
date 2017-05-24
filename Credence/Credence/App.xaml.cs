using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Credence
{
	public partial class App : Application
	{
        public static Trivia[] Database = new Trivia[2];
        public static int Score = 0;
        public static int QuestionNum = 1;
        public static bool Correct = false;

        public App ()
		{
			InitializeComponent();

			MainPage = new Credence.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
