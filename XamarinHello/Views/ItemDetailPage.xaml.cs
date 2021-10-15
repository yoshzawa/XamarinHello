using System.ComponentModel;
using Xamarin.Forms;
using XamarinHello.ViewModels;

namespace XamarinHello.Views
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