using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Credence
{
	public class TitlePage : ContentPage
	{
		public TitlePage()
		{
            App.Score = 0;
            App.RoundNum = 0;

            Button start = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                WidthRequest = 100,
                Text = "Start"
            };
            Button help = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                WidthRequest = 100,
                Text = "Help"
            };
            start.Clicked += async (sender, args) =>
            {
                Content.Opacity = 1;
                await Task.WhenAny<bool>
                (
                    Content.ScaleTo(5, 250, Easing.CubicOut),
                    Content.FadeTo(0, 250, Easing.CubicOut)
                    );
                await Navigation.PushModalAsync(new MainPage());
            };
            help.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new HelpPage());
            };

            Padding = new Thickness(20, 0, 20, 30);
            Content = new StackLayout // I should probably use an AbsoluteLayout
            {
                Children =
                {
                    new Label
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 164,
                        Text = "Odds"
                    },
                    start,
                    help
				}
			};
		}
	}
}