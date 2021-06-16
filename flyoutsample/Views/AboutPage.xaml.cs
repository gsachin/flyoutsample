using System;
using Xamarin.Forms;

namespace flyoutsample.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        protected void OnButtonClicked(object sender, EventArgs args)
        {
            //overlay.IsVisible = true;
        }

        protected void OnOkButtonClicked(object sender, EventArgs args)
        {
            
        }

        protected void OnCancelButtonClicked(object sender, EventArgs args)
        {
            //overlay.IsVisible = false;
        }

    }
}