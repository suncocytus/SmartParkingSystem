using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllenSPS;


namespace AllenSPS
{
	public partial class SearchPage : ContentPage
	{
		


		public SearchPage ()
		{
			InitializeComponent ();


		}

		/*private void SearchBar_OnSearchButtonPressed (object sender, EventArgs e)
		{    
			List<string> keyword = _names;
			IEnumerable<string> searchResult = _names.Where (name => name.ToLower ().Contains (keyword [0].ToLower ()));
			InsideDestSearch.ItemsSource = searchResult;



		}*/


		private async void Button1_Onclicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchResult());
		}
		private async void Button2_Onclicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new OffStreet());
		}
	}

}

