using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Credence
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnswerPage : ContentPage
	{
		public AnswerPage()
		{
			InitializeComponent();

            Title = "Answer Page";
            string FeedbackText;
            if (App.Correct)
            {
                FeedbackText = "Correct! blah blah blah is richer! You gain x points!";
            }
            else
            {
                FeedbackText = "Incorrect! You suck at life! You lose x points!";
            }

            Button next = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "Next Question"
            };
            next.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new MainPage());
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalTextAlignment = TextAlignment.Start,
                        Text = FeedbackText + "\n" + "Score: " + App.Score
                    },
                    next
                }
            };
        }
	}
}
