using System;

using Xamarin.Forms;

namespace AllenSPS
{
	public class searchpage : ContentPage


	{
		public searchpage ()
		{
			Label header = new Label
			{
				Text = "Welcome to Smart Parking System!",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				BackgroundColor = Color.White,
				TextColor = Color.Blue,
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold | FontAttributes.Italic
			};
			SearchBar searchbar = new SearchBar
			{
				Placeholder = "input your destination"


               	
			};
			Button button1 = new Button
			{
				Text = "On Street",
				HorizontalOptions = LayoutOptions.CenterAndExpand
				//VerticalOptions = LayoutOptions.CenterAndExpand


			};
			Button button2 = new Button
			{
				Text = "Off Street",
				HorizontalOptions = LayoutOptions.Center,
				//VerticalOptions = LayoutOptions.CenterAndExpand


			};

			this.Content = new StackLayout
			{ 
				Children = 
				{
					searchbar,
					button1,
					button2

				}
			};
		}
	}
}


