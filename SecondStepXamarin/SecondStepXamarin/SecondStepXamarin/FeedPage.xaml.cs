using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecondStepXamarin
{
    public partial class FeedPage : ContentPage
    {
        public FeedPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var data = await new NewsFeedService().Update();
            this.BindingContext = data.Channel.Items;
        }

        async void listItemTapped(object sender, ItemTappedEventArgs e)
        {
            listView.SelectedItem = null;
            var open = await DisplayAlert("Open", "Open this page in browser?", "Yes", "No");
            if (open)
                Device.OpenUri(new Uri(((RssItem)e.Item).Link));
        }
    }
}
