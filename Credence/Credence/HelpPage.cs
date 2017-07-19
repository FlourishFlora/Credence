using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Credence
{
	public class HelpPage : ContentPage
	{
		public HelpPage()
		{
            Title = "Help";

            string text = "Tutorials are for n00bs.\n\n" +
                "Thanks to:\n" +
                "Open Trivia Database for the trivia questions\n" +
                "CFAR for the idea behind the app.\n" +
                "Mr. Young for being an amazing teacher\n" +
                "And last but not least, Michael Chen for making the app";
            Button back = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                WidthRequest = 100,
                Text = "Back"
            };
            back.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new TitlePage());
            };

            Content = new StackLayout
            {
				Children =
                {
					new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        Text = text
                    },
                    back
				}
			};
            Padding = new Thickness(15, 50, 15, 15);
        }
	}
}