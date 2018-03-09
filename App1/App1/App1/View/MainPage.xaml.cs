using App1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.ViewModel;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        MainPageViewModel vm;
		public MainPage()
		{
			InitializeComponent();
            vm = new MainPageViewModel();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void ButtonList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagePerson());
        }
    }
}
