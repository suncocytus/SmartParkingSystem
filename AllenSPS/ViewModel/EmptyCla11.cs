using System;

namespace AllenSPS
{
	public class EmptyCla11 : Xamarin.Forms.INavigation
	{
		

			public INavigation Navi { get; internal set; }

			public Task<Page> PopAsync()
		{
			return Navi.PopAsync ();
		}

}

