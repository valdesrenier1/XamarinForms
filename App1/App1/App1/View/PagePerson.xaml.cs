using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.ViewModel;

namespace App1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagePerson : ContentPage
	{
		public PagePerson ()
		{
			InitializeComponent ();
            BindingContext = new PagePersonViewModel();
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //catch deselection
            }

            Person person = e.SelectedItem as Person;
            DisplayAlert("Selected", person.LastName, "OK");
        }
    }
}