using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace Credence
{
    public partial class MainPage : ContentPage
    {
        Button A50, A60, A70, A80, A90, A99, B50, B60, B70, B80, B90, B99;

        public MainPage()
        {
            InitializeComponent();
            Title = "Credence Game";

            int QuestionNum = App.rand.Next(App.Database.Count);
            App.RoundNum++;
            App.AIsCorrect = (App.rand.NextDouble() < 0.5);
            string questionText = App.RoundNum + ". " + App.Database[QuestionNum].Text;
            string aText, bText;
            if (App.AIsCorrect)
            {
                aText = "A) " + App.Database[QuestionNum].CorrectAns;
                bText = "B) " + App.Database[QuestionNum].IncorrectAns;
            }
            else
            {
                aText = "A) " + App.Database[QuestionNum].IncorrectAns;
                bText = "B) " + App.Database[QuestionNum].CorrectAns;
            }
            App.Database.RemoveAt(QuestionNum);

            A50 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "50%"
            };
            A60 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "60%"
            };
            A70 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "70%"
            };
            A80 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "80%"
            };
            A90 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "90%"
            };
            A99 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "99%"
            };
            B50 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "50%"
            };
            B60 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "60%"
            };
            B70 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "70%"
            };
            B80 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "80%"
            };
            B90 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "90%"
            };
            B99 = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = "99%"
            };

            A50.Clicked += OnAButtonClicked;
            A60.Clicked += OnAButtonClicked;
            A70.Clicked += OnAButtonClicked;
            A80.Clicked += OnAButtonClicked;
            A90.Clicked += OnAButtonClicked;
            A99.Clicked += OnAButtonClicked;
            B50.Clicked += OnBButtonClicked;
            B60.Clicked += OnBButtonClicked;
            B70.Clicked += OnBButtonClicked;
            B80.Clicked += OnBButtonClicked;
            B90.Clicked += OnBButtonClicked;
            B99.Clicked += OnBButtonClicked;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = "Score: " + App.Score + "\n"
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = 48,
                        Text = questionText
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = aText
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        Text = bText
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            A50, A60, A70, A80, A90, A99
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            B50, B60, B70, B80, B90, B99
                        }
                    }
                }
            };

            Padding = new Thickness(15, 50, 15, 15);
        }

        async void OnAButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button) sender;
            int[] correctScores = { 0, 26, 49, 68, 85, 99 };
            int[] incorrectScores = { 0, -32, -74, -132, -232, -564 };

            int i;
            if (button == A50) i = 0;
            else if (button == A60) i = 1;
            else if (button == A70) i = 2;
            else if (button == A80) i = 3;
            else if (button == A90) i = 4;
            else i = 5;

            if (App.AIsCorrect)
            {
                App.AnsweredCorrectly = true;
                App.DeltaScore = correctScores[i];
                App.Score += correctScores[i];
                App.CorrectAnswers[i]++;
            }
            else
            {
                App.AnsweredCorrectly = false;
                App.DeltaScore = incorrectScores[i];
                App.Score += incorrectScores[i];
            }
            App.TotalAnswers[i]++;
            await Navigation.PushModalAsync(new AnswerPage());
        }

        async void OnBButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button) sender;
            int[] correctScores = { 0, 26, 49, 68, 85, 99 };
            int[] incorrectScores = { 0, -32, -74, -132, -232, -564 };

            int i;
            if (button == B50) i = 0;
            else if (button == B60) i = 1;
            else if (button == B70) i = 2;
            else if (button == B80) i = 3;
            else if (button == B90) i = 4;
            else i = 5;

            if (!App.AIsCorrect)
            {
                App.AnsweredCorrectly = true;
                App.DeltaScore = correctScores[i];
                App.Score += correctScores[i];
                App.CorrectAnswers[i]++;
            }
            else
            {
                App.AnsweredCorrectly = false;
                App.DeltaScore = incorrectScores[i];
                App.Score += incorrectScores[i];
            }
            App.TotalAnswers[i]++;
            await Navigation.PushModalAsync(new AnswerPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Content.Opacity = 0;
            Content.FadeTo(1, 250, Easing.CubicOut);
        }
    }
}
