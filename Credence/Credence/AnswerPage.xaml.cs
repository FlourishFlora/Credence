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

            string text = "";
            Color textColor;
            double opacity = (App.DeltaScore == 0) ? 0.5 : 0.6 + Math.Log(Math.Abs(App.DeltaScore)) / 6.5;
            if (App.AnsweredCorrectly)
            {
                text += "+" + App.DeltaScore;
                textColor = new Color(0, 1, 0, opacity);
            }
            else
            {
                if (App.DeltaScore == 0)
                    text += "-";
                text += App.DeltaScore;
                textColor = new Color(1, 0, 0, opacity);
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
                        FontSize = 128,
                        HorizontalTextAlignment = TextAlignment.Center,
                        TextColor = textColor,
                        Text = text
                    }
                }
            };
        }

        async protected override void OnAppearing()
        {
            base.OnAppearing();

            Content.Opacity = 1;
            await Task.WhenAny<bool>
            (
                Content.ScaleTo(3, 400, Easing.CubicOut),
                Content.FadeTo(0, 400, Easing.CubicOut)
                );
            if (App.RoundNum <= 24) //end the game after 25 questions or so
                await Navigation.PushModalAsync(new MainPage());
            else
                await Navigation.PushModalAsync(new ResultsPage());
        }
    }
}
