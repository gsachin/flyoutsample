using flyoutsample.ViewModels;
using Xamarin.Forms;

namespace flyoutsample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}