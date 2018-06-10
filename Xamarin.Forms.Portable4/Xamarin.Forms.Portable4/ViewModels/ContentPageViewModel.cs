//using Microsoft.Practices.Prism.Mvvm;

namespace Xamarin.Forms.Portable4.ViewModels
{
    public abstract class ContentPageViewModel : BindableBase
    {

        private string _Title;

        public string Title
        {
            get
            {
                return this._Title;
            }
            protected set
            {
                this.SetProperty(ref this._Title, value);
            }
        }

    }

    public sealed class ContentPage1ViewModel : ContentPageViewModel
    {

        public ContentPage1ViewModel()
        {
            this.Title = "Stock";

            this.ListItem.Add(Title = "SampleSony");

        }

    }

    public sealed class ContentPage2ViewModel : ContentPageViewModel
    {
        public ContentPage2ViewModel()
        {
            this.Title = "Ranking Serchi";
        }

    }

}
