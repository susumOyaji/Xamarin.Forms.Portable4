using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

//using System.IO;
using System.Windows.Input;
//using Microsoft.Practices.Prism.Mvvm;

namespace Xamarin.Forms.Portable4.ViewModels
{
   
    public sealed class MainPageViewModel : BindableBase
    {
       public ICommand SelectCommand { private set; get; }
       

        public MainPageViewModel()
        {
          
            //SelectCommand = new CountUpCommand(Selecter);
            SelectCommand = new DelegateCommand<object>(Selecter);

        }


        public void Selecter(object sender)
        {
            //var SourceBool = (string)sender.CommandParameter;//FirstLastName (Prev_day or Percent)

            ContentPageViewModel[] ContentPageViewModels;

            var disp=Convert.ToBoolean(sender);

            if (disp == true)
            {

                ContentPageViewModels = new ContentPageViewModel[]
                {
                    new ContentPage1ViewModel()
                };

            }
            else{
                
                ContentPageViewModels = new ContentPageViewModel[]
                {
                    new ContentPage2ViewModel()
                };

            }
                      
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



    //public class ButtonClickedTriggerAction : TriggerAction<Button>
    //{
    //    protected override void Invoke(Button sender)
    //    {
    //        var SourceBool = (string)sender.CommandParameter;//FirstLastName (Prev_day or Percent)

    //        bool b = System.Convert.ToBoolean(SourceBool);
    //        MainPageViewModel M = new MainPageViewModel();

    //        M.Selecter(b);
    //    }
    //}

}