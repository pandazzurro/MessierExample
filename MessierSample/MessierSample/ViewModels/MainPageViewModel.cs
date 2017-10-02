using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessierSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private decimal _distanceProgress = 0;
        public decimal DistanceProgress
        {
            get { return _distanceProgress; }
            set { SetProperty(ref _distanceProgress, value); }
        }

        public MainPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                Device.StartTimer(TimeSpan.FromSeconds(2), () =>
                {
                    DistanceProgress = (int)DateTime.Now.Second / 60;
                    return true;
                });
            });
        }
    }
}
