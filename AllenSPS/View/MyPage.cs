using System;

using Xamarin.Forms;

namespace AllenSPS
{
	public class MyPage : ContentPage
	{
		public MyPage ()
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
			Button button = new Button
			{
				Text = "POSITION",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand

               	
			};
			button.Clicked += async (sender, e) => {
				await Navigation.PushAsync (new searchpage());
				//Navigation.RemovePage(this);
			};







			this.Content = new StackLayout
			{ 
				Children = 
				{
					header,
					button

				}
			};
			
		}








	}
}


