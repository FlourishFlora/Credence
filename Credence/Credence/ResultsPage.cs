using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Credence
{
	public class ResultsPage : ContentPage
	{
		public ResultsPage()
		{
            double[] percentages = new double[6];
            for (int i = 0; i < 6; i++)
            {
                percentages[i] = Math.Round((double) 100 * App.CorrectAnswers[i] / App.TotalAnswers[i], 2);
            }
            int totalScore = App.Score;
            double avgScore = Math.Round((double) App.Score / 25, 2);

            Button restart = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                WidthRequest = 100,
                Text = "Restart Game"
            };
            restart.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new TitlePage());
            };

            Content = new StackLayout
            {
				Children =
                {
                    new Label
                    {
                        FontSize = 64,
                        Text = "Results"
                    },
					new Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = "Final score: " + totalScore + "\n" +
                        "Average score: " + avgScore + "\n\n" +
                        "Calibration results:\n" +
                        "subjective probability given | % correct | diff | count\n" +
                        "50% | " + percentages[0] + " | " + (percentages[0] - 50) + " | " + App.TotalAnswers[0] + "\n" +
                        "60% | " + percentages[1] + " | " + (percentages[1] - 60) + " | " + App.TotalAnswers[1] + "\n" +
                        "70% | " + percentages[2] + " | " + (percentages[2] - 70) + " | " + App.TotalAnswers[2] + "\n" +
                        "80% | " + percentages[3] + " | " + (percentages[3] - 80) + " | " + App.TotalAnswers[3] + "\n" +
                        "90% | " + percentages[4] + " | " + (percentages[4] - 90) + " | " + App.TotalAnswers[4] + "\n" +
                        "99% | " + percentages[5] + " | " + (percentages[5] - 99) + " | " + App.TotalAnswers[5]
                    },
                    restart
				}
			};
            Padding = new Thickness(15, 50, 15, 15);
        }
	}
}
