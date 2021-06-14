using flyoutsample.Models;
using flyoutsample.ViewModels;
using Xamarin.Forms;

namespace flyoutsample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}