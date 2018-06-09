using System.Collections.ObjectModel;
//using Microsoft.Practices.Prism.Mvvm;

namespace Xamarin.Forms.Portable4.ViewModels
{
    public sealed class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {
            var ContentPageViewModels = new ContentPageViewModel[]
            {
                new ContentPage1ViewModel(),
                new ContentPage2ViewModel(),
            };

            this.ContentPages = new ObservableCollection<ContentPageViewModel>(ContentPageViewModels);
        }

        private ObservableCollection<ContentPageViewModel> _ContentPages;

        public ObservableCollection<ContentPageViewModel> ContentPages
        {
            get
            {
                return this._ContentPages;
            }
            set
            {
                this.SetProperty(ref this._ContentPages, value);
            }
        }

    }

}