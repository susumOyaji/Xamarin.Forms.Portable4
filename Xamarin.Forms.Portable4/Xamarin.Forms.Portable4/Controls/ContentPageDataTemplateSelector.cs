using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Portable4.ViewModels;

namespace Xamarin.Forms.Portable4.Controls
{
    public sealed class ContentPageDataTemplateSelector : DataTemplateSelector
    {

        public ContentPageDataTemplateSelector()
        {
            
        }

        public DataTemplate ContentPage1
        {
            get;
            set;
        }

        public DataTemplate ContentPage2
        {
            get;
            set;
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var viewModel = item as ContentPageViewModel;
            if (viewModel == null)
                return null;

            return viewModel is ContentPage1ViewModel ? this.ContentPage1 : viewModel is ContentPage2ViewModel ? this.ContentPage2 : null;
        }
    }
}
