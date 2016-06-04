using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AllenSPS
{
	public partial class SearchResult : ContentPage
	{


		public SearchResult ()
		{
			InitializeComponent ();
			BindingContext = new SearchResultViewModel ();
		}

		public void SearchResultTapped(object sender, ItemTappedEventArgs args)

		{

			var SearchResultList = args.Item as locationdetails;

			if (SearchResultList == null)
				return;
			Navigation.PushAsync(new UserDetail(SearchResultList));
			LocationList.SelectedItem = null;

		}
	}
}

