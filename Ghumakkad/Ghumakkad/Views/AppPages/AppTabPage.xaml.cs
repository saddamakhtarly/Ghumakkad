using Ghumakkad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ghumakkad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppTabPage : TabbedPage
    {
        public AppTabPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if(BindingContext != null && BindingContext is BaseViewModel viewModel)
            {
                if(CurrentPage.BindingContext != null && CurrentPage.BindingContext is BaseViewModel currentVM)
                {
                    viewModel.Title = currentVM.Title;
                }
            }
        }
    }
}