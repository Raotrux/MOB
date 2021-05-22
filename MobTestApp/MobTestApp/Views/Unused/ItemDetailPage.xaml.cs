using MobTestApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobTestApp.Views
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