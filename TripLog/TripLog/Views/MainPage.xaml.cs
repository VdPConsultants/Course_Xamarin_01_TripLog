using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TripLog.Models;
using TripLog.ViewModels;
using TripLog.Services;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainViewModel ViewModel => BindingContext as MainViewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(DependencyService.Get<INavService>());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Initialize MainViewModel
            ViewModel?.Init();
        }
    }
}