using System.ComponentModel;
using Xamarin.Forms;
using NotificationMobile.ViewModels;

namespace NotificationMobile.Views
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