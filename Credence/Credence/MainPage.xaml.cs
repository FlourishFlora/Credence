using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Credence
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Title = "Credence Game";

            App.Database[0] = new Trivia(
                "In 2011, each of these people was ranked by Forbes as one of the ten richest billionaires in the world. Who was ranked higher?",
                    "Carlos Slim",
                    "Lawrence Ellison",
                    1);

            Button A50 = new Button
            {
                //colored background
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "50%"
            };
            Button A60 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "60%"
            };
            Button B50 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "50%"
            };
            Button B60 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "60%"
            };

            A50.Clicked += async (sender, args) =>
            {
                if (App.Database[0].Correct == 1)
                {
                    App.Correct = true;
                }
                else
                {
                    App.Correct = false;
                }
                await Navigation.PushModalAsync(new AnswerPage());
            };
            A60.Clicked += async (sender, args) =>
            {
                if (App.Database[0].Correct == 1)
                {
                    App.Correct = true;
                    App.Score += 26;
                }
                else
                {
                    App.Correct = false;
                    App.Score += -32;
                }
                await Navigation.PushModalAsync(new AnswerPage());
            };
            B50.Clicked += async (sender, args) =>
            {
                if (App.Database[0].Correct == 2)
                {
                    App.Correct = true;
                }
                else
                {
                    App.Correct = false;
                }
                await Navigation.PushModalAsync(new AnswerPage());
            };
            B60.Clicked += async (sender, args) =>
            {
                if (App.Database[0].Correct == 2)
                {
                    App.Correct = true;
                    App.Score += 26;
                }
                else
                {
                    App.Correct = false;
                    App.Score += -32;
                }
                await Navigation.PushModalAsync(new AnswerPage());
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = App.QuestionNum + ". " + App.Database[0].Text
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = "A) " + App.Database[0].Answer1
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = "B) " + App.Database[0].Answer2
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = "Score: " + App.Score
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            A50,
                            A60
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            B50,
                            B60
                        }
                    }
                }
            };
        }
	}
}
